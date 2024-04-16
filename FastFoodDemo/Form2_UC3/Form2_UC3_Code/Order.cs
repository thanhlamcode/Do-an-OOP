using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace FastFoodDemo.Form2_UC3.Form2_UC3_Code
{
    internal class Order : IOrder
    {
        public string orderID { get; set; }
        public DateTime dateTime { get; set; }
        public int staffID { get; set; }
        public int customerID { get; set; }
        public List<OrderDetail> orderDetail { get; set; }

        public class OrderDetail
        {
            public string productName { get; set; }
            public int quantity { get; set; }
            public double unitPrice { get; set; }
        }

        public Order()
        {
            orderID = "";
            dateTime = DateTime.MinValue;
            staffID = 0;
            customerID = 0;
            orderDetail = new List<OrderDetail>();
        }

        public void Add(ComboBox cb1, TextBox txt1, TextBox txt2, TextBox txt3, DateTimePicker dtp, DataGridView dgv)
        {
            try
            {
                string orderFilePath = "Order.json";
                List<Order> orders = new List<Order>();

                if (File.Exists(orderFilePath))
                {
                    string jsonData = File.ReadAllText(orderFilePath);
                    orders = JsonConvert.DeserializeObject<List<Order>>(jsonData);
                }

                int maxOrderId = 0;

                foreach (var order in orders)
                {
                    int orderId = int.Parse(order.orderID.Substring(2)); // Bỏ qua ký tự 'HD' để lấy số
                    if (orderId > maxOrderId)
                    {
                        maxOrderId = orderId;
                    }
                }

                maxOrderId++;
                string newOrderId = "HD" + maxOrderId;
                dgv.Rows.Clear();
                cb1.Items.Add(newOrderId);
                cb1.SelectedIndex = cb1.Items.Count - 1;
                txt1.Text = newOrderId;
                txt2.Text = "";
                txt3.Text = "";
                dtp.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm hóa đơn mới: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Update(ComboBox cb2, TextBox txt1, TextBox txt2, TextBox txt3, TextBox txt4, DateTimePicker dtp, DataGridView dgv)
        {
            // Your Update method code using JSON serialization
            try
            {
                string orderFilePath = "Order.json";

                List<Order> orders = new List<Order>();
                if (File.Exists(orderFilePath))
                {
                    string jsonData = File.ReadAllText(orderFilePath);
                    orders = JsonConvert.DeserializeObject<List<Order>>(jsonData);
                }

                string maHD = txt1.Text;
                string ngay = dtp.Value.ToString("yyyy/MM/dd");
                string maNV = txt2.Text;
                string maKH = txt3.Text;

                List<OrderDetail> productList = new List<OrderDetail>();
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null)
                    {
                        string productName = row.Cells[0].Value.ToString();
                        int quantity = Convert.ToInt32(row.Cells[1].Value);
                        double unitPrice = Convert.ToDouble(row.Cells[2].Value);

                        productList.Add(new OrderDetail
                        {
                            productName = productName,
                            quantity = quantity,
                            unitPrice = unitPrice
                        });
                    }
                }

                Order orderToUpdate = null;
                foreach (Order order in orders)
                {
                    if (order.orderID == maHD)
                    {
                        orderToUpdate = order;
                        break;
                    }
                }

                if (orderToUpdate != null)
                {
                    orderToUpdate.dateTime = dtp.Value;
                    orderToUpdate.staffID = Convert.ToInt32(txt2.Text);
                    orderToUpdate.customerID = Convert.ToInt32(txt3.Text);
                    orderToUpdate.orderDetail = productList;
                }
                else
                {
                    orders.Add(new Order
                    {
                        orderID = maHD,
                        dateTime = dtp.Value,
                        staffID = Convert.ToInt32(txt2.Text),
                        customerID = Convert.ToInt32(txt3.Text),
                        orderDetail = productList
                    });
                }

                string updatedJsonData = JsonConvert.SerializeObject(orders, Formatting.Indented);
                File.WriteAllText(orderFilePath, updatedJsonData);

                MessageBox.Show("Hóa đơn đã được lưu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Delete(ComboBox cb, TextBox txt1, TextBox txt2, TextBox txt3, TextBox txt4, DateTimePicker dtp, DataGridView dgv)
        {
            try
            {
                string orderFilePath = "Order.json";
                string selectedMaHD = cb.SelectedItem.ToString();

                List<Order> orders = new List<Order>();
                if (File.Exists(orderFilePath))
                {
                    string jsonData = File.ReadAllText(orderFilePath);
                    orders = JsonConvert.DeserializeObject<List<Order>>(jsonData);
                }

                Order orderToDelete = null;
                foreach (Order order in orders)
                {
                    if (order.orderID == selectedMaHD)
                    {
                        orderToDelete = order;
                        break;
                    }
                }

                if (orderToDelete != null)
                {
                    orders.Remove(orderToDelete);

                    string updatedJsonData = JsonConvert.SerializeObject(orders, Formatting.Indented);
                    File.WriteAllText(orderFilePath, updatedJsonData);

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
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
