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
    public class MayTinh_BUS
    {
        MayTinh_DAL MayTinh_dal = new MayTinh_DAL();

        public bool Them(MayTinh_DTO MayTinh_dto)
        {
            return MayTinh_dal.Them(MayTinh_dto);
        }
        public bool Sua(MayTinh_DTO MayTinh_dto)
        {
            return MayTinh_dal.Sua(MayTinh_dto);
        }
        public bool Xoa(string _maMT)
        {
            return MayTinh_dal.Xoa(_maMT);
        }
        public DataTable TimKiem(string tenMT)
        {
            return MayTinh_dal.TimKiem(tenMT);
        }
        public DataTable GetNhaSX()
        {
            return MayTinh_dal.GetNhaSX();
        }
        public DataTable GetDaTa()
        {
            return MayTinh_dal.GetDaTa();
        }
    }
}
