namespace FastFoodDemo.Form2_UC3
{
    partial class OrderManagementForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnInHD = new System.Windows.Forms.Button();
            this.btnLuuHD = new System.Windows.Forms.Button();
            this.btnHuyHD = new System.Windows.Forms.Button();
            this.btnThemHD = new System.Windows.Forms.Button();
            this.cbMaHD = new System.Windows.Forms.ComboBox();
            this.lbMaHD = new System.Windows.Forms.Label();
            this.lbOrder = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKH = new System.Windows.Forms.TextBox();
            this.txtNV = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.lbNgayBan = new System.Windows.Forms.Label();
            this.lbMaHDchung = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDG = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.tenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbSP = new System.Windows.Forms.ComboBox();
            this.lbTenSP = new System.Windows.Forms.Label();
            this.lbDG = new System.Windows.Forms.Label();
            this.lbSL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnInHD);
            this.splitContainer1.Panel1.Controls.Add(this.btnLuuHD);
            this.splitContainer1.Panel1.Controls.Add(this.btnHuyHD);
            this.splitContainer1.Panel1.Controls.Add(this.btnThemHD);
            this.splitContainer1.Panel1.Controls.Add(this.cbMaHD);
            this.splitContainer1.Panel1.Controls.Add(this.lbMaHD);
            this.splitContainer1.Panel1.Controls.Add(this.lbOrder);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1103, 592);
            this.splitContainer1.SplitterDistance = 258;
            this.splitContainer1.TabIndex = 2;
            // 
            // btnInHD
            // 
            this.btnInHD.Location = new System.Drawing.Point(833, 46);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(120, 36);
            this.btnInHD.TabIndex = 10;
            this.btnInHD.Text = "In hóa đơn";
            this.btnInHD.UseVisualStyleBackColor = true;
            this.btnInHD.Click += new System.EventHandler(this.btnInHD_Click);
            // 
            // btnLuuHD
            // 
            this.btnLuuHD.Location = new System.Drawing.Point(707, 46);
            this.btnLuuHD.Name = "btnLuuHD";
            this.btnLuuHD.Size = new System.Drawing.Size(120, 36);
            this.btnLuuHD.TabIndex = 9;
            this.btnLuuHD.Text = "Lưu hóa đơn";
            this.btnLuuHD.UseVisualStyleBackColor = true;
            this.btnLuuHD.Click += new System.EventHandler(this.btnLuuHD_Click);
            // 
            // btnHuyHD
            // 
            this.btnHuyHD.Location = new System.Drawing.Point(582, 46);
            this.btnHuyHD.Name = "btnHuyHD";
            this.btnHuyHD.Size = new System.Drawing.Size(119, 36);
            this.btnHuyHD.TabIndex = 8;
            this.btnHuyHD.Text = "Hủy hóa đơn";
            this.btnHuyHD.UseVisualStyleBackColor = true;
            this.btnHuyHD.Click += new System.EventHandler(this.btnHuyHD_Click);
            // 
            // btnThemHD
            // 
            this.btnThemHD.Location = new System.Drawing.Point(456, 46);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(120, 36);
            this.btnThemHD.TabIndex = 7;
            this.btnThemHD.Text = "Thêm hóa đơn";
            this.btnThemHD.UseVisualStyleBackColor = true;
            this.btnThemHD.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // cbMaHD
            // 
            this.cbMaHD.FormattingEnabled = true;
            this.cbMaHD.Location = new System.Drawing.Point(120, 53);
            this.cbMaHD.Name = "cbMaHD";
            this.cbMaHD.Size = new System.Drawing.Size(330, 24);
            this.cbMaHD.TabIndex = 5;
            this.cbMaHD.SelectedIndexChanged += new System.EventHandler(this.cbMaHD_SelectedIndexChanged);
            // 
            // lbMaHD
            // 
            this.lbMaHD.AutoSize = true;
            this.lbMaHD.Location = new System.Drawing.Point(36, 56);
            this.lbMaHD.Name = "lbMaHD";
            this.lbMaHD.Size = new System.Drawing.Size(78, 16);
            this.lbMaHD.TabIndex = 4;
            this.lbMaHD.Text = "Mã hóa đơn";
            // 
            // lbOrder
            // 
            this.lbOrder.AutoSize = true;
            this.lbOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbOrder.ForeColor = System.Drawing.Color.Blue;
            this.lbOrder.Location = new System.Drawing.Point(371, -3);
            this.lbOrder.Name = "lbOrder";
            this.lbOrder.Size = new System.Drawing.Size(343, 42);
            this.lbOrder.TabIndex = 2;
            this.lbOrder.Text = "Hóa đơn bán hàng";
            this.lbOrder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKH);
            this.groupBox1.Controls.Add(this.txtNV);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Controls.Add(this.lbMaKH);
            this.groupBox1.Controls.Add(this.lbMaNV);
            this.groupBox1.Controls.Add(this.lbNgayBan);
            this.groupBox1.Controls.Add(this.lbMaHDchung);
            this.groupBox1.Location = new System.Drawing.Point(33, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1049, 170);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // txtKH
            // 
            this.txtKH.Location = new System.Drawing.Point(208, 140);
            this.txtKH.Name = "txtKH";
            this.txtKH.Size = new System.Drawing.Size(209, 22);
            this.txtKH.TabIndex = 7;
            // 
            // txtNV
            // 
            this.txtNV.Location = new System.Drawing.Point(208, 100);
            this.txtNV.Name = "txtNV";
            this.txtNV.Size = new System.Drawing.Size(209, 22);
            this.txtNV.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(208, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(209, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(208, 20);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.ReadOnly = true;
            this.txtMaHD.Size = new System.Drawing.Size(209, 22);
            this.txtMaHD.TabIndex = 4;
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Location = new System.Drawing.Point(102, 140);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(98, 16);
            this.lbMaKH.TabIndex = 3;
            this.lbMaKH.Text = "Mã khách hàng";
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Location = new System.Drawing.Point(102, 100);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(86, 16);
            this.lbMaNV.TabIndex = 2;
            this.lbMaNV.Text = "Mã nhân viên";
            // 
            // lbNgayBan
            // 
            this.lbNgayBan.AutoSize = true;
            this.lbNgayBan.Location = new System.Drawing.Point(102, 60);
            this.lbNgayBan.Name = "lbNgayBan";
            this.lbNgayBan.Size = new System.Drawing.Size(66, 16);
            this.lbNgayBan.TabIndex = 1;
            this.lbNgayBan.Text = "Ngày bán";
            // 
            // lbMaHDchung
            // 
            this.lbMaHDchung.AutoSize = true;
            this.lbMaHDchung.Location = new System.Drawing.Point(102, 20);
            this.lbMaHDchung.Name = "lbMaHDchung";
            this.lbMaHDchung.Size = new System.Drawing.Size(78, 16);
            this.lbMaHDchung.TabIndex = 0;
            this.lbMaHDchung.Text = "Mã hóa đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDG);
            this.groupBox2.Controls.Add(this.txtSL);
            this.groupBox2.Controls.Add(this.btnXoaSP);
            this.groupBox2.Controls.Add(this.btnThemSP);
            this.groupBox2.Controls.Add(this.txtTongTien);
            this.groupBox2.Controls.Add(this.lbTongTien);
            this.groupBox2.Controls.Add(this.dgvOrder);
            this.groupBox2.Controls.Add(this.cbSP);
            this.groupBox2.Controls.Add(this.lbTenSP);
            this.groupBox2.Controls.Add(this.lbDG);
            this.groupBox2.Controls.Add(this.lbSL);
            this.groupBox2.Location = new System.Drawing.Point(33, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1049, 347);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // txtDG
            // 
            this.txtDG.Location = new System.Drawing.Point(582, 29);
            this.txtDG.Name = "txtDG";
            this.txtDG.ReadOnly = true;
            this.txtDG.Size = new System.Drawing.Size(176, 22);
            this.txtDG.TabIndex = 14;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(386, 26);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(131, 22);
            this.txtSL.TabIndex = 13;
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.Location = new System.Drawing.Point(905, 19);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(120, 36);
            this.btnXoaSP.TabIndex = 12;
            this.btnXoaSP.Text = "Xóa sản phẩm";
            this.btnXoaSP.UseVisualStyleBackColor = true;
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // btnThemSP
            // 
            this.btnThemSP.Location = new System.Drawing.Point(764, 17);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(135, 36);
            this.btnThemSP.TabIndex = 11;
            this.btnThemSP.Text = "Thêm sản phẩm";
            this.btnThemSP.UseVisualStyleBackColor = true;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(789, 279);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(236, 22);
            this.txtTongTien.TabIndex = 10;
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Location = new System.Drawing.Point(720, 285);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(63, 16);
            this.lbTongTien.TabIndex = 9;
            this.lbTongTien.Text = "Tổng tiền";
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenSP,
            this.SL,
            this.DG,
            this.thanhTien});
            this.dgvOrder.Location = new System.Drawing.Point(6, 59);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.Size = new System.Drawing.Size(1019, 214);
            this.dgvOrder.TabIndex = 8;
            // 
            // tenSP
            // 
            this.tenSP.HeaderText = "Tên sản phẩm";
            this.tenSP.MinimumWidth = 6;
            this.tenSP.Name = "tenSP";
            this.tenSP.Width = 125;
            // 
            // SL
            // 
            this.SL.HeaderText = "Số lượng";
            this.SL.MinimumWidth = 6;
            this.SL.Name = "SL";
            this.SL.Width = 125;
            // 
            // DG
            // 
            this.DG.HeaderText = "Đơn giá";
            this.DG.MinimumWidth = 6;
            this.DG.Name = "DG";
            this.DG.Width = 125;
            // 
            // thanhTien
            // 
            this.thanhTien.HeaderText = "Thành tiền";
            this.thanhTien.MinimumWidth = 6;
            this.thanhTien.Name = "thanhTien";
            this.thanhTien.Width = 125;
            // 
            // cbSP
            // 
            this.cbSP.FormattingEnabled = true;
            this.cbSP.Location = new System.Drawing.Point(105, 24);
            this.cbSP.Name = "cbSP";
            this.cbSP.Size = new System.Drawing.Size(209, 24);
            this.cbSP.TabIndex = 7;
            this.cbSP.SelectedIndexChanged += new System.EventHandler(this.cbSP_SelectedIndexChanged);
            // 
            // lbTenSP
            // 
            this.lbTenSP.AutoSize = true;
            this.lbTenSP.Location = new System.Drawing.Point(6, 29);
            this.lbTenSP.Name = "lbTenSP";
            this.lbTenSP.Size = new System.Drawing.Size(93, 16);
            this.lbTenSP.TabIndex = 0;
            this.lbTenSP.Text = "Tên sản phẩm";
            // 
            // lbDG
            // 
            this.lbDG.AutoSize = true;
            this.lbDG.Location = new System.Drawing.Point(523, 29);
            this.lbDG.Name = "lbDG";
            this.lbDG.Size = new System.Drawing.Size(53, 16);
            this.lbDG.TabIndex = 2;
            this.lbDG.Text = "Đơn giá";
            // 
            // lbSL
            // 
            this.lbSL.AutoSize = true;
            this.lbSL.Location = new System.Drawing.Point(320, 29);
            this.lbSL.Name = "lbSL";
            this.lbSL.Size = new System.Drawing.Size(60, 16);
            this.lbSL.TabIndex = 1;
            this.lbSL.Text = "Số lượng";
            // 
            // OrderManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "OrderManagementForm";
            this.Size = new System.Drawing.Size(1106, 595);
            this.Load += new System.EventHandler(this.OrderManagementForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Label lbNgayBan;
        private System.Windows.Forms.Label lbMaHDchung;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbTenSP;
        private System.Windows.Forms.Label lbDG;
        private System.Windows.Forms.Label lbSL;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.ComboBox cbSP;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.ComboBox cbMaHD;
        private System.Windows.Forms.Label lbMaHD;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.Button btnInHD;
        private System.Windows.Forms.Button btnLuuHD;
        private System.Windows.Forms.Button btnHuyHD;
        private System.Windows.Forms.Button btnThemHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTien;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.TextBox txtDG;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtKH;
        private System.Windows.Forms.TextBox txtNV;
    }
}
