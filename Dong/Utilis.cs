using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Drawing;

namespace Dong
{
    public static class Utilis
    {
        public static void HeadingGroupsTransactions(DataGridView dg,bool flag)
        {
            dg.DataSource = null;
            dg.AutoGenerateColumns = false;
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewTextBoxColumn col0 = new DataGridViewTextBoxColumn();
            col0.Name = "ID";
            col0.HeaderText = "کد تراکنش";
            col0.DataPropertyName = "ID";
            col0.Width = 100;
            col0.Visible = false;
            col0.SortMode = DataGridViewColumnSortMode.Automatic;
            dg.Columns.Add(col0);

            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.Name = "GoodsID";
            col1.HeaderText = "کد کالا";
            col1.DataPropertyName = "GoodsID";
            col1.Width = 100;
            col1.Visible = false;
            col1.SortMode = DataGridViewColumnSortMode.Automatic;
            dg.Columns.Add(col1);

            
            DataGridViewCheckBoxColumn ch = new DataGridViewCheckBoxColumn();
            ch.Name = "ch";
            ch.HeaderText = "انتخاب";
            ch.DataPropertyName = "";
            ch.Width = 60;
            dg.Columns.Add(ch);


            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.Name = "FullName";
            col2.HeaderText = "خریدار";
            col2.DataPropertyName = "FullName";
            col2.Width = 80;
            col2.SortMode = DataGridViewColumnSortMode.Automatic;
            dg.Columns.Add(col2);


            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.Name = "Date";
            col3.HeaderText = "تاریخ تراکنش";
            col3.DataPropertyName = "Date";
            col3.Width = 80;
            col3.SortMode = DataGridViewColumnSortMode.Automatic;
            col3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dg.Columns.Add(col3);


            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
            col4.Name = "Title";
            col4.HeaderText = "نام کالا";
            col4.DataPropertyName = "Title";
            col4.Width = 80;
            col4.SortMode = DataGridViewColumnSortMode.Automatic;
            col4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dg.Columns.Add(col4);

            DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
            col5.Name = "SharePersons";
            col5.HeaderText = "مصرف کنندگان";
            col5.DataPropertyName = "SharePersons";
            col5.Width = 120;
            col5.SortMode = DataGridViewColumnSortMode.Automatic;
            col5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dg.Columns.Add(col5);


            DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();
            col6.Name = "TotalPrice";
            col6.HeaderText = "قیمت کل";
            col6.DataPropertyName = "TotalPrice";
            col6.Width = 80;
            col6.SortMode = DataGridViewColumnSortMode.Automatic;
            col6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dg.Columns.Add(col6);


            if (flag)
            {
                DataGridViewLinkColumn link = new DataGridViewLinkColumn();
                link.Name = "EditTrans";
                link.HeaderText = "ویرایش";
                link.LinkColor = Color.Blue;
                link.Text = "ویرایش تراکنش";
                link.UseColumnTextForLinkValue = true;
                link.Width = 120;
                link.SortMode = DataGridViewColumnSortMode.Automatic;
                link.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dg.Columns.Add(link);


                DataGridViewLinkColumn link2 = new DataGridViewLinkColumn();
                link2.Name = "DeleteTrans";
                link2.HeaderText = "حذف";
                link2.LinkColor = Color.Blue;
                link2.Text = "حذف تراکنش";
                link2.UseColumnTextForLinkValue = true;
                link2.Width = 120;
                link2.SortMode = DataGridViewColumnSortMode.Automatic;
                link2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dg.Columns.Add(link2);
            }

            DataGridViewCheckBoxColumn col7 = new DataGridViewCheckBoxColumn();
            col7.Name = "IsCheckOut";
            col7.HeaderText = "تسویه شده /نشده";
            col7.DataPropertyName = "IsCheckOut";
            col7.Width = 150;
            col7.ReadOnly = true;
            col7.SortMode = DataGridViewColumnSortMode.Automatic;
            col7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dg.Columns.Add(col7);


        }
        public static void CreateUnSelectedComboBox(ComboBox box,string DisplayMember,string ValueMember,object datasource)
        {
            box.DataSource = null;
            box.DisplayMember = DisplayMember;
            box.ValueMember = ValueMember;
            box.DataSource = datasource;
        }
        public static void HeadingGroupMember(DataGridView dg)
        {
            dg.DataSource = null;
            dg.AutoGenerateColumns = false;
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewTextBoxColumn col0 = new DataGridViewTextBoxColumn();
            col0.Name = "ID";
            col0.DataPropertyName = "ID";
            col0.Width = 100;
            col0.Visible = false;
            col0.SortMode = DataGridViewColumnSortMode.Automatic;
            dg.Columns.Add(col0);

            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.Name = "FullName";
            col1.HeaderText = "نام و نام خانوادگی";
            col1.DataPropertyName = "FullName";
            col1.Width = 100;
            col1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col1.SortMode = DataGridViewColumnSortMode.Automatic;
            dg.Columns.Add(col1);

            DataGridViewLinkColumn link = new DataGridViewLinkColumn();
            link.Name = "ManageMemner";
            link.HeaderText = "مدیریت اعضا";
            link.LinkColor = Color.Red;
            link.Text = "حذف";
            link.UseColumnTextForLinkValue = true;
            link.Width = 100;
            link.SortMode = DataGridViewColumnSortMode.Automatic;
            link.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dg.Columns.Add(link);

            
        }
        public static void HeadingCurrentGroups(DataGridView dg)
        {
            dg.DataSource = null;
            dg.AutoGenerateColumns = false;
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewTextBoxColumn col0 = new DataGridViewTextBoxColumn();
            col0.Name = "ID";
            col0.DataPropertyName = "ID";
            col0.Width = 100;
            col0.Visible = false;
            col0.SortMode = DataGridViewColumnSortMode.Automatic;
            dg.Columns.Add(col0);

            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.Name = "GroupName";
            col1.HeaderText = "عنوان گروه";
            col1.DataPropertyName = "Title";
            col1.Width = 100;
            col1.SortMode = DataGridViewColumnSortMode.Automatic;
            dg.Columns.Add(col1);

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.Name = "MemberCount";
            col2.HeaderText = "تعداد اعضا";
            col2.DataPropertyName = "Count";
            col2.Width = 40;
            col2.SortMode = DataGridViewColumnSortMode.Automatic;
            dg.Columns.Add(col2);


            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.Name = "CreateDate";
            col3.HeaderText = "تاریخ ایجاد";
            col3.DataPropertyName = "CreateDate";
            col3.Width = 80;
            col3.SortMode = DataGridViewColumnSortMode.Automatic;
            col3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dg.Columns.Add(col3);

            DataGridViewLinkColumn link = new DataGridViewLinkColumn();
            link.Name = "ManageMemner";
            link.HeaderText = "مدیریت اعضا";
            link.LinkColor = Color.Red;
            link.Text = "مدیریت اعضا";
            link.UseColumnTextForLinkValue = true;
            link.Width = 100;
            link.SortMode = DataGridViewColumnSortMode.Automatic;
            link.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dg.Columns.Add(link);


            DataGridViewLinkColumn link1 = new DataGridViewLinkColumn();
            link1.Name = "ManageMemner";
            link1.HeaderText = "مدیریت تراکنش ها";
            link1.LinkColor = Color.Green;
            link1.Text = "تراکنش";
            link1.UseColumnTextForLinkValue = true;
            link1.Width = 100;
            link1.SortMode = DataGridViewColumnSortMode.Automatic;
            link1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dg.Columns.Add(link1);


            DataGridViewLinkColumn link2 = new DataGridViewLinkColumn();
            link2.Name = "CheckOut";
            link2.HeaderText = "تسویه حساب";
            link2.LinkColor = Color.Pink;
            link2.Text = "تسویه حساب";
            link2.UseColumnTextForLinkValue = true;
            link2.Width = 100;
            link2.SortMode = DataGridViewColumnSortMode.Automatic;
            link2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dg.Columns.Add(link2);
        }
        public static string ToShamsi(this DateTime value)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetYear(value) + "/" + pc.GetMonth(value).ToString("00") + "/" + pc.GetDayOfMonth(value).ToString();
        }
        public static bool hasDigit(string Date)
        {
            if (Date.Contains("1") || Date.Contains("2") || Date.Contains("3") || Date.Contains("4") ||
                Date.Contains("5") || Date.Contains("6") || Date.Contains("7") || Date.Contains("8") ||
                Date.Contains("9"))
                return true;
            else
                return false;
        }
        public static Tuple<int, int, int> Extract_YMD_FromStringDate(string Date)
        {
            string[] parts = Date.Split('/');
            return new Tuple<int, int, int>(Convert.ToInt32(parts[0]), Convert.ToInt32(parts[1]), Convert.ToInt32(parts[2]));
        }
    }
}
