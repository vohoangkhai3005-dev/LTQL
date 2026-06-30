/*====================================================
=                 TẠO CƠ SỞ DỮ LIỆU
====================================================*/
CREATE DATABASE QLBH;
GO

USE QLBH;
GO
/*====================================================
=                 PHẦN 1 - NGHĨA
====================================================*/

/*====================================================
=                 BẢNG TAIKHOAN
====================================================*/
CREATE TABLE TAIKHOAN
(
    IDUSER INT IDENTITY(1,1),
    HOTEN NVARCHAR(100) NOT NULL,
    TAIKHOANG NVARCHAR(50) NOT NULL,
    MATKHAU NVARCHAR(50) NOT NULL,
    NHOM NVARCHAR(50) NOT NULL
);
GO

ALTER TABLE TAIKHOAN
ADD CONSTRAINT PK_TAIKHOAN PRIMARY KEY (IDUSER);
GO

INSERT INTO TAIKHOAN
(HOTEN, TAIKHOANG, MATKHAU, NHOM)
VALUES
('VOTHANHNGHOIA', 'NGHIA', '123', 'Admin'),
('VOHOANGKHAI', 'KHAI', '123', 'Admin'),
('NHATBANG', 'BANG', '123', 'Admin'),
('Binh', 'VANBINH', '123', 'User'),
('HoaI', 'MINHHOAI', '123', 'User');
GO

/*====================================================
=                 BẢNG CHUCNANG
====================================================*/
CREATE TABLE CHUCNANG
(
    IDCN INT IDENTITY(1,1),
    TENCN NVARCHAR(100) NOT NULL
);
GO

ALTER TABLE CHUCNANG
ADD CONSTRAINT PK_CHUCNANG PRIMARY KEY (IDCN);
GO

INSERT INTO CHUCNANG (TENCN)
VALUES
(N'Thêm tài khoản'),
(N'Đổi mật khẩu'),
(N'QL danh mục'),
(N'QL mặt hàng'),
(N'QL nhân viên'),
(N'QL khách hàng'),
(N'QL hóa đơn'),
(N'Chi tiết hóa đơn'),
(N'Tìm kiếm hóa đơn'),
(N'Tìm kiếm khách hàng'),
(N'Tìm kiếm mặt hàng'),
(N'Báo cáo doanh thu'),
(N'Báo cáo tồn kho'),
(N'In báo cáo');
GO
/*====================================================
=                 BẢNG VAITRO
====================================================*/
CREATE TABLE VAITRO
(
    IDVT INT IDENTITY(1,1),
    IDUSER INT NOT NULL,
    IDCN INT NOT NULL
);
GO

ALTER TABLE VAITRO
ADD CONSTRAINT PK_VAITRO PRIMARY KEY (IDVT);
GO

ALTER TABLE VAITRO
ADD CONSTRAINT FK_VT_TK
FOREIGN KEY (IDUSER)
REFERENCES TAIKHOAN(IDUSER);

ALTER TABLE VAITRO
ADD CONSTRAINT FK_VT_CN
FOREIGN KEY (IDCN)
REFERENCES CHUCNANG(IDCN);
GO

INSERT INTO VAITRO (IDUSER, IDCN)
VALUES
(2,1),
(2,2),
(2,3),
(2,4),
(2,5),
(3,6),
(3,7),
(3,8),
(3,9),
(3,10),
(1,1),
(1,2),
(4,12),
(4,13);
GO

/*====================================================
=                 BẢNG NHANVIEN
====================================================*/
CREATE TABLE NHANVIEN
(
    MANV VARCHAR(10) NOT NULL,
    TENNV NVARCHAR(100) NOT NULL,
    NGAYSINH DATE NOT NULL,
    GIOITINH NVARCHAR(10) NOT NULL,
    DIACHI NVARCHAR(100) NOT NULL,
    DIENTHOAI NVARCHAR(15) NOT NULL
);
GO

ALTER TABLE NHANVIEN
ADD CONSTRAINT PK_NHANVIEN PRIMARY KEY (MANV);
GO

