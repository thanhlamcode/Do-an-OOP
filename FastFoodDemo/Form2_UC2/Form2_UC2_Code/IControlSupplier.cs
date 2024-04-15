using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo.Form2_UC2.Form2_UC2_Code
{
    internal interface IControlSupplier
    {
        void LoadDataAndPopulateComboBox(string jsonFilePath, List<Supplier> suppliers, ComboBox comboBox_nhacungcap);
        void Desc(ComboBox comboBox_nhacungcap, List<Supplier> suppliers);
    }
}
