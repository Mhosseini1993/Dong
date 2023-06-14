namespace Dong
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Groups = new System.Windows.Forms.GroupBox();
            this.dgvGroups = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmAddNewGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.Groups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Groups
            // 
            this.Groups.Controls.Add(this.dgvGroups);
            this.Groups.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Groups.Location = new System.Drawing.Point(0, 91);
            this.Groups.Name = "Groups";
            this.Groups.Size = new System.Drawing.Size(544, 225);
            this.Groups.TabIndex = 1;
            this.Groups.TabStop = false;
            this.Groups.Text = "لیست گروه ها";
            // 
            // dgvGroups
            // 
            this.dgvGroups.AllowUserToDeleteRows = false;
            this.dgvGroups.AllowUserToResizeColumns = false;
            this.dgvGroups.AllowUserToResizeRows = false;
            this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGroups.Location = new System.Drawing.Point(3, 17);
            this.dgvGroups.Name = "dgvGroups";
            this.dgvGroups.ReadOnly = true;
            this.dgvGroups.Size = new System.Drawing.Size(538, 205);
            this.dgvGroups.TabIndex = 0;
            this.dgvGroups.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroups_CellContentClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.tsbRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(544, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAddNewGroup});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(83, 22);
            this.toolStripDropDownButton1.Text = "مدیریت گروه";
            // 
            // tsmAddNewGroup
            // 
            this.tsmAddNewGroup.Image = global::Dong.Properties.Resources.add;
            this.tsmAddNewGroup.Name = "tsmAddNewGroup";
            this.tsmAddNewGroup.Size = new System.Drawing.Size(180, 22);
            this.tsmAddNewGroup.Text = "افزودن گروه جدید";
            this.tsmAddNewGroup.Click += new System.EventHandler(this.tsmAddNewGroup_Click);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh.Image = global::Dong.Properties.Resources.undo;
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(23, 22);
            this.tsbRefresh.Text = "toolStripButton1";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(544, 316);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Groups);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صفحه اصلی";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Groups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox Groups;
        private System.Windows.Forms.DataGridView dgvGroups;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem tsmAddNewGroup;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
    }
}

