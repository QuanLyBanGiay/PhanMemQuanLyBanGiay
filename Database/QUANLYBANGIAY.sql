USE master
GO
CREATE DATABASE QUANLYBANGIAY
GO
USE QUANLYBANGIAY
GO

CREATE TABLE LOAIKHACHHANG
(
    MaLoaiKH INT IDENTITY(1,1) PRIMARY KEY,
    TenLoaiKH NVARCHAR(225) NOT NULL
)
GO

CREATE TABLE KHACHHANG
(
	MaKH INT IDENTITY(1,1),
	TongChiTieu FLOAT,
	HoTen NVARCHAR(225) NOT NULL,
	GioiTinh NVARCHAR(225) DEFAULT 'Nam',
	DiaChi NVARCHAR(225) DEFAULT N'Thành phố HCM',
	Email NVARCHAR(225),
	DienThoai NVARCHAR(225),
	PRIMARY KEY(MaKH)
)
GO

ALTER TABLE KHACHHANG
ADD MaLoaiKH INT;

ALTER TABLE KHACHHANG
ADD FOREIGN KEY (MaLoaiKH) REFERENCES LOAIKHACHHANG(MaLoaiKH);
GO


CREATE TABLE KHUYENMAI
(
    MaKM INT IDENTITY(1, 1) PRIMARY KEY,
    NgayBD DATE,
    NgayKT DATE,
    TenCT NVARCHAR(225),
    LoaiCT NVARCHAR(225),
    DieuKien NVARCHAR(225),
    CHECK (NgayBD < NgayKT)
)
GO

CREATE TABLE NHACUNGCAP
(
	MaNCC int identity(1, 1) primary key,
	TenNCC nvarchar(225),
	DiaChi nvarchar(225),
	DienThoai nvarchar(225),
	Email nvarchar(225)
)
GO

CREATE TABLE MAUSAC
(
	MaMau int identity(1,1) primary key,
	TenMau nvarchar(225)
)
GO

CREATE TABLE THUONGHIEU
(
	MaTH int identity(1,1) primary key,
	TenTH nvarchar(225),
	DiaChi nvarchar(225),
	Email nvarchar(225),
)
GO

CREATE TABLE XUATXU
(
	MaXX int identity(1,1) primary key,
	TenNuoc nvarchar(225)
)
GO

CREATE TABLE LOAI
(
	MaLoai int identity(1,1) primary key,
	TenLoai nvarchar(225)
)
GO

CREATE TABLE NHANVIEN
(
	MaNV int identity(1,1) primary key,
	ChucVu nvarchar(225),
	HoTen nvarchar(225),
	GioiTinh nvarchar(225),
	DiaChi nvarchar(225),
	DienThoai nvarchar(225),
	Email nvarchar(225),
	Luong float
)
GO

CREATE TABLE PHANQUYEN
(
    MaQuyen INT IDENTITY(1,1) PRIMARY KEY,
    TenQuyen NVARCHAR(225) NOT NULL
)
GO

CREATE TABLE NHANVIEN_QUYEN
(
    MaNV INT,
    MaQuyen INT,
    PRIMARY KEY (MaNV, MaQuyen),
    FOREIGN KEY (MaNV) REFERENCES NHANVIEN(MaNV),
    FOREIGN KEY (MaQuyen) REFERENCES PHANQUYEN(MaQuyen)
)
GO

CREATE TABLE TAIKHOANNV
(
	MaNV int primary key,
	TenDN nvarchar(225),
	MatKhau nvarchar(225),
	DaKhoa BIT DEFAULT 0,
	foreign key (MaNV) references NHANVIEN(MaNV)
)
GO

CREATE TABLE PHIEUNHAP
(
	MaPN int identity(1,1) primary key,
	NgayNhap date,
	TongTien float,
	MaNCC int,
	MaNV int,
	foreign key (MaNCC) references NHACUNGCAP(MaNCC),
	foreign key (MaNV) references NHANVIEN(MaNV)
)
GO

