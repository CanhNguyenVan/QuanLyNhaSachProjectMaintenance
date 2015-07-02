Use master
Go
Drop Database QuanLyNhaSachMaintenance
Go
Create Database QuanLyNhaSachMaintenance
Go
Use QuanLyNhaSachMaintenance
Go

set DateFormat DMY

--Create Table SACH
Create Table SACH
(
	MaSach nvarchar(10) primary key,
	TenSach nvarchar(100),
	TheLoai nvarchar(50),
	TacGia nvarchar(50),
	NamXuatBan int,
	SoLuongTon int,
	DonGiaBan float
)

--Create Table KHACHHANG
Create Table KHACHHANG
(
	MaKhachHang nvarchar(10) primary key,
	HoTen nvarchar(50),
	DiaChi nvarchar(100),
	DienThoai int,
	Email nvarchar(50),
	SoTienNo float
)

--Create Table HOADON
Create Table HOADON
(
	MaHoaDon nvarchar(10) primary key,
	MaKhachHang nvarchar(10) foreign key references KHACHHANG(MaKhachHang),
	NgayLap smalldatetime
)

--Create Table CHITIETHOADON
Create Table CHITIETHOADON
(
	MaChiTietHoaDon nvarchar(10) primary key,
	MaHoaDon nvarchar(10) foreign key references HOADON(MaHoaDon),
	MaSach nvarchar(10) foreign key references SACH(MaSach),
	SoLuongBan int
)

--Create Table BAOCAOCONGNO
Create Table BAOCAOCONGNO
(
	MaBaoCaoCongNo nvarchar(10) primary key,
	Thang int,
	MaKhachHang nvarchar(10) foreign key references KHACHHANG(MaKhachHang),
	NoDau float,
	NoPhatSinh float,
	NoCuoi float
)

--Create Table BAOCAOTON
Create Table BAOCAOTON
(
	MaBaoCaoTon nvarchar(10) primary key,
	Thang int,
	MaSach nvarchar(10) foreign key references SACH(MaSach),
	TonDau int,
	TonPhatSinh int,
	TonCuoi int
)

--Create Table PHIEUNHAP
Create Table PHIEUNHAP
(
	MaPhieuNhap nvarchar(10) primary key,
	NgayNhap smalldatetime
)	

--Create Table CHITIETPHIEUNHAP
Create Table CHITIETPHIEUNHAP
(
	MaChiTietPhieuNhap nvarchar(10) primary key,
	MaPhieuNhap nvarchar(10) foreign key references PHIEUNHAP(MaPhieuNhap),
	MaSach nvarchar(10) foreign key references SACH(MaSach),
	SoLuongNhap int,
	DonGiaNhap float
)

--Create Table PHIEUTHUTIEN
Create Table PHIEUTHUTIEN
(
	MaPhieuThuTien nvarchar(10) primary key,
	SoTienThu float,
	MaKhachHang nvarchar(10) foreign key references KHACHHANG(MaKhachHang),
	NgayThu smalldatetime
)

Create Table THAMSO
(
	MaThamSo int primary key,
	SoLuongNhapToiThieu int,
	SoLuongTonToiDaTruocKhiNhap int,
	SoLuongTonToiThieuSauKhiBan int,
	TienNoToiDa float
)

Create Table TAIKHOAN
(
	MaTK int primary key,
	TenTK nvarchar(30) not null,
	MatKhau nvarchar(30) not null,
	LoaiTK int
)

Go 

CREATE PROCEDURE TaiKhoan_Delete
@MaTK int
AS

SET NOCOUNT ON

DELETE FROM TAIKHOAN
WHERE
	MaTK = @MaTK

Go

CREATE PROCEDURE TaiKhoan_Insert
	@MaTK int, @TenTK nvarchar(30), @MatKhau nvarchar(30), @LoaiTK int
AS

SET NOCOUNT ON

INSERT INTO TAIKHOAN
VALUES (@MaTK, @TenTK, @MatKhau, @LoaiTK)

Go

CREATE PROCEDURE TaiKhoan_SelectLastMaTK
AS

