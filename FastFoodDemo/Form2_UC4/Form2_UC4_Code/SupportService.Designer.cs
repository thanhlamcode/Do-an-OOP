namespace FastFoodDemo.Form2_UC4.Form2_UC4_Code
{
    partial class SupportService
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
            this.dataGridViewRequests = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDanhGia = new System.Windows.Forms.TextBox();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.txtNgaySuDung = new System.Windows.Forms.TextBox();
            this.txtDichVuSuDung = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.btnXuLy = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.radChuaTiepNhanXuLy = new System.Windows.Forms.RadioButton();
            this.radTiepNhanXuLy = new System.Windows.Forms.RadioButton();
            this.radDaXyLy = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequests)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewRequests
            // 
            this.dataGridViewRequests.AllowUserToAddRows = false;
            this.dataGridViewRequests.AllowUserToDeleteRows = false;
            this.dataGridViewRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequests.Location = new System.Drawing.Point(12, 162);
            this.dataGridViewRequests.Name = "dataGridViewRequests";
            this.dataGridViewRequests.ReadOnly = true;
            this.dataGridViewRequests.RowHeadersWidth = 51;
            this.dataGridViewRequests.RowTemplate.Height = 24;
            this.dataGridViewRequests.Size = new System.Drawing.Size(734, 403);
            this.dataGridViewRequests.TabIndex = 0;
            this.dataGridViewRequests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRequests_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 100);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(426, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Dịch Vụ Hỗ Trợ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDanhGia);
            this.groupBox1.Controls.Add(this.txtTinhTrang);
            this.groupBox1.Controls.Add(this.txtNgaySuDung);
            this.groupBox1.Controls.Add(this.txtDichVuSuDung);
            this.groupBox1.Controls.Add(this.txtTenKhachHang);
            this.groupBox1.Controls.Add(this.btnXuLy);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Location = new System.Drawing.Point(788, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 403);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Đánh giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tình trạng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày sử dụng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dịch vụ sử dụng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên khách hàng";
            // 
            // txtDanhGia
            // 
            this.txtDanhGia.Location = new System.Drawing.Point(143, 256);
            this.txtDanhGia.Name = "txtDanhGia";
            this.txtDanhGia.ReadOnly = true;
            this.txtDanhGia.Size = new System.Drawing.Size(172, 22);
            this.txtDanhGia.TabIndex = 3;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(143, 201);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.ReadOnly = true;
            this.txtTinhTrang.Size = new System.Drawing.Size(172, 22);
            this.txtTinhTrang.TabIndex = 3;
            // 
            // txtNgaySuDung
            // 
            this.txtNgaySuDung.Location = new System.Drawing.Point(143, 149);
            this.txtNgaySuDung.Name = "txtNgaySuDung";
            this.txtNgaySuDung.ReadOnly = true;
            this.txtNgaySuDung.Size = new System.Drawing.Size(172, 22);
            this.txtNgaySuDung.TabIndex = 3;
            // 
            // txtDichVuSuDung
            // 
            this.txtDichVuSuDung.Location = new System.Drawing.Point(143, 93);
            this.txtDichVuSuDung.Name = "txtDichVuSuDung";
            this.txtDichVuSuDung.ReadOnly = true;
            this.txtDichVuSuDung.Size = new System.Drawing.Size(172, 22);
            this.txtDichVuSuDung.TabIndex = 3;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(143, 45);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.ReadOnly = true;
            this.txtTenKhachHang.Size = new System.Drawing.Size(172, 22);
            this.txtTenKhachHang.TabIndex = 3;
            // 
            // btnXuLy
            // 
            this.btnXuLy.Location = new System.Drawing.Point(135, 335);
            this.btnXuLy.Name = "btnXuLy";
            this.btnXuLy.Size = new System.Drawing.Size(78, 29);
            this.btnXuLy.TabIndex = 2;
            this.btnXuLy.Text = "Xử lý ";
            this.btnXuLy.UseVisualStyleBackColor = true;
            this.btnXuLy.Click += new System.EventHandler(this.btnXuLy_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(234, 335);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 29);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(32, 335);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 29);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // radChuaTiepNhanXuLy
            // 
            this.radChuaTiepNhanXuLy.AutoSize = true;
            this.radChuaTiepNhanXuLy.Location = new System.Drawing.Point(82, 126);
            this.radChuaTiepNhanXuLy.Name = "radChuaTiepNhanXuLy";
            this.radChuaTiepNhanXuLy.Size = new System.Drawing.Size(88, 20);
            this.radChuaTiepNhanXuLy.TabIndex = 3;
            this.radChuaTiepNhanXuLy.TabStop = true;
            this.radChuaTiepNhanXuLy.Text = "Chưa xử lý";
            this.radChuaTiepNhanXuLy.UseVisualStyleBackColor = true;
            this.radChuaTiepNhanXuLy.CheckedChanged += new System.EventHandler(this.radChuaTiepNhanXuLy_CheckedChanged);
            // 
            // radTiepNhanXuLy
            // 
            this.radTiepNhanXuLy.AutoSize = true;
            this.radTiepNhanXuLy.Location = new System.Drawing.Point(216, 126);
            this.radTiepNhanXuLy.Name = "radTiepNhanXuLy";
            this.radTiepNhanXuLy.Size = new System.Drawing.Size(89, 20);
            this.radTiepNhanXuLy.TabIndex = 4;
            this.radTiepNhanXuLy.TabStop = true;
            this.radTiepNhanXuLy.Text = "Đang xử lý";
            this.radTiepNhanXuLy.UseVisualStyleBackColor = true;
            this.radTiepNhanXuLy.CheckedChanged += new System.EventHandler(this.radTiepNhanXuLy_CheckedChanged);
            // 
            // radDaXyLy
            // 
            this.radDaXyLy.AutoSize = true;
            this.radDaXyLy.Location = new System.Drawing.Point(347, 126);
            this.radDaXyLy.Name = "radDaXyLy";
            this.radDaXyLy.Size = new System.Drawing.Size(74, 20);
            this.radDaXyLy.TabIndex = 4;
            this.radDaXyLy.TabStop = true;
            this.radDaXyLy.Text = "Đã xử lý";
            this.radDaXyLy.UseVisualStyleBackColor = true;
            this.radDaXyLy.CheckedChanged += new System.EventHandler(this.radDaXuLy_CheckedChanged);
            // 
            // SupportService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radDaXyLy);
            this.Controls.Add(this.radTiepNhanXuLy);
            this.Controls.Add(this.radChuaTiepNhanXuLy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewRequests);
            this.Name = "SupportService";
            this.Size = new System.Drawing.Size(1160, 582);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequests)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRequests;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton radChuaTiepNhanXuLy;
        private System.Windows.Forms.RadioButton radTiepNhanXuLy;
        private System.Windows.Forms.RadioButton radDaXyLy;
        private System.Windows.Forms.Button btnXuLy;
        private System.Windows.Forms.TextBox txtDanhGia;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.TextBox txtNgaySuDung;
        private System.Windows.Forms.TextBox txtDichVuSuDung;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
