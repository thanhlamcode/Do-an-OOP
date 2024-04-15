using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace FastFoodDemo.Form2_UC2.Form2_UC2_Code
{
    internal class Inventory : IControlProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int QuantityOnHand { get; set; }
        public DateTime DateIn { get; set; }

        // Constructor mặc định
        public Inventory()
        {
            // Khởi tạo các thuộc tính với giá trị mặc định
            Id = 0;
            Name = "";
            QuantityOnHand = 0;
            DateIn = DateTime.Now;
        }

        // Thêm Dữ liệu vào DataGridView từ file inventory
        public void LoadData(string filePath, DataGridView dataGridView1)
        {
            try
            {
                // Kiểm tra xem tệp tồn tại hay không
                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException("File not found.", filePath);
                }

                // Đọc nội dung của tệp JSON
                string jsonData = File.ReadAllText(filePath);

                // Deserialize dữ liệu từ JSON thành danh sách các đối tượng Inventory
                List<Inventory> inventories = JsonConvert.DeserializeObject<List<Inventory>>(jsonData);

                // Hiển thị dữ liệu trong DataGridView
                foreach (Inventory inventory in inventories)
                {
                    // Kiểm tra xem ngày nhập của Inventory có được ghi lại không
                    // Nếu không, gán ngày hiện tại
                    if (inventory.DateIn == default(DateTime))
                    {
                        inventory.DateIn = DateTime.Now;
                    }

                    dataGridView1.Rows.Add(inventory.Id, inventory.Name, inventory.QuantityOnHand, inventory.DateIn);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        //Thêm Hàng Vào Kho
        public void Add(ComboBox comboBox_nhacungcap, ComboBox comboBox_tenSanPham, TextBox textBox_soluong, DataGridView dataGridView1)
        {
            // Kiểm tra xem các trường dữ liệu đã được nhập hay chưa
            if (comboBox_nhacungcap.SelectedIndex == -1 || comboBox_tenSanPham.SelectedIndex == -1 || string.IsNullOrWhiteSpace(textBox_soluong.Text))
            {
                // Hiển thị thông báo lỗi nếu có trường dữ liệu chưa được nhập
                MessageBox.Show("Vui lòng điền đầy đủ thông tin sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Nếu các trường dữ liệu đã được nhập đầy đủ
            // Thực hiện thêm dữ liệu vào file Inventory
            try
            {
                // Đọc nội dung từ tệp JSON (nếu tệp không tồn tại, tạo một danh sách mới)
                List<Inventory> inventories = new List<Inventory>();
                string jsonData = File.Exists("Inventory.json") ? File.ReadAllText("Inventory.json") : "";

                if (!string.IsNullOrEmpty(jsonData))
                {
                    // Deserialize dữ liệu từ JSON thành danh sách các đối tượng Inventory
                    inventories = JsonConvert.DeserializeObject<List<Inventory>>(jsonData);
                }

                // Tạo đối tượng Inventory mới
                Inventory newItem = new Inventory
                {
                    Id = inventories.Count + 1,
                    Name = comboBox_tenSanPham.SelectedItem.ToString(),
                    QuantityOnHand = int.Parse(textBox_soluong.Text),
                    DateIn = DateTime.Now
                };

                // Thêm đối tượng mới vào danh sách
                inventories.Add(newItem);

                // Serialize lại danh sách thành JSON
                string updatedJsonData = JsonConvert.SerializeObject(inventories, Formatting.Indented);

                // Ghi lại dữ liệu đã cập nhật vào tệp JSON
                File.WriteAllText("Inventory.json", updatedJsonData);

                // Thêm dữ liệu vào DataGridView
                dataGridView1.Rows.Add(newItem.Id, newItem.Name, newItem.QuantityOnHand, newItem.DateIn);

                // Hiển thị thông báo thành công
                MessageBox.Show("Đã thêm sản phẩm vào kho.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có lỗi xảy ra
                MessageBox.Show("Đã xảy ra lỗi khi thêm sản phẩm vào kho: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cập nhật Data
        public void UpdateData(DataGridView dataGridView1)
        {
            try
            {
                string filePath = "Inventory.json";

                // Kiểm tra xem tệp tồn tại hay không
                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException("File not found.", filePath);
                }

                // Đọc nội dung từ tệp JSON
                string jsonData = File.ReadAllText(filePath);

                // Deserialize dữ liệu từ JSON thành danh sách các đối tượng Inventory
                List<Inventory> inventories = JsonConvert.DeserializeObject<List<Inventory>>(jsonData);

                // Duyệt qua từng dòng trong DataGridView và cập nhật dữ liệu trong danh sách
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // Kiểm tra xem dòng không phải là dòng mới
                    if (!row.IsNewRow)
                    {
                        // Lấy ID của sản phẩm từ ô đầu tiên trong dòng
                        int id = Convert.ToInt32(row.Cells[0].Value);

                        // Tìm kiếm sản phẩm trong danh sách dựa trên ID
                        Inventory itemToUpdate = inventories.Find(x => x.Id == id);

                        if (itemToUpdate != null)
                        {
                            // Cập nhật dữ liệu từ DataGridView vào đối tượng Inventory
                            itemToUpdate.Name = Convert.ToString(row.Cells[1].Value);
                            itemToUpdate.QuantityOnHand = Convert.ToInt32(row.Cells[2].Value);
                            itemToUpdate.DateIn = Convert.ToDateTime(row.Cells[3].Value);
                        }
                    }
                }

                // Serialize lại danh sách thành JSON
                string updatedJsonData = JsonConvert.SerializeObject(inventories, Formatting.Indented);

                // Ghi lại dữ liệu đã cập nhật vào tệp JSON
                File.WriteAllText(filePath, updatedJsonData);

                // Hiển thị thông báo thành công
                MessageBox.Show("Data updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        // Xóa 1 dòng trong DataGridView và file
        public void Delete(DataGridView dataGridView1)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Duyệt qua từng dòng được chọn và xóa chúng
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    // Kiểm tra xem dòng không phải là dòng mới
                    if (!row.IsNewRow)
                    {
                        // Xác định chỉ mục của dòng
                        int rowIndex = row.Index;

                        // Xóa dòng khỏi DataGridView
                        dataGridView1.Rows.Remove(row);

                        // Xóa dòng tương ứng trong danh sách và tệp JSON
                        DeleteRowFromFile(rowIndex);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Xóa dòng từ tệp Inventory.json dựa trên chỉ mục của dòng trong DataGridView
        private void DeleteRowFromFile(int rowIndex)
        {
            try
            {
                string filePath = "Inventory.json";

                // Kiểm tra xem tệp tồn tại hay không
                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException("File not found.", filePath);
                }

                // Đọc nội dung từ tệp JSON
                string jsonData = File.ReadAllText(filePath);

                // Deserialize dữ liệu từ JSON thành danh sách các đối tượng Inventory
                List<Inventory> inventories = JsonConvert.DeserializeObject<List<Inventory>>(jsonData);

                // Kiểm tra chỉ mục dòng có hợp lệ không
                if (rowIndex >= 0 && rowIndex < inventories.Count)
                {
                    // Xóa dòng tương ứng với chỉ mục đã cho
                    inventories.RemoveAt(rowIndex);

                    // Serialize lại danh sách thành JSON
                    string updatedJsonData = JsonConvert.SerializeObject(inventories, Formatting.Indented);

                    // Ghi lại dữ liệu đã cập nhật vào tệp JSON
                    File.WriteAllText(filePath, updatedJsonData);

                    // Hiển thị thông báo thành công
                    MessageBox.Show("Row deleted from file.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new IndexOutOfRangeException("Invalid row index.");
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load data from Inventory file vào ComboBox và TextBox
        public void LoadInventoryData(ComboBox comboBox_tenSP)
        {
            try
            {
                // Đường dẫn tới file Inventory
                string inventoryFilePath = "Inventory.json";

                // Kiểm tra xem file có tồn tại không
                if (File.Exists(inventoryFilePath))
                {
                    // Đọc nội dung từ file JSON
                    string jsonData = File.ReadAllText(inventoryFilePath);

                    // Deserialize dữ liệu từ JSON thành danh sách các đối tượng Inventory
                    List<Inventory> inventories = JsonConvert.DeserializeObject<List<Inventory>>(jsonData);

                    // Hiển thị tên sản phẩm trong ComboBox
                    foreach (Inventory inventory in inventories)
                    {
                        comboBox_tenSP.Items.Add(inventory.Name);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
