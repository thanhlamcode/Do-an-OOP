namespace FastFoodDemo.Form1_UC
{
    partial class Sign_Up
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
            this.Pstxb = new System.Windows.Forms.TextBox();
            this.Usernametxtb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ExiTlbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Idtxtb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pstxb
            // 
            this.Pstxb.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pstxb.Location = new System.Drawing.Point(60, 491);
            this.Pstxb.Name = "Pstxb";
            this.Pstxb.PasswordChar = '*';
            this.Pstxb.Size = new System.Drawing.Size(407, 41);
            this.Pstxb.TabIndex = 1;
            this.Pstxb.Validating += new System.ComponentModel.CancelEventHandler(this.Pstxb_Validating);
            // 
            // Usernametxtb
            // 
            this.Usernametxtb.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernametxtb.Location = new System.Drawing.Point(60, 382);
            this.Usernametxtb.Name = "Usernametxtb";
            this.Usernametxtb.Size = new System.Drawing.Size(407, 41);
            this.Usernametxtb.TabIndex = 0;
            this.Usernametxtb.Validating += new System.ComponentModel.CancelEventHandler(this.Usernametxtb_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(57, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 34);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mật Khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(54, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(179, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đăng Ký";
            // 
            // Loginbtn
            // 
            this.Loginbtn.BackColor = System.Drawing.Color.DarkOrange;
            this.Loginbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.ForeColor = System.Drawing.Color.White;
            this.Loginbtn.Location = new System.Drawing.Point(59, 641);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(407, 41);
            this.Loginbtn.TabIndex = 3;
            this.Loginbtn.Text = "Đăng Ký";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(133, 696);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(259, 46);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Nếu bạn đã có tài khoản. \r\nHãy tiến hành đăng nhập.";
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
            this.ExiTlbl.TabIndex = 12;
            this.ExiTlbl.Text = "X";
            this.ExiTlbl.Click += new System.EventHandler(this.ExiTlbl_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Idtxtb
            // 
            this.Idtxtb.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idtxtb.Location = new System.Drawing.Point(60, 276);
            this.Idtxtb.Name = "Idtxtb";
            this.Idtxtb.Size = new System.Drawing.Size(407, 41);
            this.Idtxtb.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(54, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 34);
            this.label5.TabIndex = 14;
            this.label5.Text = "Id: ";
            // 
            // Sign_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Idtxtb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ExiTlbl);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.Pstxb);
            this.Controls.Add(this.Usernametxtb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Sign_Up";
            this.Size = new System.Drawing.Size(534, 807);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Pstxb;
        private System.Windows.Forms.TextBox Usernametxtb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label ExiTlbl;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox Idtxtb;
        private System.Windows.Forms.Label label5;
    }
}
