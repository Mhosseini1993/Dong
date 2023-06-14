namespace Dong.windows
{
    partial class frmAddTransaction
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddTransaction));
            this.label1 = new System.Windows.Forms.Label();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBuyer = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.flpConsumers = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbGoodsType = new System.Windows.Forms.ComboBox();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpboxFilter = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.rbnIsNotCheckOut = new System.Windows.Forms.RadioButton();
            this.rbnIsCheckOut = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpboxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "عنوان تراکنش :";
            // 
            // txttitle
            // 
            this.txttitle.Location = new System.Drawing.Point(106, 12);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(139, 21);
            this.txttitle.TabIndex = 1;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(106, 68);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(241, 67);
            this.txtDesc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "توضیحات تراکنش:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "مبلغ تراکنش:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(106, 141);
            this.txtPrice.Mask = "999999999999";
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(163, 21);
            this.txtPrice.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTransactions);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(822, 209);
            this.groupBox1.TabIndex = 6;
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
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.Size = new System.Drawing.Size(816, 189);
            this.dgvTransactions.TabIndex = 0;
            this.dgvTransactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransactions_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "افزودن";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "خریدار:";
            // 
            // cmbBuyer
            // 
            this.cmbBuyer.FormattingEnabled = true;
            this.cmbBuyer.Location = new System.Drawing.Point(106, 171);
            this.cmbBuyer.Name = "cmbBuyer";
            this.cmbBuyer.Size = new System.Drawing.Size(121, 21);
            this.cmbBuyer.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "مصرف کنندگان:";
            // 
            // flpConsumers
            // 
            this.flpConsumers.AutoScroll = true;
            this.flpConsumers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpConsumers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpConsumers.Location = new System.Drawing.Point(106, 198);
            this.flpConsumers.Name = "flpConsumers";
            this.flpConsumers.Size = new System.Drawing.Size(121, 105);
            this.flpConsumers.TabIndex = 12;
            this.flpConsumers.WrapContents = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "نوع تراکنش :";
            // 
            // cmbGoodsType
            // 
            this.cmbGoodsType.FormattingEnabled = true;
            this.cmbGoodsType.Location = new System.Drawing.Point(106, 39);
            this.cmbGoodsType.Name = "cmbGoodsType";
            this.cmbGoodsType.Size = new System.Drawing.Size(121, 21);
            this.cmbGoodsType.TabIndex = 14;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txttitle;
            this.requiredFieldValidator1.ErrorMessage = "عنوان تراکنش نمی تواند خالی بماند";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator2.ControlToValidate = this.txtPrice;
            this.requiredFieldValidator2.ErrorMessage = "مبلغ تراکنش نمی تواند خالی بماند";
            this.requiredFieldValidator2.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator2.Icon")));
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dong.Properties.Resources.money;
            this.pictureBox1.Location = new System.Drawing.Point(353, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // grpboxFilter
            // 
            this.grpboxFilter.Controls.Add(this.button2);
            this.grpboxFilter.Controls.Add(this.rbnIsNotCheckOut);
            this.grpboxFilter.Controls.Add(this.rbnIsCheckOut);
            this.grpboxFilter.Location = new System.Drawing.Point(353, 229);
            this.grpboxFilter.Name = "grpboxFilter";
            this.grpboxFilter.Size = new System.Drawing.Size(227, 74);
            this.grpboxFilter.TabIndex = 16;
            this.grpboxFilter.TabStop = false;
            this.grpboxFilter.Text = "فیلتر";
            // 
            // button2
            // 
            this.button2.Image = global::Dong.Properties.Resources.search;
            this.button2.Location = new System.Drawing.Point(16, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 40);
            this.button2.TabIndex = 17;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rbnIsNotCheckOut
            // 
            this.rbnIsNotCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbnIsNotCheckOut.AutoSize = true;
            this.rbnIsNotCheckOut.Location = new System.Drawing.Point(138, 43);
            this.rbnIsNotCheckOut.Name = "rbnIsNotCheckOut";
            this.rbnIsNotCheckOut.Size = new System.Drawing.Size(83, 17);
            this.rbnIsNotCheckOut.TabIndex = 8;
            this.rbnIsNotCheckOut.Text = "تسویه نشده";
            this.rbnIsNotCheckOut.UseVisualStyleBackColor = true;
            // 
            // rbnIsCheckOut
            // 
            this.rbnIsCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbnIsCheckOut.AutoSize = true;
            this.rbnIsCheckOut.Checked = true;
            this.rbnIsCheckOut.Location = new System.Drawing.Point(142, 20);
            this.rbnIsCheckOut.Name = "rbnIsCheckOut";
            this.rbnIsCheckOut.Size = new System.Drawing.Size(79, 17);
            this.rbnIsCheckOut.TabIndex = 7;
            this.rbnIsCheckOut.TabStop = true;
            this.rbnIsCheckOut.Text = "تسویه شده";
            this.rbnIsCheckOut.UseVisualStyleBackColor = true;
            // 
            // frmAddTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 510);
            this.Controls.Add(this.grpboxFilter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbGoodsType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.flpConsumers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbBuyer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttitle);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddTransaction";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "افزودن تراکنش جدید";
            this.Load += new System.EventHandler(this.frmAddTransaction_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpboxFilter.ResumeLayout(false);
            this.grpboxFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBuyer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flpConsumers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbGoodsType;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpboxFilter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rbnIsNotCheckOut;
        private System.Windows.Forms.RadioButton rbnIsCheckOut;
    }
}