SET NOCOUNT ON
SET TRANSACTION ISOLATION LEVEL READ COMMITTED

SELECT TOP 1 MaTK
FROM	TAIKHOAN
ORDER BY 
	MaTK DESC

Go

CREATE PROCEDURE TaiKhoan_SelectAll
AS

SET NOCOUNT ON
SET TRANSACTION ISOLATION LEVEL READ COMMITTED
BEGIN
SELECT  *
FROM
	TAIKHOAN
END

Go

CREATE PROCEDURE TaiKhoan_Update
	@MaTK int, @TenTK nvarchar(30), @MatKhau nvarchar(30), @LoaiTK int
AS

SET NOCOUNT ON

UPDATE TAIKHOAN SET
	
	TenTK = @TenTK,
	MatKhau=@MatKhau,
	LoaiTK=@LoaiTK
WHERE
	MaTK = @MaTK


--Rang Buoc Toan Ven
--Ngay Muon Sach Phai Truoc Ngay Tra Sach

GO
CREATE PROCEDURE BaoCaoCongNo_SelectAll
AS
BEGIN
	select * from BAOCAOCONGNO
END
GO

---
CREATE PROCEDURE BaoCaoTon_SelectAll
AS
BEGIN
	select * from BAOCAOTON
END
GO

---
CREATE PROCEDURE ChiTietHoaDon_SelectAll
AS
BEGIN
	select * from CHITIETHOADON
END
GO

---
CREATE PROCEDURE ChiTietPhieuNhap_SelectAll
AS
BEGIN
	select * from CHITIETPHIEUNHAP
END
GO

---
CREATE PROCEDURE HoaDon_SelectAll
AS
BEGIN
	select * from HOADON
END
GO

---
CREATE PROCEDURE KhachHang_SelectAll
AS
BEGIN
	select * from KHACHHANG
END
GO

---
CREATE PROCEDURE PhieuNhap_SelectAll
AS
BEGIN
	select * from PHIEUNHAP
END
GO

---
CREATE PROCEDURE PhieuThuTien_SelectAll
AS
BEGIN
	select * from PHIEUTHUTIEN
END
GO

---
CREATE PROCEDURE Sach_SelectAll
AS
BEGIN
	select * from SACH
END
GO

---
CREATE PROCEDURE ThamSo_SelectAll
AS
BEGIN
	select * from THAMSO
END
GO

CREATE PROCEDURE BaoCaoCongNo_SelectByMaBaoCaoCongNo
@MaBaoCaoCongNo nvarchar(10)
AS
BEGIN
	select * from BAOCAOCONGNO where MaBaoCaoCongNo = @MaBaoCaoCongNo
END
GO

---
CREATE PROCEDURE BaoCaoTon_SelectByMaBaoCaoTon
@MaBaoCaoTon nvarchar(10)
AS
BEGIN
	select * from BAOCAOTON where MaBaoCaoTon = @MaBaoCaoTon
END
GO

---
CREATE PROCEDURE ChiTietHoaDon_SelectByMaChiTietHoaDon
@MaChiTietHoaDon nvarchar(10)
AS
BEGIN
	select * from CHITIETHOADON where MaChiTietHoaDon = @MaChiTietHoaDon
END
GO

---
CREATE PROCEDURE ChiTietPhieuNhap_SelectByMaChiTietPhieuNhap
@MaChiTietPhieuNhap nvarchar(10)
AS
BEGIN
	select * from CHITIETPHIEUNHAP where MaChiTietPhieuNhap = @MaChiTietPhieuNhap
END
GO

---
CREATE PROCEDURE HoaDon_SelectByMaHoaDon
@MaHoaDon nvarchar(10)
AS
BEGIN
	select * from HOADON where MaHoaDon = @MaHoaDon
END
GO

---
CREATE PROCEDURE KhachHang_SelectByMaKhachHang
@MaKhachHang nvarchar(10)
AS
BEGIN
	select * from KHACHHANG where MaKhachHang = @MaKhachHang
END
GO

