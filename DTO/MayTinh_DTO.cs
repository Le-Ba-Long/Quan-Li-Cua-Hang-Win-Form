using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MayTinh_DTO
    {
        private string maMT;

        public string _maMT
        {
            get { return maMT; }
            set { maMT = value; }
        }
        private string maNhaSX;

        public string _maNhaSX
        {
            get { return maNhaSX; }
            set { maNhaSX = value; }
        }
        private string tenMT;

        public string _tenMT
        {
            get { return tenMT; }
            set { tenMT = value; }
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


        public MayTinh_DTO(string mamt, string tenmt, int sl, double giaban, string manhasx)
        {
            this.maMT = mamt;
            this.tenMT = tenmt;
            this.soLuong = sl;
            this.giaBan = giaban;
            this.maNhaSX = manhasx;

        }
    }
}