CREATE TABLE HOADON
(
	MaHD int identity(1,1) primary key,
	NgayBan date,
	TongTien float,
	Thue float,
	MaKH int,
	MaNV int,
	MaKM int,
	foreign key (MaKH) references KHACHHANG(MaKH),
	foreign key (MaNV) references NHANVIEN(MaNV),
	foreign key (MaKM) references KHUYENMAI(MaKM)
)
GO

CREATE TABLE GIAY
(
	MaGiay int identity primary key,
	TenGiay nvarchar(225),
	SoLuong int,
	DonGia float,
	Size nvarchar(225),
	DoiTuongSD nvarchar(225),
	ChatLieu nvarchar(225),
	MaLoai int,
	MaXX int,
	MaMau int,
	MaTH int,
	foreign key (MaLoai) references LOAI(MaLoai),
	foreign key (MaXX) references XUATXU(MaXX),
	foreign key (MaMau) references MAUSAC(MaMau),
	foreign key (MaTH) references THUONGHIEU(MaTH)
)
GO

CREATE TABLE KIEMKE
(
    MaKK INT IDENTITY(1,1) PRIMARY KEY,
    NgayKiemKe DATE,
    MaGiay INT,
    SoLuongThucTe INT,
    FOREIGN KEY (MaGiay) REFERENCES GIAY(MaGiay)
)
GO

CREATE TABLE CHITIETKM
(
	MaKM int,
	MaGiay int,
	TiLeKM float,
	primary key(MaKM, MaGiay),
	foreign key (MaKM) references KHUYENMAI(MaKM),
	foreign key (MaGiay) references GIAY(MaGiay)
)
GO

CREATE TABLE CHITIETHD
(
	MaHD int,
	MaGiay int,
	SoLuong int,
	GiaBan float,
	primary key(MaHD, MaGiay),
	foreign key (MaHD) references HOADON(MaHD),
	foreign key (MaGiay) references GIAY(MaGiay)
)
GO

CREATE TABLE CHITIETPN
(
	MaPN int,
	MaGiay int,
	SoLuong int,
	GiaNhap float,
	primary key (MaPN, MaGiay),
	foreign key (MaPN) references PHIEUNHAP(MaPN),
	foreign key (MaGiay) references GIAY(MaGiay)
)
GO

CREATE TRIGGER trg_UpdateTongTienHD
ON CHITIETHD
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @MaHD INT;
    
    -- Trường hợp insert hoặc update
    IF EXISTS (SELECT * FROM inserted)
    BEGIN
        -- Lấy mã hóa đơn từ bảng inserted
        SELECT TOP 1 @MaHD = MaHD FROM inserted;
    END

    -- Trường hợp delete
    IF EXISTS (SELECT * FROM deleted)
    BEGIN
        -- Lấy mã hóa đơn từ bảng deleted
        SELECT TOP 1 @MaHD = MaHD FROM deleted;
    END

    -- Cập nhật tổng tiền cho hóa đơn dựa trên chi tiết hóa đơn và khuyến mãi
    UPDATE HOADON
    SET TongTien = (
        SELECT SUM(
                CHITIETHD.SoLuong * CHITIETHD.GiaBan *
                (1 - ISNULL(CHITIETKM.TiLeKM, 0)) -- Áp dụng khuyến mãi nếu có
            )
        FROM CHITIETHD
        LEFT JOIN CHITIETKM ON CHITIETHD.MaGiay = CHITIETKM.MaGiay
                             AND CHITIETKM.MaKM = (SELECT MaKM FROM HOADON WHERE HOADON.MaHD = @MaHD)
        WHERE CHITIETHD.MaHD = @MaHD
    )
    WHERE HOADON.MaHD = @MaHD;
END;
GO

