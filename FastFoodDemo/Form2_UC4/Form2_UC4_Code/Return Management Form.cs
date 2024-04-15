using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Collections;
using System.Drawing;
namespace FastFoodDemo.Form2_UC4.Form2_UC4_Code
{
    [Serializable]
    public partial class Return_Management_Form : UserControl
    {
        List<Invoice> invoices = new List<Invoice>();
        private List<Invoice> currentDisplayedInvoices = new List<Invoice>();
        private InvoiceManager invoiceManager;

        private bool sortAscending = true;
        public Return_Management_Form()
        {
            LoadDataFromFile();
            InitializeComponent();
            invoiceManager = new InvoiceManager(this, invoices);
            SetupListView();


            dateTimePickerFrom.ShowUpDown = true;

            // Đặt giá trị ban đầu cho DateTimePicker.
            dateTimePickerFrom.Format = DateTimePickerFormat.Custom;
            dateTimePickerFrom.CustomFormat = " "; // Đặt một chuỗi rỗng ban đầu
            dateTimePickerTo.Format = DateTimePickerFormat.Custom;
            dateTimePickerTo.CustomFormat = " ";
            dateTimePickerFrom.Enter += dateTimePickerFrom_Enter;
            dateTimePickerFrom.Leave += dateTimePickerFrom_Leave;
            dateTimePickerTo.Enter += dateTimePickerTo_Enter;
            dateTimePickerTo.Leave += dateTimePickerTo_Leave;
        }

        private void SetupListView()
        {
            lstvOrderlist.View = View.Details;
            lstvOrderlist.GridLines = true;
            lstvOrderlist.FullRowSelect = true;
            lstvOrderlist.Columns[0].Width = (int)(lstvOrderlist.Width * 0.12);
            lstvOrderlist.Columns[1].Width = (int)(lstvOrderlist.Width * 0.25);
            lstvOrderlist.Columns[2].Width = (int)(lstvOrderlist.Width * 0.25);
            lstvOrderlist.Columns[3].Width = (int)(lstvOrderlist.Width * 0.25);
            lstvOrderlist.Columns[4].Width = (int)(lstvOrderlist.Width * 0.25);
            lstvOrderlist.Columns[5].Width = (int)(lstvOrderlist.Width * 0.25);
            lstvOrderlist.ColumnClick += new ColumnClickEventHandler(lstvOrderlist_ColumnClick);

        }
        //Thay đổi danh sách trong code này

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            // Xóa nội dung của các TextBox tìm kiếm
            txtRequiredCode.Text = "";
            txtCustomerName.Text = "";
            txtSDT.Text = "";
            txtMaYeuCau.Text = "";
            txtTenKhachHang.Text = "";
            txtSoDienThoai.Text = "";
            txtChiTietHoaDon.Text = "";
            lstvOrderlist.Items.Clear();

        }
        private void ReloadListView(List<Invoice> list)
        {
            lstvOrderlist.Items.Clear();

            // Nạp lại ListView với danh sách đã lọc
            DisplayInvoices(list);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keywordOrderCode = txtRequiredCode.Text.ToLower();
            string keywordNameTelephoneNumber = txtCustomerName.Text.ToLower();
            string keywordSDT = txtSDT.Text.ToLower();

            // Lọc danh sách yêu cầu dựa trên từ khóa từ mỗi TextBox
            List<Invoice> filteredList = new List<Invoice>();

            foreach (Invoice item in invoices)
            {
                bool matched = true;

                if (!string.IsNullOrEmpty(keywordOrderCode) && !item.Code.ToLower().Contains(keywordOrderCode))
                    matched = false;

                if (!string.IsNullOrEmpty(keywordNameTelephoneNumber) &&
                    (!item.CustomerName.ToLower().Contains(keywordNameTelephoneNumber.ToLower()) &&
                     !item.PhoneNumber.Contains(keywordNameTelephoneNumber)))
                    matched = false;

                if (!string.IsNullOrEmpty(keywordSDT) && !item.PhoneNumber.ToLower().Contains(keywordSDT))
                    matched = false;

                if (matched)
                    filteredList.Add(item);
            }
            currentDisplayedInvoices = filteredList;
            // Nạp lại ListView với danh sách đã lọc
            ReloadListView(filteredList);
        }

        private void btnNoProcess_Click(object sender, EventArgs e)
        {

            FilterUnprocessedInvoices();
        }

