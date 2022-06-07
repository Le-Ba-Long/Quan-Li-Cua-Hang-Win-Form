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
    public partial class frm_NhanVien : Form
    {
        public frm_NhanVien()
        {
            InitializeComponent();
        }

        NhanVien_BUS nhanvien_BUS = new NhanVien_BUS();
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txtmaNV.Clear();
            txttenNV.Clear();
            txtDC.Clear();
            txtSDT.Clear();
            txtGT.Clear();
            frm_NhanVien_Load(sender, e);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            NhanVien_DTO nhanVien = new NhanVien_DTO(txtmaNV.Text, txttenNV.Text, txtDC.Text, txtSDT.Text, txtGT.Text);

            if (txtmaNV.Text.Length <= 1 || txtmaNV.Text.Length > 15 ||
               txttenNV.Text.Length <= 1 || txttenNV.Text.Length > 20 ||
               txtDC.Text.Length <= 1 || txtDC.Text.Length > 20 ||
               txtGT.Text.Length <= 1 || txtGT.Text.Length > 10 ||
               txtmaNV.Text == "" || txttenNV.Text == "" ||
               txtDC.Text == "" || txtSDT.Text == ""
               || txtGT.Text == "")
            {
                MessageBox.Show("Thên Thất Bại", "Thông Báo");
            }
            else
            {
                nhanvien_BUS.Them(nhanVien);
                frm_NhanVien_Load(sender, e);
                MessageBox.Show("Thêm Thành Công", "Thông Báo");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            NhanVien_DTO nhanVien = new NhanVien_DTO(txtmaNV.Text, txttenNV.Text, txtDC.Text, txtSDT.Text, txtGT.Text);
            if (txtmaNV.Text.Length <= 1 || txtmaNV.Text.Length > 15 ||
                txttenNV.Text.Length <= 1 || txttenNV.Text.Length > 20 ||
                txtDC.Text.Length <= 1 || txtDC.Text.Length > 20 ||
                txtGT.Text.Length <= 1 || txtGT.Text.Length > 10 ||
                txtmaNV.Text == "" || txttenNV.Text == "" ||
                txtDC.Text == "" || txtSDT.Text == ""
               || txtGT.Text == "")
            {
                MessageBox.Show("Sửa thất bại!!!", "Thông báo");
            }
            else
            {
                nhanvien_BUS.Sua(nhanVien);
                frm_NhanVien_Load(sender, e);
                MessageBox.Show("Sửa Thành Công", "Thông Báo");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

            DialogResult xoa = MessageBox.Show(" Bạn Chắc Chắn Muốn Xóa Hay Không", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (xoa == DialogResult.Yes && txtmaNV.Text != "")
            {
                nhanvien_BUS.Xoa(txtmaNV.Text);
                frm_NhanVien_Load(sender, e);
                MessageBox.Show(" Bạn Đã Xóa Thành Công", "Thông Báo");

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

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            dtg_TT_Nhan_Vien.DataSource = nhanvien_BUS.TimKiem(txt_TK.Text);
        }

        private void dtg_TT_Nhan_Vien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int t = dtg_TT_Nhan_Vien.CurrentCell.RowIndex;
            txtmaNV.Text = dtg_TT_Nhan_Vien.Rows[t].Cells[0].Value.ToString();
            txttenNV.Text = dtg_TT_Nhan_Vien.Rows[t].Cells[1].Value.ToString();
            txtDC.Text = dtg_TT_Nhan_Vien.Rows[t].Cells[2].Value.ToString();
            txtSDT.Text = dtg_TT_Nhan_Vien.Rows[t].Cells[3].Value.ToString();
            txtGT.Text = dtg_TT_Nhan_Vien.Rows[t].Cells[4].Value.ToString();
        }

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            dtg_TT_Nhan_Vien.DataSource = nhanvien_BUS.GetDaTa();
        }
     
    }
}
