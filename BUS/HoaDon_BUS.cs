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
   public  class HoaDon_BUS
    {
        HoaDon_DAL HoaDon_dal = new HoaDon_DAL();

        public bool Them(HoaDon_DTO HoaDon_dto)
        {
            return HoaDon_dal.Them(HoaDon_dto);
        }
        public bool Sua(HoaDon_DTO HoaDon_dto)
        {
            return HoaDon_dal.Sua(HoaDon_dto);
        }
        public bool Xoa(string _maHD)
        {
            return HoaDon_dal.Xoa(_maHD);
        }
        public DataTable TimKiem(string maHD)
        {
            return HoaDon_dal.TimKiem(maHD);
        }
        public DataTable GetDaTa()
        {
            return HoaDon_dal.GetDaTa();
        }
        public DataTable GetKhachHang()
        {
            return HoaDon_dal.GetKhachHang();
        }
        public DataTable GetNhanVien()
        {
            return HoaDon_dal.GetNhanVien();

        }
        
        }
}