CREATE TRIGGER trg_UpdateTongTienHD_MaKM
ON HOADON
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Chỉ cập nhật nếu cột MaKM thay đổi
    IF UPDATE(MaKM)
    BEGIN
        DECLARE @MaHD INT;

        -- Lấy mã hóa đơn từ bảng updated
        SELECT @MaHD = inserted.MaHD
        FROM inserted;

        -- Cập nhật tổng tiền cho hóa đơn dựa trên chi tiết hóa đơn và khuyến mãi
        UPDATE HOADON
        SET TongTien = (
            SELECT SUM(
                    CHITIETHD.SoLuong * CHITIETHD.GiaBan *
                    (1 - ISNULL(CHITIETKM.TiLeKM, 0)) -- Áp dụng khuyến mãi nếu có
                )
            FROM CHITIETHD
            LEFT JOIN CHITIETKM ON CHITIETHD.MaGiay = CHITIETKM.MaGiay
                                 AND CHITIETKM.MaKM = HOADON.MaKM -- Áp dụng khuyến mãi của hóa đơn
            WHERE CHITIETHD.MaHD = @MaHD
        )
        WHERE HOADON.MaHD = @MaHD;
    END
END;
GO

CREATE TRIGGER trg_UpdateTongChiTieu
ON HOADON
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @MaKH INT;

    IF EXISTS (SELECT * FROM inserted)
    BEGIN
        SELECT TOP 1 @MaKH = MaKH FROM inserted;
    END

    IF EXISTS (SELECT * FROM deleted)
    BEGIN
        SELECT TOP 1 @MaKH = MaKH FROM deleted;
    END
    UPDATE KHACHHANG
    SET TongChiTieu = (
        SELECT SUM(TongTien) 
        FROM HOADON
        WHERE MaKH = @MaKH
    )
    WHERE KHACHHANG.MaKH = @MaKH;
END;
GO


INSERT INTO LOAIKHACHHANG (TenLoaiKH) VALUES ('VIP');
INSERT INTO LOAIKHACHHANG (TenLoaiKH) VALUES ('Thường Xuyên');
INSERT INTO LOAIKHACHHANG (TenLoaiKH) VALUES ('Mới');
GO

INSERT INTO KHACHHANG (TongChiTieu, HoTen, GioiTinh, DiaChi, Email, DienThoai, MaLoaiKH) 
VALUES (0, N'Nguyễn Thị Hồng', N'Nữ', N'Số 25, Đường Nguyễn Huệ, Quận 1, TP. Hồ Chí Minh', 'emily.rose5678@gmail.com', '0987 654 321', NULL)

INSERT INTO KHACHHANG (TongChiTieu, HoTen, GioiTinh, DiaChi, Email, DienThoai, MaLoaiKH) 
VALUES (0, N'Lê Văn Hưng', N'Nam', N'Số 123, Đường Cách Mạng Tháng Tám, Quận Ninh Kiều, TP. Cần Thơ', 'david.jones91011@gmail.com', '0901 234 567', NULL)

INSERT INTO KHACHHANG (TongChiTieu, HoTen, GioiTinh, DiaChi, Email, DienThoai, MaLoaiKH) 
VALUES (0, N'Phạm Quốc Khánh', N'Nam', N'Số 45, Đường Trần Phú, Phường 5, TP. Đà Lạt, Lâm Đồng', 'sarah.williams1213@gmail.com', '0968 123 456', NULL)

INSERT INTO KHACHHANG (TongChiTieu, HoTen, GioiTinh, DiaChi, Email, DienThoai, MaLoaiKH) 
VALUES (0, N'Trần Thị Thu Hà', N'Nữ', N'Số 78, Đường Phạm Văn Đồng, Quận Sơn Trà, TP. Đà Nẵng', 'michael.brown1415@gmail.com', '0933 987 654', NULL)

INSERT INTO KHACHHANG (TongChiTieu, HoTen, GioiTinh, DiaChi, Email, DienThoai, MaLoaiKH) 
VALUES (0, N'Hoàng Thị Mai', N'Nữ', N'Số 200, Đường Hoàng Diệu, Quận Ba Đình, Hà Nội', 'mai.hoang200@gmail.com', '0977 888 999', NULL)
select * from KHACHHANG
GO

