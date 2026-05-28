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

CREATE TABLE taikhoanquanly (
    tendangnhap NVARCHAR(50) NOT NULL PRIMARY KEY,
    matkhau NVARCHAR(50) NOT NULL,
    vaitro NVARCHAR(20) NOT NULL
);

INSERT INTO taikhoanquanly (tendangnhap, matkhau, vaitro)
VALUES ('admin', '1', 'admin');
INSERT INTO taikhoanquanly (tendangnhap, matkhau, vaitro)
VALUES ('nhanvien', '1', 'nhanvien');

select * from ttMayTram
select * from taikhoan

select a.somay, a.tenmay, a.trangthai, b.tendangnhap
from ttMayTram as a
left join taikhoan as b on a.somay = b.somay


ALTER TABLE taikhoan ADD somay nchar(10);
GO
ALTER TABLE taikhoan ADD batdauluc DATETIME;
GO


SELECT tendangnhap, batdauluc FROM taikhoan;


INSERT INTO ttMayTram (somay, tenmay, trangthai)
VALUES 
('M11', N'Máy số 11', N'Tắt'),
('M12', N'Máy số 12', N'Tắt'),
('M13', N'Máy số 13', N'Tắt'),
('M14', N'Máy số 14', N'Tắt'),
('M15', N'Máy số 15', N'Tắt');


create table menudichvu (
	id int IDENTITY(1,1) PRIMARY KEY,
	tenmon nvarchar(50) not null,
	dongia int not null default 0,
	soluong int not null default 0
);

alter table menudichvu add hinhanh nvarchar(100);

select * from menudichvu




create table lichsunaptien(
	id_nap int identity(1,1) primary key,
	tendangnhap nvarchar(50) not null,
	sotiennap int not null,
	thoigiannap datetime default getdate(),
	ghichu nvarchar(200),
	constraint fk_lichsunap_taikhoan foreign key (tendangnhap)
		references taikhoan(tendangnhap)
);

select * from lichsunaptien


select * from menudichvu

INSERT INTO menudichvu (tenmon, dongia, soluong, hinhanh)
VALUES 
(N'Combo Burger + coca', 55000, 100, 'comboberger+coca.jpg'),
(N'Pepsi', 15000, 100, 'pepsi.jpg'),
(N'Sting đỏ', 15000, 100, 'siting.jpg'),
(N'Sprite', 15000, 100, 'spaite.jpg'),
(N'Bánh mì', 15000, 30, 'anhbanhmyyoung.jpg'),
(N'Mì tôm', 20000, 100, 'mytom.jpg'),
(N'Bánh mì xúc xích', 25000, 30, 'banhmyxuccich.jpg'),
(N'Bia', 20000, 50, 'bia.jpg'),
(N'Coca', 15000, 50, 'coca.jpg');


CREATE TABLE lichsugiochoi (
    id INT IDENTITY(1,1) PRIMARY KEY,
    tendangnhap NVARCHAR(50) NOT NULL,
    somay NCHAR(10) NOT NULL,
    batdauluc DATETIME NOT NULL,
    ketthuc DATETIME NOT NULL,
    thoigianchoi NVARCHAR(50),
    sotienchu INT NOT NULL DEFAULT 0,
    CONSTRAINT fk_lichsugiochoi_taikhoan FOREIGN KEY (tendangnhap)
        REFERENCES taikhoan(tendangnhap)
);
-- ttMayTram -> lichsugiochoi
ALTER TABLE lichsugiochoi
ADD CONSTRAINT fk_lichsugiochoi_maytram 
FOREIGN KEY (somay) REFERENCES ttMayTram(somay);

-- ttMayTram -> taikhoan (somay trong taikhoan trỏ về ttMayTram)
ALTER TABLE taikhoan
ADD CONSTRAINT fk_taikhoan_maytram 
FOREIGN KEY (somay) REFERENCES ttMayTram(somay);

SELECT 
    fk.name AS foreign_key,
    tp.name AS parent_table,
    tr.name AS referenced_table
FROM sys.foreign_keys fk
JOIN sys.tables tp ON fk.parent_object_id = tp.object_id
JOIN sys.tables tr ON fk.referenced_object_id = tr.object_id;

select * from menudichvu