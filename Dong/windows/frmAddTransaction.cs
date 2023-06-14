using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Model;
using ValidationComponents;
using DataLayer.ViewModel;

namespace Dong.windows
{
    public partial class frmAddTransaction : Form
    {
        public int GroupID { get; set; }
        public frmAddTransaction()
        {
            InitializeComponent();
        }
        private void frmAddTransaction_Load(object sender, EventArgs e)
        {
            Dong_DBEntities db = new Dong_DBEntities();
            List<tblUser> users = db.PRC_GET_GROUP_MEMBER(this.GroupID).Select(one => new tblUser()
            {
                FullName = one.FullName,
                ID = one.ID
            }).ToList();
            Utilis.CreateUnSelectedComboBox(cmbBuyer, "FullName", "ID", users);
            CreateSharedPersonsList(users);
            Utilis.CreateUnSelectedComboBox(cmbGoodsType, "Title", "ID", db.tblGoodsType.ToList());

            Utilis.HeadingGroupsTransactions(dgvTransactions, true);
            BindData(dgvTransactions, MakeCriteria());

        }
        private void BindData(DataGridView dgvTransactions,string criteria)
        {
            using (Dong_DBEntities db = new Dong_DBEntities())
            {
                dgvTransactions.DataSource = db.PRC_GET_GROUP_TRANSACTION(criteria).Select(one => new TransActionViewModel()
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

        private void CreateSharedPersonsList(List<tblUser> users)
        {
            for (int i = 0; i < users.Count; i++)
            {
                CheckBox ch = new CheckBox();
                ch.Text = users[i].FullName;
                ch.Tag = users[i].ID;
                flpConsumers.Controls.Add(ch);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tuple<bool, string> res = checkInputs();

            if (res.Item1)
            {
                if (BaseValidator.IsFormValid(this.components))
                {
                    using (Dong_DBEntities db = new Dong_DBEntities())
                    {
                        // درج کردن در جدول گودز یعنی مشخصات کالاهای خریداری شده

                        tblGoods goods = new tblGoods()
                        {

                            Title = txttitle.Text,
                            Description = txtDesc.Text,
                            GoodsTypeID = Convert.ToInt32(cmbGoodsType.SelectedValue)
                        };

                        db.tblGoods.Add(goods);

                        db.SaveChanges();
                        //

                        int SharedPersons = 0;
                        SharedPersons = FindNumberOfSharedPerson(flpConsumers);

                        foreach (CheckBox item in flpConsumers.Controls)
                        {
                            if ((item as CheckBox).Checked)
                            {

                                if ((int)item.Tag == (int)cmbBuyer.SelectedValue)
                                {
                                    db.tblTransaction.Add(new tblTransaction()
                                    {
                                        UserID = Convert.ToInt32(cmbBuyer.SelectedValue),
                                        GoodsID = goods.ID,
                                        IsBuyer = true,
                                        TotalPrice = Convert.ToInt32(txtPrice.Text),
                                        Get = (Convert.ToInt32(txtPrice.Text) / SharedPersons) * (SharedPersons - 1),
                                        Pay = 0,
                                        Date = DateTime.Now,
                                        IsCheckOut = false,
                                        GroupID = this.GroupID
                                    });
                                }//خریدار
                                else
                                {
                                    db.tblTransaction.Add(new tblTransaction()
                                    {
                                        UserID = Convert.ToInt32(item.Tag),
                                        GoodsID = goods.ID,
                                        IsBuyer = false,
                                        TotalPrice = 0,
                                        Get = 0,
                                        Pay = (Convert.ToInt32(txtPrice.Text) / SharedPersons) * -1,
                                        Date = DateTime.Now,
                                        IsCheckOut = false,
                                        GroupID = this.GroupID
                                    });
                                }//مصرف کننده
                                db.SaveChanges();
                            }//if
                        }//foreach
                        MessageBox.Show("تراکنش با موفقیت ثبت شد", "اطلاع", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindData(dgvTransactions, MakeCriteria());
                    }

                    ResetForm();
                }
            }
            else
            {
                MessageBox.Show(res.Item2, "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ResetForm()
        {
            txttitle.Text = txtDesc.Text = "";
            txttitle.Focus();
            txtPrice.Text = "";

            foreach (Control item in flpConsumers.Controls)
            {
                if (((CheckBox)item).Checked)
                    ((CheckBox)item).Checked = false;
            }
        }

        private int FindNumberOfSharedPerson(FlowLayoutPanel flpConsumers)
        {
            int cnt = 0;
            foreach (Control item in flpConsumers.Controls)
            {
                if (((CheckBox)item).Checked)
                    cnt++;
            }
            return cnt;
        }

        private Tuple<bool, string> checkInputs()
        {
            if (cmbGoodsType.SelectedIndex < 0)
                return new Tuple<bool, string>(false, "نوع تراکنش را مشخص کنید");
            if (cmbBuyer.SelectedIndex < 0)
                return new Tuple<bool, string>(false, "خریدار را مشخص کنید");

            if (FindNumberOfSharedPerson(flpConsumers) == 0)
                return new Tuple<bool, string>(false, "مصرف کننده را مشخص کنید");

            else
                return new Tuple<bool, string>(true, "");
        }

        private void dgvTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvTransactions.ColumnCount - 2)
            {
                int GoodsID = Convert.ToInt32(dgvTransactions.Rows[e.RowIndex].Cells[1].Value.ToString());

                DialogResult Result = MessageBox.Show("آیا از حذف این راکنش مطمئن هستید؟", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (Result == DialogResult.OK)
                {
                    using(Dong_DBEntities db=new Dong_DBEntities())
                    {
                        db.PRC_DELETE_TRANSACTION(GoodsID, this.GroupID);
                    }
                    BindData(dgvTransactions, MakeCriteria());
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BindData(dgvTransactions, MakeCriteria());
        }
        private string MakeCriteria()
        {
            string Criteria = " and GroupID=" + this.GroupID;

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
    }
}
