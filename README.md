# Đề tài: Hệ thống quản lý cửa hàng giày

## Thành viên nhóm:
| STT | Tên thành viên   | Chức vụ      |
|-----|------------------|--------------|
| 1   | Lê Thanh Yên     | Nhóm trưởng  |
| 2   | Hoàng Đức Quân   | Thành viên   |

## Giới thiệu đề tài

Hệ thống quản lý cửa hàng giày là một giải pháp phần mềm tích hợp giúp quản lý toàn bộ quy trình hoạt động của cửa hàng giày. Mục tiêu của hệ thống là tối ưu hóa việc quản lý sản phẩm, đơn hàng, khách hàng, và báo cáo doanh thu, từ đó nâng cao hiệu quả hoạt động và phục vụ khách hàng tốt hơn.

Hệ thống bao gồm hai phần chính:

1. **Phần mềm quản lý cửa hàng (WinForms):** Đây là phần mềm dành cho nhân viên quản lý cửa hàng, giúp quản lý các chức năng như nhập hàng, quản lý kho, xử lý đơn hàng, và báo cáo doanh thu. Phần mềm này được phát triển trên nền tảng WinForms, cung cấp giao diện dễ sử dụng và khả năng tương tác trực tiếp với cơ sở dữ liệu.

2. **Website bán hàng trực tuyến:** Đây là nền tảng cho phép khách hàng duyệt sản phẩm, đặt hàng và thanh toán trực tuyến. Website cũng cung cấp các tính năng quản lý đơn hàng và báo cáo doanh thu cho quản lý cửa hàng. Phần này được phát triển với công nghệ web hiện đại, đảm bảo khả năng tương thích trên nhiều thiết bị và trình duyệt.

Hệ thống giúp cửa hàng giày duy trì quy trình hoạt động hiệu quả, quản lý hàng tồn kho chính xác, xử lý đơn hàng nhanh chóng, và cung cấp dịch vụ khách hàng tốt hơn. Với giao diện người dùng thân thiện và các chức năng quản lý toàn diện, hệ thống này là công cụ hỗ trợ đắc lực cho mọi cửa hàng giày.


## Công nghệ sử dụng

Hệ thống quản lý cửa hàng giày của chúng tôi được xây dựng trên nền tảng của các công nghệ hiện đại để đảm bảo hiệu quả hoạt động và trải nghiệm người dùng tối ưu. Các công nghệ chính được sử dụng trong dự án bao gồm:

1. **WinForms:** Được sử dụng để phát triển phần mềm quản lý cửa hàng giày dành cho nhân viên. WinForms cung cấp giao diện người dùng thân thiện và khả năng tích hợp mạnh mẽ với cơ sở dữ liệu, giúp quản lý các chức năng như nhập hàng, quản lý kho, xử lý đơn hàng, và báo cáo doanh thu.

2. **SQL Server:** Được sử dụng làm hệ quản trị cơ sở dữ liệu cho hệ thống. SQL Server cung cấp khả năng lưu trữ và quản lý dữ liệu hiệu quả, bảo mật, và hỗ trợ các truy vấn phức tạp, giúp đảm bảo tính toàn vẹn và sẵn sàng của dữ liệu trong hệ thống.

3. **ASP.NET MVC:** Được sử dụng để phát triển website bán hàng trực tuyến. ASP.NET MVC cung cấp cấu trúc mô hình-view-controller mạnh mẽ, giúp xây dựng các ứng dụng web dễ bảo trì, mở rộng, và có khả năng tương tác tốt với người dùng. Phần website cho phép khách hàng duyệt sản phẩm, đặt hàng và thanh toán trực tuyến, đồng thời hỗ trợ quản lý đơn hàng và báo cáo doanh thu cho quản lý cửa hàng.

Các công nghệ này kết hợp với nhau để cung cấp một giải pháp quản lý cửa hàng giày toàn diện, từ việc quản lý nội bộ đến cung cấp dịch vụ bán hàng trực tuyến cho khách hàng.


## Danh sách chức năng Winform

