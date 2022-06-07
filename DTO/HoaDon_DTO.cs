using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon_DTO
    {
        private string maHD;

        public string _maHD
        {
            get { return maHD; }
            set { maHD = value; }
        }
        private string maKH;

        public string _maKH
        {
            get { return maKH; }
            set { maKH = value; }
        }
        private string maNV;

        public string _maNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        private string ngayNhap;

        public string _ngayNhap
        {
            get { return ngayNhap; }
            set { ngayNhap = value; }
        }
        public HoaDon_DTO(string mahd, string makh, string manv, string ngaynhap)
        {
            this.maHD = mahd;
            this.maKH = makh;
            this.maNV = manv;
            this.ngayNhap = ngaynhap;

        }
    }
}
