
namespace GUI
{
    partial class frm_ChiTietHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtg_Chi_Tiet_Hoa_Don = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_TK = new System.Windows.Forms.TextBox();
            this.cobmaMT = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtmaHD = new System.Windows.Forms.TextBox();
            this.txt_ThanhTien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_GiaBan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_SL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_QuayLai = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Chi_Tiet_Hoa_Don)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_Chi_Tiet_Hoa_Don
            // 
            this.dtg_Chi_Tiet_Hoa_Don.BackgroundColor = System.Drawing.Color.White;
            this.dtg_Chi_Tiet_Hoa_Don.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Chi_Tiet_Hoa_Don.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.MaMT,
            this.SoLuong,
            this.GiaBan,
            this.ThanhTien});
            this.dtg_Chi_Tiet_Hoa_Don.Location = new System.Drawing.Point(74, 353);
            this.dtg_Chi_Tiet_Hoa_Don.Name = "dtg_Chi_Tiet_Hoa_Don";
            this.dtg_Chi_Tiet_Hoa_Don.Size = new System.Drawing.Size(799, 189);
            this.dtg_Chi_Tiet_Hoa_Don.TabIndex = 127;
            this.dtg_Chi_Tiet_Hoa_Don.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Chi_Tiet_Hoa_Don_CellContentClick);
            this.dtg_Chi_Tiet_Hoa_Don.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Chi_Tiet_Hoa_Don_CellEndEdit);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaHD";
            this.Column1.HeaderText = "Mã HD";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // MaMT
            // 
            this.MaMT.DataPropertyName = "MaMT";
            this.MaMT.HeaderText = "Mã Máy Tính";
            this.MaMT.Name = "MaMT";
            this.MaMT.Width = 150;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SL";
            dataGridViewCellStyle1.NullValue = null;
            this.SoLuong.DefaultCellStyle = dataGridViewCellStyle1;
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 150;
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá Bán";
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.Width = 150;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 150;
            // 
            // txt_TK
            // 
            this.txt_TK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TK.Location = new System.Drawing.Point(775, 77);
            this.txt_TK.Name = "txt_TK";
            this.txt_TK.Size = new System.Drawing.Size(154, 26);
            this.txt_TK.TabIndex = 118;
            // 
            // cobmaMT
            // 
            this.cobmaMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobmaMT.FormattingEnabled = true;
            this.cobmaMT.Location = new System.Drawing.Point(113, 80);
            this.cobmaMT.Name = "cobmaMT";
            this.cobmaMT.Size = new System.Drawing.Size(154, 24);
            this.cobmaMT.TabIndex = 117;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Aqua;
            this.groupBox1.Controls.Add(this.txtmaHD);
            this.groupBox1.Controls.Add(this.txt_ThanhTien);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_GiaBan);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_SL);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_TK);
            this.groupBox1.Controls.Add(this.cobmaMT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_TimKiem);
            this.groupBox1.Location = new System.Drawing.Point(15, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(950, 217);
            this.groupBox1.TabIndex = 128;
            this.groupBox1.TabStop = false;
            // 
            // txtmaHD
            // 
            this.txtmaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaHD.Location = new System.Drawing.Point(113, 38);
            this.txtmaHD.Name = "txtmaHD";
            this.txtmaHD.Size = new System.Drawing.Size(154, 23);
            this.txtmaHD.TabIndex = 125;
            // 
            // txt_ThanhTien
            // 
            this.txt_ThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ThanhTien.Location = new System.Drawing.Point(464, 96);
            this.txt_ThanhTien.Name = "txt_ThanhTien";
            this.txt_ThanhTien.ReadOnly = true;
            this.txt_ThanhTien.Size = new System.Drawing.Size(154, 23);
            this.txt_ThanhTien.TabIndex = 124;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(346, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 123;
            this.label7.Text = "Thành Tiền:";
            // 
            // txt_GiaBan
            // 
            this.txt_GiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GiaBan.Location = new System.Drawing.Point(464, 44);
            this.txt_GiaBan.Name = "txt_GiaBan";
            this.txt_GiaBan.Size = new System.Drawing.Size(154, 23);
            this.txt_GiaBan.TabIndex = 122;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(352, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 121;
            this.label6.Text = "Giá Bán:";
            // 
            // txt_SL
            // 
            this.txt_SL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SL.Location = new System.Drawing.Point(113, 132);
            this.txt_SL.Name = "txt_SL";
            this.txt_SL.Size = new System.Drawing.Size(154, 23);
            this.txt_SL.TabIndex = 120;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 119;
            this.label5.Text = "Số Lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 94;
            this.label3.Text = "Mã Máy Tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 93;
            this.label2.Text = "Mã Hóa Đơn:";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.ForeColor = System.Drawing.Color.Blue;
            this.btn_TimKiem.Image = global::GUI.Properties.Resources.iconfinder_Zoom_In_278881;
            this.btn_TimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TimKiem.Location = new System.Drawing.Point(649, 69);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(103, 41);
            this.btn_TimKiem.TabIndex = 117;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.Blue;
            this.btn_Reset.Image = global::GUI.Properties.Resources.iconfinder_Synchronize_278832;
            this.btn_Reset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Reset.Location = new System.Drawing.Point(74, 289);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(98, 41);
            this.btn_Reset.TabIndex = 121;
            this.btn_Reset.Text = "Làm Mới";
            this.btn_Reset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.Blue;
            this.btn_Thoat.Location = new System.Drawing.Point(781, 289);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(94, 41);
            this.btn_Thoat.TabIndex = 126;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_QuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuayLai.ForeColor = System.Drawing.Color.Blue;
            this.btn_QuayLai.Image = global::GUI.Properties.Resources.iconfinder_Undo_278852;
            this.btn_QuayLai.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_QuayLai.Location = new System.Drawing.Point(646, 289);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(94, 41);
            this.btn_QuayLai.TabIndex = 125;
            this.btn_QuayLai.Text = "Quay Lại";
            this.btn_QuayLai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuayLai.UseVisualStyleBackColor = false;
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_QuayLai_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.Blue;
            this.btn_Xoa.Image = global::GUI.Properties.Resources.iconfinder_Remove_278742;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xoa.Location = new System.Drawing.Point(514, 289);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(94, 41);
            this.btn_Xoa.TabIndex = 124;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.Blue;
            this.btn_Sua.Image = global::GUI.Properties.Resources.iconfinder_Save_278762;
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sua.Location = new System.Drawing.Point(364, 289);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(94, 41);
            this.btn_Sua.TabIndex = 123;
            this.btn_Sua.Text = "Sửa ";
            this.btn_Sua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.Blue;
            this.btn_Them.Image = global::GUI.Properties.Resources.iconfinder_Stock_Index_Up_278812;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Them.Location = new System.Drawing.Point(220, 289);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(94, 41);
            this.btn_Them.TabIndex = 122;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(304, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 36);
            this.label1.TabIndex = 120;
            this.label1.Text = "Thông Tin Chi Tiết Hóa Đơn";
            // 
            // frm_ChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(981, 571);
            this.Controls.Add(this.dtg_Chi_Tiet_Hoa_Don);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_QuayLai);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label1);
            this.Name = "frm_ChiTietHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ChiTietHoaDon";
            this.Load += new System.EventHandler(this.frm_ChiTietHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Chi_Tiet_Hoa_Don)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtg_Chi_Tiet_Hoa_Don;
        private System.Windows.Forms.TextBox txt_TK;
        private System.Windows.Forms.ComboBox cobmaMT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_ThanhTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_GiaBan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_SL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_QuayLai;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}