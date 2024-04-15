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

namespace FastFoodDemo.Form2_UC3
{
    public partial class CustomerManagementForm : UserControl
    {
        public CustomerManagementForm()
        {
            InitializeComponent();

            LoadCustomerData();
        }

        private void LoadCustomerData()
        {
            // Đọc dữ liệu từ file txt
            string customerFilePath = "Customer.txt";

            if (File.Exists(customerFilePath))
            {
                string[] lines = File.ReadAllLines(customerFilePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(';');
                    if (parts.Length == 5)
                    {
                        int id = Convert.ToInt32(parts[0]);
                        string name = parts[1];
                        string address = parts[2];
                        string phoneNumber = parts[3];
                        string email = parts[4];

                        dgvCustomer.Rows.Add(id, name, address, phoneNumber, email);
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(GetNewCustomerId(), tbName.Text, tbAddr.Text, tbPhoneNumber.Text, tbEmail.Text);
            customer.Add(dgvCustomer, tbName, tbAddr, tbPhoneNumber, tbEmail);
        }

        private int GetNewCustomerId()
        {
            return dgvCustomer.Rows.Count + 1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn không
            if (dgvCustomer.SelectedRows.Count > 0)
            {
                // Lấy ID của hàng được chọn
                int customerId = Convert.ToInt32(dgvCustomer.SelectedRows[0].Cells[0].Value);

                // Tạo một đối tượng Customer với ID của khách hàng cần xóa
                Customer customer = new Customer(customerId, "", "", "", "");

                // Gọi phương thức Delete để xóa khách hàng
                customer.Delete(dgvCustomer);
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

                // Tạo một đối tượng Customer với dữ liệu của hàng được chọn
                Customer customer = new Customer(id, name, address, phoneNumber, email);

                // Gọi phương thức Update để cập nhật thông tin của khách hàng
                customer.Update(dgvCustomer);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
