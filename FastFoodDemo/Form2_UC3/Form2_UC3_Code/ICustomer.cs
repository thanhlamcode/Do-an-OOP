using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo.Form2_UC3.Form2_UC3_Code
{
    internal interface ICustomer
    {
        void Add(DataGridView dataGridView, TextBox tb1, TextBox tb2, TextBox tb3, TextBox tb4);
        void Delete(DataGridView dataGridView);
        void Update(DataGridView dataGridView);
    }
}
