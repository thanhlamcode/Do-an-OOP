using FastFoodDemo.Form2_UC3.Form2_UC3_Code;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using Newtonsoft.Json;
using FastFoodDemo.Form2_UC2.Form2_UC2_Code;

namespace FastFoodDemo.Form2_UC3
{
    public partial class OrderManagementForm : UserControl
    {
        private List<Order> orders;
        private List<Inventory> inventories;

        public OrderManagementForm()
        {
            InitializeComponent();

            string orderFilePath = "Order.json";

            if (File.Exists(orderFilePath))
            {
                string jsonData = File.ReadAllText(orderFilePath);
                orders = JsonConvert.DeserializeObject<List<Order>>(jsonData);

                foreach (Order order in orders)
                {
                    cbMaHD.Items.Add(order.orderID);
                }
            }
        }

        private void OrderManagementForm_Load(object sender, EventArgs e)
        {
            btnHuyHD.Enabled = false;
            btnLuuHD.Enabled = false;
            btnInHD.Enabled = false;
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

                string orderFilePath = "Order.json";

                // Đọc dữ liệu từ tệp tin
                string jsonData = File.ReadAllText(orderFilePath);
                List<Order> orders = JsonConvert.DeserializeObject<List<Order>>(jsonData);

                // Xóa tất cả các hàng hiện có trong DataGridView
                dgvOrder.Rows.Clear();

                cbSP.Items.Clear();

                string inventoryFilePath = "Inventory.json";

                if (File.Exists(inventoryFilePath))
                {
                    string Data = File.ReadAllText(inventoryFilePath);
                    inventories = JsonConvert.DeserializeObject<List<Inventory>>(Data);

                    foreach (Inventory inventory in inventories)
                    {
                        cbSP.Items.Add(inventory.Name);
                    }
                }

                // Tìm hóa đơn được chọn
                Order selectedOrder = null;
                foreach (Order ord in orders)
                {
                    if (ord.orderID == selectedMaHD)
                    {
                        selectedOrder = ord;
                        break;
                    }
                }

                if (selectedOrder != null)
                {
                    // Hiển thị thông tin của hóa đơn trên các controls tương ứng
                    txtMaHD.Text = selectedOrder.orderID; // Mã hóa đơn
                    dateTimePicker1.Value = selectedOrder.dateTime; // Ngày bán
                    txtNV.Text = selectedOrder.staffID.ToString(); // Mã nhân viên
                    txtKH.Text = selectedOrder.customerID.ToString(); // Mã khách hàng

                    // Hiển thị thông tin chi tiết của hóa đơn trên DataGridView
                    foreach (var detail in selectedOrder.orderDetail)
                    {
                        double totalPrice = detail.quantity * detail.unitPrice; // Tính thành tiền
                        dgvOrder.Rows.Add(detail.productName, detail.quantity, detail.unitPrice, totalPrice);
                    }

                    // Tính tổng tiền của các sản phẩm trong hóa đơn
                    double total = 0;
                    foreach (DataGridViewRow row in dgvOrder.Rows)
                    {
                        double totalPrice = Convert.ToDouble(row.Cells[3].Value);
                        total += totalPrice;
                    }

                    // Hiển thị tổng tiền lên TextBox txtTongTien
                    txtTongTien.Text = total.ToString();
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
            try
            {
                if (cbSP.SelectedItem != null)
                {
                    string selectedProductName = cbSP.SelectedItem.ToString();

                    // Khai báo và khởi tạo danh sách sản phẩm
                    List<Product> products = new List<Product>();

                    // Lấy dữ liệu sản phẩm từ file JSON và gán vào danh sách sản phẩm
                    string productFilePath = "Product.json";
                    if (File.Exists(productFilePath))
                    {
                        string jsonData = File.ReadAllText(productFilePath);
                        products = JsonConvert.DeserializeObject<List<Product>>(jsonData);
                    }

                    // Tìm sản phẩm được chọn trong danh sách sản phẩm
                    Product selectedProduct = null;
                    foreach (Product prod in products)
                    {
                        if (prod.Name == selectedProductName)
                        {
                            selectedProduct = prod;
                            break;
                        }
                    }

                    if (selectedProduct != null)
                    {
                        // Hiển thị giá của sản phẩm lên txtDG
                        txtDG.Text = selectedProduct.Price.ToString();
                    }
                }
                else
                {
                    txtDG.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chọn sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Add(cbMaHD, txtMaHD, txtNV, txtKH, dateTimePicker1, dgvOrder);
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
