# Hệ Thống Quản Lý Cửa Hàng Giày
## Danh Sách Thành Viên Nhóm

| STT | Mã Sinh Viên | Họ Tên          | Lớp          | Vai Trò      |
| --- | ------------ | --------------- | ------------ | ------------ |
| 1   | 2001216333     | Lê Thanh Yên    | 12DHTH03    | Nhóm trưởng |
| 2   | 2001216074     | Hoàng Đức Quân      | 12DHTH02    | Thành viên |


## Mục Lục
1. [Giới Thiệu](#giới-thiệu)
2. [Chức Năng Chính](#chức-năng-chính)
    - [Quản Lý Khách Hàng](#quản-lý-khách-hàng)
    - [Quản Lý Nhân Viên](#quản-lý-nhân-viên)
    - [Quản Lý Hàng Tồn Kho](#quản-lý-hàng-tồn-kho)
    - [Quản Lý Doanh Số Bán Hàng](#quản-lý-doanh-số-bán-hàng)
    - [Quản Lý Nhà Cung Cấp](#quản-lý-nhà-cung-cấp)
    - [Báo Cáo Và Phân Tích](#báo-cáo-và-phân-tích)
    - [Tích Hợp Hệ Thống](#tích-hợp-hệ-thống)
3. [Cài Đặt](#cài-đặt)
4. [Sử Dụng](#sử-dụng)
5. [Báo Cáo](#báo-cáo)
6. [Liên Hệ](#liên-hệ)

## Giới Thiệu
Hệ thống quản lý cửa hàng giày là một ứng dụng quản lý toàn diện giúp theo dõi thông tin khách hàng, nhân viên, hàng tồn kho, doanh số bán hàng, và nhà cung cấp. Hệ thống được phát triển nhằm tối ưu hóa quá trình quản lý và đưa ra phân tích dữ liệu hiệu quả.

## Chức Năng Chính

### Quản Lý Khách Hàng
- Thêm, xoá, sửa thông tin khách hàng.
- Xem lịch sử mua hàng chi tiết.
- Phân loại khách hàng theo mức độ ưu tiên: VIP, tiềm năng, thân thiết, mới.
- Tự động chăm sóc khách hàng với các chương trình khuyến mãi và ưu đãi.

### Quản Lý Nhân Viên
- Quản lý thông tin cá nhân, lịch làm việc, và mức lương của nhân viên.
- Đánh giá hiệu suất dựa trên doanh số bán hàng và các chỉ số công việc.
- Tự động hoá việc xếp lịch làm việc cho nhân viên.

### Quản Lý Hàng Tồn Kho
- Theo dõi trạng thái hàng hoá (còn hàng/hết hàng), số lượng, kích cỡ, và màu sắc.
- Hỗ trợ kiểm kê kho định kỳ và cập nhật số liệu tồn kho.
- Cảnh báo khi hàng tồn kho sắp hết.

### Quản Lý Doanh Số Bán Hàng
- Quản lý giao dịch bán hàng, tính toán doanh thu theo từng khoảng thời gian.
- Cung cấp báo cáo doanh số bán hàng chi tiết và biểu đồ phân tích doanh số.

### Quản Lý Nhà Cung Cấp
- Lưu trữ và quản lý thông tin nhà cung cấp: tên, địa chỉ, sản phẩm cung cấp.
- Quản lý các giao dịch nhập hàng và theo dõi lịch sử giao dịch.
- Đánh giá hiệu suất của nhà cung cấp dựa trên giao hàng và chất lượng sản phẩm.

### Báo Cáo Và Phân Tích
- Tạo báo cáo tổng hợp về tình hình kinh doanh, bao gồm báo cáo tài chính, hàng tồn kho, và nhân sự.
- Xuất báo cáo ra các định dạng như Excel, PDF, hoặc in ấn trực tiếp.

### Tích Hợp Hệ Thống
- Kết nối với website bán hàng thông qua API, đồng bộ hóa dữ liệu khách hàng, đơn hàng và hàng tồn kho.

## Cài Đặt
### Yêu Cầu Hệ Thống
- .NET Framework 4.8 trở lên
- SQL Server 2019
- Windows 10 hoặc phiên bản cao hơn

### Các Bước Cài Đặt
1. Clone repo từ GitHub:
    ```bash
   [https://github.com/QuanLyBanGiay/PhanMenQuanLyBanGiay.git](https://github.com/QuanLyBanGiay/PhanMenQuanLyBanGiay.git)
    ```
2. Mở dự án trong Visual Studio.
3. Thiết lập chuỗi kết nối đến SQL Server trong file `appsettings.json`.
4. Khởi tạo cơ sở dữ liệu:
    ```bash
    Update-Database
    ```
5. Chạy dự án trên Visual Studio.

## Sử Dụng
1. Đăng nhập vào hệ thống với tài khoản quản trị viên.
2. Truy cập vào từng mục trong hệ thống để quản lý thông tin khách hàng, nhân viên, hàng tồn kho, doanh số và nhà cung cấp.
3. Sử dụng chức năng báo cáo để xem chi tiết tình hình kinh doanh và đưa ra phân tích.
4. Kết nối với website bán hàng để đồng bộ hóa dữ liệu.

## Báo Cáo
- Các báo cáo về doanh thu, tồn kho, và hiệu suất nhân viên có thể được xuất ra file PDF hoặc Excel.
- Biểu đồ phân tích xu hướng bán hàng và hiệu suất có thể xem trực tiếp trên dashboard của ứng dụng.

## Liên Hệ
- **Email:**
- **Phone:**
- **GitHub:**

