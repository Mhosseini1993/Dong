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
    public partial class frmAddNewGroup : Form
    {
        public frmAddNewGroup()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                using (Dong_DBEntities db = new Dong_DBEntities())
                {

                    db.tblGroup.Add(new tblGroup()
                    {
                        CreateDate = DateTime.Now,
                        Title = txtGroupName.Text,
                    });
                    db.SaveChanges();
                }
                txtGroupName.Text = "";
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
