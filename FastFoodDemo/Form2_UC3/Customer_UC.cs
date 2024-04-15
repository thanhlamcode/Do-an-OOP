using FastFoodDemo.Form2_UC3.Form2_UC3_Code;
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
using Newtonsoft.Json;

namespace FastFoodDemo.Form2_UC3
{
    public partial class CustomerManagementForm : UserControl
    {
        private List<Customer> customers;

        public CustomerManagementForm()
        {
            InitializeComponent();

            LoadCustomerData();
        }

        private void LoadCustomerData()
        {
            string customerFilePath = "Customer.json";

            if (File.Exists(customerFilePath))
            {
                string jsonData = File.ReadAllText(customerFilePath);
                customers = JsonConvert.DeserializeObject<List<Customer>>(jsonData);

                foreach (Customer customer in customers)
                {
                    dgvCustomer.Rows.Add(customer.ID, customer.name, customer.address, customer.phoneNumber, customer.email);
                }
            }
            else
            {
                customers = new List<Customer>();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Add(dgvCustomer, tbName, tbAddr, tbPhoneNumber, tbEmail);

            // Cập nhật danh sách khách hàng sau khi thêm
            UpdateCustomerList();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn không
            if (dgvCustomer.SelectedRows.Count > 0)
            {
                // Lấy ID của hàng được chọn
                int customerId = Convert.ToInt32(dgvCustomer.SelectedRows[0].Cells[0].Value);

                // Xóa khách hàng từ danh sách
                customers.RemoveAll(c => c.ID == customerId);

                // Cập nhật tệp JSON
                UpdateJsonFile();

                // Xóa hàng khỏi DataGridView
                dgvCustomer.Rows.Remove(dgvCustomer.SelectedRows[0]);

                // Hiển thị thông báo xóa thành công
                MessageBox.Show("Data deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn không
            if (dgvCustomer.SelectedRows.Count > 0)
            {
                // Lấy dữ liệu của hàng được chọn
                int id = Convert.ToInt32(dgvCustomer.SelectedRows[0].Cells[0].Value);
                string name = dgvCustomer.SelectedRows[0].Cells[1].Value.ToString();
                string address = dgvCustomer.SelectedRows[0].Cells[2].Value.ToString();
                string phoneNumber = dgvCustomer.SelectedRows[0].Cells[3].Value.ToString();
                string email = dgvCustomer.SelectedRows[0].Cells[4].Value.ToString();

                // Cập nhật thông tin khách hàng trong danh sách
                Customer customerToUpdate = customers.Find(c => c.ID == id);
                if (customerToUpdate != null)
                {
                    customerToUpdate.name = name;
                    customerToUpdate.address = address;
                    customerToUpdate.phoneNumber = phoneNumber;
                    customerToUpdate.email = email;
                }

                // Cập nhật tệp JSON
                UpdateJsonFile();

                // Hiển thị thông báo cập nhật thành công
                MessageBox.Show("Data updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateJsonFile()
        {
            string customerFilePath = "Customer.json";
            string jsonData = JsonConvert.SerializeObject(customers, Formatting.Indented);
            File.WriteAllText(customerFilePath, jsonData);
        }

        private void UpdateCustomerList()
        {
            customers = dgvCustomer.Rows.Cast<DataGridViewRow>()
                                .Where(row => !row.IsNewRow)
                                .Select(row => new Customer
                                {
                                    ID = Convert.ToInt32(row.Cells[0].Value),
                                    name = row.Cells[1].Value.ToString(),
                                    address = row.Cells[2].Value.ToString(),
                                    phoneNumber = row.Cells[3].Value.ToString(),
                                    email = row.Cells[4].Value.ToString()
                                })
                                .ToList();
        }
    }
}
