using FastFoodDemo.Form1_UC.Form1_Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo.Form1_UC
{
    public partial class Sign_Up : UserControl
    {
        public event EventHandler turnToLogin;
        public event EventHandler _closeForm;
        SignUp_Code signUp_ = new SignUp_Code();
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            turnToLogin?.Invoke(this, EventArgs.Empty);
        }

        private void ExiTlbl_Click(object sender, EventArgs e)
        {
            _closeForm?.Invoke(this, EventArgs.Empty);
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            string id = Idtxtb.Text;
            string username = Usernametxtb.Text;
            string password = Pstxb.Text;
            if (signUp_.Validate_SignUp(id, password) && ValidateChildren(ValidationConstraints.Enabled))
            {
                signUp_.SignUp_ToWriteFile(id, username, password);
                MessageBox.Show("Đăng Ký thành công.", "Thông báo", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tài khoản bị trùng\nVui lòng thử lại",
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Idtxb_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(Idtxtb.Text))
            {
                e.Cancel = true;
                Usernametxtb.Focus();
                errorProvider1.SetError(Idtxtb, "Vui lòng nhập Id");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Idtxtb, null);
            }
        }
        private void Pstxb_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(Pstxb.Text))
            {
                e.Cancel = true;
                Pstxb.Focus();
                errorProvider1.SetError(Pstxb, "Vui lòng nhập Password");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Pstxb, null);
            }
        }
        private void Usernametxtb_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(Usernametxtb.Text))
            {
                e.Cancel = true;
                Usernametxtb.Focus();
                errorProvider1.SetError(Usernametxtb, "Vui lòng nhập Username");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Usernametxtb, null);
            }
        }
    }
}