---
CREATE PROCEDURE PhieuNhap_SelectByPhieuNhap
@MaPhieuNhap nvarchar(10)
AS
BEGIN
	select * from PHIEUNHAP where MaPhieuNhap = @MaPhieuNhap
END
GO

---
CREATE PROCEDURE PhieuThuTien_SelectByMaPhieuThuTien
@MaPhieuThuTien nvarchar(10)
AS
BEGIN
	select * from PHIEUTHUTIEN where MaPhieuThuTien = @MaPhieuThuTien
END
GO

---
CREATE PROCEDURE Sach_SelectByMaSach
@MaSach nvarchar(10)
AS
BEGIN
	select * from SACH where MaSach = @MaSach
END
GO

---

CREATE PROCEDURE BaoCaoCongNo_Insert
@MaBaoCaoCongNo nvarchar(10),
@Thang int,
@MaKhachHang nvarchar(10),
@NoDau float,
@NoPhatSinh float,
@NoCuoi float
AS
BEGIN
	insert into BAOCAOCONGNO (MaBaoCaoCongNo, Thang, MaKhachHang, NoDau, NoPhatSinh, NoCuoi)
	values (@MaBaoCaoCongNo, @Thang, @MaKhachHang, @NoDau, @NoPhatSinh, @NoCuoi)
END
GO

---
CREATE PROCEDURE BaoCaoTon_Insert
@MaBaoCaoTon nvarchar(10),
@Thang int,
@MaSach nvarchar(10),
@TonDau int,
@TonPhatSinh int,
@TonCuoi int
AS
BEGIN
	insert into BAOCAOTON (MaBaoCaoTon, Thang, MaSach, TonDau, TonPhatSinh, TonCuoi)
	values (@MaBaoCaoTon, @Thang, @MaSach, @TonDau, @TonPhatSinh, @TonCuoi)
END
GO

---
CREATE PROCEDURE ChiTietHoaDon_Insert
@MaChiTietHoaDon nvarchar(10),
@MaHoaDon nvarchar(10),
@MaSach nvarchar(10),
@SoLuongBan int
AS
BEGIN
	insert into CHITIETHOADON (MaChiTietHoaDon, MaHoaDon, MaSach, SoLuongBan)
	values (@MaChiTietHoaDon, @MaHoaDon, @MaSach, @SoLuongBan)
END
GO

---
CREATE PROCEDURE ChiTietPhieuNhap_Insert
@MaChiTietPhieuNhap nvarchar(10),
@MaPhieuNhap nvarchar(10),
@MaSach nvarchar(10),
@SoLuongNhap int,
@DonGiaNhap float
AS
BEGIN
	insert into CHITIETPHIEUNHAP (MaChiTietPhieuNhap, MaPhieuNhap, MaSach, SoLuongNhap, DonGiaNhap)
	values (@MaChiTietPhieuNhap, @MaPhieuNhap, @MaSach, @SoLuongNhap, @DonGiaNhap)
END
GO

---
CREATE PROCEDURE HoaDon_Insert
@MaHoaDon nvarchar(10),
@MaKhachHang nvarchar(10),
@NgayLap smalldatetime
AS
BEGIN
	insert into HOADON (MaHoaDon, MaKhachHang, NgayLap)
	values (@MaHoaDon, @MaKhachHang, @NgayLap)
END
GO

---
CREATE PROCEDURE KhachHang_Insert
@MaKhachHang nvarchar(10),
@HoTen nvarchar(50),
@DiaChi nvarchar(100),
@DienThoai int,
@Email nvarchar(50),
@SoTienNo float
AS
BEGIN
	insert into KHACHHANG (MaKhachHang, HoTen, DiaChi, DienThoai, Email, SoTienNo)
	values (@MaKhachHang, @HoTen, @DiaChi, @DienThoai, @Email, @SoTienNo)
END
GO

---
CREATE PROCEDURE PhieuNhap_Insert
@MaPhieuNhap nvarchar(10),
@NgayNhap smalldatetime
AS
BEGIN
	insert into PHIEUNHAP (MaPhieuNhap, NgayNhap)
	values (@MaPhieuNhap, @NgayNhap)
