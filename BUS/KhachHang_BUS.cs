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
   public class KhachHang_BUS
    {

       KhachHang_DAL KhachHang_dal = new KhachHang_DAL();

        public bool Them(KhachHang_DTO KhachHang_dto)
        {
            return KhachHang_dal.Them(KhachHang_dto);
        }
        public bool Sua(KhachHang_DTO KhachHang_dto)
        {
            return KhachHang_dal.Sua(KhachHang_dto);
        }
        public bool Xoa(string _maKH)
        {
            return KhachHang_dal.Xoa(_maKH);
        }
        public DataTable TimKiem(string tenKH)
        {
            return KhachHang_dal.TimKiem(tenKH);
        }
        public DataTable GetDaTa()
        {
            return KhachHang_dal.GetDaTa();
        }
    }
}