### Phân công công việc
| STT | Tên thành viên   | Công việc                                     |
|-----|------------------|-----------------------------------------------|
| 1   | Lê Thanh Yên     | **Quản lý khách hàng**                       |
| 1.1 | Lê Thanh Yên     | Quản lý thông tin khách hàng                 |
| 1.2 | Lê Thanh Yên     | Xem lịch sử mua hàng                         |
| 1.3 | Lê Thanh Yên     | Phân loại khách hàng                         |
| 1.4 | Lê Thanh Yên     | Chăm sóc khách hàng                          |
| 2   | Hoàng Đức Quân   | **Quản lý nhân viên**                        |
| 2.1 | Hoàng Đức Quân   | Quản lý thông tin nhân viên                  |
| 2.2 | Hoàng Đức Quân   | Quản lý lịch làm việc                        |
| 2.3 | Hoàng Đức Quân   | Quản lý lương                                 |
| 2.4 | Hoàng Đức Quân   | Đánh giá hiệu suất làm việc                  |
| 3   | Lê Thanh Yên     | **Quản lý hàng tồn kho**                     |
| 3.1 | Lê Thanh Yên     | Quản lý nhập/xuất hàng                       |
| 3.2 | Lê Thanh Yên     | Theo dõi và kiểm kê kho                      |
| 3.3 | Lê Thanh Yên     | Quản lý trạng thái hàng hóa                  |
| 4   | Hoàng Đức Quân   | **Quản lý doanh số bán hàng**                |
| 4.1 | Hoàng Đức Quân   | Xử lý giao dịch bán hàng                     |
| 4.2 | Hoàng Đức Quân   | Tính toán và báo cáo doanh thu               |
| 4.3 | Hoàng Đức Quân   | Phân tích doanh số                           |
| 5   | Lê Thanh Yên     | **Quản lý nhà cung cấp**                     |
| 5.1 | Lê Thanh Yên     | Quản lý thông tin nhà cung cấp               |
| 5.2 | Lê Thanh Yên     | Quản lý giao dịch nhập hàng                  |
| 5.3 | Lê Thanh Yên     | Đánh giá nhà cung cấp                        |
| 6   | Hoàng Đức Quân   | **Báo cáo và phân tích**                     |
| 6.1 | Hoàng Đức Quân   | Tạo báo cáo tổng hợp                         |
| 6.2 | Hoàng Đức Quân   | Phân tích dữ liệu kinh doanh                 |
| 7   | Lê Thanh Yên     | **Tích hợp hệ thống khác**                   |
| 7.1 | Lê Thanh Yên     | Kết nối với website bán hàng                 |


## Danh sách chức năng Website

### Phân công công việc
| STT | Tên thành viên   | Công việc                                    |
|-----|------------------|----------------------------------------------|
| 1   | Lê Thanh Yên     | **Trang chủ**                                |
| 1.1 | Lê Thanh Yên     | Hiển thị sản phẩm nổi bật, khuyến mãi        |
| 1.2 | Lê Thanh Yên     | Cung cấp thanh tìm kiếm sản phẩm             |
| 2   | Hoàng Đức Quân   | **Quản lý sản phẩm**                         |
| 2.1 | Hoàng Đức Quân   | Xem chi tiết sản phẩm                        |
| 2.2 | Hoàng Đức Quân   | Bộ lọc sản phẩm                              |
| 2.3 | Hoàng Đức Quân   | Thêm sản phẩm vào giỏ hàng                   |
| 3   | Lê Thanh Yên     | **Giỏ hàng**                                 |
| 3.1 | Lê Thanh Yên     | Xem và chỉnh sửa giỏ hàng                   |
| 3.2 | Lê Thanh Yên     | Tính toán tổng tiền                          |
| 4   | Hoàng Đức Quân   | **Thanh toán**                               |
| 4.1 | Hoàng Đức Quân   | Chọn phương thức thanh toán                  |
| 4.2 | Hoàng Đức Quân   | Nhập địa chỉ giao hàng                       |
| 4.3 | Hoàng Đức Quân   | Xác nhận đơn hàng                            |
| 5   | Lê Thanh Yên     | **Quản lý tài khoản khách hàng**             |
| 5.1 | Lê Thanh Yên     | Đăng ký/Đăng nhập                            |
| 5.2 | Lê Thanh Yên     | Quên mật khẩu                                |
| 5.3 | Lê Thanh Yên     | Quản lý thông tin cá nhân                    |
| 5.4 | Lê Thanh Yên     | Xem lịch sử mua hàng                         |
| 6   | Hoàng Đức Quân   | **Quản lý đơn hàng**                         |
| 6.1 | Hoàng Đức Quân   | Theo dõi trạng thái đơn hàng                 |
| 6.2 | Hoàng Đức Quân   | Hủy hoặc thay đổi đơn hàng                   |
| 7   | Lê Thanh Yên     | **Hỗ trợ khách hàng**                        |
| 7.1 | Lê Thanh Yên     | Liên hệ và giải quyết hỗ trợ                 |
| 7.2 | Lê Thanh Yên     | Câu hỏi thường gặp (FAQ)                     |

## AI sử dụng: Nhận dạng hình ảnh sản phẩm (Product Image Recognition)
