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
    public partial class frm_Hoa_Don : Form
    {
        public frm_Hoa_Don()
        {
            InitializeComponent();
        }

        HoaDon_BUS HoaDon_BUS = new HoaDon_BUS();
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_MaHD.Clear();
            txt_TK.Clear();
            frm_Hoa_Don_Load(sender, e);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            HoaDon_DTO hoadon = new HoaDon_DTO(txt_MaHD.Text, cobmaKH.Text, cobmaNV.Text,datengayN.Text);
            if (datengayN.Text == "" || cobmaNV.Text == "" || cobmaKH.Text == "" || txt_MaHD.Text == "")
            {
                MessageBox.Show("Thêm thất bại!!!", "Thông báo");
            }
            else
            {
                HoaDon_BUS.Them(hoadon);
                frm_Hoa_Don_Load(sender, e);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            HoaDon_DTO hoadon = new HoaDon_DTO(txt_MaHD.Text, cobmaKH.Text, cobmaNV.Text,datengayN.Text);
            if ( datengayN.Text == ""|| cobmaNV.Text == ""||cobmaKH.Text == "" || txt_MaHD.Text == "")
            {
                HoaDon_BUS.Sua(hoadon);
                MessageBox.Show("Sửa thất bại!!!", "Thông báo");
            }
            else
            {
                HoaDon_BUS.Sua(hoadon);
                frm_Hoa_Don_Load(sender, e);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult xoa = MessageBox.Show(" Bạn Chắc Chắn Muốn Xóa Hay Không", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (xoa == DialogResult.Yes && txt_MaHD.Text != "")
            {
                HoaDon_BUS.Xoa(txt_MaHD.Text);
                frm_Hoa_Don_Load(sender, e);
                MessageBox.Show(" Bạn Đã Xóa Thành Công");

            }
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dtg_TT_Hoa_Don_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = dtg_TT_Hoa_Don.CurrentCell.RowIndex;
            txt_MaHD.Text = dtg_TT_Hoa_Don.Rows[t].Cells[0].Value.ToString();
            cobmaKH.Text = dtg_TT_Hoa_Don.Rows[t].Cells[1].Value.ToString();
            cobmaNV.Text = dtg_TT_Hoa_Don.Rows[t].Cells[2].Value.ToString();
            datengayN.Text = dtg_TT_Hoa_Don.Rows[t].Cells[3].Value.ToString();
           
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            dtg_TT_Hoa_Don.DataSource = HoaDon_BUS.TimKiem(txt_TK.Text);
        }

        private void frm_Hoa_Don_Load(object sender, EventArgs e)
        {
            cobmaKH.DataSource = HoaDon_BUS.GetKhachHang();
            cobmaKH.DisplayMember = "MaKH";
            cobmaKH.ValueMember = "MaKH";
            cobmaNV.DataSource = HoaDon_BUS.GetNhanVien();
            cobmaNV.DisplayMember = "MaNV";
            cobmaNV.ValueMember = "MaNV";
            dtg_TT_Hoa_Don.DataSource = HoaDon_BUS.GetDaTa();
        }
    }
}
