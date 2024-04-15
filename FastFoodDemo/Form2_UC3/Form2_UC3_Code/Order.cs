using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FastFoodDemo.Form2_UC3.Form2_UC3_Code
{
    internal class Order : IOrder
    {
        public string orderID { get; set; }
        public DateTime dateTime { get; set; }
        public int staffID { get; set; }
        public int customerID { get; set; }
        public List<ProductDetail> orderDetail { get; set; }

        public class ProductDetail
        {
            public string productName { get; set; }
            public int quantity { get; set; }
            public double unitPrice { get; set; }
        }

        public bool isSaved = false;

        public Order()
        {
            orderID = "";
            dateTime = DateTime.MinValue;
            staffID = 0;
            customerID = 0;
            orderDetail = new List<ProductDetail>();
        }

        public void Add(ComboBox cb1, TextBox txt, DateTimePicker dtp)
        {
            // Đọc tất cả các dòng trong tệp tin "Order.txt"
            string[] lines = File.ReadAllLines("Order.txt");

            // Tạo một biến để lưu trữ mã hóa đơn lớn nhất
            int maxOrderId = 0;

            // Duyệt qua từng dòng trong danh sách
            foreach (string line in lines)
            {
                // Phân tách dòng thành các phần tử
                string[] parts = line.Split(',');

                // Lấy mã hóa đơn từ phần tử đầu tiên
                if (parts.Length > 0)
                {
                    // Loại bỏ ký tự 'HD' để lấy số
                    string orderIdString = parts[0].Replace("HD", "");
                    int orderId;

                    // Chuyển đổi mã hóa đơn thành số
                    if (int.TryParse(orderIdString, out orderId))
                    {
                        // So sánh với mã hóa đơn lớn nhất hiện có
                        if (orderId > maxOrderId)
                        {
                            maxOrderId = orderId;
                        }
                    }
                }
            }

            maxOrderId++;
            string newOrderId = "HD" + maxOrderId;

            // Thêm mã hóa đơn mới vào ComboBox
            cb1.Items.Add(newOrderId);
            cb1.SelectedIndex = cb1.Items.Count - 1;
            txt.Text = newOrderId;
            dtp.Value = DateTime.Now;
        }

        public void Update(ComboBox cb2, TextBox txt1, TextBox txt2, TextBox txt3, TextBox txt4, DateTimePicker dtp, DataGridView dgv)
        {
            if (!isSaved)
            {
                string maHD = txt1.Text;
                string ngay = dtp.Value.ToString("yyyy/MM/dd");
                string maNV = txt2.Text;
                string maKH = txt3.Text;

                // Tạo một danh sách để lưu trữ thông tin chi tiết sản phẩm
                List<ProductDetail> productList = new List<ProductDetail>();

                // Lặp qua từng hàng trong DataGridView để lấy thông tin sản phẩm
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null)
                    {
                        string productName = row.Cells[0].Value.ToString();
                        int quantity = Convert.ToInt32(row.Cells[1].Value);
                        double unitPrice = Convert.ToDouble(row.Cells[2].Value);

                        // Tạo một đối tượng ProductDetail và thêm vào danh sách
                        productList.Add(new ProductDetail
                        {
                            productName = productName,
                            quantity = quantity,
                            unitPrice = unitPrice
                        });
                    }
                }

                // Lưu danh sách chi tiết sản phẩm vào thuộc tính orderDetail
                orderDetail = productList;

                // Tạo chuỗi productDetails từ danh sách chi tiết sản phẩm
                StringBuilder sb = new StringBuilder();
                foreach (ProductDetail product in productList)
                {
                    sb.Append(product.productName + "-" + product.quantity + "-" + product.unitPrice + ",");
                }

                // Xóa ký tự ';' cuối cùng nếu có
                if (sb.Length > 0)
                {
                    sb.Length--;
                }

                string productDetails = sb.ToString();

                // Kiểm tra xem là tạo hóa đơn mới hay cập nhật hóa đơn
                bool orderExists = false;
                string orderFilePath = "Order.txt";
                List<string> lines = File.ReadAllLines(orderFilePath).ToList();
                for (int i = 0; i < lines.Count; i++)
                {
                    if (lines[i].StartsWith(maHD + ","))
                    {
                        // Cập nhật thông tin của hóa đơn
                        lines[i] = $"{maHD},{ngay},{maNV},{maKH},{productDetails}";
                        orderExists = true;
                        break;
                    }
                }

                // Nếu hóa đơn không tồn tại, thêm mới vào file
                if (!orderExists)
                {
                    string newOrder = $"{maHD},{ngay},{maNV},{maKH},{productDetails}";
                    lines.Add(newOrder);
                }

                File.WriteAllLines(orderFilePath, lines);

                // Kiểm tra xem đã chọn sản phẩm từ ComboBox cbSP chưa
                if (string.IsNullOrWhiteSpace(cb2.Text))
                {
                    MessageBox.Show("Vui lòng chọn một sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra xem đã nhập số lượng từ TextBox txtSL chưa
                if (string.IsNullOrWhiteSpace(txt4.Text))
                {
                    MessageBox.Show("Vui lòng nhập số lượng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string tenSanPham = cb2.Text;
                int soLuong = Convert.ToInt32(txt4.Text);
                int soLuongTrongKho = LaySoLuongSanPhamTrongKho(tenSanPham);

                // Cập nhật số lượng sản phẩm trong file txt inventory
                string inventoryFilePath = "Inventory.txt";
                List<string> rows = File.ReadAllLines(inventoryFilePath).ToList();
                for (int i = 0; i < rows.Count; i++)
                {
                    string[] parts = rows[i].Split(',');
                    if (parts.Length == 4 && parts[1].Trim() == tenSanPham)
                    {
                        rows[i] = $"{parts[0]},{tenSanPham},{soLuongTrongKho - soLuong},{parts[3]}";
                        break;
                    }
                }
                File.WriteAllLines(inventoryFilePath, rows);

                // Đặt lại biến cờ là đã lưu hóa đơn
                isSaved = true;
                // Hiển thị thông báo lưu thành công
                MessageBox.Show("Hóa đơn đã được lưu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Nếu hóa đơn đã được lưu trước đó, hiển thị thông báo rằng hóa đơn đã được lưu
                MessageBox.Show("Hóa đơn đã được lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Phương thức lấy số lượng sản phẩm trong kho từ file txt inventory
        public int LaySoLuongSanPhamTrongKho(string tenSanPham)
        {
            string filePath = "Inventory.txt";
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 4 && parts[1].Trim() == tenSanPham)
                {
                    return Convert.ToInt32(parts[2].Trim());
                }
            }
            return 0; // Trả về 0 nếu không tìm thấy sản phẩm trong kho
        }

        public void Delete(ComboBox cb, TextBox txt1, TextBox txt2, TextBox txt3, TextBox txt4, DateTimePicker dtp, DataGridView dgv)
        {
            string selectedMaHD = cb.SelectedItem.ToString();

            string filePath = "Order.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();
            for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i].StartsWith(selectedMaHD + ","))
                {
                    lines.RemoveAt(i);
                    break;
                }
            }
            File.WriteAllLines(filePath, lines);

            // Xóa các giá trị trên giao diện
            txt1.Text = "";
            dtp.Value = DateTime.Now;
            txt2.Text = "";
            txt3.Text = "";
            dgv.Rows.Clear();
            txt4.Text = "";
            cb.SelectedIndex = -1;
            cb.Items.Remove(selectedMaHD);
        }
    }
}
