using FastFoodDemo.Form2_UC2.Form2_UC2_Code;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo.Form2_UC2
{
    public partial class Inventory_UC : UserControl
    {
        private List<Supplier> suppliers = new List<Supplier>(); // Danh sách các nhà cung cấp
        Inventory inventory = new Inventory();
        Supplier supplier = new Supplier();        
        public Inventory_UC()
        {
            InitializeComponent();
            // Bước 1
            supplier.LoadDataAndPopulateComboBox("Supply.json", suppliers, comboBox_nhacungcap); // Load dữ liệu từ tệp JSON và hiển thị tên nhà cung cấp
            //Bước 3
            comboBox_nhacungcap.SelectedIndexChanged += comboBox_nhacungcap_SelectedIndexChanged; // Thêm sự kiện SelectedIndexChanged của comboBox_nhacungcap
            //Bước 4
            inventory.LoadData("Inventory.json", dataGridView1);
        }

        private void comboBox_nhacungcap_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_tenSanPham.Items.Clear(); // Xóa các mục đã có trong combobox_tenSanPham trước đó
            int selectedIndex = comboBox_nhacungcap.SelectedIndex; // Lấy chỉ mục của nhà cung cấp được chọn trong combobox_nhacungcap
            if (selectedIndex >= 0 && selectedIndex < suppliers.Count) // Kiểm tra xem chỉ mục có hợp lệ hay không
            {
                Supplier selectedSupplier = suppliers[selectedIndex]; // Lấy thông tin của nhà cung cấp được chọn từ danh sách suppliers
                foreach (string productName in selectedSupplier.nameproduct) // Duyệt qua danh sách tên sản phẩm của nhà cung cấp được chọn
                {
                    comboBox_tenSanPham.Items.Add(productName); // Thêm tên sản phẩm vào combobox_tenSanPham để hiển thị cho người dùng
                }
            }
        }

        //xử lý sự kiện thêm đơn hàng vào kho
        private void button_add_Click(object sender, EventArgs e)
        {
            inventory.Add(comboBox_nhacungcap, comboBox_tenSanPham, textBox_soluong, dataGridView1);

        }

        //Button Delete
        private void button_DELETE_Click(object sender, EventArgs e)
        {
            inventory.Delete(dataGridView1);
        }


        // Xem thông tin chi tiết Nhà cung cấp
        private void button_DESC_Click(object sender, EventArgs e)
        {
            supplier.Desc(comboBox_nhacungcap, suppliers);
        }

        //Cập nhập Data
        private void button_Update_Click(object sender, EventArgs e)
        {
            inventory.UpdateData(dataGridView1);
        }

        // hiển thị tên các nhà cung cấp lên combobox
        private void PopulateSupplierComboBox()
        {
            foreach (Supplier supplier in suppliers)
            {
                comboBox_nhacungcap.Items.Add(supplier.namesupply);
            }
        }
    }
}