INSERT INTO NHANVIEN
(MANV, TENNV, NGAYSINH, GIOITINH, DIACHI, DIENTHOAI)
VALUES
('NV001', N'Võ Thành Nghĩa', '2004-05-10', N'Nam', N'TP.HCM', '0901234567'),
('NV002', N'Võ Hoàng Khải', '2004-08-15', N'Nam', N'Bình Dương', '0902345678'),
('NV003', N'Nhật Bằng', '2004-12-20', N'Nam', N'Đồng Nai', '0903456789'),
('NV004', N'Nguyễn Thị Hoa', '2003-03-25', N'Nữ', N'Tây Ninh', '0904567890'),
('NV005', N'Trần Văn Bình', '2002-11-05', N'Nam', N'Long An', '0905678901');
GO
/*====================================================
=                 PHẦN 2 - KHẢI
====================================================*/

/*====================================================
=                 BẢNG DANHMUC
====================================================*/
CREATE TABLE DANHMUC
(
    MaDanhMuc VARCHAR(10) NOT NULL,
    TenDanhMuc NVARCHAR(100) NOT NULL,
    MoTa NVARCHAR(200)
);
GO

ALTER TABLE DANHMUC
ADD CONSTRAINT PK_DANHMUC PRIMARY KEY (MaDanhMuc);
GO

INSERT INTO DANHMUC
(MaDanhMuc, TenDanhMuc, MoTa)
VALUES
('DM001',N'Thực phẩm bổ sung',N'Các sản phẩm bổ sung dinh dưỡng: Whey Protein, BCAA, Vitamin...'),
('DM002',N'Dụng cụ tập luyện',N'Tạ, thanh tạ, dây kéo lò xo, ghế tập...'),
('DM003',N'Phụ kiện',N'Thắt lưng, găng tay, dây buộc, khăn...'),
('DM004',N'Thiết bị thể thao',N'Vợt cầu lông, bóng, giày thể thao...'),
('DM005',N'Đồ uống năng lượng',N'Nước uống bổ sung điện giải, năng lượng...');
GO

/*====================================================
=              BẢNG NHACUNGCAP
====================================================*/
CREATE TABLE NHACUNGCAP
(
    MaNCC VARCHAR(10) NOT NULL,
    TenNCC NVARCHAR(100) NOT NULL,
    SDT VARCHAR(15),
    Email VARCHAR(100),
    DiaChi NVARCHAR(200)
);
GO

ALTER TABLE NHACUNGCAP
ADD CONSTRAINT PK_NHACUNGCAP PRIMARY KEY (MaNCC);
GO

INSERT INTO NHACUNGCAP
(MaNCC, TenNCC, SDT, Email, DiaChi)
VALUES
('NCC001',N'Công ty Cơ Phí Việt Nam','0283456789','sales@cophy.vn',N'123 Nguyễn Hữu Cảnh, Quận 1, TP.HCM'),
('NCC002',N'Nhập khẩu Thể Thao Global','0289234567','contact@ttglobal.vn',N'456 Lê Lợi, Quận 5, TP.HCM'),
('NCC003',N'PROTEIN PLUS LTD','0287654321','orders@proteinplus.vn',N'789 Trần Hưng Đạo, Quận 1, TP.HCM'),
('NCC004',N'Fitness Equipment Co.','0285678901','supply@fitequip.vn',N'321 Nguyễn Văn Linh, Quận 7, TP.HCM'),
('NCC005',N'VitaminWorld Việt','0286789012','wholesale@vitaminworld.vn',N'654 Điện Biên Phủ, Quận 3, TP.HCM');
GO
/*====================================================
=                 BẢNG SANPHAM
====================================================*/
CREATE TABLE SANPHAM
(
    MaSP VARCHAR(10) NOT NULL,
    TenSP NVARCHAR(150) NOT NULL,
    MaNCC VARCHAR(10) NOT NULL,
    MaDanhMuc VARCHAR(10) NOT NULL,
    PhanLoai NVARCHAR(100),
    GiaBan DECIMAL(18,0) NOT NULL,
    SoLuongTon INT NOT NULL,
    HanSuDung DATE,
    HinhAnh VARCHAR(200),
    MoTa NVARCHAR(500) NOT NULL,
    TrangThai BIT NOT NULL DEFAULT 1
);
GO

ALTER TABLE SANPHAM
ADD CONSTRAINT PK_SANPHAM PRIMARY KEY (MaSP);
GO

ALTER TABLE SANPHAM
ADD CONSTRAINT FK_SP_NCC
FOREIGN KEY (MaNCC)
REFERENCES NHACUNGCAP(MaNCC);

ALTER TABLE SANPHAM
ADD CONSTRAINT FK_SP_DM
FOREIGN KEY (MaDanhMuc)
REFERENCES DANHMUC(MaDanhMuc);
GO

