using FastFoodDemo.Form2_UC3.Form2_UC3_Code;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.IO;
using System.Windows.Forms;

namespace FastFoodDemo.Form2_UC3
{
    public partial class OrderManagementForm : UserControl
    {
        public OrderManagementForm()
        {
            InitializeComponent();

            LoadDataIntoComboBox("Order.txt", cbMaHD);
        }

        private void OrderManagementForm_Load(object sender, EventArgs e)
        {
            btnHuyHD.Enabled = false;
            btnLuuHD.Enabled = false;
            btnInHD.Enabled = false;
        }

        private void LoadDataIntoComboBox(string filePath, ComboBox cb)
        {
            // Kiểm tra xem tệp tin tồn tại
            if (File.Exists(filePath))
            {
                // Đọc dữ liệu từ tệp tin
                string[] lines = File.ReadAllLines(filePath);

                // Thêm dữ liệu từ cột đầu tiên vào ComboBox
                foreach (string line in lines)
                {
                    string[] parts = line.Split(','); // Phân tách dữ liệu theo dấu chấm phẩy
                    if (parts.Length > 0 && cb == cbMaHD)
                    {
                        cb.Items.Add(parts[0]); // Thêm phần tử đầu tiên vào ComboBox
                    }
                    else if (parts.Length > 1 && cb == cbSP)
                    {
                        cb.Items.Add(parts[1]);
                    }
                }
            }
        }

