using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
   public  class ChiTietHoaDon_BUS
    {
        ChiTietHoaDon_DAL ChiTietHoaDon_dal = new ChiTietHoaDon_DAL();

        public bool Them(ChiTietHoaDon_DTO ChiTietHoaDon_dto)
        {
            return ChiTietHoaDon_dal.Them(ChiTietHoaDon_dto);
        }
        public bool Sua(ChiTietHoaDon_DTO ChiTietHoaDon_dto)
        {
            return ChiTietHoaDon_dal.Sua(ChiTietHoaDon_dto);
        }
        public bool Xoa(string _maHD)
        {
            return ChiTietHoaDon_dal.Xoa(_maHD);
        }
        public DataTable TimKiem(string maHD)
        {
            return ChiTietHoaDon_dal.TimKiem(maHD);
        }
        public DataTable GetDaTa()
        {
            return ChiTietHoaDon_dal.GetDaTa();
        }
        public DataTable GetMayTinh()
        {
            return ChiTietHoaDon_dal.GetMayTinh();
        }
        public DataTable GetHoaDon()
        {
            return ChiTietHoaDon_dal.GetHoaDon();
        }
        public DataTable Getupdate()
        {
            return ChiTietHoaDon_dal.GetUpdate();
        }
    }
}
