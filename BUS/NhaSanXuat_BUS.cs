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
   public class NhaSanXuat_BUS
    {
        NhaSanXuat_DAL NhaSanXuat_dal = new NhaSanXuat_DAL();

        public bool Them(NhaSanXuat_DTO NhaSanXuat_dto)
        {
            return NhaSanXuat_dal.Them(NhaSanXuat_dto);
        }
        public bool Sua(NhaSanXuat_DTO NhaSanXuat_dto)
        {
            return NhaSanXuat_dal.Sua(NhaSanXuat_dto);
        }
        public bool Xoa(string _maNhaSX)
        {
            return NhaSanXuat_dal.Xoa(_maNhaSX);
        }
        public DataTable TimKiem(string tenNhaSX)
        {
            return NhaSanXuat_dal.TimKiem(tenNhaSX);
        }
        public DataTable GetDaTa()
        {
            return NhaSanXuat_dal.GetDaTa();
        }
    }
}