INSERT INTO KHUYENMAI(NgayBD, NgayKT, TenCT, LoaiCT, DieuKien) 
VALUES('2024-09-01', '2024-09-30', N'Giảm giá mùa thu', N'Giảm giá', N'Tổng hóa đơn trên 1 triệu');

INSERT INTO KHUYENMAI(NgayBD, NgayKT, TenCT, LoaiCT, DieuKien) 
VALUES('2024-10-01', '2024-10-31', N'Khuyến mãi ngày 20/10', N'Tặng quà', N'Áp dụng cho khách nữ');

INSERT INTO KHUYENMAI(NgayBD, NgayKT, TenCT, LoaiCT, DieuKien) 
VALUES('2024-11-01', '2024-11-15', N'Giảm giá Black Friday', N'Giảm giá', N'Tổng hóa đơn trên 2 triệu');

INSERT INTO KHUYENMAI(NgayBD, NgayKT, TenCT, LoaiCT, DieuKien) 
VALUES('2024-12-01', '2024-12-31', N'Khuyến mãi Noel', N'Giảm giá', N'Áp dụng cho tất cả đơn hàng');

INSERT INTO KHUYENMAI(NgayBD, NgayKT, TenCT, LoaiCT, DieuKien) 
VALUES('2024-12-15', '2024-12-25', N'Khuyến mãi cuối năm', N'Tặng quà', N'Tổng hóa đơn trên 500 nghìn');

select * from KHUYENMAI
GO

INSERT INTO NHACUNGCAP(TenNCC, DiaChi, DienThoai, Email) 
VALUES(N'Công ty TNHH ABC', N'Số 10, Đường Lê Lợi, Quận 1, TP. Hồ Chí Minh', '0901 234 567', 'contact@abc.com')
INSERT INTO NHACUNGCAP(TenNCC, DiaChi, DienThoai, Email) 
VALUES(N'Công ty CP XYZ', N'Số 55, Đường Phạm Văn Đồng, Quận Cầu Giấy, Hà Nội', '0987 654 321', 'info@xyz.com')
INSERT INTO NHACUNGCAP(TenNCC, DiaChi, DienThoai, Email) 
VALUES(N'Tập đoàn Sun Group', N'Số 99, Đường Trần Hưng Đạo, Quận Hải Châu, Đà Nẵng', '0932 888 999', 'sales@sun-group.com')
INSERT INTO NHACUNGCAP(TenNCC, DiaChi, DienThoai, Email) 
VALUES(N'Công ty TNHH Tân Hoàng Minh', N'Số 12, Đường Hoàng Diệu, Quận Ba Đình, Hà Nội', '0912 345 678', 'support@tanhoangminh.com')
INSERT INTO NHACUNGCAP(TenNCC, DiaChi, DienThoai, Email) 
VALUES(N'Công ty TNHH VinaMilk', N'Số 66, Đường Cách Mạng Tháng Tám, Quận Tân Bình, TP. Hồ Chí Minh', '0977 123 456', 'vinamilk@support.com')
select * from NHACUNGCAP
GO

INSERT INTO MAUSAC(TenMau) 
VALUES(N'Đỏ');

INSERT INTO MAUSAC(TenMau) 
VALUES(N'Xanh lá cây');

INSERT INTO MAUSAC(TenMau) 
VALUES(N'Xanh dương');

INSERT INTO MAUSAC(TenMau) 
VALUES(N'Vàng');

INSERT INTO MAUSAC(TenMau) 
VALUES(N'Tím');

select * from MAUSAC
GO

INSERT INTO THUONGHIEU(TenTH, DiaChi, Email) 
VALUES(N'Nike', N'Số 20, Đường Nguyễn Trãi, Quận 5, TP. Hồ Chí Minh', 'contact@nike.com');