INSERT INTO SANPHAM
(MaSP, TenSP, MaNCC, MaDanhMuc, PhanLoai, GiaBan, SoLuongTon, HanSuDung, HinhAnh, MoTa, TrangThai)
VALUES
('SP001',N'Whey Protein Gold Standard 5lb','NCC001','DM001',N'Whey Protein Concentrate',1200000,15,'2026-12-31','whey_gold.jpg',N'Bột whey protein chất lượng cao, hỗ trợ tăng cơ bắp, 2.3kg mỗi hộp',1),

('SP002',N'BCAA 8:1:1 500g','NCC003','DM001',N'BCAA',450000,20,'2027-06-30','bcaa_500.jpg',N'Bộ ba amino acid thiên về leucine, tăng sức bền và phục hồi',1),

('SP003',N'Vitamin D3 1000IU - 120 viên','NCC005','DM001',N'Vitamin',180000,30,'2027-12-31','vitamind3.jpg',N'Hỗ trợ hấp thụ canxi, tăng cường miễn dịch',1),

('SP004',N'Creatine Monohydrate 300g','NCC001','DM001',N'Creatine',280000,18,'2027-03-31','creatine.jpg',N'Tăng sức mạnh và khả năng bùng nổ trong tập luyện',1),

('SP005',N'Pre-Workout Extreme 250g','NCC003','DM001',N'Pre-Workout',350000,12,'2026-09-30','preworkout.jpg',N'Tăng năng lượng, tập trung và bơm máu trước khi tập',1),

('SP006',N'Tạ ngang 20kg','NCC002','DM002',N'Tạ ngang',450000,25,NULL,'ta_20kg.jpg',N'Tạ ngang thép chất lượng cao, phù hợp phòng gym',1),

('SP007',N'Tạ tròn 10kg','NCC004','DM002',N'Tạ tròn',280000,40,NULL,'ta_tron_10.jpg',N'Tạ tròn bằng thép cao cấp',1),

('SP008',N'Dây kéo lò xo 3 mức sức','NCC002','DM002',N'Dây kéo lò xo',120000,50,NULL,'day_keo_loxo.jpg',N'Dây kéo lò xo hỗ trợ tập cơ tay và vai',1),

('SP009',N'Ghế tập đa năng','NCC004','DM002',N'Ghế tập',3500000,5,NULL,'ghe_tap.jpg',N'Ghế tập đa năng hỗ trợ nhiều bài tập',1),

('SP010',N'Thảm Yoga cao cấp','NCC002','DM002',N'Thảm tập',380000,22,NULL,'mat_yoga.jpg',N'Thảm yoga chống trượt dày 6mm',1),

('SP011',N'Thắt lưng tập Gym','NCC002','DM003',N'Thắt lưng',280000,35,NULL,'that_lung.jpg',N'Hỗ trợ bảo vệ lưng khi nâng tạ',1),

('SP012',N'Găng tay tập Gym','NCC004','DM003',N'Găng tay',150000,60,NULL,'gang_tay.jpg',N'Găng tay chống trơn trượt',1),

('SP013',N'Dây buộc tóc thể thao','NCC002','DM003',N'Dây buộc',45000,100,NULL,'day_buoc_toc.jpg',N'Chất liệu cotton co giãn',1),

('SP014',N'Khăn thể thao Microfiber','NCC002','DM003',N'Khăn',65000,80,NULL,'khan.jpg',N'Khăn thấm hút mồ hôi tốt',1),

('SP015',N'Bóng bàn 40mm','NCC002','DM004',N'Bóng bàn',95000,45,NULL,'bongban.jpg',N'Hộp 6 quả tiêu chuẩn thi đấu',1),

('SP016',N'Dây nhảy tốc độ','NCC004','DM004',N'Dây nhảy',185000,30,NULL,'daynhay.jpg',N'Dây nhảy tốc độ cao',1),

('SP017',N'Gatorade Lemon 500ml','NCC005','DM005',N'Nước điện giải',45000,120,'2026-08-31','gatorade.jpg',N'Bổ sung điện giải sau khi tập',1),

