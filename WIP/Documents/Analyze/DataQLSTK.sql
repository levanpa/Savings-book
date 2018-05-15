use QuanLySoTietKiem

Go
set dateformat dmy

GO
insert into khachhang values('KH01','Nguyen Van An','731 Tran Hung Dao, Q5, TpHCM','0982423451', 'Nam','22/07/1986','197400522')
insert into khachhang values('KH02','Tran Van Nam','23/5 Nguyen Trai, Q5, TpHCM','0908256478', 'Nam','30/07/1982','197401348')
insert into khachhang values('KH03','Tran Ngoc Linh','45 Nguyen Canh Chan, Q1, TpHCM','0938776266', N'Nữ','08/05/1983','197400332')

Go
insert into loaitk values('LTK01','Tiet kiem co ky han 3 thang',0.48, '3 Thang')
insert into loaitk values('LTK02','Tiet kiem co ky han 6 thang',0.53, '6 Thang')
insert into loaitk values('LTK03','Tiet kiem co ky han 12 thang',0.66, '12 Thang')
insert into loaitk values('LTK04','Tiet kiem khong ky han',0.3, 'Khong co ky han')


GO
insert into STK values('STK01','KH01','LTK01', '1/07/2017', '1/07/2017', '1/11/2017', 2000000)
insert into STK values('STK02','KH02','LTK02', '1/08/2016', '1/08/2016', '1/02/2017', 40000000)
insert into STK values('STK03','KH03','LTK03', '1/03/2016', '1/03/2016', NULL, 80000000)

GO
insert into QUAYGD values('QGD01','Quay giao dich tiet kiem ky han 3 thang')
insert into QUAYGD values('QGD02','Quay giao dich tiet kiem ky han 6 thang')
insert into QUAYGD values('QGD03','Quay giao dich tiet kiem khong ky han')

GO
insert into ACCOUNT values('TK01', 'taikhoan01','123456789')
insert into ACCOUNT values('TK02', 'taikhoan02','123456789')
insert into ACCOUNT values('TK03', 'taikhoan03','123456789')

GO
insert into GIAODICHVIEN values('GDV01', NULL,'Le Nhat Minh','34 Truong Dinh, Q3, TpHCM','08246108', 'Nam', '09/11/1983', '197300549', 'TK01')
insert into GIAODICHVIEN values('GDV02',NULL,'Nguyen Van Tam','32/3 Tran Binh Trong, Q5, TpHCM','0916783565', N'Nữ', '24/03/1984', '197300579','TK02')
insert into GIAODICHVIEN values('GDV03',NULL,'Phan Thi Thanh','45/2 An Duong Vuong, Q5, TpHCM','0938435756', N'Nữ', '14/02/1982', '197300226', 'TK03')

GO
insert into GIAODICH values('GD01', 'GDV01','KH01', 'QGD01', '1/07/2017', 'Mo tai khoan')
insert into GIAODICH values('GD02','GDV02','KH02', 'QGD02', '1/08/2016', 'Mo tai khoan')
insert into GIAODICH values('GD03','GDV03','KH03', 'QGD03', '1/03/2016', 'Mo tai khoan')

GO
insert into PHONGBAN values('PH01', '873 Le Hong Phong, Q5, TpHCM','GDV01','02/12/2017')
insert into PHONGBAN values('PH02', '34/34B Nguyen Trai, Q1, TpHCM','GDV02', '14/12/2015')
insert into PHONGBAN values('PH03', '50/34 Le Dai Hanh, Q10, TpHCM','GDV03', '04/08/2016')

GO
update GIAODICHVIEN
Set MAPHONG = 'PH01'
where MAGDV = 'GDV01'

GO
update GIAODICHVIEN
Set MAPHONG = 'PH02'
where MAGDV = 'GDV02'

GO
update GIAODICHVIEN
Set MAPHONG = 'PH03'
where MAGDV = 'GDV03'

-------Phần sửa lại ()
--GO
--use QuanLySoTietKiem

--Go
--insert into loaitk values('LTK04','Tiet kiem co ky han 12 thang',0.66, '12 Thang')

--GO
--update loaitk
--Set LAISUAT = 0.48
--where MALOAITK = 'LTK01'

--GO
--update loaitk
--Set LAISUAT = 0.53
--where MALOAITK = 'LTK02'

--GO
--update loaitk
--Set LAISUAT = 0.3
--where MALOAITK = 'LTK03'

--GO
--Alter table stk
--alter column sodu decimal

--GO
--Alter table loaitk
--alter column laisuat float
