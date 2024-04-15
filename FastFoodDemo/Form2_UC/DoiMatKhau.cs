using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FastFoodDemo.Form2_UC
{
    public partial class DoiMatKhau : UserControl
    {
        private int TargetId { get; set; }
        private string _oldPass { get; set; }
        public void SetId(int id)
        {
            TargetId = id;
        }
        public void SetPass(string pass)
        {
            _oldPass = pass;
        }
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void MKOLDtxt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(MKOLDtxt.Text))
            {
                e.Cancel = true;
                MKOLDtxt.Focus();
                errorProvider1.SetError(MKOLDtxt, "Vui lòng không để trống");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(MKOLDtxt, null);
            }
        }

        private void Pstxb_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(Pstxb.Text))
            {
                e.Cancel = true;
                Pstxb.Focus();
                errorProvider1.SetError(Pstxb, "Vui lòng không để trống");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Pstxb, null);
            }
        }

        private void DoiMKtxtb_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(DoiMKtxtb.Text))
            {
                e.Cancel = true;
                DoiMKtxtb.Focus();
                errorProvider1.SetError(DoiMKtxtb, "Vui lòng không để trống");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(DoiMKtxtb, null);
            }
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            string old_MK = MKOLDtxt.Text;
            string new_MK = Pstxb.Text;
            string vertif_MK = DoiMKtxtb.Text;
            if (isOldMK(old_MK) && ValidateChildren(ValidationConstraints.Enabled))//
            {
                errorProvider1.SetError(MKOLDtxt, null);
                if (idNewMK(new_MK, vertif_MK))//
                {
                    errorProvider1.SetError(DoiMKtxtb, null);
                    MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                }
                else
                {
                    errorProvider1.SetError(DoiMKtxtb, "Mật khẩu nhập lại chưa đúng.");
                    DoiMKtxtb.Focus();
                    return;
                }
            }
            else
            {
                errorProvider1.SetError(MKOLDtxt, "Mật khẩu cũ chưa chính xác.");
                MKOLDtxt.Focus();
                return;
            }
        }
        private bool isOldMK(string old_MK)
        {
            if (old_MK == _oldPass)
            {
                return true;
            }
            return false;
        }

        private bool idNewMK(string new_MK, string vertif_MK)
        {
            string filename = "LoginData.txt";
            if (vertif_MK == new_MK)
            {
                string[] lines = File.ReadAllLines(filename);
                foreach (var line in lines)
                {
                    string[] words = line.Split(',');
                    if (words[0] == TargetId.ToString())
                    {
                        words[2] = new_MK;
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
