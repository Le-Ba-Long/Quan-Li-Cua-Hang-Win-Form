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
    public class MayTinh_DAL : DBconnect
    {

        public DataTable GetNhaSX()
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
        public DataTable TimKiem(string tenMT)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from MayTinh where TenMT like  N'%" + tenMT + "%'", sql_con);
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
                SqlDataAdapter da = new SqlDataAdapter("select * from MayTinh ", sql_con);
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
        public MayTinh_DAL()
        {
            dt = GetDaTa();
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
        }

        public bool Them(MayTinh_DTO MayTinh_dto)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from MayTinh ", sql_con);


                DataRow r = dt.NewRow();

                r["MaMT"] = MayTinh_dto._maMT;
                r["TenMT"] = MayTinh_dto._tenMT;
                r["SL"] = MayTinh_dto._soLuong;
                r["GiaBan"] = MayTinh_dto._giaBan;
                r["MaNhaSX"] = MayTinh_dto._maNhaSX;

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

        public bool Xoa(string _maMT)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from MayTinh", sql_con);
                DataRow r = dt.Rows.Find(_maMT);
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
        public bool Sua(MayTinh_DTO MayTinh_dto)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from MayTinh ", sql_con);
                DataRow r = dt.Rows.Find(MayTinh_dto._maMT);
                if (r != null)
                {
                    r["MaMT"] = MayTinh_dto._maMT;
                    r["TenMT"] = MayTinh_dto._tenMT;
                    r["SL"] = MayTinh_dto._soLuong;
                    r["GiaBan"] = MayTinh_dto._giaBan;
                    r["MaNhaSX"] = MayTinh_dto._maNhaSX;
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