END
GO

---
CREATE PROCEDURE PhieuThuTien_Insert
@MaPhieuThuTien nvarchar(10),
@SoTienThu float,
@MaKhachHang nvarchar(10),
@NgayThu smalldatetime
AS
BEGIN
	insert into PHIEUTHUTIEN (MaPhieuThuTien, SoTienThu, MaKhachHang, NgayThu)
	values (@MaPhieuThuTien, @SoTienThu, @MaKhachHang, @NgayThu)
END
GO

---
CREATE PROCEDURE Sach_Insert
@MaSach nvarchar(10),
@TenSach nvarchar(100),
@TheLoai nvarchar(50),
@TacGia nvarchar(50),
@NamXuatBan int,
@SoLuongTon int,
@DonGiaBan float
AS
BEGIN
	insert into SACH (MaSach, TenSach, TheLoai, TacGia, NamXuatBan, SoLuongTon, DonGiaBan)
	values (@MaSach, @TenSach, @TheLoai, @TacGia, @NamXuatBan, @SoLuongTon, @DonGiaBan)
END
GO

---
CREATE PROCEDURE BaoCaoCongNo_Update
@MaBaoCaoCongNo nvarchar(10),
@Thang int,
@MaKhachHang nvarchar(10),
@NoDau float,
@NoPhatSinh float,
@NoCuoi float
AS
BEGIN
	update BAOCAOCONGNO
	set
		MaBaoCaoCongNo = @MaBaoCaoCongNo,
		Thang = @Thang,
		MaKhachHang = @MaKhachHang,
		NoDau = @NoDau,
		NoPhatSinh = @NoPhatSinh,
		NoCuoi = @NoCuoi
	where (MaBaoCaoCongNo = @MaBaoCaoCongNo)
END
GO

CREATE PROCEDURE BaoCaoTon_Update
@MaBaoCaoTon nvarchar(10),
@Thang int,
@MaSach nvarchar(10),
@TonDau int,
@TonPhatSinh int,
@TonCuoi int
AS
BEGIN
	update BAOCAOTON
	set
		MaBaoCaoTon = @MaBaoCaoTon,
		Thang = @Thang,
		MaSach = @MaSach,
		TonDau = @TonDau,
		TonPhatSinh = @TonPhatSinh,
		TonCuoi = @TonCuoi
	where (MaBaoCaoTon = @MaBaoCaoTon)
END
GO

CREATE PROCEDURE ChiTietHoaDon_Update
@MaChiTietHoaDon nvarchar(10),
@MaHoaDon nvarchar(10),
@MaSach nvarchar(10),
@SoLuongBan int
AS
BEGIN
	update CHITIETHOADON
	set
		MaChiTietHoaDon = @MaChiTietHoaDon,
		MaHoaDon = @MaHoaDon,
		MaSach = @MaSach,
		SoLuongBan = @SoLuongBan
	where (MaChiTietHoaDon = @MaChiTietHoaDon)
END
GO

CREATE PROCEDURE ChiTietPhieuNhap_Update
@MaChiTietPhieuNhap nvarchar(10),
@MaPhieuNhap nvarchar(10),
@MaSach nvarchar(10),
@SoLuongNhap int,
@DonGiaNhap float
AS
BEGIN
	update CHITIETPHIEUNHAP
	set
		MaChiTietPhieuNhap = @MaChiTietPhieuNhap,
		MaPhieuNhap = @MaPhieuNhap,
		MaSach = @MaSach,
		SoLuongNhap = @SoLuongNhap,
		DonGiaNhap = @DonGiaNhap
	where (MaChiTietPhieuNhap = @MaChiTietPhieuNhap)
END
GO

CREATE PROCEDURE HoaDon_Update
@MaHoaDon nvarchar(10),
@MaKhachHang nvarchar(10),
@NgayLap smalldatetime
AS
BEGIN
	update HOADON
	set
		MaHoaDon = @MaHoaDon,
		MaKhachHang = @MaKhachHang,
		NgayLap = @NgayLap
	where (MaHoaDon = @MaHoaDon)
