using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_MeNu : Form
    {
        public frm_MeNu()
        {
            InitializeComponent();
        }

        private void thôngTinMáyTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_MayTinh frm_MayTinh = new frm_MayTinh();
            frm_MayTinh.Show();
        }

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_NhanVien frm_NhanVien = new frm_NhanVien();
            frm_NhanVien.Show();
        }

        private void thôngTinNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_NhaSanXuat frm_NhaSanXuat = new frm_NhaSanXuat();
            frm_NhaSanXuat.Show();
        }

        private void thôngTinHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Hoa_Don frm_Hoa_Don = new frm_Hoa_Don();
            frm_Hoa_Don.Show();
        }

        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_KhachHang frm_KhachHang = new frm_KhachHang();
            frm_KhachHang.Show();
        }

        private void quayLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void thốngKêHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Thong_Ke_HD frm_Thong_Ke_HD = new frm_Thong_Ke_HD();
            frm_Thong_Ke_HD.Show();
        }

        private void thôngTinChiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ChiTietHoaDon frm_ChiTietHoaDon = new frm_ChiTietHoaDon();
            frm_ChiTietHoaDon.Show();
        }
    }
}