INSERT INTO THUONGHIEU(TenTH, DiaChi, Email) 
VALUES(N'Adidas', N'Số 45, Đường Láng, Quận Đống Đa, Hà Nội', 'info@adidas.com');

INSERT INTO THUONGHIEU(TenTH, DiaChi, Email) 
VALUES(N'Puma', N'Số 88, Đường Võ Thị Sáu, TP. Đà Nẵng', 'support@puma.com');

INSERT INTO THUONGHIEU(TenTH, DiaChi, Email) 
VALUES(N'Reebok', N'Số 12, Đường Nguyễn Huệ, Quận 1, TP. Hồ Chí Minh', 'service@reebok.com');

INSERT INTO THUONGHIEU(TenTH, DiaChi, Email) 
VALUES(N'Converse', N'Số 33, Đường Trần Phú, Quận Ba Đình, Hà Nội', 'contact@converse.com');

select * from THUONGHIEU
GO

INSERT INTO XUATXU(TenNuoc) 
VALUES(N'Việt Nam');

INSERT INTO XUATXU(TenNuoc) 
VALUES(N'Nhật Bản');

INSERT INTO XUATXU(TenNuoc) 
VALUES(N'Hàn Quốc');

INSERT INTO XUATXU(TenNuoc) 
VALUES(N'Mỹ');

INSERT INTO XUATXU(TenNuoc) 
VALUES(N'Ý');

select * from XUATXU
GO

INSERT INTO LOAI(TenLoai) 
VALUES(N'Giày thể thao');

INSERT INTO LOAI(TenLoai) 
VALUES(N'Giày công sở');

INSERT INTO LOAI(TenLoai) 
VALUES(N'Giày sandal');

INSERT INTO LOAI(TenLoai) 
VALUES(N'Giày boot');

INSERT INTO LOAI(TenLoai) 
VALUES(N'Giày loafer');

select * from LOAI
GO

INSERT INTO NHANVIEN(ChucVu, HoTen, GioiTinh, DiaChi, DienThoai, Email, Luong) 
VALUES(N'Quản lý', N'Nguyễn Văn An', N'Nam', N'Số 12, Đường Nguyễn Trãi, TP. Hồ Chí Minh', '0909 123 456', 'an.nguyen@example.com', 15000000);

INSERT INTO NHANVIEN(ChucVu, HoTen, GioiTinh, DiaChi, DienThoai, Email, Luong) 
VALUES(N'Nhân viên bán hàng', N'Vũ Thị Lan', N'Nữ', N'Số 45, Đường Láng, Hà Nội', '0912 345 678', 'lan.vu@example.com', 10000000);

INSERT INTO NHANVIEN(ChucVu, HoTen, GioiTinh, DiaChi, DienThoai, Email, Luong) 
VALUES(N'Tiếp tân', N'Hoàng Minh Tuấn', N'Nam', N'Số 78, Đường Trần Phú, TP. Đà Nẵng', '0923 456 789', 'tuan.hoang@example.com', 12000000);

INSERT INTO NHANVIEN(ChucVu, HoTen, GioiTinh, DiaChi, DienThoai, Email, Luong) 
VALUES(N'Kế toán', N'Phạm Thị Hương', N'Nữ', N'Số 33, Đường Hoàng Diệu, Hà Nội', '0934 567 890', 'huong.pham@example.com', 13000000);

INSERT INTO NHANVIEN(ChucVu, HoTen, GioiTinh, DiaChi, DienThoai, Email, Luong) 
VALUES(N'Nhân viên kho', N'Lê Văn Tùng', N'Nam', N'Số 22, Đường Võ Thị Sáu, TP. Hồ Chí Minh', '0945 678 901', 'tung.le@example.com', 11000000);

select * from NHANVIEN
GO

INSERT INTO PHANQUYEN (TenQuyen) VALUES (N'Quản lý sản phẩm');
INSERT INTO PHANQUYEN (TenQuyen) VALUES (N'Quản lý hóa đơn');
INSERT INTO PHANQUYEN (TenQuyen) VALUES (N'Xem báo cáo');
select * from PHANQUYEN
GO

