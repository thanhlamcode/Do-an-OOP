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

namespace FastFoodDemo.Form2_UC
{
    public partial class LGHistory : UserControl
    {
        public LGHistory()
        {
            InitializeComponent();
        }
        private void LGHistory_Load(object sender, EventArgs e)
        {
            string filename = "LoginHistory.txt";
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                listBox1.Items.Add(line);
            }
        }
    }
}
