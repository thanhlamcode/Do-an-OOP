using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo.Form2_UC.Form2_Code
{
    internal interface IqLNV
    {
        void Delete(DataGridView dataGridView1, List<string> rowDataList);
        void Save(DataGridView dataGridView1, List<string> rowDataList);
        void Write_ToTxt(List<string> rowDataList);
        void Write_ToList(DataGridView dataGridView1, List<string> rowDataList);

    }
}
