using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDon_DTO
    {
        private string maHD;

        public string _maHD
        {
            get { return maHD; }
            set { maHD = value; }
        }
        private string maMT;

        public string _maMT
        {
            get { return maMT; }
            set { maMT = value; }
        }
        private int soLuong;

        public int _soLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        private double giaBan;

        public double _giaBan
        {
            get { return giaBan; }
            set { giaBan = value; }
        }
        private double thanhTien;

        public double _thanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }
        public ChiTietHoaDon_DTO(string mahd, string mamt, int sl, double giaban, double thanhtien)
        {
            this.maHD = mahd;
            this.maMT = mamt;
            this.soLuong = sl;
            this.giaBan = giaban;
            this.thanhTien = thanhtien;

        }
    }
}
