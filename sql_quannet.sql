create database winform;
go 
use winform
go 

create table taikhoan (
	tendangnhap nvarchar(50) not null,
	matkhau nvarchar(50) not null,
	sodu int default 0,
	constraint pk_taikhoan primary key (tendangnhap)
);
go

ALTER TABLE taikhoan ADD tongtiennap INT DEFAULT 0;
ALTER TABLE taikhoan ADD tongtiendung INT DEFAULT 0;

create table ttMayTram (
	somay nchar(10) primary key,
	tenmay nvarchar(50),
	trangthai nvarchar(20)
);

-- Thêm ràng buộc: Chỉ cho phép nhập 'Tắt' hoặc N'Đang mở'
ALTER TABLE ttMayTram
ADD CONSTRAINT CHK_TrangThai 
CHECK (trangthai IN (N'Tắt', N'Đang mở'));

create trigger checksodu
on taikhoan
after update
as 
begin
	if exists (select 1 from inserted where sodu < 0)
	begin 
		raiserror (N'lỗi: tài khoản không đủ tiền', 16,1);
		rollback tran;
	end
end;


select * from taikhoan

select a.somay, a.tenmay, a.trangthai, b.tendangnhap
from ttMayTram as a
left join taikhoan as b on a.somay = b.somay


ALTER TABLE taikhoan ADD somay nchar(10);
GO

-- Thêm cột lưu giờ bắt đầu vào bảng tài khoản
ALTER TABLE taikhoan ADD batdauluc DATETIME;
GO

select * from ttMayTram
select * from taikhoan

SELECT tendangnhap, batdauluc FROM taikhoan;

update taikhoan set sodu = 0;
update taikhoan set	tongtiendung = 0;
UPDATE taikhoan SET tongtiennap = 0 WHERE tongtiennap IS NULL;
UPDATE taikhoan SET tongtiendung = 0 WHERE tongtiendung IS NULL;


INSERT INTO ttMayTram (somay, tenmay, trangthai)
VALUES 
('M11', N'Máy số 11', N'Tắt'),
('M12', N'Máy số 12', N'Tắt'),
('M13', N'Máy số 13', N'Tắt'),
('M14', N'Máy số 14', N'Tắt'),
('M15', N'Máy số 15', N'Tắt');