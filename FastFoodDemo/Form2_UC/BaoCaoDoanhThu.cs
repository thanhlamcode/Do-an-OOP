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

namespace FastFoodDemo.Form2_UC
{
    public partial class BaoCaoDoanhThu : UserControl
    {
        public BaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string ngayLamViec = DateTime.Now.ToString("dd/MM/yyyy");
                string id = Idtxb.Text;
                string tenThuNgan = Nametxtb.Text;
                string caLamViec = String.Empty;
                foreach (var t in checkedListBox1.SelectedItems)
                {
                    caLamViec += t.ToString() + "-";
                }
                string tongDoanhThu = DoanhThutxtb.Text;

                string data = $"[Báo cáo Doanh thu ngày {ngayLamViec}]\n\n" +
                              $"Id: {id}\n" +
                              $"Thu ngân: {tenThuNgan}\n" +
                              $"Ca Làm Việc: {caLamViec}\n" +
                              $"Tổng doanh thu: {tongDoanhThu}\n";
                Write_ToTxt(data);
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
        private void Nametxtb_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(Nametxtb.Text))
            {
                e.Cancel = true;
                Nametxtb.Focus();
                errorProvider1.SetError(Nametxtb, "Vui lòng nhập Id");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Nametxtb, null);
            }
        }
        private void checkedListBox1_Validating(object sender, CancelEventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count > 0)
            {
                e.Cancel = false;
                errorProvider1.SetError(checkedListBox1, null);
            }
            else
            {
                e.Cancel = true;
                checkedListBox1.Focus();
                errorProvider1.SetError(checkedListBox1, "Vui lòng nhập Id");
            }
        }
        private void DoanhThutxtb_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(DoanhThutxtb.Text))
            {
                e.Cancel = true;
                DoanhThutxtb.Focus();
                errorProvider1.SetError(DoanhThutxtb, "Vui lòng nhập Id");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(DoanhThutxtb, null);
            }
        }
        private void Write_ToTxt(string data)
        {
            string filename = "Baocaodoanhthu.txt";
            try
            {
                using (StreamWriter writer = File.AppendText(filename))
                {
                    // Ghi dữ liệu vào tệp văn bản
                    writer.WriteLine(data);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