INSERT INTO NHANVIEN_QUYEN (MaNV, MaQuyen) VALUES (1, 1);
INSERT INTO NHANVIEN_QUYEN (MaNV, MaQuyen) VALUES (1, 2);
INSERT INTO NHANVIEN_QUYEN (MaNV, MaQuyen) VALUES (2, 3);
select * from NHANVIEN_QUYEN
GO

INSERT INTO TAIKHOANNV(MaNV, TenDN, MatKhau) 
VALUES(1, N'annguyen', N'Annguyen123@');

INSERT INTO TAIKHOANNV(MaNV, TenDN, MatKhau) 
VALUES(2, N'lanvu', N'Lanvu123@');

INSERT INTO TAIKHOANNV(MaNV, TenDN, MatKhau) 
VALUES(3, N'tuanhoang', N'Tuanhoang123@');

INSERT INTO TAIKHOANNV(MaNV, TenDN, MatKhau) 
VALUES(4, N'huongpham', N'Huongpham123@');

INSERT INTO TAIKHOANNV(MaNV, TenDN, MatKhau) 
VALUES(5, N'tungle', N'tungle123@');

select * from TAIKHOANNV
GO

INSERT INTO PHIEUNHAP(NgayNhap, TongTien, MaNCC, MaNV) 
VALUES('2024-09-01', 2000000, 1, 1);

INSERT INTO PHIEUNHAP(NgayNhap, TongTien, MaNCC, MaNV) 
VALUES('2024-09-05', 3500000, 2, 5);

INSERT INTO PHIEUNHAP(NgayNhap, TongTien, MaNCC, MaNV) 
VALUES('2024-09-10', 1500000, 3, 1);

INSERT INTO PHIEUNHAP(NgayNhap, TongTien, MaNCC, MaNV) 
VALUES('2024-09-15', 4200000, 4, 5);

INSERT INTO PHIEUNHAP(NgayNhap, TongTien, MaNCC, MaNV) 
VALUES('2024-09-20', 2800000, 5, 5);

select * from PHIEUNHAP
GO

INSERT INTO HOADON(NgayBan, TongTien, Thue, MaKH, MaNV, MaKM) 
VALUES('2024-09-01', 1000000, 100000, 1, 1, 1);

INSERT INTO HOADON(NgayBan, TongTien, Thue, MaKH, MaNV, MaKM) 
VALUES('2024-09-02', 1500000, 150000, 2, 2, 2);

INSERT INTO HOADON(NgayBan, TongTien, Thue, MaKH, MaNV, MaKM) 
VALUES('2024-09-03', 2000000, 200000, 3, 1, 3);

INSERT INTO HOADON(NgayBan, TongTien, Thue, MaKH, MaNV, MaKM) 
VALUES('2024-09-04', 2500000, 250000, 4, 2, 4);

INSERT INTO HOADON(NgayBan, TongTien, Thue, MaKH, MaNV, MaKM) 
VALUES('2024-09-05', 3000000, 300000, 5, 2, 5);

select * from HOADON
GO

INSERT INTO GIAY(TenGiay, SoLuong, DonGia, Size, DoiTuongSD, ChatLieu, MaLoai, MaXX, MaMau, MaTH) 
VALUES(N'Giày thể thao Nike Air Max', 50, 2500000, N'42', N'Nam', N'Vải', 1, 1, 1, 1);

INSERT INTO GIAY(TenGiay, SoLuong, DonGia, Size, DoiTuongSD, ChatLieu, MaLoai, MaXX, MaMau, MaTH) 
VALUES(N'Giày công sở Adidas', 30, 1800000, N'40', N'Nữ', N'Da', 2, 2, 2, 2);

