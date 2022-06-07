using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace GUI
{
    public partial class frm_Thong_Ke_HD : Form
    {
        public frm_Thong_Ke_HD()
        {
            InitializeComponent();
        }
        ThongKe_BUS ThongKe_BUS = new ThongKe_BUS();
      
        private void frm_Thong_Ke_HD_Load(object sender, EventArgs e)
        {
            dgv_ThongKe.DataSource = ThongKe_BUS.GetDaTa();
        }

        private void btnTKHD_Click_1(object sender, EventArgs e)
        {
            string chon = cobTKHD.Text;
            switch (chon)
            {
                case "Thông Tin Các Mặt Hàng Đã Bán":
                    dgv_ThongKe.DataSource = ThongKe_BUS.Get_All_MayTinh();
                    break;

                case "Tổng Doanh Thu":
                    string thang = cobThang.Text;
                    string nam = txt_Nam.Text;
                    switch (thang)
                    {
                        case "Tháng 1":
                            dgv_ThongKe.DataSource = ThongKe_BUS.Get_DoanhThu_Thang("1", nam);
                            break;
                        case "Tháng 2":
                            dgv_ThongKe.DataSource = ThongKe_BUS.Get_DoanhThu_Thang("2", nam);
                            break;
                        case "Tháng 3":
                            dgv_ThongKe.DataSource = ThongKe_BUS.Get_DoanhThu_Thang("3", nam);
                            break;
                        case "Tháng 4":
                            dgv_ThongKe.DataSource = ThongKe_BUS.Get_DoanhThu_Thang("4", nam);
                            break;
                        case "Tháng 5":
                            dgv_ThongKe.DataSource = ThongKe_BUS.Get_DoanhThu_Thang("5", nam);
                            break;
                        case "Tháng 6":
                            dgv_ThongKe.DataSource = ThongKe_BUS.Get_DoanhThu_Thang("6", nam);
                            break;
                        case "Tháng 7":
                            dgv_ThongKe.DataSource = ThongKe_BUS.Get_DoanhThu_Thang("7", nam);
                            break;
                        case "Tháng 8":
                            dgv_ThongKe.DataSource = ThongKe_BUS.Get_DoanhThu_Thang("8", nam);
                            break;
                        case "Tháng 9":
                            dgv_ThongKe.DataSource = ThongKe_BUS.Get_DoanhThu_Thang("9", nam);
                            break;
                        case "Tháng 10":
                            dgv_ThongKe.DataSource = ThongKe_BUS.Get_DoanhThu_Thang("10", nam);
                            break;
                        case "Tháng 11":
                            dgv_ThongKe.DataSource = ThongKe_BUS.Get_DoanhThu_Thang("11", nam);
                            break;
                        case "Tháng 12":
                            dgv_ThongKe.DataSource = ThongKe_BUS.Get_DoanhThu_Thang("12", nam);
                            break;
                        case "Năm":
                            dgv_ThongKe.DataSource = ThongKe_BUS.Get_DoanhThu_Nam(nam);
                            break;

                    }
                    break;

                case "Tổng Tiền Từng Hóa Đơn":
                    dgv_ThongKe.DataSource = ThongKe_BUS.Get_Tong_Tien_Tung_HD();
                    break;
                case "Tổng Số Tiền Mua Của Từng Khách Hàng":
                    dgv_ThongKe.DataSource = ThongKe_BUS.Get_Tong_Tien_KH();
                    break;
                case "Tổng Số Khách Mua Hàng":
                    dgv_ThongKe.DataSource = ThongKe_BUS.Get_TongKH();
                    break;
                case " Lượt Mua Của Từng Khách Hàng":
                    dgv_ThongKe.DataSource = ThongKe_BUS.Get_Luot_Mua_KH();
                    break;
            }
        }

        private void btnNhapLai_Click_1(object sender, EventArgs e)
        {
            frm_Thong_Ke_HD_Load(sender, e);
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