('SP018',N'Red Bull 250ml','NCC005','DM005',N'Nước tăng lực',35000,150,'2026-10-15','redbull.jpg',N'Nước tăng lực',1);
GO
/*====================================================
=                 BẢNG PHIEUNHAP
====================================================*/
CREATE TABLE PHIEUNHAP
(
    MaPN VARCHAR(10) NOT NULL,
    MaNCC VARCHAR(10) NOT NULL,
    MaNV VARCHAR(10) NOT NULL,
    NgayNhap DATETIME NOT NULL,
    TongTien DECIMAL(18,0) NOT NULL,
    GhiChu NVARCHAR(300)
);
GO

ALTER TABLE PHIEUNHAP
ADD CONSTRAINT PK_PHIEUNHAP PRIMARY KEY (MaPN);
GO

/*====================================================
=          BẢNG CHITIETPHIEUNHAP
====================================================*/
CREATE TABLE CHITIETPHIEUNHAP
(
    MaCTPN INT NOT NULL,
    MaPN VARCHAR(10) NOT NULL,
    MaSP VARCHAR(10) NOT NULL,
    SoLuong INT NOT NULL,
    DonGiaBan DECIMAL(18,0) NOT NULL,
    ThanhTien AS (SoLuong * DonGiaBan) PERSISTED
);
GO

ALTER TABLE CHITIETPHIEUNHAP
ADD CONSTRAINT PK_CHITIETPHIEUNHAP PRIMARY KEY (MaCTPN);
GO

/*====================================================
=                 KHÓA NGOẠI
====================================================*/

ALTER TABLE PHIEUNHAP
ADD CONSTRAINT FK_PN_NCC
FOREIGN KEY (MaNCC)
REFERENCES NHACUNGCAP(MaNCC);
GO

/* ĐÃ SỬA */
ALTER TABLE PHIEUNHAP
ADD CONSTRAINT FK_PN_NV
FOREIGN KEY (MaNV)
REFERENCES NHANVIEN(MANV);
GO

ALTER TABLE CHITIETPHIEUNHAP
ADD CONSTRAINT FK_CTPN_PN
FOREIGN KEY (MaPN)
REFERENCES PHIEUNHAP(MaPN);
GO

ALTER TABLE CHITIETPHIEUNHAP
ADD CONSTRAINT FK_CTPN_SP
FOREIGN KEY (MaSP)
REFERENCES SANPHAM(MaSP);
GO

/*====================================================
=                 DỮ LIỆU PHIEUNHAP
====================================================*/

INSERT INTO PHIEUNHAP
(MaPN, MaNCC, MaNV, NgayNhap, TongTien, GhiChu)
VALUES
('PN001','NCC001','NV001','2026-05-10 10:30:00',8400000,N'Nhập hàng Whey Protein và Creatine'),
('PN002','NCC002','NV001','2026-05-15 14:20:00',12500000,N'Nhập tạ, thảm tập và dây kéo'),
('PN003','NCC005','NV002','2026-06-01 09:15:00',5400000,N'Nhập Vitamin D3 và Gatorade');
GO

/*====================================================
=           DỮ LIỆU CHITIETPHIEUNHAP
====================================================*/

INSERT INTO CHITIETPHIEUNHAP
(MaCTPN, MaPN, MaSP, SoLuong, DonGiaBan)
VALUES
(1,'PN001','SP001',10,1000000),
(2,'PN001','SP004',12,200000),
(3,'PN002','SP006',15,400000),
(4,'PN002','SP010',20,320000),
(5,'PN002','SP008',30,100000),
(6,'PN003','SP003',25,150000),
(7,'PN003','SP017',60,35000);
GO
/*====================================================
=                 PHẦN 3 - BẰNG
====================================================*/

/*====================================================
=                 BẢNG KHACHHANG
====================================================*/
CREATE TABLE KHACHHANG
(
    MAKH VARCHAR(10) NOT NULL,
    TENKH NVARCHAR(100) NOT NULL,
    SDT VARCHAR(15) NULL,
    DIACHI NVARCHAR(200) NULL,
    EMAIL VARCHAR(100) NULL
);
GO

ALTER TABLE KHACHHANG
ADD CONSTRAINT PK_KHACHHANG PRIMARY KEY (MAKH);
GO

