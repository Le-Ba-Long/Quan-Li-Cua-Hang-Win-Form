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
    public class NhanVien_BUS
    {

        NhanVien_DAL NhanVien_dal = new NhanVien_DAL();

        public bool Them(NhanVien_DTO NhanVien_dto)
        {
            return NhanVien_dal.Them(NhanVien_dto);
        }
        public bool Sua(NhanVien_DTO NhanVien_dto)
        {
            return NhanVien_dal.Sua(NhanVien_dto);
        }
        public bool Xoa(string _maNV)
        {
            return NhanVien_dal.Xoa(_maNV);
        }
        public DataTable TimKiem(string tenNV)
        {
            return NhanVien_dal.TimKiem(tenNV);
        }
        public DataTable GetDaTa()
        {
            return NhanVien_dal.GetDaTa();
        }
    }
}
