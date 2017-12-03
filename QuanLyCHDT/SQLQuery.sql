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
--------------------------

