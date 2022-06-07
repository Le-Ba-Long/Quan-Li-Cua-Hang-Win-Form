using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
  public  class ThongKe_DAL : DBconnect
    {

        public DataTable GetDaTa()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from ChiTietHoaDon ", sql_con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }
        // Thống Kê
        //  Đưa ra Thông Tin Của Từng Mặt Hàng Đã Bán
        public DataTable Get_All_MayTinh()
        {
            try
            {  
                SqlDataAdapter da = new SqlDataAdapter("select MayTinh.MaMT,TenMT, count(ChiTietHoaDon.MaHD) as 'Số Lượng' ," +
                    " sum(ChiTietHoaDon.SL) as 'Tổng' " +
                    "from MayTinh, ChiTietHoaDon, HoaDon where MayTinh.MaMT = ChiTietHoaDon.MaMT and ChiTietHoaDon.MaHD = HoaDon.MaHD   " +
                    " group by MayTinh.MaMT, TenMT", sql_con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }
        //  Đưa ra Tổng Doanh Thu Theo Tháng 
        public DataTable Get_DoanhThu_Thang(string thang, string nam)
        {
            try
            {  
                SqlDataAdapter da = new SqlDataAdapter(" select sum(ChiTietHoaDon.ThanhTien) as 'Tổng Doanh Thu' " +
                    " from ChiTietHoaDon , HoaDon " +
                    "where ChiTietHoaDon.MaHD = HoaDon.MaHD and MONTH(NgayNhap) = N'" + thang + "' and YEAR(NgayNhap) = N'" + nam + "'", sql_con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        //  Đưa ra Tổng Doanh Thu Theo Năm
        public DataTable Get_DoanhThu_Nam(string nam)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(" select sum(ChiTietHoaDon.ThanhTien) as TongDoanhThu from ChiTietHoaDon ," +
                    " HoaDon where ChiTietHoaDon.MaHD = HoaDon.MaHD and YEAR(NgayNhap) = '" + nam + "'", sql_con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }
        //
        // Đưa Ra Tổng Số Tiền Mua Của Từng Khách Hàng
        public DataTable Get_Tong_Tien_KH()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select  KhachHang.MaKH,TenKH,sum(ThanhTien) as TongTien " +
                    " from KhachHang, HoaDon, ChiTietHoaDon where KhachHang.MaKH = HoaDon.MaKH  and HoaDon.MaHD = ChiTietHoaDon.MaHD" +
                    " group by KhachHang.MaKH, TenKH", sql_con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }
        //   Tính Tổng Số Khách Mua Hàng
        public DataTable Get_TongKH()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(" select count(KhachHang.MaKH) as 'Tổng Số Khách Mua Hàng Là '" +
                    " from KhachHang, HoaDon where KhachHang.MaKH = HoaDon.MaKH ", sql_con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }
        // Số Lượt Mua Của Từng Khách Hàng
        public DataTable Get_Luot_Mua_KH()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select  KhachHang.MaKH,TenKH,count(KhachHang.MaKH)  as SoLanMua " +
                    " from KhachHang, HoaDon where KhachHang.MaKH = HoaDon.MaKH " +
                    " group by KhachHang.MaKH, TenKH", sql_con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }
        //Tổng Tiền Của Từng Hóa Đơn
        public DataTable Get_Tong_Tien_Tung_HD()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(" select MaHD,MaMT,SL,GiaBan,(SL*GiaBan) as ThanhTien  from ChiTietHoaDon ", sql_con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

    }
}
