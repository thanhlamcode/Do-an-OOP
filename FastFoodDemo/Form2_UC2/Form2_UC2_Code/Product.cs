using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo.Form2_UC2.Form2_UC2_Code
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public double Discount { get; set; }

        public DateTime DateOut { get; set; }

        public Product() { }
        public Product(int id, string name, decimal price, double discount, DateTime dateTime, int quantity)
        {
            Id = id;
            Name = name;
            Price = price;
            Discount = discount;
            DateOut = dateTime;
            Quantity = quantity;
        }

        // Phương thức để tải dữ liệu sản phẩm vào DataGridView (xong)
        public void LoadProductData(DataGridView dataGridView1)
        {
            try
            {
                string productFilePath = "Product.json";

                if (File.Exists(productFilePath))
                {
                    string jsonData = File.ReadAllText(productFilePath);
                    List<Product> products = JsonConvert.DeserializeObject<List<Product>>(jsonData);

                    foreach (Product product in products)
                    {
                        // Tính doanh thu từ sản phẩm
                        decimal revenue = (product.Price * product.Quantity) * (1 - (decimal)product.Discount);

                        // Thêm dữ liệu của sản phẩm vào DataGridView
                        dataGridView1.Rows.Add(product.Name, product.Quantity, product.DateOut, product.Price, product.Discount * 100 + "%", revenue);
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ValidateAndAddProduct(DataGridView dataGridView1, ComboBox comboBox_tenSP, TextBox textBox_soluongxuatkho, TextBox textBox_giaban, ComboBox comboBox_discount, TextBox textBox_Tonkho)
        {
            try
            {
                // Kiểm tra có sản phẩm nào được chọn từ ComboBox không
                if (comboBox_tenSP.SelectedItem == null)
                {
                    throw new Exception("Vui lòng chọn tên sản phẩm.");
                }

                // Kiểm tra số lượng xuất kho có phải là số nguyên không âm hay không
                int soLuongXuatKho;
                if (!int.TryParse(textBox_soluongxuatkho.Text, out soLuongXuatKho) || soLuongXuatKho < 0)
                {
                    throw new Exception("Vui lòng nhập số lượng xuất kho là một số nguyên không âm.");
                }

                // Kiểm tra giá bán có phải là số không âm hay không
                decimal giaBan;
                if (!decimal.TryParse(textBox_giaban.Text, out giaBan) || giaBan < 0)
                {
                    throw new Exception("Vui lòng nhập giá bán là một số không âm.");
                }

                // Kiểm tra có chọn mức giảm giá từ ComboBox không
                double discountPercent = 0;
                string discount = comboBox_discount.SelectedItem?.ToString();
                if (discount != null)
                {
                    switch (discount)
                    {
                        case "5%":
                            discountPercent = 0.05;
                            break;
                        case "10%":
                            discountPercent = 0.1;
                            break;
                        case "20%":
                            discountPercent = 0.2;
                            break;
                        default:
                            throw new Exception("Vui lòng chọn một mức giảm giá hợp lệ.");
                    }
                }
                else
                {
                    throw new Exception("Vui lòng chọn một mức giảm giá.");
                }

                // Lấy tên sản phẩm đã chọn từ ComboBox
                string selectedTenSP = comboBox_tenSP.SelectedItem.ToString();

                // Cập nhật số lượng tồn kho trong file Inventory
                UpdateInventoryFile(selectedTenSP, soLuongXuatKho);
                UpdateTextboxTonKho(comboBox_tenSP, textBox_Tonkho);

                // Tính toán doanh thu
                decimal revenue = (giaBan * soLuongXuatKho) * (decimal)(1 - discountPercent);

                // Cập nhật DataGridView
                dataGridView1.Rows.Add(selectedTenSP, soLuongXuatKho, DateTime.Now.ToString("yyyy/MM/dd"), giaBan, discountPercent * 100 + "%", revenue);

                // Cập nhật thông tin sản phẩm vào file Product.txt
                UpdateProductFile(selectedTenSP, soLuongXuatKho, giaBan, discountPercent, DateTime.Now.ToString("yyyy/MM/dd"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateProductFile(string tenSP, int soluong, decimal giaBan, double discount, string ngayxuat)
        {
            try
            {
                // Đường dẫn tới file Product
                string productFilePath = "Product.json";

                // Kiểm tra xem file tồn tại không
                if (File.Exists(productFilePath))
                {
                    // Đọc dữ liệu từ file JSON và deserialize thành danh sách các đối tượng Product
                    string jsonData = File.ReadAllText(productFilePath);
                    List<Product> products = JsonConvert.DeserializeObject<List<Product>>(jsonData);

                    // Tạo id tiếp theo
                    int nextId = 1;
                    if (products.Any())
                    {
                        nextId = products.Max(p => p.Id) + 1;
                    }

                    // Tạo đối tượng Product mới
                    Product newProduct = new Product
                    {
                        Id = nextId,
                        Name = tenSP,
                        Quantity = soluong,
                        Price = giaBan,
                        Discount = discount,
                        DateOut = DateTime.Parse(ngayxuat)
                    };

                    // Thêm đối tượng mới vào danh sách sản phẩm
                    products.Add(newProduct);

                    // Serialize lại danh sách Product thành JSON và ghi vào file
                    string updatedJsonData = JsonConvert.SerializeObject(products, Formatting.Indented);
                    File.WriteAllText(productFilePath, updatedJsonData);
                }
                else
                {
                    throw new FileNotFoundException("File not found.", productFilePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cập nhập textbox tồn kho sau khi nhấn nút xuất hàng
        public void UpdateTextboxTonKho(ComboBox comboBox_tenSP, TextBox textBox_Tonkho)
        {
            try
            {
                // Lấy chỉ mục của sản phẩm đã chọn từ ComboBox
                int selectedIndex = comboBox_tenSP.SelectedIndex;

                // Đọc dữ liệu từ file Inventory.json
                string inventoryFilePath = "Inventory.json";
                string jsonData = File.ReadAllText(inventoryFilePath);

                // Deserialize dữ liệu từ JSON thành danh sách các đối tượng Inventory
                List<Inventory> inventories = JsonConvert.DeserializeObject<List<Inventory>>(jsonData);

                // Kiểm tra xem chỉ mục đã chọn có hợp lệ không
                if (selectedIndex >= 0 && selectedIndex < inventories.Count)
                {
                    // Lấy đối tượng Inventory tương ứng với chỉ mục đã chọn
                    Inventory selectedInventory = inventories[selectedIndex];

                    // Cập nhật số lượng tồn kho vào TextBox
                    textBox_Tonkho.Text = selectedInventory.QuantityOnHand.ToString();
                }
                else
                {
                    // Nếu chỉ mục không hợp lệ, hiển thị thông báo
                    MessageBox.Show("Không tìm thấy sản phẩm trong kho.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Cập nhập file
        private void UpdateInventoryFile(string tenSP, int soLuongXuatKho)
        {
            try
            {
                // Đường dẫn tới file Inventory
                string inventoryFilePath = "Inventory.json";

                // Đọc dữ liệu từ file JSON và deserialize thành danh sách các đối tượng Inventory
                string jsonData = File.ReadAllText(inventoryFilePath);
                List<Inventory> inventories = JsonConvert.DeserializeObject<List<Inventory>>(jsonData);

                // Tìm đối tượng Inventory tương ứng với sản phẩm được chọn
                Inventory selectedInventory = inventories.FirstOrDefault(inv => inv.Name == tenSP);

                // Kiểm tra xem đối tượng Inventory có tồn tại không
                if (selectedInventory != null)
                {
                    // Cập nhật số lượng tồn kho
                    selectedInventory.QuantityOnHand -= soLuongXuatKho;

                    // Kiểm tra xem số lượng tồn kho có âm không
                    if (selectedInventory.QuantityOnHand < 0)
                    {
                        throw new Exception($"Số lượng tồn kho của sản phẩm '{tenSP}' không đủ để xuất hàng.");
                    }

                    // Serialize lại danh sách Inventory thành JSON và ghi vào file
                    string updatedJsonData = JsonConvert.SerializeObject(inventories, Formatting.Indented);
                    File.WriteAllText(inventoryFilePath, updatedJsonData);
                }
                else
                {
                    // Nếu không tìm thấy sản phẩm, hiển thị thông báo
                    MessageBox.Show("Không tìm thấy sản phẩm trong kho.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
