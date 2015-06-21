Use master
Go
Drop Database QuanLyNhaSachMaintenance
Go
Create Database QuanLyNhaSachMaintenance
Go
Use QuanLyNhaSachMaintenance
Go

--Create Table SACH
Create Table SACH
(
	MaSach char(10) primary key,
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
	MaKhachHang char(10) primary key,
	HoTen nvarchar(50),
	DiaChi nvarchar(100),
	DienThoai int,
	Email nvarchar(50),
	SoTienNo float
)

--Create Table HOADON
Create Table HOADON
(
	MaHoaDon char(10) primary key,
	MaKhachHang char(10) foreign key references KHACHHANG(MaKhachHang),
	NgayLap smalldatetime
)

--Create Table CHITIETHOADON
Create Table CHITIETHOADON
(
	MaChiTietHoaDon char(10) primary key,
	MaHoaDon char(10) foreign key references HOADON(MaHoaDon),
	MaSach char(10) foreign key references SACH(MaSach),
	SoLuongBan int
)

--Create Table BAOCAOCONGNO
Create Table BAOCAOCONGNO
(
	MaBaoCaoCongNo char(10) primary key,
	Thang int,
	MaKhachHang char(10) foreign key references KHACHHANG(MaKhachHang),
	NoDau float,
	NoPhatSinh float,
	NoCuoi float
)

--Create Table BAOCAOTON
Create Table BAOCAOTON
(
	MaBaoCaoTon char(10) primary key,
	Thang int,
	MaSach char(10) foreign key references SACH(MaSach),
	TonDau int,
	TonPhatSinh int,
	TonCuoi int
)

--Create Table PHIEUNHAP
Create Table PHIEUNHAP
(
	MaPhieuNhap char(10) primary key,
	NgayNhap smalldatetime
)	

--Create Table CHITIETPHIEUNHAP
Create Table CHITIETPHIEUNHAP
(
	MaChiTietPhieuNhap char(10) primary key,
	MaPhieuNhap char(10) foreign key references PHIEUNHAP(MaPhieuNhap),
	MaSach char(10) foreign key references SACH(MaSach),
	SoLuongNhap int,
	DonGiaNhap float
)

--Create Table PHIEUTHUTIEN
Create Table PHIEUTHUTIEN
(
	MaPhieuThuTien char(10) primary key,
	SoTienThu float,
	MaKhachHang char(10) foreign key references KHACHHANG(MaKhachHang),
	NgayThu smalldatetime
)

Create Table THAMSO
(
	MaThamSo int identity(1,1) primary key,
	SoLuongNhapToiThieu int,
	SoLuongTonToiDaTruocKhiNhap int,
	SoLuongTonToiThieuSauKhiBan int,
	TienNoToiDa float
)
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
@MaBaoCaoCongNo char(10)
AS
BEGIN
	select * from BAOCAOCONGNO where MaBaoCaoCongNo = @MaBaoCaoCongNo
END
GO

---
CREATE PROCEDURE BaoCaoTon_SelectByMaBaoCaoTon
@MaBaoCaoTon char(10)
AS
BEGIN
	select * from BAOCAOTON where MaBaoCaoTon = @MaBaoCaoTon
END
GO

---
CREATE PROCEDURE ChiTietHoaDon_SelectByMaChiTietHoaDon
@MaChiTietHoaDon char(10)
AS
BEGIN
	select * from CHITIETHOADON where MaChiTietHoaDon = @MaChiTietHoaDon
END
GO

---
CREATE PROCEDURE ChiTietPhieuNhap_SelectByMaChiTietPhieuNhap
@MaChiTietPhieuNhap char(10)
AS
BEGIN
	select * from CHITIETPHIEUNHAP where MaChiTietPhieuNhap = @MaChiTietPhieuNhap
END
GO

---
CREATE PROCEDURE HoaDon_SelectByMaHoaDon
@MaHoaDon char(10)
AS
BEGIN
	select * from HOADON where MaHoaDon = @MaHoaDon
END
GO

---
CREATE PROCEDURE KhachHang_SelectByMaKhachHang
@MaKhachHang char(10)
AS
BEGIN
	select * from KHACHHANG where MaKhachHang = @MaKhachHang
END
GO

---
CREATE PROCEDURE PhieuNhap_SelectByPhieuNhap
@MaPhieuNhap char(10)
AS
BEGIN
	select * from PHIEUNHAP where MaPhieuNhap = @MaPhieuNhap
END
GO

---
CREATE PROCEDURE PhieuThuTien_SelectByMaPhieuThuTien
@MaPhieuThuTien char(10)
AS
BEGIN
	select * from PHIEUTHUTIEN where MaPhieuThuTien = @MaPhieuThuTien
END
GO

---
CREATE PROCEDURE Sach_SelectByMaSach
@MaSach char(10)
AS
BEGIN
	select * from SACH where MaSach = @MaSach
END
GO

---
CREATE PROCEDURE ThamSo_SelectByMaThamSo
@MaThamSo int
AS
BEGIN
	select * from THAMSO where MaThamSo = @MaThamSo
END
GO

CREATE PROCEDURE BaoCaoCongNo_Insert
@MaBaoCaoCongNo char(10),
@Thang int,
@MaKhachHang char(10),
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
@MaBaoCaoTon char(10),
@Thang int,
@MaSach char(10),
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
@MaChiTietHoaDon char(10),
@MaHoaDon char(10),
@MaSach char(10),
@SoLuongBan int
AS
BEGIN
	insert into CHITIETHOADON (MaChiTietHoaDon, MaHoaDon, MaSach, SoLuongBan)
	values (@MaChiTietHoaDon, @MaHoaDon, @MaSach, @SoLuongBan)
