📚 *README: Chương Trình Quản Lý Bán Hàng Siêu Thị*

---

✨ **Giới Thiệu**

Dự án này là một Chương Trình Quản Lý Bán Hàng Siêu Thị được phát triển bằng ngôn ngữ lập trình C# sử dụng giao diện Winform. Trong bối cảnh thị trường bán lẻ và thương mại điện tử ngày càng cạnh tranh, việc áp dụng CNTT để tối ưu hóa quy trình quản lý là rất cần thiết. Chương trình này ra đời nhằm giải quyết các thách thức trong việc quản lý hàng tồn kho, đơn hàng, khách hàng, nhân viên và các nghiệp vụ bán hàng khác tại siêu thị, từ đó nâng cao hiệu quả vận hành và trải nghiệm khách hàng.

---

🎯 **Mục Tiêu**

* Áp dụng kiến thức về Lập trình Hướng Đối Tượng (OOP) vào thực tế.
* Xây dựng hệ thống quản lý bán hàng cơ bản.
* Nâng cao kỹ năng lập trình C# và thiết kế giao diện Winform.

---

🔑 **Các Nguyên Lý Lập Trình Hướng Đối Tượng (OOP) Áp Dụng**

* **Tính Đóng Gói (Encapsulation)** 📦: Dữ liệu và phương thức được gói gọn trong các lớp như `Supplier`, `Customer`, `Product`... Việc truy cập được kiểm soát qua getter/setter.
* **Tính Kế Thừa (Inheritance)** 🧬: Các lớp con kế thừa từ lớp cha, ví dụ: `MayAsus` kế thừa từ `MayViTinh`, `Admin`, `ThuNgan`, `BaoVe` kế thừa từ `IEmployee`.
* **Tính Đa Hình (Polymorphism)** 🎭: Áp dụng nạp chồng và ghi đè phương thức, ví dụ như `TinhDienTich()` trong các lớp kế thừa từ lớp trừu tượng `Hinh`.
* **Tính Trừu Tượng (Abstraction)** 👻: Sử dụng các lớp trừu tượng và interface như `ILogin`, `ISignUp`, `ICustomer`, `IOrder`, `IInvoiceManager`, v.v.

---

🛠️ **Công Nghệ Sử Dụng**

* Ngôn ngữ: C#
* Framework: .NET Framework (Winform)
* Lưu trữ: File (JSON, TXT)

---

🏗️ **Cấu Trúc Dự Án và Thiết Kế Lớp**

Dự án được chia thành các Form và User Control theo từng chức năng. Các lớp chính bao gồm:

* **Quản lý người dùng**: `Login_Code`, `SignUp_Code`, `Admin`, `ThuNgan`, `BaoVe`, `IEmployee`
* **Quản lý kho và sản phẩm**: `Product`, `Inventory`, `Supplier`, `IControlInventory`, `IControlProduct`, `IControlSupplier`
* **Quản lý bán hàng**: `Customer`, `Order`, `ICustomer`, `IOrder`
* **Nghiệp vụ khác**: `Invoice`, `SupportRequest`, `Promotion`, `IInvoiceManager`, `ISupportService`, `IInvoiceManagement`

**Giao diện/Chức năng chính**:

* Đăng nhập/Đăng ký (Form1, Form2)
* Trang chức năng theo phân quyền (Form2\_UCx)
* Đổi mật khẩu, lịch sử đăng nhập, báo cáo vấn đề
* Quản lý xuất - nhập hàng, nhân viên, khách hàng, đơn hàng, đổi trả, dịch vụ hỗ trợ, khuyến mãi

---

🚀 **Các Chức Năng Chính**

**🛡️ Bảo Vệ**

* Đổi mật khẩu
* Xem lịch sử đăng nhập
* Báo cáo vấn đề

**💰 Thu Ngân** (bao gồm chức năng của Bảo Vệ)

* Báo cáo doanh thu
* Xuất hàng

**👑 Admin** (bao gồm chức năng của Bảo Vệ và Thu Ngân)

* Nhập hàng
* Quản lý nhân viên, khách hàng, đơn hàng, đổi trả
* Quản lý dịch vụ hỗ trợ, khuyến mãi

---

📦 **Hướng Dẫn Cài Đặt và Chạy Ứng Dụng**

1. **Clone Repository:**

```bash
git clone https://github.com/thanhlamcode/Do-an-OOP.git
```

2. **Mở bằng Visual Studio**: Mở file `.sln` trong thư mục dự án.
3. **Build Project**: `Build` -> `Build Solution`
4. **Chạy chương trình**: `Debug` -> `Start Debugging` hoặc nhấn `F5`

---

🚧 **Tồn Tại và Hướng Phát Triển**

❌ **Tồn Tại**

* Dữ liệu giữa các form chưa được kết nối hoàn chỉnh.
* Chưa có chức năng đánh giá chất lượng dịch vụ.
* Chưa áp dụng khuyến mãi khi mua hàng.
* Chưa có giao diện cho khách hàng.

🌱 **Hướng Phát Triển**

* Đồng bộ dữ liệu giữa các chức năng.
* Thêm chức năng đánh giá dịch vụ.
* Tích hợp tính năng khuyến mãi.
* Phát triển giao diện dành cho khách hàng.
* Nghiên cứu tính năng từ Shopee, Lazada, Tiki để nâng cao trải nghiệm người dùng.

---

👥 **Thành Viên Dự Án**

* Đoàn Thanh Lâm
* Dương Lâm Gia Kiệt
* Nguyễn Hoàng Minh Tấn
* Phạm Trung
