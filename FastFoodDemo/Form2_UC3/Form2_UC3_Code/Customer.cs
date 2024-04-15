using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FastFoodDemo.Form2_UC3.Form2_UC3_Code
{
    internal class Customer : ICustomer
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }

        public Customer(int iD, string name, string address, string phoneNumber, string email)
        {
            ID = iD;
            this.name = name;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        public void Add(DataGridView dataGridView, TextBox tbName, TextBox tbAddr, TextBox tbPhoneNumber, TextBox tbEmail)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text) || string.IsNullOrWhiteSpace(tbAddr.Text) || string.IsNullOrWhiteSpace(tbPhoneNumber.Text))
            {
                // Hiển thị thông báo lỗi nếu có trường dữ liệu chưa được nhập
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string customerFilePath = "Customer.txt";
                int newID;

                // Mở tệp để đọc
                using (StreamReader reader = new StreamReader(customerFilePath))
                {
                    string lastLine = File.ReadLines(customerFilePath).LastOrDefault();
                    if (lastLine != null)
                    {
                        string[] parts = lastLine.Split(';');
                        newID = Convert.ToInt32(parts[0]) + 1;
                    }
                    else
                    {
                        newID = 1; // Nếu không có dữ liệu trong tệp, ID mới sẽ là 1
                    }
                }

                // Mở tệp để ghi
                using (StreamWriter writer = new StreamWriter(customerFilePath, true))
                {
                    string name = tbName.Text;
                    string addr = tbAddr.Text;
                    string phone = tbPhoneNumber.Text;
                    string email = tbEmail.Text;
                    // Ghi dữ liệu vào file
                    writer.WriteLine($"{newID};{name};{addr};{phone};{email}");
                    // Thêm dữ liệu vào DataGridView
                    dataGridView.Rows.Add(newID, name, addr, phone, email);
                }

                // Hiển thị thông báo thành công
                MessageBox.Show("Đã thêm khách hàng mới thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có lỗi xảy ra
                MessageBox.Show("Đã xảy ra lỗi khi thêm : " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Update(DataGridView dataGridView)
        {
            try
            {
                string filePath = "Customer.txt";
                // Kiểm tra xem tập tồn tại hay không
                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException("File not found.", filePath);
                }

                // Mở tệp để ghi
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Duyệt qua từng dòng trong DataGridView và ghi lại dữ liệu vào tập
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        // Kiểm tra xem dòng không phải là dòng mới
                        if (!row.IsNewRow)
                        {
                            // Xây dựng lại chuỗi dữ liệu từ các ô dữ liệu trong dòng
                            string rowData = string.Join(";", row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value.ToString()).ToArray());
                            // Ghi lại chuỗi dữ liệu vào tập
                            writer.WriteLine(rowData);
                        }
                    }
                }
                // Hiển thị thông báo thành công
                MessageBox.Show("Data updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                // Xóa dữ liệu trong file txt
                string customerFilePath = "Customer.txt";
                List<string> lines = new List<string>();
                using (StreamReader reader = new StreamReader(customerFilePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] parts = line.Split(';');
                        int id = Convert.ToInt32(parts[0]);

                        if (!customerIds.Contains(id))
                        {
                            lines.Add(line);
                        }
                    }
                }

                using (StreamWriter writer = new StreamWriter(customerFilePath, false))
                {
                    foreach (string line in lines)
                    {
                        writer.WriteLine(line);
                    }
                }

                // Cập nhật DataGridView
                dataGridView.Rows.Remove(dataGridView.SelectedRows[0]);
            }
        }
    }
}
