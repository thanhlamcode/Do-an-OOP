using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo.Form2_UC3.Form2_UC3_Code
{
    internal interface IOrder
    {
        void Add(ComboBox cb1, TextBox txt1, TextBox txt2, TextBox txt3, DateTimePicker dtp, DataGridView dgv);
        void Update(ComboBox cb2, TextBox txt1, TextBox txt2, TextBox txt3, TextBox txt4, DateTimePicker dtp, DataGridView dgv);
        void Delete(ComboBox cb, TextBox txt1, TextBox txt2, TextBox txt3, TextBox txt4, DateTimePicker dtp, DataGridView dgv);
    }
}
