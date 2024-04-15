using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo.Form2_UC2.Form2_UC2_Code
{
    internal interface IControlProduct
    {
        void LoadData(string filePath, DataGridView dataGridView1);
        void Add(ComboBox comboBox_nhacungcap, ComboBox comboBox_tenSanPham, TextBox textBox_soluong, DataGridView dataGridView1);
        void UpdateData(DataGridView dataGridView1);
        void Delete(DataGridView dataGridView1);
    }
}
