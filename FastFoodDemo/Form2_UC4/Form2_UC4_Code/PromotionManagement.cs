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
using System.Xml.Serialization;


namespace FastFoodDemo.Form2_UC4.Form2_UC4_Code
{

    public interface IInvoiceManagement
    {
        void AddInvoice();
        void EditInvoice();
        void DeleteInvoice();
    }
    [Serializable]
    public partial class Promotion_Management : UserControl, IInvoiceManagement
    {
        private List<Promotion> promotions = new List<Promotion>();

        public Promotion_Management()
        {
            InitializeComponent();

            LoadData(); // Tải dữ liệu từ file khi form được khởi tạo
            UpdateDataGridView(); // Hiển thị dữ liệu lên DataGridView
        }



        // Phương thức thêm hóa đơn
        public void AddInvoice()
        {
            // Kiểm tra xem các trường dữ liệu có rỗng không
            if (string.IsNullOrWhiteSpace(cbNhomHang.Text) || string.IsNullOrWhiteSpace(txtTenChuongTrinh.Text) ||
                string.IsNullOrWhiteSpace(txtMotachuongtrinh.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            try
            {
                // Lấy thông tin hóa đơn từ các controls trên form
                string productType = cbNhomHang.Text.ToUpper(); // Chuyển đổi thành chữ in hoa
                string promotionCode = txtMaKhuyenMai.Text.ToUpper(); // Chuyển đổi thành chữ in hoa
                string promotionName = txtTenChuongTrinh.Text.ToUpper(); // Chuyển đổi thành chữ in hoa
                DateTime startDate = dateTimePickerStart.Value;
                DateTime endDate = dateTimePickerEnd.Value;
                string description = txtMotachuongtrinh.Text.ToUpper(); // Chuyển đổi thành chữ in hoa

                // Kiểm tra xem mã khuyến mãi đã tồn tại chưa
                foreach (Promotion promotion in promotions)
                {
                    if (promotion.PromotionCode == promotionCode)
                    {
                        MessageBox.Show("Mã khuyến mãi đã tồn tại. Vui lòng chọn mã khuyến mãi khác.");
                        return;
                    }
                }

                // Tạo hóa đơn mới và thêm vào danh sách
                Promotion newPromotion = new Promotion(productType, promotionCode, promotionName, startDate, endDate, description);
                promotions.Add(newPromotion);

                // Lưu dữ liệu vào file
                SaveData();

                // Cập nhật DataGridView
                UpdateDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm hóa đơn: " + ex.Message);
            }
        }



        public void EditInvoice()
        {
            try
            {
                // Kiểm tra xem có dòng nào được chọn không
                if (dataGridViewPromotions.SelectedRows.Count > 0)
                {
                    // Lấy thông tin hóa đơn từ các controls trên form
                    DataGridViewRow selectedRow = dataGridViewPromotions.SelectedRows[0];
                    Promotion selectedPromotion = selectedRow.DataBoundItem as Promotion;

                    selectedPromotion.ProductType = cbNhomHang.Text;
                    selectedPromotion.PromotionCode = txtMaKhuyenMai.Text;
                    selectedPromotion.PromotionName = txtTenChuongTrinh.Text;
                    selectedPromotion.StartDate = dateTimePickerStart.Value;
                    selectedPromotion.EndDate = dateTimePickerEnd.Value;
                    selectedPromotion.Description = txtMotachuongtrinh.Text;

                    // Lưu dữ liệu vào file
                    SaveData();

                    // Cập nhật DataGridView
                    UpdateDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa hóa đơn: " + ex.Message);
            }
        }

        public void DeleteInvoice()
        {
            try
            {
                // Kiểm tra xem có dòng nào được chọn không
                if (dataGridViewPromotions.SelectedRows.Count > 0)
                {
                    // Lấy dòng được chọn và xóa khỏi danh sách
                    DataGridViewRow selectedRow = dataGridViewPromotions.SelectedRows[0];
                    Promotion selectedPromotion = selectedRow.DataBoundItem as Promotion;
                    promotions.Remove(selectedPromotion);

                    // Lưu dữ liệu vào file
                    SaveData();

                    // Cập nhật DataGridView
                    UpdateDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa hóa đơn: " + ex.Message);
            }
        }


        public class Promotion
        {
            public string ProductType { get; set; }
            public string PromotionCode { get; set; }
            public string PromotionName { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public string Description { get; set; }

            public Promotion()
            {
            }

            public Promotion(string productType, string code, string name, DateTime startDate, DateTime endDate, string description)
            {
                ProductType = productType;
                PromotionCode = code;
                PromotionName = name;
                StartDate = startDate;
                EndDate = endDate;
                Description = description;
            }
        }


        private void LoadData()
        {
            try
            {
                if (!File.Exists("promotions.xml"))
                {
                    // Nếu tệp không tồn tại, tạo một danh sách mới của Promotion
                    promotions = new List<Promotion>();
                    // Ghi danh sách mới vào tệp mới tạo
                    SaveData();
                }
                else
                {
                    // Nếu tệp tồn tại, đọc dữ liệu từ tệp
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Promotion>));
                    using (FileStream fs = new FileStream("promotions.xml", FileMode.Open))
                    {
                        promotions = (List<Promotion>)serializer.Deserialize(fs);
                    }
                }
            }



            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc dữ liệu từ tệp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveData()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Promotion>));
                using (FileStream fs = new FileStream("promotions.xml", FileMode.Create))
                {
                    serializer.Serialize(fs, promotions);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi dữ liệu vào tệp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void UpdateDataGridView()
        {
            dataGridViewPromotions.DataSource = null;
            dataGridViewPromotions.DataSource = promotions;
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void dataGridViewPromotions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData();
        }

        private void cbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy giá trị đã chọn từ ComboBox
            string selectedProductType = cbProductType.SelectedItem?.ToString();

            // Kiểm tra nếu giá trị đã chọn không rỗng
            if (!string.IsNullOrEmpty(selectedProductType))
            {
                // Tạo một danh sách mới để lưu trữ các đối tượng Promotion đã được lọc
                List<Promotion> filteredPromotions = new List<Promotion>();

                // Duyệt qua danh sách promotions để lọc các đối tượng có ProductType tương ứng
                foreach (Promotion promotion in promotions)
                {
                    if (promotion.ProductType == selectedProductType)
                    {
                        filteredPromotions.Add(promotion);
                    }
                }

                // Hiển thị dữ liệu lọc lên DataGridView
                dataGridViewPromotions.DataSource = filteredPromotions;
            }
            else
            {
                // Nếu không có giá trị được chọn, hiển thị tất cả các hóa đơn trên DataGridView
                dataGridViewPromotions.DataSource = promotions;
            }
        }


        // Các sự kiện click nút Thêm, Sửa, Xóa
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddInvoice();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditInvoice();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteInvoice();
        }


    }
}