END
GO

---
CREATE PROCEDURE ChiTietPhieuNhap_Insert
@MaChiTietPhieuNhap char(10),
@MaPhieuNhap char(10),
@MaSach char(10),
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
@MaHoaDon char(10),
@MaKhachHang char(10),
@NgayLap smalldatetime
AS
BEGIN
	insert into HOADON (MaHoaDon, MaKhachHang, NgayLap)
	values (@MaHoaDon, @MaKhachHang, @NgayLap)
END
GO

---
CREATE PROCEDURE KhachHang_Insert
@MaKhachHang char(10),
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
@MaPhieuNhap char(10),
@NgayNhap smalldatetime
AS
BEGIN
	insert into PHIEUNHAP (MaPhieuNhap, NgayNhap)
	values (@MaPhieuNhap, @NgayNhap)
END
GO

---
CREATE PROCEDURE PhieuThuTien_Insert
@MaPhieuThuTien char(10),
@SoTienThu float,
@MaKhachHang char(10),
@NgayThu smalldatetime
AS
BEGIN
	insert into PHIEUTHUTIEN (MaPhieuThuTien, SoTienThu, MaKhachHang, NgayThu)
	values (@MaPhieuThuTien, @SoTienThu, @MaKhachHang, @NgayThu)
END
GO

---
CREATE PROCEDURE Sach_Insert
@MaSach char(10),
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
CREATE PROCEDURE ThamSo_Insert
@MaThamSo int,
@SoLuongNhapToiThieu int,
@SoLuongTonToiDaTruocKhiNhap int,
@SoLuongTonToiThieuSauKhiBan int,
@TienNoToiDa float
AS
BEGIN
	insert into THAMSO (MaThamSo, SoLuongNhapToiThieu, SoLuongTonToiDaTruocKhiNhap, SoLuongTonToiThieuSauKhiBan, TienNoToiDa)
	values (@MaThamSo, @SoLuongNhapToiThieu, @SoLuongTonToiDaTruocKhiNhap, @SoLuongTonToiThieuSauKhiBan, @TienNoToiDa)
END
GO

---
CREATE PROCEDURE BaoCaoCongNo_Update
@MaBaoCaoCongNo char(10),
@Thang int,
@MaKhachHang char(10),
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
@MaBaoCaoTon char(10),
@Thang int,
@MaSach char(10),
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
@MaChiTietHoaDon char(10),
@MaHoaDon char(10),
@MaSach char(10),
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
@MaChiTietPhieuNhap char(10),
@MaPhieuNhap char(10),
@MaSach char(10),
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
@MaHoaDon char(10),
@MaKhachHang char(10),
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
@MaKhachHang char(10),
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
@MaPhieuNhap char(10),
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
@MaPhieuThuTien char(10),
@SoTienThu float,
@MaKhachHang char(10),
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
@MaSach char(10),
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
	where (MaThamSo = @MaThamSo)
END
GO

CREATE PROCEDURE BaoCaoCongNo_DeleteByMaBaoCaoCongNo
@MaBaoCaoCongNo char(10)
AS
BEGIN
	delete from BAOCAOCONGNO where (MaBaoCaoCongNo = @MaBaoCaoCongNo)
END
GO

---
CREATE PROCEDURE BaoCaoTon_DeleteByMaBaoCaoTon
@MaBaoCaoTon char(10)
AS
BEGIN
	delete from BAOCAOTON where (MaBaoCaoTon = @MaBaoCaoTon)
END
GO

---
CREATE PROCEDURE ChiTietHoaDon_DeleteByMaChIietHoaDon
@MaChiTietHoaDon char(10)
AS
BEGIN
	delete from CHITIETHOADON where (MaChiTietHoaDon = @MaChiTietHoaDon)
END
GO

---
CREATE PROCEDURE ChiTietPhieuNhap_DeleteByMaChiTietPhieuNhap
@MaChiTietPhieuNhap char(10)
AS
BEGIN
	delete from CHITIETPHIEUNHAP where (MaChiTietPhieuNhap = @MaChiTietPhieuNhap)
END
GO

---
CREATE PROCEDURE HoaDon_DeleteByMaHoaDon
@MaHoaDon char(10)
AS
BEGIN
	delete from HOADON where (MaHoaDon = @MaHoaDon)
END
GO

---
CREATE PROCEDURE KhachHang_DeleteByMaKhachHang
@MaKhachHang char(10)
AS
BEGIN
	delete from KHACHHANG where (MaKhachHang = @MaKhachHang)
END
GO

---
CREATE PROCEDURE PhieuNhap_DeleteByMaPhieuNhap
@MaPhieuNhap char(10)
AS
BEGIN
	delete from PHIEUNHAP where (MaPhieuNhap = @MaPhieuNhap)
END
GO

---
CREATE PROCEDURE PhieuThuTien_DeleteByMaPhieuThuTien
@MaPhieuThuTien char(10)
AS
BEGIN
	delete from PHIEUTHUTIEN where (MaPhieuThuTien = @MaPhieuThuTien)
END
GO

---
CREATE PROCEDURE Sach_DeleteByMaSach
@MaSach char(10)
AS
BEGIN
	delete from SACH where (MaSach = @MaSach)
END
GO
