using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang_DTO
    {
        private string maKH;

        public string _maKH
        {
            get { return maKH; }
            set { maKH = value; }
        }
        private string tenKH;

        public string _tenKH
        {
            get { return tenKH; }
            set { tenKH = value; }
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
        private string gioiTinh;

        public string _gioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }


        public KhachHang_DTO(string makh, string tenkh, string diachi, string sdt, string gioitinh)
        {
            this.maKH = makh;
            this.tenKH = tenkh;
            this.DiaChi = diachi;
            this.sodienThoai = sdt;
            this.gioiTinh = gioitinh;

        }
    }
}
