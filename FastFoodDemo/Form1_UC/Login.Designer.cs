namespace FastFoodDemo.Form1_UC
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Idtxb = new System.Windows.Forms.TextBox();
            this.Pstxb = new System.Windows.Forms.TextBox();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ExiTlbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(163, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(60, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(60, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật Khẩu:";
            // 
            // Idtxb
            // 
            this.Idtxb.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idtxb.Location = new System.Drawing.Point(66, 291);
            this.Idtxb.Name = "Idtxb";
            this.Idtxb.Size = new System.Drawing.Size(407, 41);
            this.Idtxb.TabIndex = 0;
            this.Idtxb.Validating += new System.ComponentModel.CancelEventHandler(this.Idtxb_Validating);
            // 
            // Pstxb
            // 
            this.Pstxb.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pstxb.Location = new System.Drawing.Point(63, 403);
            this.Pstxb.Name = "Pstxb";
            this.Pstxb.PasswordChar = '*';
            this.Pstxb.Size = new System.Drawing.Size(407, 41);
            this.Pstxb.TabIndex = 1;
            this.Pstxb.Validating += new System.ComponentModel.CancelEventHandler(this.Pstxb_Validating);
            // 
            // Loginbtn
            // 
            this.Loginbtn.BackColor = System.Drawing.Color.DarkOrange;
            this.Loginbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.ForeColor = System.Drawing.Color.White;
            this.Loginbtn.Location = new System.Drawing.Point(66, 619);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(407, 41);
            this.Loginbtn.TabIndex = 3;
            this.Loginbtn.Text = "Đăng Nhập";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(66, 705);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(407, 23);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Nhấn vào đây nếu bạn chưa có tài khoản";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ExiTlbl
            // 
            this.ExiTlbl.AutoSize = true;
            this.ExiTlbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExiTlbl.ForeColor = System.Drawing.Color.DarkOrange;
            this.ExiTlbl.Location = new System.Drawing.Point(499, 12);
            this.ExiTlbl.Name = "ExiTlbl";
            this.ExiTlbl.Size = new System.Drawing.Size(22, 23);
            this.ExiTlbl.TabIndex = 5;
            this.ExiTlbl.Text = "X";
            this.ExiTlbl.Click += new System.EventHandler(this.ExiTlbl_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ExiTlbl);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.Pstxb);
            this.Controls.Add(this.Idtxb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(534, 807);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Idtxb;
        private System.Windows.Forms.TextBox Pstxb;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label ExiTlbl;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
