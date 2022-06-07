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
    public partial class frm_MayTinh : Form
    {
        public frm_MayTinh()
        {
            InitializeComponent();
        }
        MayTinh_BUS maytinh_BUS = new MayTinh_BUS();
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txtmaMT.Clear();
            txttenMT.Clear();
            txtSL.Clear();
            txtdonGia.Clear();
            frm_MayTinh_Load(sender, e);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            MayTinh_DTO mayTinh = new MayTinh_DTO(txtmaMT.Text, txttenMT.Text, int.Parse(txtSL.Text), double.Parse(txtdonGia.Text), cob_Ma_NhaCC.Text);

            try
            {

                if (txtmaMT.Text.Length <= 1 || txtmaMT.Text.Length > 15 || txttenMT.Text.Length <= 1 || txttenMT.Text.Length > 15 || txtmaMT.Text == "" || txttenMT.Text == "" || txtSL.Text == "" || txtdonGia.Text == ""
                || cob_Ma_NhaCC.Text == "")
                {
                    MessageBox.Show("Thêm Thất Bại", "Thông Báo");
                }
                else
                {
                    maytinh_BUS.Them(mayTinh);
                    frm_MayTinh_Load(sender, e);
                    MessageBox.Show("Thêm Thành Công", "Thông Báo");
                }
            }
            catch (Exception loi)
            {
                MessageBox.Show("Nhập Sai Kiểu Dữ Liệu");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            MayTinh_DTO mayTinh = new MayTinh_DTO(txtmaMT.Text, txttenMT.Text, int.Parse(txtSL.Text), double.Parse(txtdonGia.Text), cob_Ma_NhaCC.Text);

            try
            {

                if (txtmaMT.Text.Length <= 1 || txtmaMT.Text.Length > 15 || txttenMT.Text.Length <= 1 || 
                    txttenMT.Text.Length > 15 || txtmaMT.Text == "" ||
                    txttenMT.Text == "" || txtSL.Text == "" || txtdonGia.Text == ""
                || cob_Ma_NhaCC.Text == "")
                {
                    MessageBox.Show("Sửa Thất Bại", "Thông Báo");
                }
                else
                {
                    maytinh_BUS.Sua(mayTinh);
                    frm_MayTinh_Load(sender, e);
                    MessageBox.Show("Sửa Thành Công", "Thông Báo");
                }
            }
            catch (Exception loi)
            {
                MessageBox.Show("Nhập Sai Kiểu Dữ Liệu");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult xoa = MessageBox.Show(" Bạn Chắc Chắn Muốn Xóa Hay Không", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (xoa == DialogResult.Yes && txtmaMT.Text != "")
            {
                maytinh_BUS.Xoa(txtmaMT.Text);
                frm_MayTinh_Load(sender, e);
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

        private void dtg_TT_May_Tinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = dtg_TT_May_Tinh.CurrentCell.RowIndex;
            txtmaMT.Text = dtg_TT_May_Tinh.Rows[t].Cells[0].Value.ToString();
            txttenMT.Text = dtg_TT_May_Tinh.Rows[t].Cells[1].Value.ToString();
            txtSL.Text = dtg_TT_May_Tinh.Rows[t].Cells[2].Value.ToString();
            txtdonGia.Text = dtg_TT_May_Tinh.Rows[t].Cells[3].Value.ToString();
            cob_Ma_NhaCC.Text = dtg_TT_May_Tinh.Rows[t].Cells[4].Value.ToString();
        }

        private void frm_MayTinh_Load(object sender, EventArgs e)
        {
            cob_Ma_NhaCC.DataSource = maytinh_BUS.GetNhaSX();
            cob_Ma_NhaCC.DisplayMember = "MaNhaSX";
            cob_Ma_NhaCC.ValueMember = "MaNhaSX";
            dtg_TT_May_Tinh.DataSource = maytinh_BUS.GetDaTa();
        }

        private void btnTK_Click_1(object sender, EventArgs e)
        {
            dtg_TT_May_Tinh.DataSource = maytinh_BUS.TimKiem(txt_TK.Text);
        }
    }
}
