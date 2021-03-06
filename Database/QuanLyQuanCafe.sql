CREATE DATABASE QLCAFE
go
USE QLCAFE
go
CREATE TABLE SANPHAM(
IDSP int identity(1,1) PRIMARY KEY,
TenSP NVARCHAR(50),
Dongia money,
Trangthai int
)
go
CREATE TABLE LOAINV(
IDLoaiNV int identity(1,1) primary key,
TenLNV nvarchar(100)
)
go
CREATE TABLE NHANVIEN(
IDNV int identity(1,1) PRIMARY KEY,
Hoten NVARCHAR(50),
IDLoaiNV int,
Dienthoai varchar(10),
Gioitinh nvarchar(3),
Ngaysinh date,
CMND varchar(30),
TaiKhoan varchar(100),
MatKhau varchar(100),
Diachi NVARCHAR(100),
Trangthai int,
foreign key (IDLoaiNV) references LOAINV (IDLoaiNV)
)
go
CREATE TABLE KHACHHANG(
IDKH int identity(1,1) PRIMARY KEY,
Hoten NVARCHAR(50),
Dienthoai varchar(10),
Gioitinh nvarchar(3),
Trangthai int
)
go
CREATE TABLE HOADON(
IDHD int identity(1,1) PRIMARY KEY,
IDNV int,
IDKH int,
Ngaylap date,
GioLap time,
TongTien int,
foreign key (IDNV) references NHANVIEN (IDNV),
foreign key (IDKH) references KHACHHANG (IDKH)
)
go
CREATE TABLE CHITIETHOADON(
IDHD int,
IDSP int,
Soluong int,
ThanhTien money,
foreign key (IDHD) references HOADON (IDHD),
foreign key (IDSP) references SANPHAM (IDSP),
)
go
Insert into LOAINV(TenLNV)
values (N'Nhân Viên'),
		(N'Quản Lí');
Insert into NHANVIEN (Hoten,IDLoaiNV,Dienthoai,Gioitinh,Ngaysinh,CMND,TaiKhoan,MatKhau,Diachi,Trangthai)
values(N'Nguyễn Văn Trọng',2,'0326440254',N'Nam','10/23/2000','072200004866','nkiPX9PiYNhRh6A7Nscbi1fxmBn7OJZPQHLqadKHGzw=','BzE4xZwLMT2lPcmlFzLUgA==',N'Tây Ninh',1),
(N'Phạm Như Thuần',1,'0916494960',N'Nam','02/04/2000','072200005864','fx0p0U9A3ScFU8AiHFoVxJwvMtEnBvbfJw13P3OEQe4=','BzE4xZwLMT2lPcmlFzLUgA==',N'Cầu Thăng Tiến',1);
go
InSert into SANPHAM(TenSP,Dongia,Trangthai)
values (N'Cafe đen đá',15000,1),
		(N'Cafe sữa đá',15000,1),
		(N'Trà sữa trân châu',20000,1),
		(N'Trà sữa dâu',20000,1),
		(N'Trà sữa bạc hà',20000,1),
		(N'Trà sữa nho',20000,1),
		(N'Trà sữa cam',20000,1),
		(N'Trà sữa chanh day',20000,1),
		(N'Trà dâu',12000,1),
		(N'Trà táo',12000,1),
		(N'Trà tắc',12000,1),
		(N'Kem socola',10000,1),
		(N'Kem nho',10000,1),
		(N'Bò húc',15000,1),
		(N'Sting',12000,1),
		(N'Cocacola',10000,1),
		(N'Pepsi',10000,1);
go
insert into KHACHHANG(Hoten,Dienthoai,Gioitinh,Trangthai)
values (N'Nguyễn Văn Trọng','0326440254',N'Nam',1);
go
insert into HOADON(IDNV,IDKH,Ngaylap,GioLap,TongTien)
values(1,1,'07/03/2020','00:03:29',51000);	
go
insert into CHITIETHOADON
values(1,1,1,15000),
	(1,10,1,12000),
	(1,11,1,12000),
	(1,9,1,12000);
