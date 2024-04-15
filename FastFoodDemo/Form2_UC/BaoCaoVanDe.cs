using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace FastFoodDemo.Form2_UC
{
    public partial class BaoCaoVanDe : UserControl
    {
        public BaoCaoVanDe()
        {
            InitializeComponent();
        }

        private void Idtxb_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(Idtxb.Text))
            {
                e.Cancel = true;
                Idtxb.Focus();
                errorProvider1.SetError(Idtxb, "Vui lòng không để trống");
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
                errorProvider1.SetError(Nametxtb, "Vui lòng không để trốngd");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Nametxtb, null);
            }
        }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(comboBox1.Text))
            {
                e.Cancel = true;
                comboBox1.Focus();
                errorProvider1.SetError(comboBox1, "Vui lòng không để trống");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(comboBox1, null);
            }
        }

        private void Probtxtb_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(Probtxtb.Text))
            {
                e.Cancel = true;
                Probtxtb.Focus();
                errorProvider1.SetError(Probtxtb, "Vui lòng không để trống");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Probtxtb, null);
            }
        }

        private void detailstxtb_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(detailstxtb.Text))
            {
                e.Cancel = true;
                detailstxtb.Focus();
                errorProvider1.SetError(detailstxtb, "Vui lòng không để trống");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(detailstxtb, null);
            }
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string id = Idtxb.Text;
                string name = Nametxtb.Text;
                string job = comboBox1.SelectedItem.ToString();
                string problem = Probtxtb.Text;
                string details = detailstxtb.Text;

                try
                {
                    using (SaveFileDialog sdf = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
                    {
                        if (sdf.ShowDialog() == DialogResult.OK)
                        {
                            using (PdfWriter writer = new PdfWriter(sdf.FileName))
                            {
                                using (PdfDocument pdf = new PdfDocument(writer))
                                {
                                    Document document = new Document(pdf);

                                    Paragraph title = new Paragraph(problem)
                                        .SetTextAlignment(TextAlignment.LEFT)
                                        .SetFontSize(20)
                                        .SetBold();
                                    document.Add(title);

                                    Paragraph sub_title = new Paragraph($"Từ : {name} - {id} - Chức vụ: {job}\n" +
                                        $"Tới Quản Lý")
                                        .SetTextAlignment(TextAlignment.CENTER)
                                        .SetFontSize(14);
                                    document.Add(sub_title);

                                    Paragraph content = new Paragraph(details)
                                        .SetTextAlignment(TextAlignment.LEFT)
                                        .SetFontSize(12);
                                    document.Add(content);

                                    document.Close();
                                }
                            }
                            MessageBox.Show("Đăng nhập thành công.", "Thông báo", MessageBoxButtons.OK
                            , MessageBoxIcon.Information);
                        }
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
}
