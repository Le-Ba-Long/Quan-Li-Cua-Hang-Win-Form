using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
namespace BUS
{
   public class ThongKe_BUS
    {
        ThongKe_DAL thongKe_DAL = new ThongKe_DAL();

        public DataTable GetDaTa()
        {
            return thongKe_DAL.GetDaTa();

        }
        public DataTable Get_All_MayTinh()
        {
            return thongKe_DAL.Get_All_MayTinh();

        }
        public DataTable Get_DoanhThu_Thang(string thang, string nam)
        {
            return thongKe_DAL.Get_DoanhThu_Thang(thang, nam);
        }

        public DataTable Get_DoanhThu_Nam(string nam)
        {
            return thongKe_DAL.Get_DoanhThu_Nam(nam);

        }
        public DataTable Get_Tong_Tien_KH()
        {
            return thongKe_DAL.Get_Tong_Tien_KH();

        }
        public DataTable Get_TongKH()
        {
            return thongKe_DAL.Get_TongKH();

        }
        public DataTable Get_Luot_Mua_KH()
        {
            return thongKe_DAL.Get_Luot_Mua_KH();

        }
        public DataTable Get_Tong_Tien_Tung_HD()
        {
            return thongKe_DAL.Get_Tong_Tien_Tung_HD();

        }
    }
}
