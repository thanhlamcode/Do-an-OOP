namespace FastFoodDemo.Form2_UC
{
    partial class QLNV
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
            this.Delbtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Delbtn
            // 
            this.Delbtn.BackColor = System.Drawing.Color.DarkOrange;
            this.Delbtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delbtn.ForeColor = System.Drawing.Color.White;
            this.Delbtn.Location = new System.Drawing.Point(133, 520);
            this.Delbtn.Name = "Delbtn";
            this.Delbtn.Size = new System.Drawing.Size(228, 41);
            this.Delbtn.TabIndex = 18;
            this.Delbtn.Text = "Xóa";
            this.Delbtn.UseVisualStyleBackColor = false;
            this.Delbtn.Click += new System.EventHandler(this.Delbtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.BackColor = System.Drawing.Color.DarkOrange;
            this.Savebtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebtn.ForeColor = System.Drawing.Color.White;
            this.Savebtn.Location = new System.Drawing.Point(725, 520);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(228, 41);
            this.Savebtn.TabIndex = 21;
            this.Savebtn.Text = "Lưu";
            this.Savebtn.UseVisualStyleBackColor = false;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1106, 491);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridView1_Scroll);
            // 
            // QLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.Delbtn);
            this.Name = "QLNV";
            this.Size = new System.Drawing.Size(1106, 595);
            this.Load += new System.EventHandler(this.QLNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Delbtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
