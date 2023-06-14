using DataLayer.Model;
using DataLayer.ViewModel;
using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dong.windows
{
    public partial class frmCheckOut : Form
    {
        public int GroupID { get; set; }
        public frmCheckOut()
        {
            InitializeComponent();
        }

        private void frmCheckOut_Load(object sender, EventArgs e)
        {
            SetDateTime();
            ConstructFilters(flpUsers);
            Utilis.HeadingGroupsTransactions(dgvTransactions, false);
            BindData(dgvTransactions, MakeCriteria());
        }

        private void SetDateTime()
        {
            string date = DateTime.Now.ToShamsi();
            FDateTo.Text = date;
        }

        private void ConstructFilters(FlowLayoutPanel flpUsers)
        {
            using (Dong_DBEntities db = new Dong_DBEntities())
            {
                List<tblTransaction> Transactions = db.tblTransaction.Where(one => one.GroupID == this.GroupID && one.IsBuyer == true && one.IsCheckOut==false)
                                                    .OrderBy(one => one.Date)
                                                    .ToList();

                if (Transactions.Count() != 0)
                    FDateFrom.Text = Transactions.Take(1).Select(one => one.Date).ToList()[0].Value.ToShamsi();
                else
                    FDateFrom.Text = DateTime.Now.ToShamsi();

                List<int> userID = db.tblUserGroup.Where(one => one.GroupID == this.GroupID).Select(two => two.UserID.Value).ToList();

                List<tblUser> users = db.tblUser.Where(one => userID.Contains(one.ID)).ToList();
                
                if (users.Count != 0)
                {
                    foreach (tblUser user in users)
                    {
                        CheckBox checkBox = new CheckBox();
                        checkBox.Tag = user.ID;
                        checkBox.Text = user.FullName;

                        flpUsers.Controls.Add(checkBox);
                    }
                }

            }
        }

        private void BindData(DataGridView dgvTransactions, string Criteria)
        {
            dgvTransactions.DataSource = null;

            using (Dong_DBEntities db = new Dong_DBEntities())
            {
                dgvTransactions.DataSource = db.PRC_GET_GROUP_TRANSACTION(Criteria).Select(one => new TransActionViewModel()
                {
                    ID = one.ID,
                    GoodsID = one.GoodsID,
                    FullName = one.FullName,
                    Title = one.Title,
                    SharePersons = one.SharePersons,
                    TotalPrice = one.TotalPrice,
                    IsCheckOut = one.IsCheckOut,
                    Date = (one.Date != null) ? one.Date.Value.ToShamsi() : ""
                }).ToList();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            BindData(dgvTransactions, MakeCriteria());
        }
        private string MakeCriteria()
        {
            string Criteria = " and GroupID=" + this.GroupID;
            List<int> UserId = new List<int>();
            foreach (var item in flpUsers.Controls)
            {
                if (((CheckBox)item).Checked)
                    UserId.Add((int)((CheckBox)item).Tag);
            }

            if (UserId.Count != 0)
                Criteria = Criteria + " and UserID in (" + string.Join(",", UserId) + ")";

            if (Utilis.hasDigit(FDateFrom.Text) && !string.IsNullOrEmpty(FDateFrom.Text))
            {
                Tuple<int, int, int> YMD = Utilis.Extract_YMD_FromStringDate(FDateFrom.Text);
                string FDate = new DateTime(YMD.Item1, YMD.Item2, YMD.Item3, new System.Globalization.PersianCalendar()).ToShortDateString();
                Criteria = Criteria + " and Date>='" + FDate + "'";
            }
            if (Utilis.hasDigit(FDateTo.Text) && !string.IsNullOrEmpty(FDateTo.Text))
            {
                Tuple<int, int, int> YMD = Utilis.Extract_YMD_FromStringDate(FDateTo.Text);
                string FDate = new DateTime(YMD.Item1, YMD.Item2, YMD.Item3, new System.Globalization.PersianCalendar()).ToShortDateString();
                Criteria = Criteria + " and Date<= '" + FDate + "'";
            }
            if (rbnIsCheckOut.Checked)
            {
                Criteria = Criteria + " and IsCheckOut=" + 1;
            }
            if (rbnIsNotCheckOut.Checked)
            {
                Criteria = Criteria + " and IsCheckOut=" + 0;
            }
            return Criteria;
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

            DialogResult ResMessage = MessageBox.Show("آیا از تسویه حساب کردن مطمئن هستید؟", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            Tuple<string, int> Result;

            if (ResMessage == DialogResult.OK)
            {
                string Criteria = string.Empty;
                int transCount = 0;

                Result = Make_CheckOut_Criteria();
                Criteria = Result.Item1;
                transCount = Result.Item2;

                if (!string.IsNullOrEmpty(Criteria) && transCount != 0)
                {
                    PrintCheckout(Criteria, transCount);
                    ExpireGoods(Criteria);
                }
                else
                {
                    MessageBox.Show("تراکنشی موجود نیست", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }

            }
        }

        private void ExpireGoods(string criteria)
        {
            using (Dong_DBEntities db = new Dong_DBEntities())
            {
                if (!string.IsNullOrEmpty(criteria))
                {
                    db.PRC_EXPIRE_GOODS(criteria);
                }
            }
        }

        private void PrintCheckout(string criteria, int count)
        {
            string Connectionstring = "Data Source=.;Initial Catalog=Dong_DB;Integrated security=true;";
            SqlConnection con = new SqlConnection(Connectionstring);
            SqlCommand com = new SqlCommand("PRC_CHECK_OUT", con);
            com.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(com);

            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "Criteria";
            parameter.SqlDbType = SqlDbType.VarChar;
            parameter.Value = criteria;
            parameter.Direction = ParameterDirection.Input;

            adapter.SelectCommand.Parameters.Add(parameter);

            DataTable dtResult = new DataTable();

            adapter.Fill(dtResult);

            con.Close();

            StiReport report = new StiReport();
            report.Load(Application.StartupPath + "\\Report.mrt");
            report.Dictionary.Variables.Add("FDate", FDateFrom.Text);
            report.Dictionary.Variables.Add("TDate", FDateTo.Text);
            report.Dictionary.Variables.Add("TransCount", count);
            report.RegData("DT", dtResult);
            report.Show();

        }
        private Tuple<string, int> Make_CheckOut_Criteria()
        {
            string Criteria = string.Empty;

            List<int> GoodsID = new List<int>();
            for (int i = 0; i < dgvTransactions.Rows.Count; i++)
            {
                if (dgvTransactions.Rows[i].Cells["ch"].Value != null && (bool)dgvTransactions.Rows[i].Cells["ch"].Value)
                    GoodsID.Add(Convert.ToInt32(dgvTransactions.Rows[i].Cells["GoodsID"].Value.ToString()));
            }

            if (GoodsID.Count != 0)
                Criteria = Criteria + " GroupID=" + this.GroupID + " and GoodsID in (" + string.Join(",", GoodsID) + ")";

            return new Tuple<string, int>(Criteria, GoodsID.Count);
        }
    }
}