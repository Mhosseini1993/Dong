using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dong.windows;
using DataLayer.Model;
using DataLayer.ViewModel;

namespace Dong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Utilis.HeadingCurrentGroups(dgvGroups);
            BindData(dgvGroups);
        }

        private void BindData(DataGridView dgvGroups)
        {
            using(Dong_DBEntities db=new Dong_DBEntities())
            {
                dgvGroups.DataSource = db.PRC_GET_GROUP_LIST().Select(one => new GroupViewModel()
                {
                    ID=one.ID,
                    Count = one.cnt,
                    CreateDate = (one.CreateDate != null) ? one.CreateDate.Value.ToShamsi() : "",
                    Title = one.Title
                }).ToList();
            }
        }

        private void dgvGroups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0 && e.ColumnIndex == dgvGroups.ColumnCount - 3)
            {
                int GroupID = Convert.ToInt32(dgvGroups.Rows[e.RowIndex].Cells[0].Value.ToString());

                frmAddGroupUser frm = new frmAddGroupUser();
                frm.GroupName = dgvGroups.Rows[e.RowIndex].Cells["GroupName"].Value.ToString();
                frm.GroupID = GroupID;
                frm.ShowDialog();

            }

            else if (e.RowIndex >= 0 && e.ColumnIndex == dgvGroups.ColumnCount - 2)
            {
                int GroupID = Convert.ToInt32(dgvGroups.Rows[e.RowIndex].Cells[0].Value.ToString());

                frmAddTransaction frm = new frmAddTransaction();
                frm.GroupID = GroupID;
                frm.ShowDialog();
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == dgvGroups.ColumnCount - 1)
            {
                int GroupID = Convert.ToInt32(dgvGroups.Rows[e.RowIndex].Cells[0].Value.ToString());

                frmCheckOut frm = new frmCheckOut();
                frm.GroupID = GroupID;
                frm.ShowDialog();
            }
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            BindData(dgvGroups);
        }

        private void tsmAddNewGroup_Click(object sender, EventArgs e)
        {
            frmAddNewGroup frm = new frmAddNewGroup();
            if (frm.ShowDialog() == DialogResult.OK)
                BindData(dgvGroups);
        }
    }
}