END
GO

CREATE PROCEDURE KhachHang_Update
@MaKhachHang nvarchar(10),
@HoTen nvarchar(50),
@DiaChi nvarchar(100),
@DienThoai int,
@Email nvarchar(50),
@SoTienNo float
AS
BEGIN
	update KHACHHANG
	set
		MaKhachHang = @MaKhachHang,
		HoTen = @HoTen,
		DiaChi = @DiaChi,
		DienThoai = @DienThoai,
		Email = @Email,
		SoTienNo = @SoTienNo
	where (MaKhachHang = @MaKhachHang)
END
GO

CREATE PROCEDURE PhieuNhap_Update
@MaPhieuNhap nvarchar(10),
@NgayNhap smalldatetime
AS
BEGIN
	update PHIEUNHAP
	set
		MaPhieuNhap = @MaPhieuNhap,
		NgayNhap = @NgayNhap
	where (MaPhieuNhap = @MaPhieuNhap)
END
GO

CREATE PROCEDURE PhieuThuTien_Update
@MaPhieuThuTien nvarchar(10),
@SoTienThu float,
@MaKhachHang nvarchar(10),
@NgayThu smalldatetime
AS
BEGIN
	update PHIEUTHUTIEN
	set
		MaPhieuThuTien = @MaPhieuThuTien,
		SoTienThu = @SoTienThu,
		MaKhachHang = @MaKhachHang,
		NgayThu = @NgayThu
	where (MaPhieuThuTien = @MaPhieuThuTien)
END
GO

CREATE PROCEDURE Sach_Update
@MaSach nvarchar(10),
@TenSach nvarchar(100),
@TheLoai nvarchar(50),
@TacGia nvarchar(50),
@NamXuatBan int,
@SoLuongTon int,
@DonGiaBan float
AS
BEGIN
	update SACH
	set
		MaSach = @MaSach,
		TenSach = @TenSach,
		TheLoai = @TheLoai,
		TacGia = @TacGia,
		NamXuatBan = @NamXuatBan,
		SoLuongTon = @SoLuongTon,
		DonGiaBan = @DonGiaBan
	where (MaSach = @MaSach)
END
GO

CREATE PROCEDURE ThamSo_Update
@MaThamSo int,
@SoLuongNhapToiThieu int,
@SoLuongTonToiDaTruocKhiNhap int,
@SoLuongTonToiThieuSauKhiBan int,
@TienNoToiDa float
AS
BEGIN
	update THAMSO
	set
		SoLuongNhapToiThieu = @SoLuongNhapToiThieu,
		SoLuongTonToiDaTruocKhiNhap = @SoLuongTonToiDaTruocKhiNhap,
		SoLuongTonToiThieuSauKhiBan = @SoLuongTonToiThieuSauKhiBan,
		TienNoToiDa = @TienNoToiDa
	where MaThamSo = @MaThamSo
END
GO

CREATE PROCEDURE BaoCaoCongNo_DeleteByMaBaoCaoCongNo
@MaBaoCaoCongNo nvarchar(10)
AS
BEGIN
	delete from BAOCAOCONGNO where (MaBaoCaoCongNo = @MaBaoCaoCongNo)
END
GO

---
CREATE PROCEDURE BaoCaoTon_DeleteByMaBaoCaoTon
@MaBaoCaoTon nvarchar(10)
AS
BEGIN
	delete from BAOCAOTON where (MaBaoCaoTon = @MaBaoCaoTon)
END
GO

---
CREATE PROCEDURE ChiTietHoaDon_DeleteByMaChIietHoaDon
@MaChiTietHoaDon nvarchar(10)
AS
BEGIN
	delete from CHITIETHOADON where (MaChiTietHoaDon = @MaChiTietHoaDon)
END
GO

---
CREATE PROCEDURE ChiTietPhieuNhap_DeleteByMaChiTietPhieuNhap
@MaChiTietPhieuNhap nvarchar(10)
AS
BEGIN
	delete from CHITIETPHIEUNHAP where (MaChiTietPhieuNhap = @MaChiTietPhieuNhap)
