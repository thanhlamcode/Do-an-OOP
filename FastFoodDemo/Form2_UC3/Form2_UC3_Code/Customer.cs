using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using FastFoodDemo.Form2_UC2.Form2_UC2_Code;
using Newtonsoft.Json;

namespace FastFoodDemo.Form2_UC3.Form2_UC3_Code
{
    internal class Customer : ICustomer
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }

        public Customer()
        {
            ID = 0;
            name = "";
            address = "";
            phoneNumber = "";
            email = "";
        }

        public void Add(DataGridView dataGridView, TextBox tbName, TextBox tbAddr, TextBox tbPhoneNumber, TextBox tbEmail)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text) || string.IsNullOrWhiteSpace(tbAddr.Text) || string.IsNullOrWhiteSpace(tbPhoneNumber.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                List<Customer> customers = new List<Customer>();
                string jsonData = File.Exists("Customer.json") ? File.ReadAllText("Customer.json") : "";

                if (!string.IsNullOrEmpty(jsonData))
                {
                    // Deserialize dữ liệu từ JSON thành danh sách các đối tượng Inventory
                    customers = JsonConvert.DeserializeObject<List<Customer>>(jsonData);
                }

                // Tạo đối tượng Inventory mới
                Customer newCustomer = new Customer
                {
                    ID = customers.Count + 1,
                    name = tbName.Text,
                    address = tbAddr.Text,
                    phoneNumber = tbPhoneNumber.Text,
                    email = tbEmail.Text
                };

                // Thêm vào danh sách khách hàng
                customers.Add(newCustomer);

                // Serialize lại danh sách thành JSON
                string updatedJsonData = JsonConvert.SerializeObject(customers, Formatting.Indented);
                // Ghi lại dữ liệu đã cập nhật vào tệp JSON

                File.WriteAllText("Customer.json", updatedJsonData);

                // Thêm vào DataGridView
                dataGridView.Rows.Add(newCustomer.ID, newCustomer.name, newCustomer.address, newCustomer.phoneNumber, newCustomer.email);

                MessageBox.Show("Đã thêm khách hàng mới thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm : " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Update(DataGridView dataGridView)
        {
            try
            {
                string filePath = "Customer.json";
                // Kiểm tra xem tập tồn tại hay không
                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException("File not found.", filePath);
                }

                // Đọc dữ liệu từ tệp JSON vào danh sách khách hàng
                List<Customer> customers = JsonConvert.DeserializeObject<List<Customer>>(File.ReadAllText(filePath));

                // Cập nhật dữ liệu từ DataGridView vào danh sách khách hàng
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        int customerId = Convert.ToInt32(row.Cells[0].Value);
                        Customer customerToUpdate = null;
                        foreach (Customer customer in customers)
                        {
                            if (customer.ID == customerId)
                            {
                                customerToUpdate = customer;
                                break;
                            }
                        }
                        if (customerToUpdate != null)
                        {
                            customerToUpdate.name = row.Cells[1].Value.ToString();
                            customerToUpdate.address = row.Cells[2].Value.ToString();
                            customerToUpdate.phoneNumber = row.Cells[3].Value.ToString();
                            customerToUpdate.email = row.Cells[4].Value.ToString();
                        }
                    }
                }

                // Ghi danh sách khách hàng cập nhật vào tệp JSON
                string updatedJsonData = JsonConvert.SerializeObject(customers, Formatting.Indented);
                File.WriteAllText(filePath, updatedJsonData);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Delete(DataGridView dataGridView)
        {
            // Xác nhận việc xóa
            DialogResult check = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                // Lấy danh sách ID khách hàng cần xóa
                List<int> customerIds = new List<int>();
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    customerIds.Add(Convert.ToInt32(row.Cells[0].Value));
                }

                // Đọc dữ liệu từ tệp JSON vào danh sách khách hàng
                string jsonFilePath = "Customer.json";
                List<Customer> customers = JsonConvert.DeserializeObject<List<Customer>>(File.ReadAllText(jsonFilePath));

                // Loại bỏ khách hàng cần xóa khỏi danh sách
                List<Customer> updatedCustomers = new List<Customer>();
                foreach (Customer customer in customers)
                {
                    if (!customerIds.Contains(customer.ID))
                    {
                        updatedCustomers.Add(customer);
                    }
                }

                // Ghi danh sách khách hàng đã cập nhật vào tệp JSON
                string updatedJsonData = JsonConvert.SerializeObject(customers, Formatting.Indented);
                File.WriteAllText(jsonFilePath, updatedJsonData);

                // Cập nhật DataGridView
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    dataGridView.Rows.Remove(row);
                }
            }
        }
    }
}
