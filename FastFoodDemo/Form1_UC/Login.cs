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
    public partial class Login : UserControl
    {
        public event EventHandler turnToSignUp;
        public event EventHandler _closeForm;
        Login_Code login = new Login_Code();
        public Login()
        {
            InitializeComponent();
        }
        private void ExiTlbl_Click(object sender, EventArgs e)
        {
            _closeForm?.Invoke(this, EventArgs.Empty);
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            turnToSignUp?.Invoke(this, EventArgs.Empty);
        }
        private void Loginbtn_Click(object sender, EventArgs e)
        {
            string id = Idtxb.Text;
            string password = Pstxb.Text;
            if (login.Validate_Login(id, password) && ValidateChildren(ValidationConstraints.Enabled))
            {
                login.Write_ToLoginHistory(id);
                DialogResult result = MessageBox.Show("Đăng nhập thành công.", "Thông báo", MessageBoxButtons.OK
                , MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    // Mở Form2
                    Form2 form2 = new Form2();
                    form2.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ\nVui lòng thử lại",
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Idtxb_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(Idtxb.Text))
            {
                e.Cancel = true;
                Idtxb.Focus();
                errorProvider1.SetError(Idtxb, "Vui lòng nhập Id");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Idtxb, null);
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
    }
}
