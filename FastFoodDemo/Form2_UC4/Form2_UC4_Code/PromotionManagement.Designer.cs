namespace FastFoodDemo.Form2_UC4.Form2_UC4_Code
{
    partial class Promotion_Management
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPromotionManager = new System.Windows.Forms.Label();
            this.lblNhomHang = new System.Windows.Forms.Label();
            this.cbProductType = new System.Windows.Forms.ComboBox();
            this.dataGridViewPromotions = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbNhomHang = new System.Windows.Forms.ComboBox();
            this.txtTenChuongTrinh = new System.Windows.Forms.TextBox();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.txtMotachuongtrinh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaKhuyenMai = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPromotions)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.lblPromotionManager);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1375, 91);
            this.panel1.TabIndex = 0;
            // 
            // lblPromotionManager
            // 
            this.lblPromotionManager.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromotionManager.Location = new System.Drawing.Point(513, 0);
            this.lblPromotionManager.Name = "lblPromotionManager";
            this.lblPromotionManager.Size = new System.Drawing.Size(399, 91);
            this.lblPromotionManager.TabIndex = 1;
            this.lblPromotionManager.Text = "Chương trình khuyến mãi";
            this.lblPromotionManager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNhomHang
            // 
            this.lblNhomHang.AutoSize = true;
            this.lblNhomHang.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhomHang.Location = new System.Drawing.Point(287, 185);
            this.lblNhomHang.Name = "lblNhomHang";
            this.lblNhomHang.Size = new System.Drawing.Size(181, 19);
            this.lblNhomHang.TabIndex = 1;
            this.lblNhomHang.Text = "Nhóm hàng khuyến mãi";
            // 
            // cbProductType
            // 
            this.cbProductType.FormattingEnabled = true;
            this.cbProductType.Items.AddRange(new object[] {
            "",
            "LOẠI 1",
            "LOẠI 2",
            "LOẠI 3",
            "LOẠI 4",
            "LOẠI 5"});
            this.cbProductType.Location = new System.Drawing.Point(474, 183);
            this.cbProductType.Name = "cbProductType";
            this.cbProductType.Size = new System.Drawing.Size(116, 24);
            this.cbProductType.TabIndex = 5;
            this.cbProductType.SelectedIndexChanged += new System.EventHandler(this.cbProductType_SelectedIndexChanged);
            // 
            // dataGridViewPromotions
            // 
            this.dataGridViewPromotions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPromotions.Location = new System.Drawing.Point(21, 213);
            this.dataGridViewPromotions.Name = "dataGridViewPromotions";
            this.dataGridViewPromotions.RowHeadersWidth = 51;
            this.dataGridViewPromotions.RowTemplate.Height = 24;
            this.dataGridViewPromotions.Size = new System.Drawing.Size(961, 538);
            this.dataGridViewPromotions.TabIndex = 7;
            this.dataGridViewPromotions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPromotions_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 350);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 25);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(134, 350);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(98, 25);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(252, 350);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 25);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePickerEnd);
            this.groupBox1.Controls.Add(this.dateTimePickerStart);
            this.groupBox1.Controls.Add(this.txtMotachuongtrinh);
            this.groupBox1.Controls.Add(this.txtMaKhuyenMai);
            this.groupBox1.Controls.Add(this.txtTenChuongTrinh);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.cbNhomHang);
            this.groupBox1.Location = new System.Drawing.Point(988, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 477);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chỉnh sửa";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(21, 184);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "Tải lên";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(907, 185);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbNhomHang
            // 
            this.cbNhomHang.FormattingEnabled = true;
            this.cbNhomHang.Items.AddRange(new object[] {
            "LOẠI 1",
            "LOẠI 2",
            "LOẠI 3",
            "LOẠI 4",
            "LOẠI 5"});
            this.cbNhomHang.Location = new System.Drawing.Point(155, 31);
            this.cbNhomHang.Name = "cbNhomHang";
            this.cbNhomHang.Size = new System.Drawing.Size(116, 24);
            this.cbNhomHang.TabIndex = 5;
            this.cbNhomHang.SelectedIndexChanged += new System.EventHandler(this.cbProductType_SelectedIndexChanged);
            // 
            // txtTenChuongTrinh
            // 
            this.txtTenChuongTrinh.Location = new System.Drawing.Point(155, 124);
            this.txtTenChuongTrinh.Name = "txtTenChuongTrinh";
            this.txtTenChuongTrinh.Size = new System.Drawing.Size(116, 22);
            this.txtTenChuongTrinh.TabIndex = 9;

            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(155, 171);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerStart.TabIndex = 10;
            this.dateTimePickerStart.Value = new System.DateTime(2024, 4, 11, 0, 0, 0, 0);

            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(155, 219);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(201, 22);
            this.dateTimePickerEnd.TabIndex = 11;
            this.dateTimePickerEnd.Value = new System.DateTime(2024, 4, 11, 0, 0, 0, 0);

            // 
            // txtMotachuongtrinh
            // 
            this.txtMotachuongtrinh.Location = new System.Drawing.Point(155, 262);
            this.txtMotachuongtrinh.Name = "txtMotachuongtrinh";
            this.txtMotachuongtrinh.Size = new System.Drawing.Size(116, 22);
            this.txtMotachuongtrinh.TabIndex = 9;

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nhóm hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã khuyến mãi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tên chương trình";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ngày bắt đầu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ngày kết thúc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mô tả chương trình";
            // 
            // txtMaKhuyenMai
            // 
            this.txtMaKhuyenMai.Location = new System.Drawing.Point(155, 81);
            this.txtMaKhuyenMai.Name = "txtMaKhuyenMai";
            this.txtMaKhuyenMai.Size = new System.Drawing.Size(116, 22);
            this.txtMaKhuyenMai.TabIndex = 9;

            // 
            // Promotion_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewPromotions);
            this.Controls.Add(this.cbProductType);
            this.Controls.Add(this.lblNhomHang);
            this.Controls.Add(this.panel1);
            this.Name = "Promotion_Management";
            this.Size = new System.Drawing.Size(1375, 842);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPromotions)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPromotionManager;
        private System.Windows.Forms.Label lblNhomHang;
        private System.Windows.Forms.ComboBox cbProductType;
        private System.Windows.Forms.DataGridView dataGridViewPromotions;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbNhomHang;
        private System.Windows.Forms.TextBox txtTenChuongTrinh;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMotachuongtrinh;
        private System.Windows.Forms.TextBox txtMaKhuyenMai;
    }
}