INSERT INTO KHACHHANG
(MAKH, TENKH, SDT, DIACHI, EMAIL)
VALUES
('KH001', N'Nguyễn Văn An', '0901111111', N'12 Nguyễn Trãi, Q1, TP.HCM', 'an@gmail.com'),
('KH002', N'Trần Thị Lan', '0902222222', N'45 Lê Lợi, Q3, TP.HCM', 'lan@gmail.com'),
('KH003', N'Lê Minh Quân', '0903333333', N'78 Pasteur, Q1, TP.HCM', 'quan@gmail.com'),
('KH004', N'Phạm Thị Hương', '0904444444', N'112 Võ Văn Kiệt, Q5, TP.HCM', 'huong@gmail.com'),
('KH005', N'Hoàng Đức Mạnh', '0905555555', N'25 Đường 3/2, Q10, TP.HCM', 'manh@gmail.com'),
('KH006', N'Vũ Thị Ngọc', '0906666666', N'67 Nguyễn Thị Minh Khai, Q3, TP.HCM', 'ngoc@gmail.com');
GO

/*====================================================
=                 BẢNG HOADON
====================================================*/
CREATE TABLE HOADON
(
    MAHD VARCHAR(10) NOT NULL,
    MANV VARCHAR(10) NOT NULL,
    MAKH VARCHAR(10) NOT NULL,
    NGAYLAP DATE NOT NULL,
    TONGTIEN DECIMAL(18,2) NOT NULL
);
GO

ALTER TABLE HOADON
ADD CONSTRAINT PK_HOADON PRIMARY KEY (MAHD);
GO

ALTER TABLE HOADON
ADD CONSTRAINT FK_HOADON_NHANVIEN
FOREIGN KEY (MANV)
REFERENCES NHANVIEN(MANV);
GO

ALTER TABLE HOADON
ADD CONSTRAINT FK_HOADON_KHACHHANG
FOREIGN KEY (MAKH)
REFERENCES KHACHHANG(MAKH);
GO

INSERT INTO HOADON
(MAHD, MANV, MAKH, NGAYLAP, TONGTIEN)
VALUES
('HD001','NV001','KH001','2026-06-10',2450000),
('HD002','NV002','KH002','2026-06-12',1350000),
('HD003','NV003','KH003','2026-06-15',3780000),
('HD004','NV004','KH004','2026-06-16',890000),
('HD005','NV001','KH001','2026-06-17',1560000),
('HD006','NV005','KH005','2026-06-17',2650000);
GO

/*====================================================
=              BẢNG CHITIETHOADON
====================================================*/
CREATE TABLE CHITIETHOADON
(
    MACHITIET VARCHAR(10) NOT NULL,
    MAHD VARCHAR(10) NOT NULL,
    MASP VARCHAR(10) NOT NULL,
    SOLUONG INT NOT NULL,
    DONGIA DECIMAL(18,2) NOT NULL,
    THANHTIEN DECIMAL(18,2) NOT NULL
);
GO

ALTER TABLE CHITIETHOADON
ADD CONSTRAINT PK_CHITIETHOADON PRIMARY KEY (MACHITIET);
GO

ALTER TABLE CHITIETHOADON
ADD CONSTRAINT FK_CHITIETHOADON_HOADON
FOREIGN KEY (MAHD)
REFERENCES HOADON(MAHD);
GO

ALTER TABLE CHITIETHOADON
ADD CONSTRAINT FK_CHITIETHOADON_SANPHAM
FOREIGN KEY (MASP)
REFERENCES SANPHAM(MASP);
GO

INSERT INTO CHITIETHOADON
(MACHITIET, MAHD, MASP, SOLUONG, DONGIA, THANHTIEN)
VALUES
('CT001','HD001','SP001',2,650000,1300000),
('CT002','HD001','SP005',1,1150000,1150000),
('CT003','HD002','SP003',3,450000,1350000),
('CT004','HD003','SP002',1,1250000,1250000),
('CT005','HD003','SP004',2,850000,1700000),
('CT006','HD003','SP006',1,830000,830000),
('CT007','HD004','SP007',1,890000,890000),
('CT008','HD005','SP001',1,650000,650000),
('CT009','HD005','SP008',2,455000,910000),
('CT010','HD006','SP002',1,1250000,1250000),
('CT011','HD006','SP009',3,280000,840000),
('CT012','HD006','SP005',1,560000,560000),
('CT013','HD001','SP010',1,420000,420000),
('CT014','HD002','SP011',2,750000,1500000),
('CT015','HD003','SP012',1,980000,980000),
('CT016','HD004','SP013',4,250000,1000000),
('CT017','HD005','SP014',1,1350000,1350000),
('CT018','HD006','SP015',2,395000,790000);
GO