namespace FastFoodDemo.Form2_UC3
{
    partial class CustomerManagementForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.idCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.lbAddr = new System.Windows.Forms.Label();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAddr = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCustomer,
            this.nameCustomer,
            this.addressCustomer,
            this.phoneNumberCustomer,
            this.emailCustomer});
            this.dgvCustomer.Location = new System.Drawing.Point(426, 39);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.RowTemplate.Height = 24;
            this.dgvCustomer.Size = new System.Drawing.Size(677, 553);
            this.dgvCustomer.TabIndex = 0;
            // 
            // idCustomer
            // 
            this.idCustomer.HeaderText = "ID";
            this.idCustomer.MinimumWidth = 6;
            this.idCustomer.Name = "idCustomer";
            this.idCustomer.Width = 125;
            // 
            // nameCustomer
            // 
            this.nameCustomer.HeaderText = "Tên Khách Hàng";
            this.nameCustomer.MinimumWidth = 6;
            this.nameCustomer.Name = "nameCustomer";
            this.nameCustomer.Width = 125;
            // 
            // addressCustomer
            // 
            this.addressCustomer.HeaderText = "Địa chỉ";
            this.addressCustomer.MinimumWidth = 6;
            this.addressCustomer.Name = "addressCustomer";
            this.addressCustomer.Width = 125;
            // 
            // phoneNumberCustomer
            // 
            this.phoneNumberCustomer.HeaderText = "Số điện thoại";
            this.phoneNumberCustomer.MinimumWidth = 6;
            this.phoneNumberCustomer.Name = "phoneNumberCustomer";
            this.phoneNumberCustomer.Width = 125;
            // 
            // emailCustomer
            // 
            this.emailCustomer.HeaderText = "Email";
            this.emailCustomer.MinimumWidth = 6;
            this.emailCustomer.Name = "emailCustomer";
            this.emailCustomer.Width = 125;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(27, 207);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(113, 38);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(167, 207);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(113, 38);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(307, 207);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(113, 38);
            this.btnCapNhat.TabIndex = 3;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(15, 39);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(103, 16);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "Tên khách hàng";
            // 
            // lbAddr
            // 
            this.lbAddr.AutoSize = true;
            this.lbAddr.Location = new System.Drawing.Point(15, 79);
            this.lbAddr.Name = "lbAddr";
            this.lbAddr.Size = new System.Drawing.Size(47, 16);
            this.lbAddr.TabIndex = 5;
            this.lbAddr.Text = "Địa chỉ";
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Location = new System.Drawing.Point(15, 120);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(85, 16);
            this.lbPhoneNumber.TabIndex = 6;
            this.lbPhoneNumber.Text = "Số điện thoại";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(15, 156);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(41, 16);
            this.lbEmail.TabIndex = 7;
            this.lbEmail.Text = "Email";
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Location = new System.Drawing.Point(124, 39);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(296, 22);
            this.tbName.TabIndex = 8;
            // 
            // tbAddr
            // 
            this.tbAddr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAddr.Location = new System.Drawing.Point(124, 79);
            this.tbAddr.Name = "tbAddr";
            this.tbAddr.Size = new System.Drawing.Size(296, 22);
            this.tbAddr.TabIndex = 9;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPhoneNumber.Location = new System.Drawing.Point(124, 114);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(156, 22);
            this.tbPhoneNumber.TabIndex = 10;
            // 
            // tbEmail
            // 
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEmail.Location = new System.Drawing.Point(124, 154);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(296, 22);
            this.tbEmail.TabIndex = 11;
            // 
            // CustomerManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.tbAddr);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbPhoneNumber);
            this.Controls.Add(this.lbAddr);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvCustomer);
            this.Name = "CustomerManagementForm";
            this.Size = new System.Drawing.Size(1106, 595);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailCustomer;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbAddr;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAddr;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.TextBox tbEmail;
    }
}
