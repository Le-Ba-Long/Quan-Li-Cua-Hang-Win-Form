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
    public partial class frm_Dang_Nhap : Form
    {
        public frm_Dang_Nhap()
        {
            InitializeComponent();
        }

        private void frm_Dang_Nhap_Load(object sender, EventArgs e)
        {

        }

        private void btn_dang_nhap_Click(object sender, EventArgs e)
        {
           if (txt_tai_khoan.Text == "Admin" && txt_mat_khau.Text == "123")
            {
                MessageBox.Show("Đăng Nhập Thành Công", "Thông Báo");
                //this.Hide();*/
                frm_MeNu frm = new frm_MeNu();
                frm.Show();
           }
            else
            {
                MessageBox.Show("Sai Tên Tài Khoản Hoặc Mật Khẩu!", "Thông Báo");
                txt_tai_khoan.Focus();
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
