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

namespace Dong.windows
{
    public partial class frmAddGroupUser : Form
    {

        public int GroupID { get; set; }
        public string GroupName { get; set; }
        public frmAddGroupUser()
        {
            InitializeComponent();
        }

        private void frmAddGroupUser_Load(object sender, EventArgs e)
        {
            lblGroupName.Text = this.GroupName;
            Utilis.HeadingGroupMember(dgvMember);
            BindData(dgvMember);
        }

        private void BindData(DataGridView dgvMember)
        {
            using (Dong_DBEntities db=new Dong_DBEntities())
            {
                dgvMember.DataSource = (db.PRC_GET_GROUP_MEMBER(this.GroupID)).Select(one => new tblUser
                {
                    ID = one.ID,
                    FullName = one.FullName
                }).ToList();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidationComponents.BaseValidator.IsFormValid(this.components))
            {
                using(Dong_DBEntities db=new Dong_DBEntities())
                {
                    tblUser user = new tblUser();
                    user.FullName = txtFullName.Text;
                    db.tblUser.Add(user);

                    db.SaveChanges();
                    int userid = user.ID;


                    db.tblUserGroup.Add(new tblUserGroup()
                    {
                        GroupID = this.GroupID,
                        UserID = userid
                    });

                    db.SaveChanges();

                }//using
                txtFullName.Text = "";
                txtFullName.Focus();
                BindData(dgvMember);
            }
        }

        private void dgvMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvMember.ColumnCount - 1)
            {
                int userid = Convert.ToInt32(dgvMember.Rows[e.RowIndex].Cells[0].Value.ToString());

                DialogResult result = MessageBox.Show( "آیا از حذف این عضو مطمٔن هستید?", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    using(Dong_DBEntities db=new Dong_DBEntities())
                    {
                        db.tblUser.Remove(db.tblUser.Find(userid));

                        db.SaveChanges();

                        tblUserGroup UserGroup = db.tblUserGroup.Where(one => one.UserID == userid && one.GroupID == this.GroupID).FirstOrDefault();

                        db.tblUserGroup.Remove(UserGroup);

                        db.SaveChanges();
                    }

                    BindData(dgvMember);
                }
            }
        }
    }
}
