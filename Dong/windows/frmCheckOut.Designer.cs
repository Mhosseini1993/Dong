namespace Dong.windows
{
    partial class frmCheckOut
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.FDateTo = new FarsiLibrary.Win.Controls.FADatePicker();
            this.FDateFrom = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flpUsers = new System.Windows.Forms.FlowLayoutPanel();
            this.rbnIsCheckOut = new System.Windows.Forms.RadioButton();
            this.rbnIsNotCheckOut = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTransactions);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تراکنش ها";
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AllowUserToDeleteRows = false;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransactions.Location = new System.Drawing.Point(3, 17);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.Size = new System.Drawing.Size(771, 178);
            this.dgvTransactions.TabIndex = 0;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(667, 192);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(98, 23);
            this.btnCheckOut.TabIndex = 1;
            this.btnCheckOut.Text = "تسویه حساب";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rbnIsNotCheckOut);
            this.groupBox2.Controls.Add(this.rbnIsCheckOut);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.FDateTo);
            this.groupBox2.Controls.Add(this.FDateFrom);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.flpUsers);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 215);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "فیلتر";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "جستجو";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FDateTo
            // 
            this.FDateTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FDateTo.Location = new System.Drawing.Point(397, 160);
            this.FDateTo.Name = "FDateTo";
            this.FDateTo.Size = new System.Drawing.Size(120, 20);
            this.FDateTo.TabIndex = 4;
            // 
            // FDateFrom
            // 
            this.FDateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FDateFrom.Location = new System.Drawing.Point(397, 125);
            this.FDateFrom.Name = "FDateFrom";
            this.FDateFrom.Size = new System.Drawing.Size(120, 20);
            this.FDateFrom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(523, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "تا تاریخ :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(523, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "از تاریخ :";
            // 
            // flpUsers
            // 
            this.flpUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpUsers.Location = new System.Drawing.Point(3, 17);
            this.flpUsers.Name = "flpUsers";
            this.flpUsers.Size = new System.Drawing.Size(567, 89);
            this.flpUsers.TabIndex = 0;
            // 
            // rbnIsCheckOut
            // 
            this.rbnIsCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbnIsCheckOut.AutoSize = true;
            this.rbnIsCheckOut.Location = new System.Drawing.Point(266, 125);
            this.rbnIsCheckOut.Name = "rbnIsCheckOut";
            this.rbnIsCheckOut.Size = new System.Drawing.Size(79, 17);
            this.rbnIsCheckOut.TabIndex = 5;
            this.rbnIsCheckOut.TabStop = true;
            this.rbnIsCheckOut.Text = "تسویه شده";
            this.rbnIsCheckOut.UseVisualStyleBackColor = true;
            // 
            // rbnIsNotCheckOut
            // 
            this.rbnIsNotCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbnIsNotCheckOut.AutoSize = true;
            this.rbnIsNotCheckOut.Checked = true;
            this.rbnIsNotCheckOut.Location = new System.Drawing.Point(266, 160);
            this.rbnIsNotCheckOut.Name = "rbnIsNotCheckOut";
            this.rbnIsNotCheckOut.Size = new System.Drawing.Size(83, 17);
            this.rbnIsNotCheckOut.TabIndex = 6;
            this.rbnIsNotCheckOut.TabStop = true;
            this.rbnIsNotCheckOut.Text = "تسویه نشده";
            this.rbnIsNotCheckOut.UseVisualStyleBackColor = true;
            // 
            // frmCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 419);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCheckOut";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تسویه حساب";
            this.Load += new System.EventHandler(this.frmCheckOut_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flpUsers;
        private FarsiLibrary.Win.Controls.FADatePicker FDateFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FarsiLibrary.Win.Controls.FADatePicker FDateTo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rbnIsNotCheckOut;
        private System.Windows.Forms.RadioButton rbnIsCheckOut;
    }
}