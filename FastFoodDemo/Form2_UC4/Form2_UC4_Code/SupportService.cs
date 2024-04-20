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

namespace FastFoodDemo.Form2_UC4.Form2_UC4_Code
{
    public interface ISupportRequest
    {
        void Save();
        void Delete();
    }

    public enum RequestStatus
    {
        ChuaTiepNhanXuLy,
        DaTiepNhanXuLy,
        DaXuLy
    }

    [Serializable]
    public partial class SupportService : UserControl, ISupportRequest
    {

        private List<SupportRequest> list = new List<SupportRequest>();
        public class SupportRequest
        {
            public string CustomerName { get; set; }
            public string ServiceName { get; set; }
            public DateTime Date { get; set; }
            public RequestStatus Status { get; set; }
            public int ProductRating { get; set; }

            public SupportRequest()
            {

            }
            public SupportRequest(string customerName, string servicename, RequestStatus status, DateTime date, int productRating)
            {
                CustomerName = customerName;
                ServiceName = servicename;
                Status = status;
                Date = date;
                ProductRating = productRating;
            }
        }

        private void UpdateDataGridView()
        {
            // Gán danh sách dữ liệu mới cho DataGridView
            dataGridViewRequests.DataSource = list;

            // Cập nhật lại giao diện người dùng
            dataGridViewRequests.Refresh();
        }

        public SupportService()
        {
            InitializeComponent();
            SupportServiceLoad();
            dataGridViewRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        public void Save()
        {
            string filePath = "support_requests.json";

            // Sử dụng Newtonsoft.Json để serialize danh sách thành chuỗi JSON
            string jsonData = JsonConvert.SerializeObject(list);

            // Ghi chuỗi JSON vào tệp tin
            File.WriteAllText(filePath, jsonData);
            MessageBox.Show("Đã lưu", "Thông báo", MessageBoxButtons.OK);
        }

        public void SupportServiceLoad()
        {
            string filePath = "support_requests.json";

            // Kiểm tra nếu tệp tin không tồn tại
            if (!File.Exists(filePath))
            {
                // Tạo tệp mới
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    // Ghi nội dung mặc định vào tệp tin mới tạo (có thể là một mảng JSON rỗng, hoặc một đối tượng JSON mẫu)
                    sw.WriteLine("[]");
                }
            }

            // Đọc nội dung của tệp tin
            string jsonData = File.ReadAllText(filePath);

            // Sử dụng Newtonsoft.Json để deserialize chuỗi JSON thành danh sách các đối tượng
            list = JsonConvert.DeserializeObject<List<SupportRequest>>(jsonData);

            // Cập nhật DataGridView sau khi tải dữ liệu
            UpdateDataGridView();
        }

        public void Delete()
        {
            foreach (DataGridViewRow selectedRow in dataGridViewRequests.SelectedRows)
            {
                int rowIndex = selectedRow.Index;

                if (rowIndex >= 0 && rowIndex < list.Count)
                {
                    list.RemoveAt(rowIndex);
                }
            }

            // Clear the DataGridView before updating it
            dataGridViewRequests.DataSource = null;

            // Update DataGridView after deletion
            UpdateDataGridView();
            MessageBox.Show("Đã xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }
        private void btnXuLy_Click(object sender, EventArgs e)
        {
            SupportRequestManager.ProcessRequests(dataGridViewRequests);
            UpdateDataGridView();
        }

        private void dataGridViewRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewRequests.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridViewRequests.Rows[e.RowIndex];

                txtTenKhachHang.Text = selectedRow.Cells["CustomerName"].Value.ToString();
                txtDichVuSuDung.Text = selectedRow.Cells["ServiceName"].Value.ToString();
                txtNgaySuDung.Text = selectedRow.Cells["Date"].Value.ToString();
                txtTinhTrang.Text = selectedRow.Cells["Status"].Value.ToString();
                txtDanhGia.Text = selectedRow.Cells["ProductRating"].Value.ToString();
            }
        }


        private void radChuaTiepNhanXuLy_CheckedChanged(object sender, EventArgs e)
        {
            List<SupportRequest> supportRequests = new List<SupportRequest>();
            foreach (SupportRequest a in list)
            {
                if (a.Status == RequestStatus.ChuaTiepNhanXuLy)
                {
                    supportRequests.Add(a);
                }
            }
            dataGridViewRequests.DataSource = supportRequests;
        }

        private void radTiepNhanXuLy_CheckedChanged(object sender, EventArgs e)
        {
            List<SupportRequest> supportRequests1 = new List<SupportRequest>();
            foreach (SupportRequest a in list)
            {
                if (a.Status == RequestStatus.DaTiepNhanXuLy)
                {
                    supportRequests1.Add(a);
                }
            }
            dataGridViewRequests.DataSource = supportRequests1;
        }

        private void radDaXuLy_CheckedChanged(object sender, EventArgs e)
        {
            List<SupportRequest> supportRequests2 = new List<SupportRequest>();
            foreach (SupportRequest a in list)
            {
                if (a.Status == RequestStatus.DaXuLy)
                {
                    supportRequests2.Add(a);
                }
            }
            dataGridViewRequests.DataSource = supportRequests2;
        }
        public sealed class SupportRequestManager
        {
            public static void ProcessRequests(DataGridView dataGridView)
            {
                // Lặp qua từng hàng được chọn trong DataGridView
                foreach (DataGridViewRow selectedRow in dataGridView.SelectedRows)
                {
                    // Lấy yêu cầu từ hàng được chọn
                    SupportService.SupportRequest request = selectedRow.DataBoundItem as SupportService.SupportRequest;

                    if (request != null)
                    {
                        // Xử lý yêu cầu tùy thuộc vào trạng thái hiện tại của nó
                        switch (request.Status)
                        {
                            case RequestStatus.ChuaTiepNhanXuLy:
                                request.Status = RequestStatus.DaTiepNhanXuLy;
                                break;
                            case RequestStatus.DaTiepNhanXuLy:
                                request.Status = RequestStatus.DaXuLy;
                                break;
                            case RequestStatus.DaXuLy:
                                request.Status = RequestStatus.ChuaTiepNhanXuLy;
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }
    }
}
