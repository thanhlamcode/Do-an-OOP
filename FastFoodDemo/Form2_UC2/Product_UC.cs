using FastFoodDemo.Form2_UC2.Form2_UC2_Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo.Form2_UC2
{
    public partial class Product_UC : UserControl
    {
        Inventory inventory = new Inventory();
        Product product = new Product();
        public Product_UC()
        {
            InitializeComponent();
            // Đăng ký sự kiện SelectedIndexChanged cho ComboBox
            comboBox_tenSP.SelectedIndexChanged += ComboBox_tenSP_SelectedIndexChanged;
        }
        private void ComboBox_tenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            product.UpdateTextboxTonKho(comboBox_tenSP, textBox_Tonkho);
        }
        private void button_xuathang_Click(object sender, EventArgs e)
        {
            product.ValidateAndAddProduct(dataGridView1, comboBox_tenSP, textBox_soluongxuatkho, textBox_giaban, comboBox_discount, textBox_Tonkho);
        }

        private void button_LOAD_Click(object sender, EventArgs e)
        {
            // Load data from Inventory file vào Combobox và textbox (danh sách hàng hóa và hàng tồn kho)
            inventory.LoadInventoryData(comboBox_tenSP);

            // Phương thức để tải dữ liệu sản phẩm vào DataGridView
            product.LoadProductData(dataGridView1);
        }
    }
}
