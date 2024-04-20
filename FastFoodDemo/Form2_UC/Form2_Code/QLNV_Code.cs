using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo.Form2_UC.Form2_Code
{
    internal class QLNV_Code : IqLNV
    {
        public void Delete(DataGridView dataGridView1, List<string> rowDataList)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    rowDataList.Clear();
                    foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                    {
                        dataGridView1.Rows.Remove(item);
                    }
                    Write_ToList(dataGridView1, rowDataList);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        public void Save(DataGridView dataGridView1, List<string> rowDataList)
        {
            Write_ToList(dataGridView1, rowDataList);
            Write_ToTxt(rowDataList);
        }
        public void Write_ToList(DataGridView dataGridView1, List<string> rowDataList)
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                // Tạo một chuỗi để lưu trữ dữ liệu từng dòng
                StringBuilder rowData = new StringBuilder();

                // Duyệt qua mỗi ô trong dòng hiện tại
                foreach (DataGridViewCell cell in item.Cells)
                {
                    // Kiểm tra nếu ô đó không phải là null
                    if (cell.Value != null)
                    {
                        // Thêm dữ liệu của mỗi ô vào chuỗi rowData, phân tách bằng dấu phẩy (,),
                        // bạn có thể thay đổi ký tự phân tách tùy theo nhu cầu
                        if (cell.Value.ToString() == "Thu Ngân")
                        {
                            rowData.Append("1" + ',');
                        }
                        else if (cell.Value.ToString() == "Bảo Vệ")
                        {
                            rowData.Append("2" + ',');
                        }
                        else if (cell.Value.ToString() == "Admin")
                        {
                            rowData.Append("0" + ',');
                        }
                        else
                        {
                            rowData.Append(cell.Value?.ToString() + ",");
                        }
                    }
                }
                // Xóa dấu phẩy cuối cùng nếu có
                if (rowData.Length > 0)
                    rowData.Remove(rowData.Length - 1, 1);

                // Thêm chuỗi rowData vào danh sách rowDataList
                rowDataList.Add(rowData.ToString());
            }
        }
        public void Write_ToTxt(List<string> rowDataList)
        {
            string filename = "LoginData.txt";
            // Tiến hành ghi dữ liệu vào file, tự động ghi đè lên nếu file đã tồn tại
            File.WriteAllText(filename, "");
            using (StreamWriter writer = new StreamWriter(filename))
            {
                for (int i = 0; i < rowDataList.Count - 1; i++)
                {
                    if (i == rowDataList.Count - 1)
                    {
                        writer.Write(rowDataList[i]);
                    }
                    else
                    {
                        writer.WriteLine(rowDataList[i]);
                    }
                }
                rowDataList.Clear();
            }
        }
    }
}
