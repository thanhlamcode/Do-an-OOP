using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace FastFoodDemo.Form2_UC2.Form2_UC2_Code
{
    internal class Supplier : IControlSupplier
    {
        public string namesupply { get; set; } // Tên nhà cung cấp
        public string position { get; set; } // Địa chỉ
        public string email { get; set; } // Email
        public string phone { get; set; } // Số điện thoại
        public List<string> nameproduct { get; set; } // Danh sách tên sản phẩm

        public Supplier()
        {
            // Khởi tạo các thuộc tính mặc định
            namesupply = "";
            position = "";
            email = "";
            phone = "";
            nameproduct = new List<string>();
        }

        public Supplier(string supplierName, string address, string email1, string phoneNumber)
        {
            namesupply = supplierName;
            position = address;
            email = email1;
            phone = phoneNumber;
            nameproduct = new List<string>();
        }
        public void LoadDataAndPopulateComboBox(string jsonFilePath, List<Supplier> suppliers, ComboBox comboBox_nhacungcap)
        {
            // Kiểm tra xem tệp tồn tại không
            if (File.Exists(jsonFilePath))
            {
                // Đọc toàn bộ nội dung của tệp JSON
                string jsonContent = File.ReadAllText(jsonFilePath);

                // Deserialize JSON thành danh sách các đối tượng Supplier
                List<Supplier> loadedSuppliers = JsonConvert.DeserializeObject<List<Supplier>>(jsonContent);

                // Thêm các đối tượng Supplier đã đọc vào danh sách ban đầu
                suppliers.AddRange(loadedSuppliers);

                // Hiển thị tên nhà cung cấp trong ComboBox
                foreach (Supplier supplier in loadedSuppliers)
                {
                    comboBox_nhacungcap.Items.Add(supplier.namesupply);
                }
            }
            else
            {
                // Xử lý tệp không tồn tại
                throw new FileNotFoundException("File not found", jsonFilePath);
            }
        }
        //Chi tiết Supply
        public void Desc(ComboBox comboBox_nhacungcap, List<Supplier> suppliers)
        {
            // Kiểm tra xem có nhà cung cấp nào được chọn không
            if (comboBox_nhacungcap.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn một nhà cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Lấy chỉ mục của nhà cung cấp được chọn trong combobox_nhacungcap
            int selectedIndex = comboBox_nhacungcap.SelectedIndex;

            // Kiểm tra xem chỉ mục có hợp lệ hay không
            if (selectedIndex >= 0 && selectedIndex < suppliers.Count)
            {
                // Lấy thông tin của nhà cung cấp được chọn từ danh sách suppliers
                Supplier selectedSupplier = suppliers[selectedIndex];

                // Hiển thị thông tin chi tiết của nhà cung cấp
                string message = $"Tên: {selectedSupplier.namesupply}\n" +
                                 $"Địa chỉ: {selectedSupplier.position}\n" +
                                 $"Email: {selectedSupplier.email}\n" +
                                 $"Số điện thoại: {selectedSupplier.phone}\n" +
                                 $"Các sản phẩm cung cấp: {string.Join(", ", selectedSupplier.namesupply)}";

                MessageBox.Show(message, "Thông tin nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Chỉ mục không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
