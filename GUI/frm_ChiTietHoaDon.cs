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
    public partial class frm_ChiTietHoaDon : Form
    {
        public frm_ChiTietHoaDon()
        {
            InitializeComponent();
        }

        ChiTietHoaDon_BUS ChiTietHoaDon_BUS = new ChiTietHoaDon_BUS();
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_SL.Clear();
            txt_GiaBan.Clear();
            txt_ThanhTien.Clear();
            txt_TK.Clear();
            frm_ChiTietHoaDon_Load(sender, e);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            
            if (txtmaHD.Text == "" || cobmaMT.Text == "" || txt_SL.Text == "" || txt_GiaBan.Text == "")
            {
                MessageBox.Show("Thêm thất bại!!!", "Thông báo");
            }
            else
            {
                ChiTietHoaDon_DTO cthd_dto = new ChiTietHoaDon_DTO(txtmaHD.Text, cobmaMT.Text, int.Parse(txt_SL.Text),
                Convert.ToDouble(txt_GiaBan.Text), Convert.ToDouble(txt_ThanhTien.Text));
                ChiTietHoaDon_BUS.Them(cthd_dto);
                frm_ChiTietHoaDon_Load(sender, e);
                dtg_Chi_Tiet_Hoa_Don.DataSource = ChiTietHoaDon_BUS.Getupdate();
                MessageBox.Show("Thêm Thành Công");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            
            if (txtmaHD.Text == "" || cobmaMT.Text == "" || txt_SL.Text == "" || txt_GiaBan.Text == "")
            {
                MessageBox.Show("Sửa thất bại!!!", "Thông báo");
            }
            else
            {
                ChiTietHoaDon_DTO cthd_dto = new ChiTietHoaDon_DTO(txtmaHD.Text, cobmaMT.Text, int.Parse(txt_SL.Text),
                Convert.ToDouble(txt_GiaBan.Text), Convert.ToDouble(txt_ThanhTien.Text));
                ChiTietHoaDon_BUS.Sua(cthd_dto);
                frm_ChiTietHoaDon_Load(sender, e);
                dtg_Chi_Tiet_Hoa_Don.DataSource = ChiTietHoaDon_BUS.Getupdate();

                MessageBox.Show("Sửa Thành Công");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

            DialogResult xoa = MessageBox.Show(" Bạn Chắc Chắn Muốn Xóa Hay Không", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (xoa == DialogResult.Yes && txtmaHD.Text != "")
            {
                ChiTietHoaDon_BUS.Xoa(txtmaHD.Text);
                frm_ChiTietHoaDon_Load(sender, e);
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

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            dtg_Chi_Tiet_Hoa_Don.DataSource = ChiTietHoaDon_BUS.TimKiem(txt_TK.Text);
        }

       

        private void frm_ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            cobmaMT.DataSource = ChiTietHoaDon_BUS.GetMayTinh();
            cobmaMT.DisplayMember = "MaMT";
            cobmaMT.ValueMember = "MaMT";
            dtg_Chi_Tiet_Hoa_Don.DataSource = ChiTietHoaDon_BUS.GetDaTa();

        }

        private void dtg_Chi_Tiet_Hoa_Don_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int t = dtg_Chi_Tiet_Hoa_Don.CurrentCell.RowIndex;
            txtmaHD.Text = dtg_Chi_Tiet_Hoa_Don.Rows[t].Cells[0].Value.ToString();
            cobmaMT.Text = dtg_Chi_Tiet_Hoa_Don.Rows[t].Cells[1].Value.ToString();
            txt_SL.Text = dtg_Chi_Tiet_Hoa_Don.Rows[t].Cells[2].Value.ToString();
            txt_GiaBan.Text = dtg_Chi_Tiet_Hoa_Don.Rows[t].Cells[3].Value.ToString();         
            txt_ThanhTien.Text = dtg_Chi_Tiet_Hoa_Don.Rows[t].Cells[4].Value.ToString();
           


        }

        private void dtg_Chi_Tiet_Hoa_Don_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
           /* foreach (DataGridViewRow row in dtg_Chi_Tiet_Hoa_Don.Rows)
            {
                row.Cells["ThanhTien"].Value = 
                    Convert.ToDouble(row.Cells["GiaBan"].Value) 
                    * Convert.ToDouble(row.Cells["SoLuong"].Value);
            }
            */
        }
    }
}