END
GO

---
CREATE PROCEDURE HoaDon_DeleteByMaHoaDon
@MaHoaDon nvarchar(10)
AS
BEGIN
	delete from HOADON where (MaHoaDon = @MaHoaDon)
END
GO

---
CREATE PROCEDURE KhachHang_DeleteByMaKhachHang
@MaKhachHang nvarchar(10)
AS
BEGIN
	delete from KHACHHANG where (MaKhachHang = @MaKhachHang)
END
GO

---
CREATE PROCEDURE PhieuNhap_DeleteByMaPhieuNhap
@MaPhieuNhap nvarchar(10)
AS
BEGIN
	delete from PHIEUNHAP where (MaPhieuNhap = @MaPhieuNhap)
END
GO

---
CREATE PROCEDURE PhieuThuTien_DeleteByMaPhieuThuTien
@MaPhieuThuTien nvarchar(10)
AS
BEGIN
	delete from PHIEUTHUTIEN where (MaPhieuThuTien = @MaPhieuThuTien)
END
GO

---
CREATE PROCEDURE Sach_DeleteByMaSach
@MaSach nvarchar(10)
AS
BEGIN
	delete from SACH where (MaSach = @MaSach)
END
GO
---
Create Procedure BaoCaoCongNo_SelectThang
As
Begin
	Select Thang
	From BAOCAOCONGNO
End

GO

--
Create Procedure BaoCaoCongNo_SelectAllByThang
AS
Begin	
	Select kh.HoTen, cn.NoDau, cn.NoPhatSinh, cn.NoCuoi, cn.Thang
	From BAOCAOCONGNO cn, KHACHHANG kh
	Where cn.MaKhachHang = kh.MaKhachHang
End

GO

-- 
Create Procedure BaoCaoTon_SelectAllByThang
AS
Begin 
	Select s.TenSach, t.TonDau, t.TonPhatSinh, t.TonCuoi, t.Thang
	From BAOCAOTON t, SACH s
	Where t.MaSach = s.MaSach
End

GO
--
Create Procedure BaoCaoTon_SelectThang
AS
Begin
	Select distinct Thang
	From BAOCAOTON
End

GO

insert into SACH (MaSach, TenSach, TheLoai, TacGia, NamXuatBan, SoLuongTon, DonGiaBan) values ('S1', N'Cấu trúc rời rạc', N'Sách giáo trình', N'Nguyễn Văn Cảnh', 2000, 100, 25000)
insert into SACH (MaSach, TenSach, TheLoai, TacGia, NamXuatBan, SoLuongTon, DonGiaBan) values ('S2', N'Tắt đèn', N'Sách văn học', N'Ngô Tất Tố', 2001, 50, 55000)
insert into SACH (MaSach, TenSach, TheLoai, TacGia, NamXuatBan, SoLuongTon, DonGiaBan) values ('S3', N'Tôi tài giỏi bạn cũng thế', N'Sách Kinh Tế', N'Adam Khoo', 1998, 75, 100000)

insert into KHACHHANG (MaKhachHang, HoTen, DiaChi, DienThoai, Email, SoTienNo) values ('KH1', N'Nguyễn Văn A', N'Quận 2', 01678321564, 'nguyenvana@gmail.com', 20000)
insert into KHACHHANG (MaKhachHang, HoTen, DiaChi, DienThoai, Email, SoTienNo) values ('KH2', N'Phạm Thị B', N'Quận Thủ Đức', 0987451231, 'phamthib@gmail.com', 10000)
insert into KHACHHANG (MaKhachHang, HoTen, DiaChi, DienThoai, Email, SoTienNo) values ('KH3', N'Võ Văn C', N'Quận 9', 01677853412, 'vovanc@gmail.com', 0)

