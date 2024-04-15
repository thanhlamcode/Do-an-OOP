namespace FastFoodDemo.Form2_UC4.Form2_UC4_Code
{
    partial class Return_Management_Form
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
            this.lstvOrderlist = new System.Windows.Forms.ListView();
            this.colRequiredCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCustomerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateRequired = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRequiredDetail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpQuickFilter = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnProcessed = new System.Windows.Forms.Button();
            this.btnNoProcess = new System.Windows.Forms.Button();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtRequiredCode = new System.Windows.Forms.TextBox();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpTimeFilter = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.lblChonHoaDon = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtChiTietHoaDon = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtMaYeuCau = new System.Windows.Forms.TextBox();
            this.btnUpLoad = new System.Windows.Forms.Button();
            this.grpQuickFilter.SuspendLayout();
            this.grpFilter.SuspendLayout();
            this.grpTimeFilter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstvOrderlist
            // 
            this.lstvOrderlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colRequiredCode,
            this.colCustomerName,
            this.colSDT,
            this.colDateRequired,
            this.colRequiredDetail,
            this.colStatus});
            this.lstvOrderlist.HideSelection = false;
            this.lstvOrderlist.LabelEdit = true;
            this.lstvOrderlist.Location = new System.Drawing.Point(450, 71);
            this.lstvOrderlist.Name = "lstvOrderlist";
            this.lstvOrderlist.Size = new System.Drawing.Size(909, 573);
            this.lstvOrderlist.TabIndex = 0;
            this.lstvOrderlist.UseCompatibleStateImageBehavior = false;
            this.lstvOrderlist.SelectedIndexChanged += new System.EventHandler(this.lstvOrderlist_SelectedIndexChanged);
            // 
            // colRequiredCode
            // 
            this.colRequiredCode.Text = "Mã yêu cầu";
            // 
            // colCustomerName
            // 
            this.colCustomerName.Text = "Tên khách hàng ";
            this.colCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colSDT
            // 
            this.colSDT.Text = "Số điện thoại";
            this.colSDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colDateRequired
            // 
            this.colDateRequired.Text = "Ngày yêu cầu";
            this.colDateRequired.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colRequiredDetail
            // 
            this.colRequiredDetail.Text = "Chi tiết yêu cầu";
            this.colRequiredDetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Trạng thái";
            this.colStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpQuickFilter
            // 
            this.grpQuickFilter.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpQuickFilter.Controls.Add(this.btnSave);
            this.grpQuickFilter.Controls.Add(this.btnProcess);
            this.grpQuickFilter.Controls.Add(this.btnReturn);
            this.grpQuickFilter.Controls.Add(this.btnChange);
            this.grpQuickFilter.Controls.Add(this.btnProcessed);
            this.grpQuickFilter.Controls.Add(this.btnNoProcess);
            this.grpQuickFilter.Location = new System.Drawing.Point(450, 666);
            this.grpQuickFilter.Name = "grpQuickFilter";
            this.grpQuickFilter.Size = new System.Drawing.Size(909, 100);
            this.grpQuickFilter.TabIndex = 1;
            this.grpQuickFilter.TabStop = false;
            this.grpQuickFilter.Text = "Lọc nhanh";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(746, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 57);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(607, 21);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(101, 57);
            this.btnProcess.TabIndex = 1;
            this.btnProcess.Text = "Xử lý đơn hàng";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(471, 21);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(101, 57);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Yêu cầu trả hàng";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(332, 21);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(101, 57);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "Yêu cầu đổi hàng";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnProcessed
            // 
            this.btnProcessed.Location = new System.Drawing.Point(197, 21);
            this.btnProcessed.Name = "btnProcessed";
            this.btnProcessed.Size = new System.Drawing.Size(101, 57);
            this.btnProcessed.TabIndex = 1;
            this.btnProcessed.Text = "Đơn đã xử lý";
            this.btnProcessed.UseVisualStyleBackColor = true;
            this.btnProcessed.Click += new System.EventHandler(this.btnProcessed_Click);
            // 
            // btnNoProcess
            // 
            this.btnNoProcess.Location = new System.Drawing.Point(66, 21);
            this.btnNoProcess.Name = "btnNoProcess";
            this.btnNoProcess.Size = new System.Drawing.Size(101, 57);
            this.btnNoProcess.TabIndex = 0;
            this.btnNoProcess.Text = "Đơn chưa xử lý";
            this.btnNoProcess.UseVisualStyleBackColor = true;
            this.btnNoProcess.Click += new System.EventHandler(this.btnNoProcess_Click);
            // 
            // grpFilter
            // 
            this.grpFilter.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.grpFilter.Controls.Add(this.txtSDT);
            this.grpFilter.Controls.Add(this.txtCustomerName);
            this.grpFilter.Controls.Add(this.txtRequiredCode);
            this.grpFilter.Controls.Add(this.btnDeleteAll);
            this.grpFilter.Controls.Add(this.btnSearch);
            this.grpFilter.Location = new System.Drawing.Point(3, 135);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(312, 232);
            this.grpFilter.TabIndex = 1;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Tìm kiếm hóa đơn";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(16, 102);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(268, 22);
            this.txtSDT.TabIndex = 0;
            this.txtSDT.Text = "Nhập SĐT khách hàng";
            this.txtSDT.Enter += new System.EventHandler(this.txtSDT_Enter);
            this.txtSDT.Leave += new System.EventHandler(this.txtSDT_Leave);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(16, 62);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(268, 22);
            this.txtCustomerName.TabIndex = 0;
            this.txtCustomerName.Text = "Nhập tên khách hàng";
            this.txtCustomerName.Enter += new System.EventHandler(this.txtCustomerName_Enter);
            this.txtCustomerName.Leave += new System.EventHandler(this.txtCustomerName_Leave);
            // 
            // txtRequiredCode
            // 
            this.txtRequiredCode.Location = new System.Drawing.Point(16, 22);
            this.txtRequiredCode.Name = "txtRequiredCode";
            this.txtRequiredCode.Size = new System.Drawing.Size(268, 22);
            this.txtRequiredCode.TabIndex = 0;
            this.txtRequiredCode.Text = "Nhập mã yêu cầu";
            this.txtRequiredCode.Enter += new System.EventHandler(this.txtRequiredCode_Enter);
            this.txtRequiredCode.Leave += new System.EventHandler(this.txtRequiredCode_Leave);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(138, 146);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(101, 57);
            this.btnDeleteAll.TabIndex = 0;
            this.btnDeleteAll.Text = "Xóa toàn bộ";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(16, 146);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 57);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Lọc";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grpTimeFilter
            // 
            this.grpTimeFilter.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.grpTimeFilter.Controls.Add(this.label2);
            this.grpTimeFilter.Controls.Add(this.label1);
            this.grpTimeFilter.Controls.Add(this.dateTimePickerTo);
            this.grpTimeFilter.Controls.Add(this.dateTimePickerFrom);
            this.grpTimeFilter.Location = new System.Drawing.Point(3, 416);
            this.grpTimeFilter.Name = "grpTimeFilter";
            this.grpTimeFilter.Size = new System.Drawing.Size(312, 106);
            this.grpTimeFilter.TabIndex = 1;
            this.grpTimeFilter.TabStop = false;
            this.grpTimeFilter.Text = "Tìm kiếm theo thời gian";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(55, 66);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.ShowUpDown = true;
            this.dateTimePickerTo.Size = new System.Drawing.Size(229, 22);
            this.dateTimePickerTo.TabIndex = 1;
            this.dateTimePickerTo.ValueChanged += new System.EventHandler(this.dateTimePickerTo_ValueChanged);
            this.dateTimePickerTo.Enter += new System.EventHandler(this.dateTimePickerTo_Enter);
            this.dateTimePickerTo.Leave += new System.EventHandler(this.dateTimePickerTo_Leave);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(55, 21);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.ShowUpDown = true;
            this.dateTimePickerFrom.Size = new System.Drawing.Size(229, 22);
            this.dateTimePickerFrom.TabIndex = 0;
            this.dateTimePickerFrom.ValueChanged += new System.EventHandler(this.dateTimePickerFrom_ValueChanged);
            this.dateTimePickerFrom.Leave += new System.EventHandler(this.dateTimePickerFrom_Leave);
            // 
            // lblChonHoaDon
            // 
            this.lblChonHoaDon.AutoSize = true;
            this.lblChonHoaDon.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonHoaDon.Location = new System.Drawing.Point(12, 25);
            this.lblChonHoaDon.Name = "lblChonHoaDon";
            this.lblChonHoaDon.Size = new System.Drawing.Size(408, 38);
            this.lblChonHoaDon.TabIndex = 2;
            this.lblChonHoaDon.Text = "Chọn hóa đơn muốn đổi/trả";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(42, 167);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(162, 167);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(101, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(282, 167);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSoDienThoai);
            this.groupBox1.Controls.Add(this.txtChiTietHoaDon);
            this.groupBox1.Controls.Add(this.txtTenKhachHang);
            this.groupBox1.Controls.Add(this.txtMaYeuCau);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Location = new System.Drawing.Point(3, 570);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 196);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chỉnh sửa";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(138, 109);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(268, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Chi tiết hóa đơn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày yêu cầu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã yêu cầu";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(138, 80);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(268, 22);
            this.txtSoDienThoai.TabIndex = 4;
            // 
            // txtChiTietHoaDon
            // 
            this.txtChiTietHoaDon.Location = new System.Drawing.Point(138, 136);
            this.txtChiTietHoaDon.Name = "txtChiTietHoaDon";
            this.txtChiTietHoaDon.Size = new System.Drawing.Size(268, 22);
            this.txtChiTietHoaDon.TabIndex = 4;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(138, 52);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(268, 22);
            this.txtTenKhachHang.TabIndex = 4;
            // 
            // txtMaYeuCau
            // 
            this.txtMaYeuCau.Location = new System.Drawing.Point(138, 24);
            this.txtMaYeuCau.Name = "txtMaYeuCau";
            this.txtMaYeuCau.Size = new System.Drawing.Size(268, 22);
            this.txtMaYeuCau.TabIndex = 4;
            // 
            // btnUpLoad
            // 
            this.btnUpLoad.Location = new System.Drawing.Point(1247, 39);
            this.btnUpLoad.Name = "btnUpLoad";
            this.btnUpLoad.Size = new System.Drawing.Size(75, 23);
            this.btnUpLoad.TabIndex = 5;
            this.btnUpLoad.Text = "Tải lên";
            this.btnUpLoad.UseVisualStyleBackColor = true;
            this.btnUpLoad.Click += new System.EventHandler(this.btnUpLoad_Click);
            // 
            // Return_Management_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnUpLoad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblChonHoaDon);
            this.Controls.Add(this.grpTimeFilter);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.grpQuickFilter);
            this.Controls.Add(this.lstvOrderlist);
            this.Name = "Return_Management_Form";
            this.Size = new System.Drawing.Size(1375, 842);
            this.grpQuickFilter.ResumeLayout(false);
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.grpTimeFilter.ResumeLayout(false);
            this.grpTimeFilter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvOrderlist;
        private System.Windows.Forms.GroupBox grpQuickFilter;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.GroupBox grpTimeFilter;
        private System.Windows.Forms.Label lblChonHoaDon;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnProcessed;
        private System.Windows.Forms.Button btnNoProcess;
        private System.Windows.Forms.TextBox txtRequiredCode;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ColumnHeader colRequiredCode;
        private System.Windows.Forms.ColumnHeader colCustomerName;
        private System.Windows.Forms.ColumnHeader colSDT;
        private System.Windows.Forms.ColumnHeader colDateRequired;
        private System.Windows.Forms.ColumnHeader colRequiredDetail;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaYeuCau;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtChiTietHoaDon;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnUpLoad;
    }
}