        private void cbMaHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order order = new Order();
            // Kiểm tra xem có mục nào được chọn không
            if (cbMaHD.SelectedItem != null)
            {
                // Nếu có hóa đơn nào được chọn từ cbMaHD, kích hoạt các nút
                btnHuyHD.Enabled = true;
                btnLuuHD.Enabled = true;
                btnInHD.Enabled = true;

                string selectedMaHD = cbMaHD.SelectedItem.ToString();

                string orderFilePath = "Order.txt";

                // Kiểm tra xem tệp tin tồn tại
                if (File.Exists(orderFilePath))
                {
                    // Đọc dữ liệu từ tệp tin
                    string[] lines = File.ReadAllLines(orderFilePath);

                    // Xóa tất cả các hàng hiện có trong DataGridView
                    dgvOrder.Rows.Clear();

                    LoadDataIntoComboBox("Inventory.txt", cbSP);

                    // Tìm dòng chứa thông tin của hóa đơn được chọn
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(','); // Phân tách dữ liệu theo dấu chấm phẩy
                        if (parts.Length > 0 && parts[0] == selectedMaHD) // Kiểm tra xem mã hóa đơn có trùng khớp không
                        {
                            // Hiển thị thông tin của hóa đơn trên các controls tương ứng
                            txtMaHD.Text = parts[0]; // Mã hóa đơn
                            dateTimePicker1.Value = DateTime.Parse(parts[1]); // Ngày bán
                            txtNV.Text = parts[2]; // Mã nhân viên
                            txtKH.Text = parts[3]; // Mã khách hàng

                            // Phân tích thông tin chi tiết của hóa đơn
                            for (int i = 4; i < parts.Length; i++)
                            {
                                string[] productInfo = parts[i].Split('-'); // Phân tách thông tin sản phẩm
                                if (productInfo.Length == 3)
                                {
                                    string productName = productInfo[0].Trim();
                                    int quantity = int.Parse(productInfo[1].Trim());
                                    double unitPrice = double.Parse(productInfo[2].Trim());
                                    double totalPrice = quantity * unitPrice; // Tính thành tiền

                                    // Thêm hàng vào DataGridView
                                    dgvOrder.Rows.Add(productName, quantity, unitPrice, totalPrice);
                                }
                            }

                            double total = 0;

                            // Tính tổng tiền của các sản phẩm trong hóa đơn
                            foreach (DataGridViewRow row in dgvOrder.Rows)
                            {
                                double totalPrice = Convert.ToDouble(row.Cells[3].Value);
                                total += totalPrice;
                            }

                            // Hiển thị tổng tiền lên TextBox txtTongTien
                            txtTongTien.Text = total.ToString();

                            break; // Dừng việc tìm kiếm khi đã tìm thấy thông tin của hóa đơn được chọn
                        }
                    }
                }
            }
            else
            {
                btnHuyHD.Enabled = false;
                btnLuuHD.Enabled = false;
                btnInHD.Enabled = false;
            }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn sản phẩm từ ComboBox cbSP chưa
            if (string.IsNullOrWhiteSpace(cbSP.Text))
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem đã nhập số lượng từ TextBox txtSL chưa
            if (string.IsNullOrWhiteSpace(txtSL.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenSanPham = cbSP.Text;
            int soLuong = Convert.ToInt32(txtSL.Text);
            double donGia = Convert.ToDouble(txtDG.Text);

            // Kiểm tra xem sản phẩm đã tồn tại trong DataGridView chưa
            bool productExists = false;
            foreach (DataGridViewRow row in dgvOrder.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == tenSanPham)
                {
                    // Nếu sản phẩm đã tồn tại, cộng thêm số lượng mới vào số lượng đã có
                    int existingQuantity = Convert.ToInt32(row.Cells[1].Value);
                    row.Cells[1].Value = existingQuantity + soLuong;
                    productExists = true;
                    break;
                }
            }

            // Nếu sản phẩm chưa tồn tại, thêm mới vào DataGridView
            if (!productExists)
            {
                dgvOrder.Rows.Add(tenSanPham, soLuong, donGia, soLuong * donGia);
            }
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (dgvOrder.SelectedRows.Count > 0)
            {
                // Lặp qua các hàng được chọn và xóa chúng khỏi DataGridView
                foreach (DataGridViewRow row in dgvOrder.SelectedRows)
                {
                    dgvOrder.Rows.Remove(row);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất một sản phẩm để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProductId = cbSP.SelectedItem.ToString();
            string productFilePath = "Product.txt";

            // Kiểm tra xem tệp tin sản phẩm có tồn tại
            if (File.Exists(productFilePath))
            {
                string[] lines = File.ReadAllLines(productFilePath);

                // Duyệt qua các dòng trong file sản phẩm
                foreach (string line in lines)
                {
                    string[] parts = line.Split(','); // Phân tách dữ liệu bởi dấu phẩy
                    if (parts.Length == 6 && parts[1] == selectedProductId)
                    {
                        // Lấy đơn giá từ phần tử thứ 4 của mảng parts
                        string unitPrice = parts[3];
                        // Hiển thị đơn giá lên textbox txtDG
                        txtDG.Text = unitPrice;
                        break; // Dừng khi đã tìm thấy đơn giá của sản phẩm
                    }
                    else if (parts[1] != selectedProductId)
                    {
                        txtDG.Text = "";
                    }
                }
            }
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Add(cbMaHD, txtMaHD, dateTimePicker1);
        }

        private void btnHuyHD_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Delete(cbMaHD, txtMaHD, txtNV, txtKH, txtTongTien, dateTimePicker1, dgvOrder);
        }

        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Update(cbSP, txtMaHD, txtNV, txtKH, txtSL, dateTimePicker1, dgvOrder);
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có ít nhất một hàng dữ liệu trong DataGridView không
            if (dgvOrder.Rows.Count > 0)
            {
                // Yêu cầu người dùng chọn nơi để lưu file PDF
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF file (*.pdf)|*.pdf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Tạo một tài liệu PDF mới
                    Document document = new Document();
                    PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    document.Open();

                    //Full path to the Unicode Arial file
                    string Arial = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Arial.TTF");

                    //Create a base font object making sure to specify IDENTITY-H
                    BaseFont bf = BaseFont.CreateFont(Arial, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                    //Create a specific font object
                    Font f = new Font(bf, 12);

                    // Tiêu đề cho hóa đơn
                    Paragraph title = new Paragraph("HÓA ĐƠN", f);
                    title.Alignment = Element.ALIGN_CENTER;
                    document.Add(title);

                    // Thông tin đơn hàng
                    Paragraph orderInfo = new Paragraph();
                    orderInfo.Font = f; // Áp dụng font cho toàn bộ đoạn văn bản
                    orderInfo.Add("Mã hóa đơn: " + txtMaHD.Text + "\n");
                    orderInfo.Add("Ngày bán: " + dateTimePicker1.Value.ToShortDateString() + "\n");
                    orderInfo.Add("Mã nhân viên: " + txtNV.Text + "\n");
                    orderInfo.Add("Mã khách hàng: " + txtKH.Text + "\n");
                    orderInfo.Add("Tổng tiền: " + txtTongTien.Text + "\n\n");
                    document.Add(orderInfo);

                    // Tạo bảng PDF với font Unicode cho các ô
                    PdfPTable pdfTable = new PdfPTable(dgvOrder.Columns.Count);

                    // Thêm các cột từ DataGridView vào bảng PDF
                    foreach (DataGridViewColumn column in dgvOrder.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, f));
                        pdfTable.AddCell(cell);
                    }

                    // Thêm các dòng từ DataGridView vào bảng PDF
                    foreach (DataGridViewRow row in dgvOrder.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            pdfTable.AddCell(new Phrase(cell.Value?.ToString(), f));
                        }
                    }

                    // Thêm bảng PDF vào tài liệu
                    document.Add(pdfTable);


                    // Đóng tài liệu
                    document.Close();

                    MessageBox.Show("Hóa đơn đã được xuất ra file PDF thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để in.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
