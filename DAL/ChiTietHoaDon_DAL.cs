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
   public  class ChiTietHoaDon_DAL : DBconnect
    {
            public DataTable GetHoaDon()
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
            public DataTable TimKiem(string maHD)
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("select * from ChiTietHoaDon where MaHD like  N'%" + maHD + "%'", sql_con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return null;
                }
            }
            public DataTable GetMayTinh()
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

            public DataTable GetDaTa()
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("select * from ChiTietHoaDon ", sql_con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return null;
                }
            }
        public DataTable GetUpdate()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(" select MaHD,MaMT,SL,GiaBan,(SL*GiaBan) as ThanhTien  from ChiTietHoaDon  ", sql_con);
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
            public ChiTietHoaDon_DAL()
            {
                dt = GetDaTa();
                dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
            }

            public bool Them(ChiTietHoaDon_DTO ChiTietHoaDon_dto)
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("select * from ChiTietHoaDon", sql_con);
                    DataRow r = dt.NewRow();
                    r["MaHD"] = ChiTietHoaDon_dto._maHD;
                    r["MaMT"] = ChiTietHoaDon_dto._maMT;
                    r["SL"] = ChiTietHoaDon_dto._soLuong;
                    r["GiaBan"] = ChiTietHoaDon_dto._giaBan;
                    r["ThanhTien"] = ChiTietHoaDon_dto._thanhTien;
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
                    SqlDataAdapter da = new SqlDataAdapter("select * from ChiTietHoaDon", sql_con);
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
            public bool Sua(ChiTietHoaDon_DTO ChiTietHoaDon_dto)
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(" select * from ChiTietHoaDon ", sql_con);
                    DataRow r = dt.Rows.Find(ChiTietHoaDon_dto._maHD);
                    if (r != null)
                    {
                    r["MaHD"] = ChiTietHoaDon_dto._maHD;
                    r["MaMT"] = ChiTietHoaDon_dto._maMT;
                    r["SL"] = ChiTietHoaDon_dto._soLuong;
                    r["GiaBan"] = ChiTietHoaDon_dto._giaBan;
                    r["ThanhTien"] = ChiTietHoaDon_dto._thanhTien;

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
