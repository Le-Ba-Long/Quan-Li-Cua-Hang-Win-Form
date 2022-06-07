using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public  class NhaSanXuat_DTO
    {
        private string maNhaSX;

        public string _maNhaSX
        {
            get { return maNhaSX; }
            set { maNhaSX = value; }
        }
        private string tenNhaSX;

        public string _tenNhaSX
        {
            get { return tenNhaSX; }
            set { tenNhaSX = value; }
        }
        private string DiaChi;

        public string _diaChi
        {
            get { return DiaChi; }
            set { DiaChi = value; }
        }

        private string sodienThoai;

        public string _sodienThoai
        {
            get { return sodienThoai; }
            set { sodienThoai = value; }
        }

        public NhaSanXuat_DTO(string manhasx, string tennhasx, string diachi, string sdt)
        {
            this.maNhaSX = manhasx;
            this.tenNhaSX = tennhasx;
            this.DiaChi = diachi;
            this.sodienThoai = sdt;

        }
    }
}
