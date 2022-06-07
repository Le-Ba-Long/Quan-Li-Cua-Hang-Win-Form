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
    public partial class frm_NhaSanXuat : Form
    {
        public frm_NhaSanXuat()
        {
            InitializeComponent();
        }
        NhaSanXuat_BUS nhaSanXuat_BUS = new NhaSanXuat_BUS();
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txtmaNhaSX.Clear();
            txttenNhaSX.Clear();
            txtDC.Clear();
            txtSDT.Clear();
            frm_NhaSanXuat_Load(sender, e);

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            NhaSanXuat_DTO nhaSanXuat = new NhaSanXuat_DTO(txtmaNhaSX.Text, txttenNhaSX.Text, txtDC.Text, txtSDT.Text);
            if (txtmaNhaSX.Text.Length <= 1 || txtmaNhaSX.Text.Length > 15 || txttenNhaSX.Text.Length <= 1 || txttenNhaSX.Text.Length > 15
                || txtDC.Text.Length <= 1 || txtDC.Text.Length > 15 || txtSDT.Text.Length <= 1 || txtSDT.Text.Length > 15 ||
               txtmaNhaSX.Text == "" || txttenNhaSX.Text == "" || txtDC.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Thêm Thất Bại", "Thông Báo");
            }
            else
            {
              nhaSanXuat_BUS.Them(nhaSanXuat);
                frm_NhaSanXuat_Load(sender, e);
                MessageBox.Show("Thêm Thành Công", "Thông Báo");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            NhaSanXuat_DTO nhaSanXuat = new NhaSanXuat_DTO(txtmaNhaSX.Text, txttenNhaSX.Text, txtDC.Text, txtSDT.Text);
            if (txtmaNhaSX.Text == "" || txttenNhaSX.Text == "" || txtDC.Text == ""
            || txtSDT.Text == "")
            {
                MessageBox.Show("Sửa thất bại!!!", "Thông báo");
            }
            else
            {
                nhaSanXuat_BUS.Sua(nhaSanXuat);
                frm_NhaSanXuat_Load(sender, e);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult xoa = MessageBox.Show(" Bạn Chắc Chắn Muốn Xóa Hay Không", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (xoa == DialogResult.Yes && txtmaNhaSX.Text != "")
            {
                nhaSanXuat_BUS.Xoa(txtmaNhaSX.Text);
                frm_NhaSanXuat_Load(sender, e);

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

        private void dtg_NhaCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = dtg_NhaCC.CurrentCell.RowIndex;
            txtmaNhaSX.Text = dtg_NhaCC.Rows[t].Cells[0].Value.ToString();
            txttenNhaSX.Text = dtg_NhaCC.Rows[t].Cells[1].Value.ToString();
            txtDC.Text = dtg_NhaCC.Rows[t].Cells[2].Value.ToString();
            txtSDT.Text = dtg_NhaCC.Rows[t].Cells[3].Value.ToString();
        }

        private void frm_NhaSanXuat_Load(object sender, EventArgs e)
        {

            dtg_NhaCC.DataSource = nhaSanXuat_BUS.GetDaTa();
        }

        private void btn_TimKiem_Click_1(object sender, EventArgs e)
        {
            dtg_NhaCC.DataSource = nhaSanXuat_BUS.TimKiem(txt_TK.Text);
        }
    }
}
