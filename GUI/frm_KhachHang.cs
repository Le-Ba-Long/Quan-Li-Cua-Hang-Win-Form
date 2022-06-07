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
    public partial class frm_KhachHang : Form
    {
        public frm_KhachHang()
        {
            InitializeComponent();
        }
        KhachHang_BUS KhachHang_BUS = new KhachHang_BUS();
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txtmaKH.Clear();
            txttenKH.Clear();
            txttenDC.Clear();
            txtSDT.Clear();
            txtGT.Clear();
            frm_KhachHang_Load(sender, e);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            KhachHang_DTO khachHang = new KhachHang_DTO(txtmaKH.Text, txttenKH.Text, txttenDC.Text, txtSDT.Text, txtGT.Text);
            if (txtmaKH.Text.Length <= 1 || txtmaKH.Text.Length > 15 ||
               txttenKH.Text.Length <= 1 || txttenKH.Text.Length > 15 ||
               txtmaKH.Text == "" || txttenKH.Text == "" || txttenDC.Text == "" || txtSDT.Text == ""
               || txtGT.Text == "")
            {
                MessageBox.Show("Thêm Thất Bại", "Thông Báo");
            }
            else
            {
                KhachHang_BUS.Them(khachHang);
                frm_KhachHang_Load(sender, e);
                MessageBox.Show("Thêm Thành Công", "Thông Báo");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            KhachHang_DTO khachHang = new KhachHang_DTO(txtmaKH.Text, txttenKH.Text, txttenDC.Text, txtSDT.Text, txtGT.Text);
            if (txttenDC.Text == "" || txttenKH.Text == "" || txtSDT.Text == ""
             || txtGT.Text == "" || txtmaKH.Text == "")
            {
                MessageBox.Show("Sửa thất bại!!!", "Thông báo");
            }
            else
            {
                KhachHang_BUS.Sua(khachHang);
                frm_KhachHang_Load(sender, e);
                MessageBox.Show("Sửa Thành Công", "Thông báo");
            }

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult xoa = MessageBox.Show(" Bạn Chắc Chắn Muốn Xóa Hay Không", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (xoa == DialogResult.Yes && txtmaKH.Text != "")
            {
                KhachHang_BUS.Xoa(txtmaKH.Text);
                frm_KhachHang_Load(sender, e);
                MessageBox.Show("Xóa Thành Công", "Thông báo");

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

        private void dtg_TT_Khach_Hang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = dtg_TT_Khach_Hang.CurrentCell.RowIndex;
            txtmaKH.Text = dtg_TT_Khach_Hang.Rows[t].Cells[0].Value.ToString();
            txttenKH.Text = dtg_TT_Khach_Hang.Rows[t].Cells[1].Value.ToString();
            txttenDC.Text = dtg_TT_Khach_Hang.Rows[t].Cells[2].Value.ToString();
            txtSDT.Text = dtg_TT_Khach_Hang.Rows[t].Cells[3].Value.ToString();
            txtGT.Text = dtg_TT_Khach_Hang.Rows[t].Cells[4].Value.ToString();
        }

        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            dtg_TT_Khach_Hang.DataSource = KhachHang_BUS.GetDaTa();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            dtg_TT_Khach_Hang.DataSource = KhachHang_BUS.TimKiem(txt_TK.Text);
        }
    }
}
