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
   public  class NhanVien_DAL : DBconnect
    {
        public DataTable GetDaTa()
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
        public DataTable TimKiem(string tenNV)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from NhanVien where TenNV like  N'%" + tenNV + "%'", sql_con);
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

        public NhanVien_DAL()
        {
            dt = GetDaTa();
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
        }

        public bool Them(NhanVien_DTO NhanVien_dto)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from NhanVien ",sql_con);
                DataRow r = dt.NewRow();
                r["MaNV"] = NhanVien_dto._maNV;
                r["TenNV"] = NhanVien_dto._tenNV;
                r["DiaChi"] = NhanVien_dto._diaChi;
                r["SDT"] = NhanVien_dto._sodienThoai;
                r["GioiTinh"] = NhanVien_dto._gioiTinh;
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

        public bool Xoa(string _maNV)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from NhanVien ", sql_con);
                DataRow r = dt.Rows.Find(_maNV);
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
        public bool Sua(NhanVien_DTO NhanVien_dto)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from NhanVien", sql_con);
                DataRow r = dt.Rows.Find(NhanVien_dto._maNV);
                if (r != null)
                {
                    r["MaNV"] = NhanVien_dto._maNV;
                    r["TenNV"] = NhanVien_dto._tenNV;
                    r["DiaChi"] = NhanVien_dto._diaChi;
                    r["SDT"] = NhanVien_dto._sodienThoai;
                    r["GioiTinh"] = NhanVien_dto._gioiTinh;
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