insert into HOADON (MaHoaDon, MaKhachHang, NgayLap) values ('HD1', 'KH1', '10/6/2015')
insert into HOADON (MaHoaDon, MaKhachHang, NgayLap) values ('HD2', 'KH2', '12/6/2015')
insert into HOADON (MaHoaDon, MaKhachHang, NgayLap) values ('HD3', 'KH3', '14/6/2015')

insert into CHITIETHOADON (MaChiTietHoaDon, MaHoaDon, MaSach, SoLuongBan) values('CTHD1', 'HD1', 'S2', 20)
insert into CHITIETHOADON (MaChiTietHoaDon, MaHoaDon, MaSach, SoLuongBan) values('CTHD2', 'HD2', 'S1', 10)
insert into CHITIETHOADON (MaChiTietHoaDon, MaHoaDon, MaSach, SoLuongBan) values('CTHD3', 'HD3', 'S3', 35)

insert into BAOCAOCONGNO (MaBaoCaoCongNo, Thang, MaKhachHang, NoDau, NoPhatSinh, NoCuoi) values ('BCCN1', 5, 'KH1', 20000, 0, 20000)
insert into BAOCAOCONGNO (MaBaoCaoCongNo, Thang, MaKhachHang, NoDau, NoPhatSinh, NoCuoi) values ('BCCN2', 6, 'KH2', 10000, 5000, 15000)
insert into BAOCAOCONGNO (MaBaoCaoCongNo, Thang, MaKhachHang, NoDau, NoPhatSinh, NoCuoi) values ('BCCN3', 7, 'KH3', 0, 0, 0)

insert into BAOCAOTON (MaBaoCaoTon, Thang, MaSach, TonDau, TonPhatSinh, TonCuoi) values ('BCT1', 5, 'S1', 30, 0, 30)
insert into BAOCAOTON (MaBaoCaoTon, Thang, MaSach, TonDau, TonPhatSinh, TonCuoi) values ('BCT2', 5, 'S2', 40, 10, 50)
insert into BAOCAOTON (MaBaoCaoTon, Thang, MaSach, TonDau, TonPhatSinh, TonCuoi) values ('BCT3', 6, 'S3', 20, 5, 25)
insert into BAOCAOTON (MaBaoCaoTon, Thang, MaSach, TonDau, TonPhatSinh, TonCuoi) values ('BCT4', 7, 'S2', 10, 0, 10)

insert into PHIEUNHAP (MaPhieuNhap, NgayNhap) values('PN1', '15/6/2015')
insert into PHIEUNHAP (MaPhieuNhap, NgayNhap) values('PN2', '16/6/2015')
insert into PHIEUNHAP (MaPhieuNhap, NgayNhap) values('PN3', '17/6/2015')

insert into CHITIETPHIEUNHAP (MaChiTietPhieuNhap, MaPhieuNhap, MaSach, SoLuongNhap, DonGiaNhap) values ('CTPN1', 'PN1', 'S1', 200, 25000)
insert into CHITIETPHIEUNHAP (MaChiTietPhieuNhap, MaPhieuNhap, MaSach, SoLuongNhap, DonGiaNhap) values ('CTPN2', 'PN2', 'S2', 300, 55000)
insert into CHITIETPHIEUNHAP (MaChiTietPhieuNhap, MaPhieuNhap, MaSach, SoLuongNhap, DonGiaNhap) values ('CTPN3', 'PN3', 'S3', 150, 100000)

insert into PHIEUTHUTIEN (MaPhieuThuTien, SoTienThu, MaKhachHang, NgayThu) values ('PTT1', 1100000, 'KH1', '10/6/2015')
insert into PHIEUTHUTIEN (MaPhieuThuTien, SoTienThu, MaKhachHang, NgayThu) values ('PTT2', 250000, 'KH1', '12/6/2015')
insert into PHIEUTHUTIEN (MaPhieuThuTien, SoTienThu, MaKhachHang, NgayThu) values ('PTT3', 3500000, 'KH1', '14/6/2015')

insert into TAIKHOAN values(1,'Admin','123456',1)
insert into TAIKHOAN values(2,'NhanVien','123456',2)

insert into THAMSO values(1,150,300,20,20000)
