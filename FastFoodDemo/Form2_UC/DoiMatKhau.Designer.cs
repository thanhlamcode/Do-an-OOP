namespace FastFoodDemo.Form2_UC
{
    partial class DoiMatKhau
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
            this.components = new System.ComponentModel.Container();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.Pstxb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DoiMKtxtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MKOLDtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Loginbtn
            // 
            this.Loginbtn.BackColor = System.Drawing.Color.DarkOrange;
            this.Loginbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.ForeColor = System.Drawing.Color.White;
            this.Loginbtn.Location = new System.Drawing.Point(350, 470);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(407, 41);
            this.Loginbtn.TabIndex = 6;
            this.Loginbtn.Text = "Đăng Nhập";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // Pstxb
            // 
            this.Pstxb.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pstxb.Location = new System.Drawing.Point(347, 236);
            this.Pstxb.Name = "Pstxb";
            this.Pstxb.PasswordChar = '*';
            this.Pstxb.Size = new System.Drawing.Size(407, 41);
            this.Pstxb.TabIndex = 4;
            this.Pstxb.Validating += new System.ComponentModel.CancelEventHandler(this.Pstxb_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(344, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật Khẩu:";
            // 
            // DoiMKtxtb
            // 
            this.DoiMKtxtb.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoiMKtxtb.Location = new System.Drawing.Point(347, 362);
            this.DoiMKtxtb.Name = "DoiMKtxtb";
            this.DoiMKtxtb.PasswordChar = '*';
            this.DoiMKtxtb.Size = new System.Drawing.Size(407, 41);
            this.DoiMKtxtb.TabIndex = 7;
            this.DoiMKtxtb.Validating += new System.ComponentModel.CancelEventHandler(this.DoiMKtxtb_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(344, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nhập Lại Mật Khẩu Mới:";
            // 
            // MKOLDtxt
            // 
            this.MKOLDtxt.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MKOLDtxt.Location = new System.Drawing.Point(347, 131);
            this.MKOLDtxt.Name = "MKOLDtxt";
            this.MKOLDtxt.PasswordChar = '*';
            this.MKOLDtxt.Size = new System.Drawing.Size(407, 41);
            this.MKOLDtxt.TabIndex = 9;
            this.MKOLDtxt.Validating += new System.ComponentModel.CancelEventHandler(this.MKOLDtxt_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(344, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 34);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mật Khẩu Cũ:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MKOLDtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DoiMKtxtb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.Pstxb);
            this.Controls.Add(this.label3);
            this.Name = "DoiMatKhau";
            this.Size = new System.Drawing.Size(1106, 595);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.TextBox Pstxb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DoiMKtxtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MKOLDtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
