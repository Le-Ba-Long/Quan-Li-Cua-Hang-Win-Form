using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien_DTO
    {
        private string maNV;

        public string _maNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        private string tenNV;

        public string _tenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
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


        public NhanVien_DTO(string manv, string tennv, string diachi, string sdt, string gioitinh)
        {
            this.maNV = manv;
            this.tenNV = tennv;
            this.DiaChi = diachi;
            this.sodienThoai = sdt;
            this.gioiTinh = gioitinh;

        }
    }
}
