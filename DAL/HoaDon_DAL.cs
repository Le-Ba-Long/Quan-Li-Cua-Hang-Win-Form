using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public  class HoaDon_DAL : DBconnect
    {
        public DataTable GetKhachHang()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from KhachHang ", sql_con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }
        public DataTable TimKiem(string maHD)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from HoaDon where MaHD like  N'%" + maHD + "%'", sql_con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }
        public DataTable GetNhanVien()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from NhanVien ", sql_con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }
        public DataTable GetDaTa()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from HoaDon ", sql_con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        DataTable dt = new DataTable();
        public HoaDon_DAL()
        {
            dt = GetDaTa();
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
        }

        public bool Them(HoaDon_DTO HoaDon_dto)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from HoaDon", sql_con);


                DataRow r = dt.NewRow();

                r["MaHD"] = HoaDon_dto._maHD;
                r["MaKH"] = HoaDon_dto._maKH;
                r["MaNV"] = HoaDon_dto._maNV;
                r["NgayNhap"] = HoaDon_dto._ngayNhap;
                dt.Rows.Add(r);
                SqlCommandBuilder cm = new SqlCommandBuilder(da);
                da.Update(dt);
                return true;

            }
            catch
            {

                return false;
            }
        }

        public bool Xoa(string _maHD)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from HoaDon", sql_con);
                DataRow r = dt.Rows.Find(_maHD);
                if (r != null)
                {

                    r.Delete();
                }
                SqlCommandBuilder cm = new SqlCommandBuilder(da);
                da.Update(dt);

                return true;
            }
            catch
            {

                return false;
            }
        }
        public bool Sua(HoaDon_DTO HoaDon_dto)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from HoaDon", sql_con);
                DataRow r = dt.Rows.Find(HoaDon_dto._maHD);
                if (r != null)
                {
                    r["MaHD"] = HoaDon_dto._maHD;
                    r["MaKH"] = HoaDon_dto._maKH;
                    r["MaNV"] = HoaDon_dto._maNV;
                    r["NgayNhap"] = HoaDon_dto._ngayNhap;
                   
                }
                SqlCommandBuilder cm = new SqlCommandBuilder(da);
                da.Update(dt);

                return true;
            }
            catch
            {

                return false;
            }
        }

    }
}
