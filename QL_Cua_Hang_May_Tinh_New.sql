create database Quan_Li_Cua_Hang_May_Tinh
   go
       use  Quan_Li_Cua_Hang_May_Tinh
          go
		create table NhanVien
				 (
				 MaNV char(15) primary key ,
				 TenNV nvarchar(20),
				 DiaChi nvarchar(20),
				 SDT  nvarchar(10),
				 GioiTinh  nvarchar(10)
				 )

		 create table KhachHang
				 (
				 MaKH char(15) primary key ,
				 TenKH nvarchar(20),
				 DiaChi nvarchar(20),
				 SDT  nvarchar(10),
				 GioiTinh  nvarchar(10)
				 )

		 create table NhaSanXuat
				 (
				 MaNhaSX char(15) primary key ,
				 TenNhaSX nvarchar(20),
				 DiaChi nvarchar(20),
				 SDT  nvarchar(10)
				 )

		create table MayTinh
				 (
				  MaMT char(15) primary key,
				  TenMT nvarchar(20),
				  SL int,
				  GiaBan MONEY,
				  MaNhaSX char(15),
				  constraint MaNhaSX_FK foreign key(MaNhaSX) references NhaSanXuat(MaNhaSX)
				  )

		create table HoaDon
				(
				MaHD char(15) primary key ,
				MaKH char(15),
				MaNV char(15),
				NgayNhap date,
				constraint MaNV1_FK foreign key(MaNV) references NhanVien(MaNV),
				constraint MaKH1_FK foreign key(MaKH) references KhachHang(MaKH)
				)

		create table ChiTietHoaDon
				(
				MaHD char(15),
				MaMT char(15),
				SL int,
				GiaBan MONEY,
				ThanhTien MONEY,
				constraint MaHD_MaMT primary key(MaHD,MaMT),
			    constraint MaHD_FK foreign key(MaHD) references HoaDon(MaHD),
			    constraint MaMT_FK foreign key(MaMT) references MayTinh(MaMT)

				)
				ALTER TABLE MayTinh
				  ALTER COLUMN GiaBan MONEY;

				select * from HoaDon
				select * from ChiTietHoaDon
				select * from MayTinh
				select MaHD,MaMT,SL,GiaBan,SL*GiaBan as 'ThanhTien' from ChiTietHoaDon


			-- Tổng Số Lượng Mặt Hàng Đã Bán
					select MayTinh.MaMT,TenMT, count(MayTinh.MaMT) as 'Số Lượng', sum(ChiTietHoaDon.SL) as 'Tổng'
								from MayTinh,ChiTietHoaDon
								where MayTinh.MaMT=ChiTietHoaDon.MaMT
								group by  MayTinh.MaMT,TenMT,MayTinh.SL
            -- Tính Tổng Số Khách Mua Hàng
				select count(KhachHang.MaKH)  as "Tổng Số Khách Mua Hàng Là " 
								from KhachHang, HoaDon
								where KhachHang.MaKH=HoaDon.MaKH 
						
			-- thông tin số lượng của từng mặt hàng đã bán
			select MayTinh.MaMT,TenMT, count(ChiTietHoaDon.MaHD) as 'Số Lượng' , sum(ChiTietHoaDon.SL) as 'Tổng'
			from MayTinh, ChiTietHoaDon, HoaDon 
			where MayTinh.MaMT = ChiTietHoaDon.MaMT and ChiTietHoaDon.MaHD = HoaDon.MaHD
			group by MayTinh.MaMT,TenMT
			
			--Tổng Doanh Thu Theo Tháng 
			select sum(ChiTietHoaDon.ThanhTien) as TongDoanhThu 
			from ChiTietHoaDon ,HoaDon 
			where ChiTietHoaDon.MaHD=HoaDon.MaHD and MONTH(NgayNhap)=0 and YEAR(NgayNhap)=2021

			--Tổng Doanh Thu Theo Năm 
			select sum(ChiTietHoaDon.ThanhTien) as TongDoanhThu 
			from ChiTietHoaDon ,HoaDon 
			where ChiTietHoaDon.MaHD=HoaDon.MaHD and YEAR(NgayNhap)='2021'
			-- Tổng số Khách mua Hàng
			select count(KhachHang.MaKH)  as 'Tổng Số Khách Mua Hàng Là '
			from KhachHang, HoaDon 
			where KhachHang.MaKH = HoaDon.MaKH
			-- Tổng Số Tiền Mua Của Từng Khách
			select  KhachHang.MaKH,TenKH,sum(ThanhTien) as TongTien
			from KhachHang, HoaDon,ChiTietHoaDon  
			where KhachHang.MaKH = HoaDon.MaKH  and HoaDon.MaHD = ChiTietHoaDon.MaHD
			group by KhachHang.MaKH,TenKH
			
			-- Số Lượt Mua Của Từng Khách
				select  KhachHang.MaKH,TenKH,count(KhachHang.MaKH)  as SoLanMua 
				from KhachHang, HoaDon where KhachHang.MaKH = HoaDon.MaKH 
				group by KhachHang.MaKH,TenKH

			-- Tổng Tiền Của Từng Hóa Đơn
			UPDATE ChiTietHoaDon set  ThanhTien=(SL*GiaBan)
			select MaHD,MaMT,SL,GiaBan,(SL*GiaBan) as ThanhTien  from ChiTietHoaDon 