INSERT INTO GIAY(TenGiay, SoLuong, DonGia, Size, DoiTuongSD, ChatLieu, MaLoai, MaXX, MaMau, MaTH) 
VALUES(N'Giày sandal Puma', 40, 1200000, N'39', N'Nam', N'Vải', 3, 3, 3, 3);

INSERT INTO GIAY(TenGiay, SoLuong, DonGia, Size, DoiTuongSD, ChatLieu, MaLoai, MaXX, MaMau, MaTH) 
VALUES(N'Giày boot Reebok', 20, 3500000, N'43', N'Nữ', N'Da', 4, 4, 4, 4);

INSERT INTO GIAY(TenGiay, SoLuong, DonGia, Size, DoiTuongSD, ChatLieu, MaLoai, MaXX, MaMau, MaTH) 
VALUES(N'Giày loafer Converse', 25, 1500000, N'41', N'Nam', N'Vải', 5, 5, 5, 5);

select * from GIAY
GO

-- Thêm dữ liệu kiểm kê cho ngày cụ thể
INSERT INTO KIEMKE (NgayKiemKe, MaGiay, SoLuongThucTe)
VALUES
('2024-09-15', 1, 50),
('2024-09-15', 2, 30),
('2024-09-15', 3, 20);


INSERT INTO CHITIETKM(MaKM, MaGiay, TiLeKM) 
VALUES(1, 1, 0.10);

INSERT INTO CHITIETKM(MaKM, MaGiay, TiLeKM) 
VALUES(2, 2, 0.15);

INSERT INTO CHITIETKM(MaKM, MaGiay, TiLeKM) 
VALUES(3, 3, 0.20);

INSERT INTO CHITIETKM(MaKM, MaGiay, TiLeKM) 
VALUES(4, 4, 0.25); 

INSERT INTO CHITIETKM(MaKM, MaGiay, TiLeKM) 
VALUES(5, 5, 0.30);

select * from CHITIETKM
GO

INSERT INTO CHITIETHD(MaHD, MaGiay, SoLuong, GiaBan) 
VALUES(1, 1, 2, 2500000);

INSERT INTO CHITIETHD(MaHD, MaGiay, SoLuong, GiaBan) 
VALUES(2, 2, 1, 1800000);

INSERT INTO CHITIETHD(MaHD, MaGiay, SoLuong, GiaBan) 
VALUES(3, 3, 3, 1200000);

INSERT INTO CHITIETHD(MaHD, MaGiay, SoLuong, GiaBan) 
VALUES(4, 4, 1, 3500000);

INSERT INTO CHITIETHD(MaHD, MaGiay, SoLuong, GiaBan) 
VALUES(5, 5, 4, 1500000);

select * from CHITIETHD
GO

INSERT INTO CHITIETPN(MaPN, MaGiay, SoLuong, GiaNhap) 
VALUES(1, 1, 10, 2000000);

INSERT INTO CHITIETPN(MaPN, MaGiay, SoLuong, GiaNhap) 
VALUES(2, 2, 20, 1800000);

INSERT INTO CHITIETPN(MaPN, MaGiay, SoLuong, GiaNhap) 
VALUES(3, 3, 15, 1200000);

INSERT INTO CHITIETPN(MaPN, MaGiay, SoLuong, GiaNhap) 
VALUES(4, 4, 5, 3500000);

INSERT INTO CHITIETPN(MaPN, MaGiay, SoLuong, GiaNhap) 
VALUES(5, 5, 8, 1500000);

select * from CHITIETPN
GO

-- Tổng hợp số lượng sản phẩm còn lại trong kho
SELECT 
    GIAY.MaGiay,
    GIAY.TenGiay,
    GIAY.SoLuong AS SoLuongTonKho
FROM GIAY
ORDER BY GIAY.TenGiay

-- Tổng hợp thông tin phiếu nhập hàng
SELECT 
    PHIEUNHAP.MaPN,
    PHIEUNHAP.NgayNhap,
    NHACUNGCAP.TenNCC,
    SUM(CHITIETPN.SoLuong) AS TongSoLuongNhap,
    SUM(CHITIETPN.GiaNhap * CHITIETPN.SoLuong) AS TongGiaNhap
