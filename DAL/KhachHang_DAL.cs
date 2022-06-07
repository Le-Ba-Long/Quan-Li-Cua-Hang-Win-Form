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
   public  class KhachHang_DAL : DBconnect
    {
        public DataTable GetDaTa()
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
        public DataTable TimKiem(string tenKH)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from KhachHang where TenKH like  N'%" + tenKH + "%'", sql_con);
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

        public KhachHang_DAL()
        {
            dt = GetDaTa();
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
        }

        public bool Them(KhachHang_DTO KhachHang_dto)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from KhachHang", sql_con);
                DataRow r = dt.NewRow();

                r["MaKH"] = KhachHang_dto._maKH;
                r["TenKH"] = KhachHang_dto._tenKH;
                r["DiaChi"] = KhachHang_dto._diaChi;
                r["SDT"] = KhachHang_dto._sodienThoai;
                r["GioiTinh"] = KhachHang_dto._gioiTinh;

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

        public bool Xoa(string _maKH)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from KhachHang", sql_con);
                DataRow r = dt.Rows.Find(_maKH);
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
    
        public bool Sua(KhachHang_DTO KhachHang_dto)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from KhachHang", sql_con);
                DataRow r = dt.Rows.Find(KhachHang_dto._maKH);
                if (r != null)
                {

                    r["MaKH"] = KhachHang_dto._maKH;
                    r["TenKH"] = KhachHang_dto._tenKH;
                    r["DiaChi"] = KhachHang_dto._diaChi;
                    r["SDT"] = KhachHang_dto._sodienThoai;
                    r["GioiTinh"] = KhachHang_dto._gioiTinh;
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
