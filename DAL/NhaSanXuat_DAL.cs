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
   public class NhaSanXuat_DAL : DBconnect
    {
        public DataTable GetDaTa()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from NhaSanXuat ", sql_con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }
        public DataTable TimKiem(string tenNhaSX)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from NhaSanXuat where TenNhaSX like  N'%" + tenNhaSX + "%'", sql_con);
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
        public NhaSanXuat_DAL()
        {
            dt = GetDaTa();
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
        }

        public bool Them(NhaSanXuat_DTO nhaSanXuat_dto)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from NhaSanXuat", sql_con);


                DataRow r = dt.NewRow();

                r["MaNhaSX"] = nhaSanXuat_dto._maNhaSX;
                r["TenNhaSX"] = nhaSanXuat_dto._tenNhaSX;
                r["DiaChi"] = nhaSanXuat_dto._diaChi;
                r["SDT"] = nhaSanXuat_dto._sodienThoai;

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

        public bool Xoa(string _maNhaSX)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from NhaSanXuat", sql_con);
                DataRow r = dt.Rows.Find(_maNhaSX);
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
        public bool Sua(NhaSanXuat_DTO nhaSanXuat_dto)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from NhaSanXuat", sql_con);
                DataRow r = dt.Rows.Find(nhaSanXuat_dto._maNhaSX);
                if (r != null)
                {
                    r["MaNhaSX"] = nhaSanXuat_dto._maNhaSX;
                    r["TenNhaSX"] = nhaSanXuat_dto._tenNhaSX;
                    r["DiaChi"] = nhaSanXuat_dto._diaChi;
                    r["SDT"] = nhaSanXuat_dto._sodienThoai;
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