FROM PHIEUNHAP
INNER JOIN NHACUNGCAP ON PHIEUNHAP.MaNCC = NHACUNGCAP.MaNCC
INNER JOIN CHITIETPN ON PHIEUNHAP.MaPN = CHITIETPN.MaPN
GROUP BY PHIEUNHAP.MaPN, PHIEUNHAP.NgayNhap, NHACUNGCAP.TenNCC
ORDER BY PHIEUNHAP.NgayNhap DESC

-- Tổng hợp thông tin hóa đơn bán hàng
SELECT 
    HOADON.MaHD,
    HOADON.NgayBan,
    KHACHHANG.HoTen AS TenKhachHang,
    SUM(CHITIETHD.SoLuong) AS TongSoLuongBan,
    SUM(CHITIETHD.GiaBan * CHITIETHD.SoLuong) AS TongGiaBan
FROM HOADON
INNER JOIN KHACHHANG ON HOADON.MaKH = KHACHHANG.MaKH
INNER JOIN CHITIETHD ON HOADON.MaHD = CHITIETHD.MaHD
GROUP BY HOADON.MaHD, HOADON.NgayBan, KHACHHANG.HoTen
ORDER BY HOADON.NgayBan DESC

select * from KHACHHANG

-- Xem quyền của nhân viên 1
SELECT nv.HoTen, pq.TenQuyen
FROM NHANVIEN nv
JOIN NHANVIEN_QUYEN nvq ON nv.MaNV = nvq.MaNV
JOIN PHANQUYEN pq ON nvq.MaQuyen = pq.MaQuyen
WHERE nv.MaNV = 1

-- Truy vấn để so sánh số lượng thực tế và số lượng trong hệ thống
SELECT 
    GIAY.MaGiay,
    GIAY.TenGiay,
    GIAY.SoLuong AS SoLuongHienCo,
    KIEMKE.SoLuongThucTe AS SoLuongThucTe,
    (GIAY.SoLuong - KIEMKE.SoLuongThucTe) AS ChenhLech
FROM GIAY
INNER JOIN KIEMKE ON GIAY.MaGiay = KIEMKE.MaGiay
WHERE KIEMKE.NgayKiemKe = '2024-09-15'

-- Doanh thu từ hóa đơn
SELECT SUM(TongTien) AS DoanhThu FROM HOADON;

-- Chi từ phiếu nhập
SELECT SUM(TongTien) AS Chi FROM PHIEUNHAP;

-- Báo cáo lợi nhuận theo tháng
SELECT 
    MONTH(NgayBan) AS Thang, 
    YEAR(NgayBan) AS Nam, 
    SUM(TongTien - Thue) AS DoanhThu,
    (SELECT SUM(TongTien) FROM PHIEUNHAP WHERE MONTH(NgayNhap) = MONTH(HOADON.NgayBan) AND YEAR(NgayNhap) = YEAR(HOADON.NgayBan)) AS Chi,
    SUM(TongTien - Thue) - (SELECT SUM(TongTien) FROM PHIEUNHAP WHERE MONTH(NgayNhap) = MONTH(HOADON.NgayBan) AND YEAR(NgayNhap) = YEAR(HOADON.NgayBan)) AS LoiNhuan
FROM HOADON
GROUP BY MONTH(NgayBan), YEAR(NgayBan);

-- Báo cáo lợi nhuận tổng hợp
SELECT 
    SUM(TongTien - Thue) AS TongDoanhThu,
    (SELECT SUM(TongTien) FROM PHIEUNHAP) AS TongChi,
    SUM(TongTien - Thue) - (SELECT SUM(TongTien) FROM PHIEUNHAP) AS TongLoiNhuan
FROM HOADON;

select * from TAIKHOANNV, NhanVien where TaiKhoanNV.MaNV = NhanVien.MaNV