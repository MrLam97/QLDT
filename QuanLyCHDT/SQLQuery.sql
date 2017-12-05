use QLCHDT
go
------------------------Thêm hãng sản xuất
alter proc ThemHangSX
@MaH nvarchar(20),
@TenH nvarchar(20)
as
begin
insert into HangSX values(@MaH,@TenH)
end
go
------------------------Xuất hãng sản xuất
alter proc HienHangSX
as
begin
select * from HangSX
end
go
------------------------Xóa hãng sản xuất
create proc XoaHangSX
@MaH nvarchar(20),
@TenH nvarchar(20)
as
begin
delete from HangSX where MaH = @MaH and TenH = @TenH
end
go
--------------------------Sửa thông tin hãng sản xuất
--create proc SuaHangSX
--@Mah nvarchar(20),
--@TenH nvarchar(20),
--@Mah1 nvarchar(20),
--@TenH1 nvarchar(20)
--as
--begin
--update HangSX set Mah=@Mah, TenH=@TenH where MaH=@Mah1 and TenH=@TenH1
--end
--go
--------------------------Tìm hãng sản xuất
create proc TimHangSX
@TenH nvarchar(20)
as
begin
select * from HangSX where TenH=@TenH 
end
go
--------------------------Nhập máy
create proc NhapMay
@MaM nvarchar(20),
@MaH nvarchar(20),
@TenM nvarchar(20),
@Gia money,
@SoLuongTon int,
@TGBH int,
@DungLuong int
as
begin
insert into LoaiMay values(@MaM,@MaH,@TenM,@Gia,@SoLuongTon,@TGBH,@DungLuong)
end
go
-------------------------xuất máy
create proc XuatTTMay
as
begin
select * from LoaiMay
end
go
-------------------------Nhập chi tiết máy
create proc NhapCTMay
@Imei nvarchar(20),
@MaM nvarchar(20),
@Mau nvarchar(15),
@DaBan bit
as
begin
insert into ChiTietMay values(@Imei,@MaM,@Mau,@DaBan)
end
go
--------------------------Nhập số lượng tồn
alter proc SoLuongTon
@MaM nvarchar(20)
as
begin
select COUNT(DaBan) from ChiTietMay c, LoaiMay l where DaBan='False' and c.MaM = l.MaM and l.MaM=@MaM
end
go
-------------------------Cập nhật số lượng tồn
create proc CapNhatSLT
@SoLuongTon int,
@MaM nvarchar(20)
as
begin
update LoaiMay set SoLuongTon = @SoLuongTon where MaM=@MaM
end
go
-------------------------Lấy dung lượng
create proc LayDL
as
begin
select distinct DungLuong from LoaiMay
end
go
-------------------------Lấy màu
create proc LayMau
as
begin
select distinct Mau from ChiTietMay
end
go
--------------------------Thêm nhân viên
alter proc ThemNV
@MaNV nvarchar(20),
@TenNV nvarchar(50),
@PassNV nvarchar(20),
@SDTNV nvarchar(12)
as
begin
insert into NhanVien values(@MaNV,@TenNV,@PassNV,@SDTNV)
end
go
-------------------------Đổi mật khẩu nhân viên
create proc DoiMK
@MaNV nvarchar(20),
@PassNV nvarchar(20),
@Pass nvarchar(20)
as
begin
update NhanVien set PassNV = @Pass where MaNV = @MaNV and PassNV=@PassNV
end
go
------------------------Tra cứu máy theo hãng
create proc HienMayTheoHSX
@MaH nvarchar(20)
as
begin
select * from LoaiMay where MaH=@MaH
end
go
------------------------Tra cứu chi tiết máy theo mã máy
create proc CTMTheoMaM
@MaM nvarchar(20)
as
begin
select * from ChiTietMay where MaM=@MaM
end
go
------------------------