        private void btnProcessed_Click(object sender, EventArgs e)
        {

            FilterProcessedInvoices();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {

            FilterExchangeRequests();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

            FilterReturnRequests();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {

            ProcessSelectedInvoices();
        }
        private void FilterUnprocessedInvoices()
        {
            List<Invoice> unprocessedInvoices = new List<Invoice>();
            foreach (Invoice inv in invoices)
            {
                if (inv.Status == "Chưa xử lý")
                {
                    unprocessedInvoices.Add(inv);
                }
            }
            currentDisplayedInvoices = unprocessedInvoices; // Lưu danh sách hiện tại đang được hiển thị
            DisplayInvoices(unprocessedInvoices);
        }

        private void FilterProcessedInvoices()
        {
            List<Invoice> processedInvoices = new List<Invoice>();
            foreach (Invoice inv in invoices)
            {
                if (inv.Status == "Đã xử lý")
                {
                    processedInvoices.Add(inv);
                }
            }
            currentDisplayedInvoices = processedInvoices; // Lưu danh sách hiện tại đang được hiển thị
            DisplayInvoices(processedInvoices);
        }

        private void FilterExchangeRequests()
        {
            List<Invoice> exchangeInvoices = new List<Invoice>();
            foreach (Invoice inv in invoices)
            {
                if (inv.RequestDetail == "Đổi hàng")
                {
                    exchangeInvoices.Add(inv);
                }
            }
            currentDisplayedInvoices = exchangeInvoices; // Lưu danh sách hiện tại đang được hiển thị
            DisplayInvoices(exchangeInvoices);
        }

        private void FilterReturnRequests()
        {
            List<Invoice> returnInvoices = new List<Invoice>();
            foreach (Invoice inv in invoices)
            {
                if (inv.RequestDetail == "Trả hàng")
                {
                    returnInvoices.Add(inv);
                }
            }
            currentDisplayedInvoices = returnInvoices; // Lưu danh sách hiện tại đang được hiển thị
            DisplayInvoices(returnInvoices);
        }

        private void ProcessSelectedInvoices()
        {
            try
            {
                // Lặp qua tất cả các mục được chọn trong ListView
                foreach (ListViewItem item in lstvOrderlist.SelectedItems)
                {
                    // Lấy mã hóa đơn từ cột đầu tiên của mỗi mục
                    string invoiceCode = item.SubItems[0].Text;

                    // Tìm hóa đơn trong danh sách hóa đơn dựa trên mã hóa đơn
                    Invoice invoice = null;
                    foreach (Invoice inv in invoices)
                    {
                        if (inv.Code == invoiceCode)
                        {
                            invoice = inv;
                            break;
                        }
                    }
                    // Kiểm tra xem hóa đơn có tồn tại không và trạng thái của nó là "Chưa xử lý"
                    if (invoice != null && invoice.Status == "Chưa xử lý")
                    {
                        // Đánh dấu hóa đơn là đã xử lý
                        invoice.Status = "Đã xử lý";

                        // Cập nhật lại ListView để hiển thị trạng thái mới của hóa đơn
                        item.SubItems[5].Text = "Đã xử lý";
                    }
                    else if (invoice != null && invoice.Status == "Đã xử lý")
                    {
                        // Nếu hóa đơn đã được xử lý trước đó, hiển thị thông báo
                        MessageBox.Show("Hóa đơn này đã được xử lý trước đó.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ và hiển thị thông báo lỗi
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void lstvOrderlist_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Lấy ListView
            ListView lv = (ListView)sender;
            IComparer comparer;
            // Không thực hiện gì nếu không nhấp vào cột Mã yêu cầu hoặc Ngày yêu cầu
            if (e.Column != 0 && e.Column != 3)
                return;
            else
                comparer = new ListViewComparer(sortAscending);

            // Sắp xếp ListView bằng cách gán Comparer
            lv.ListViewItemSorter = comparer;

            // Đảo ngược hướng sắp xếp cho lần tiếp theo
            sortAscending = !sortAscending;

            // Sắp xếp lại ListView
            lv.Sort();
        }
        private void txtRequiredCode_Enter(object sender, EventArgs e)
        {
            if (txtRequiredCode.Text == "Nhập mã yêu cầu") txtRequiredCode.Text = "";
        }

        private void txtRequiredCode_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRequiredCode.Text))
            {
                txtRequiredCode.Text = "Nhập mã yêu cầu";
            }
        }
        private void txtCustomerName_Enter(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "Nhập tên khách hàng") txtCustomerName.Text = "";
        }

        private void txtCustomerName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                txtCustomerName.Text = "Nhập tên khách hàng";
            }
        }

