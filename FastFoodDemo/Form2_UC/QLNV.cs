using FastFoodDemo.Form2_UC.Form2_Code;
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

namespace FastFoodDemo.Form2_UC
{
    public partial class QLNV : UserControl
    {
        DateTimePicker dtp = new DateTimePicker();
        ComboBox cbb = new ComboBox();
        Rectangle _rectangle;
        List<string> rowDataList = new List<string>();
        QLNV_Code qLNV = new QLNV_Code();
        public QLNV()
        {
            InitializeComponent();

            dataGridView1.Controls.Add(dtp);
            dtp.Visible = false;
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "dd/MM/yyyy";
            dtp.TextChanged += new EventHandler(dtp_TextChanged);

            dataGridView1.Controls.Add(cbb);
            cbb.Items.Add("Thu Ngân");
            cbb.Items.Add("Bảo Vệ");
            cbb.Visible = false;
            cbb.TextChanged += new EventHandler(cbb_TextChanged);
        }
        private void cbb_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell.Value = cbb.SelectedItem.ToString();
        }
        private void dtp_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell.Value = dtp.Text.ToString();
        }

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            dtp.Visible = false;
            cbb.Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex >=0 && e.ColumnIndex < dataGridView1.Columns.Count){
                switch (dataGridView1.Columns[e.ColumnIndex].Name)
                {
                    case "Ngayvaolam":
                        _rectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                        dtp.Size = new Size(_rectangle.Width, _rectangle.Height);
                        dtp.Location = new Point(_rectangle.X, _rectangle.Y);
                        dtp.Visible = true;
                        break;
                    case "QuyenTruyCap":
                        _rectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                        cbb.Size = new Size(_rectangle.Width, _rectangle.Height);
                        cbb.Location = new Point(_rectangle.X, _rectangle.Y);
                        cbb.Visible = true;
                        break;
                }
            }
        }
        private void QLNV_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Ten", "Tên");
            dataGridView1.Columns.Add("MatKhau", "Mật khẩu");
            dataGridView1.Columns.Add("QuyenTruyCap", "Quyền truy cập");
            dataGridView1.Columns.Add("Ngayvaolam", "Ngày vào làm");
            try
            {
                string filename = "LoginData.txt";
                string[] lines = File.ReadAllLines(filename);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] columns = lines[i].Split(',');
                    if (columns[3] == "0")
                    {
                        columns[3] = "Admin";
                    }
                    else if (columns[3] == "1")
                    {
                        columns[3] = "Thu Ngân";
                    }
                    else if (columns[3] == "2")
                    {
                        columns[3] = "Bảo Vệ";
                    }
                    dataGridView1.Rows.Add(columns);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Delbtn_Click(object sender, EventArgs e)
        {
            qLNV.Delete(dataGridView1, rowDataList);
        }
        private void Savebtn_Click(object sender, EventArgs e)
        {
            qLNV.Save(dataGridView1, rowDataList);
        }
    }
}