        private void txtSDT_Enter(object sender, EventArgs e)
        {
            if (txtSDT.Text == "Nhập SĐT khách hàng") txtSDT.Text = "";
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                txtSDT.Text = "Nhập SĐT khách hàng";
            }
        }

        private void FilterRequestsByDateRange()
        {
            DateTime fromDate = dateTimePickerFrom.Value;
            DateTime toDate = dateTimePickerTo.Value;
            List<Invoice> filteredList = new List<Invoice>();

            foreach (Invoice invoice in invoices)
            {
                if (invoice.RequestDate >= fromDate && invoice.RequestDate <= toDate)
                {
                    filteredList.Add(invoice);
                }
            }

            // Nạp lại ListView với danh sách đã lọc theo khoảng ngày
            ReloadListView(filteredList);
        }

        private void dateTimePickerFrom_Enter(object sender, EventArgs e)
        {
            // Xoá văn bản rỗng khi DateTimePicker được nhấn vào
            if (dateTimePickerFrom.CustomFormat == " ")
            {
                dateTimePickerFrom.CustomFormat = "dd/MM/yyyy";
                dateTimePickerFrom.Value = DateTime.Now; // hoặc bạn có thể đặt giá trị mặc định khác ở đây
            }
        }

        private void dateTimePickerTo_Enter(object sender, EventArgs e)
        {
            // Xoá văn bản rỗng khi DateTimePicker được nhấn vào
            if (dateTimePickerTo.CustomFormat == " ")
            {
                dateTimePickerTo.CustomFormat = "dd/MM/yyyy";
                dateTimePickerTo.Value = DateTime.Now; // hoặc bạn có thể đặt giá trị mặc định khác ở đây
            }
        }

        private void dateTimePickerFrom_Leave(object sender, EventArgs e)
        {
            // Nếu không có giá trị được chọn, hiển thị văn bản mặc định lại
            if (dateTimePickerFrom.Value == DateTimePicker.MinimumDateTime)
            {
                dateTimePickerFrom.CustomFormat = " ";
            }
        }

        private void dateTimePickerTo_Leave(object sender, EventArgs e)
        {
            // Nếu không có giá trị được chọn, hiển thị văn bản mặc định lại
            if (dateTimePickerTo.Value == DateTimePicker.MinimumDateTime)
            {
                dateTimePickerTo.CustomFormat = " ";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveDataToFile();
        }

        private void SaveDataToFile()
        {
            try
            {
                string jsonData = JsonConvert.SerializeObject(invoices);
                File.WriteAllText("danhSachYeuCau.json", jsonData);
                MessageBox.Show("Dữ liệu đã được lưu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDataFromFile()
        {
            try
            {
                if (File.Exists("danhSachYeuCau.json"))
                {
                    string jsonData = File.ReadAllText("danhSachYeuCau.json");
                    invoices = JsonConvert.DeserializeObject<List<Invoice>>(jsonData);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tệp dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            FilterRequestsByDateRange();
        }

        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            FilterRequestsByDateRange();
        }

        public void DisplayInvoices(List<Invoice> invoiceList)
        {
            lstvOrderlist.Items.Clear();
            foreach (Invoice invoice in invoiceList)
            {
                ListViewItem item = new ListViewItem(invoice.Code);
                item.SubItems.Add(invoice.CustomerName);
                item.SubItems.Add(invoice.PhoneNumber);
                item.SubItems.Add(invoice.RequestDate.ToShortDateString());
                item.SubItems.Add(invoice.RequestDetail);
                item.SubItems.Add(invoice.Status);
                lstvOrderlist.Items.Add(item);
            }
        }

        // Class này cung cấp logic sắp xếp mặc định cho các cột không phải thời gian
        public class ListViewComparer : IComparer
        {
            private bool ascending;

            public ListViewComparer(bool ascending)
            {
                this.ascending = ascending;
            }

            public int Compare(object x, object y)
            {
                // Ép kiểu các đối tượng thành ListViewItem để có thể truy cập vào SubItems (các cột)
                ListViewItem itemX = (ListViewItem)x;
                ListViewItem itemY = (ListViewItem)y;

                // So sánh dựa trên dữ liệu văn bản của cột
                int result = string.Compare(itemX.SubItems[0].Text, itemY.SubItems[0].Text);
                if (!ascending)
                {
                    result = -result; // Đảo ngược kết quả nếu sắp xếp giảm dần
                }
                return result;
            }
        }

        public class Invoice
        {
            public string Code { get; set; }
            public string CustomerName { get; set; }
            public string PhoneNumber { get; set; }
            public DateTime RequestDate { get; set; }
            public string RequestDetail { get; set; }
            public string Status { get; set; }

            public Invoice(string code, string customerName, string phoneNumber, DateTime requestDate, string requestDetail, string status)
            {
                Code = code;
                CustomerName = customerName;
                PhoneNumber = phoneNumber;
                RequestDate = requestDate;
                RequestDetail = requestDetail;
                Status = status;
            }
        }
        public interface IInvoiceManager
        {
            // Phương thức thêm hóa đơn
            void AddInvoice(Invoice newInvoice);

            // Phương thức sửa thông tin hóa đơn
            void EditInvoice(string code, string customerName, string phoneNumber, DateTime requestDate, string requestDetail);


            // Phương thức xóa hóa đơn
            void DeleteInvoice(string invoiceCode);
        }

        // Lớp quản lý hóa đơn triển khai giao diện IInvoiceManager
        public class InvoiceManager : IInvoiceManager
        {
            private Return_Management_Form returnForm;
            private List<Invoice> invoices;

            // Constructor của InvoiceManager
            public InvoiceManager(Return_Management_Form form, List<Invoice> invoiceList)
            {
                returnForm = form;
                invoices = invoiceList;
            }

            // Phương thức thêm hóa đơn và nạp lại danh sách
            public void AddInvoice(Invoice newInvoice)
            {
                invoices.Add(newInvoice);
                ReloadInvoices();
            }

            // Phương thức sửa thông tin hóa đơn và nạp lại danh sách
            public void EditInvoice(string code, string customerName, string phoneNumber, DateTime requestDate, string requestDetail)
            {
                // Tìm và sửa hóa đơn trong danh sách
                foreach (Invoice invoice in invoices)
                {
                    if (invoice.Code == code)
                    {
                        invoice.CustomerName = customerName;
                        invoice.PhoneNumber = phoneNumber;
                        invoice.RequestDate = requestDate;
                        invoice.RequestDetail = requestDetail;
                        break;
                    }
                }

                // Nạp lại danh sách hóa đơn sau khi sửa
                ReloadInvoices();
            }

            // Phương thức xóa hóa đơn và nạp lại danh sách
            public void DeleteInvoice(string invoiceCode)
            {
                int indexToRemove = -1;
                for (int i = 0; i < invoices.Count; i++)
                {
                    if (invoices[i].Code == invoiceCode)
                    {
                        indexToRemove = i;
                        break;
                    }
                }

                // Kiểm tra xem hóa đơn cần xóa có tồn tại trong danh sách không
                if (indexToRemove != -1)
                {
                    // Xóa hóa đơn khỏi danh sách
                    invoices.RemoveAt(indexToRemove);

                    // Nạp lại danh sách hóa đơn sau khi xóa
                    ReloadInvoices();
                }
            }

            // Phương thức nạp lại danh sách hóa đơn
            private void ReloadInvoices()
            {
                returnForm.DisplayInvoices(invoices);
            }

            // Phương thức lấy tất cả hóa đơn
            public List<Invoice> GetAllInvoices()
            {
                return invoices;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem các trường đã được điền đầy đủ chưa
            if (string.IsNullOrEmpty(txtMaYeuCau.Text) || string.IsNullOrEmpty(txtTenKhachHang.Text) || string.IsNullOrEmpty(txtSoDienThoai.Text) || string.IsNullOrEmpty(txtChiTietHoaDon.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // Kiểm tra xem invoiceManager đã được khởi tạo chưa
            else if (invoiceManager != null)
            {
                // Kiểm tra xem hóa đơn đã tồn tại trong ListView hay không
                bool daTonTai = false;
                foreach (ListViewItem item in lstvOrderlist.Items)
                {
                    if (item.SubItems[0].Text == txtMaYeuCau.Text)
                    {
                        daTonTai = true;
                        break;
                    }
                }

                if (daTonTai)
                {
                    MessageBox.Show("Yêu cầu đã tồn tại trong danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Tạo một đối tượng Invoice từ thông tin nhập vào từ giao diện
                    Invoice newInvoice = new Invoice(
                        txtMaYeuCau.Text,
                        txtTenKhachHang.Text,
                        txtSoDienThoai.Text,
                        dateTimePicker1.Value,
                        txtChiTietHoaDon.Text,
                        "Chưa xử lý" // Đặt trạng thái mặc định là "Chưa xử lý"
                    );

                    // Gọi phương thức AddInvoice từ InvoiceManager để thêm hóa đơn mới
                    invoiceManager.AddInvoice(newInvoice);
                }
            }
            else
            {
                MessageBox.Show("Lỗi: InvoiceManager chưa được khởi tạo.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sửa hóa đơn

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có ít nhất một mục đã được chọn trong danh sách hiển thị
            if (lstvOrderlist.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy chỉ mục của mục được chọn trong danh sách hiển thị được lọc
            int selectedIndex = lstvOrderlist.SelectedIndices[0];

            // Kiểm tra xem danh sách hiển thị hiện tại có ít nhất một mục không
            if (currentDisplayedInvoices.Count == 0 || selectedIndex >= currentDisplayedInvoices.Count)
            {
                MessageBox.Show("Không thể tìm thấy hóa đơn trong danh sách hiển thị.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy hóa đơn tương ứng với chỉ mục đã chọn trong danh sách hiển thị được lọc
            Invoice selectedInvoice = currentDisplayedInvoices[selectedIndex];

            // Tìm hóa đơn trong danh sách gốc để cập nhật
            int indexInOriginalList = -1;
            for (int i = 0; i < invoices.Count; i++)
            {
                if (invoices[i].Code == selectedInvoice.Code)
                {
                    indexInOriginalList = i;
                    break;
                }
            }

            if (indexInOriginalList != -1)
            {
                // Cập nhật thông tin của hóa đơn trong danh sách gốc
                invoices[indexInOriginalList].CustomerName = txtTenKhachHang.Text;
                invoices[indexInOriginalList].PhoneNumber = txtSoDienThoai.Text;
                invoices[indexInOriginalList].RequestDate = dateTimePicker1.Value;
                invoices[indexInOriginalList].RequestDetail = txtChiTietHoaDon.Text;

                // Cập nhật lại ListView
                DisplayInvoices(currentDisplayedInvoices);
                // Xóa nội dung các TextBox sau khi sửa
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Không thể tìm thấy hóa đơn trong danh sách gốc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có mục nào được chọn không
            if (lstvOrderlist.SelectedItems.Count > 0)
            {
                // Lấy chỉ mục của mục được chọn
                int selectedIndex = lstvOrderlist.SelectedIndices[0];
                // Lấy hóa đơn tương ứng với chỉ mục đã chọn
                Invoice selectedInvoice = invoices[selectedIndex];

                // Gọi phương thức DeleteInvoice từ InvoiceManager để xóa hóa đơn
                invoiceManager.DeleteInvoice(selectedInvoice.Code);

                // Cập nhật lại ListView
                DisplayInvoices(invoices);
                // Xóa nội dung các TextBox sau khi xóa
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void ClearTextBoxes()
        {
            // Sau khi thêm, làm sạch các trường nhập liệu
            txtMaYeuCau.Text = "";
            txtTenKhachHang.Text = "";
            txtSoDienThoai.Text = "";
            dateTimePicker1.CustomFormat = "";
            txtChiTietHoaDon.Text = "";
        }

        private void lstvOrderlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvOrderlist.SelectedItems.Count > 0)
            {
                int selectedIndex = lstvOrderlist.SelectedIndices[0];

                // Kiểm tra xem chỉ mục được chọn có hợp lệ không
                if (selectedIndex >= 0 && selectedIndex < currentDisplayedInvoices.Count)
                {
                    Invoice selectedInvoice = currentDisplayedInvoices[selectedIndex];
                    txtMaYeuCau.Text = selectedInvoice.Code;
                    txtTenKhachHang.Text = selectedInvoice.CustomerName;
                    txtSoDienThoai.Text = selectedInvoice.PhoneNumber;
                    dateTimePicker1.Value = selectedInvoice.RequestDate;
                    txtChiTietHoaDon.Text = selectedInvoice.RequestDetail;
                }

            }
        }


        private void btnUpLoad_Click(object sender, EventArgs e)
        {
            LoadDataFromFile();
        }
    }
}
