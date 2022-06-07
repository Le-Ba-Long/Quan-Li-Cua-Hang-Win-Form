
namespace GUI
{
    partial class frm_Thong_Ke_HD
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
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_ThongKe = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cobThang = new System.Windows.Forms.ComboBox();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTKHD = new System.Windows.Forms.Button();
            this.cobTKHD = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKe)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(356, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 36);
            this.label3.TabIndex = 20;
            this.label3.Text = "Thống Kê Hóa Đơn";
            // 
            // dgv_ThongKe
            // 
            this.dgv_ThongKe.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_ThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThongKe.Location = new System.Drawing.Point(199, 249);
            this.dgv_ThongKe.Name = "dgv_ThongKe";
            this.dgv_ThongKe.Size = new System.Drawing.Size(547, 189);
            this.dgv_ThongKe.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Nam);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cobThang);
            this.groupBox1.Controls.Add(this.btnNhapLai);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnTKHD);
            this.groupBox1.Controls.Add(this.cobTKHD);
            this.groupBox1.Location = new System.Drawing.Point(129, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 184);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 18);
            this.label1.TabIndex = 36;
            this.label1.Text = "Thống Kê Theo Năm :";
            // 
            // txt_Nam
            // 
            this.txt_Nam.Location = new System.Drawing.Point(233, 137);
            this.txt_Nam.Name = "txt_Nam";
            this.txt_Nam.Size = new System.Drawing.Size(100, 20);
            this.txt_Nam.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 18);
            this.label4.TabIndex = 34;
            this.label4.Text = " Thống Kê Theo Tháng :";
            // 
            // cobThang
            // 
            this.cobThang.FormattingEnabled = true;
            this.cobThang.Items.AddRange(new object[] {
            "Tháng 1",
            "Tháng 2",
            "Tháng 3",
            "Tháng 4",
            "Tháng 5",
            "Tháng 6",
            "Tháng 7",
            "Tháng 8",
            "Tháng 9",
            "Tháng 10",
            "Tháng 11",
            "Tháng 12",
            "Năm"});
            this.cobThang.Location = new System.Drawing.Point(233, 93);
            this.cobThang.Margin = new System.Windows.Forms.Padding(4);
            this.cobThang.Name = "cobThang";
            this.cobThang.Size = new System.Drawing.Size(87, 21);
            this.cobThang.TabIndex = 33;
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNhapLai.Image = global::GUI.Properties.Resources.iconfinder_Synchronize_278832;
            this.btnNhapLai.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhapLai.Location = new System.Drawing.Point(600, 28);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(89, 37);
            this.btnNhapLai.TabIndex = 32;
            this.btnNhapLai.Text = "Nhập Lại";
            this.btnNhapLai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapLai.UseVisualStyleBackColor = false;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click_1);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnThoat.Image = global::GUI.Properties.Resources.iconfinder_Remove_278742;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.Location = new System.Drawing.Point(600, 121);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(89, 36);
            this.btnThoat.TabIndex = 31;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // btnTKHD
            // 
            this.btnTKHD.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTKHD.Image = global::GUI.Properties.Resources.iconfinder_Save_278762;
            this.btnTKHD.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTKHD.Location = new System.Drawing.Point(41, 36);
            this.btnTKHD.Margin = new System.Windows.Forms.Padding(4);
            this.btnTKHD.Name = "btnTKHD";
            this.btnTKHD.Size = new System.Drawing.Size(117, 35);
            this.btnTKHD.TabIndex = 30;
            this.btnTKHD.Text = "Thống Kê ";
            this.btnTKHD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTKHD.UseVisualStyleBackColor = false;
            this.btnTKHD.Click += new System.EventHandler(this.btnTKHD_Click_1);
            // 
            // cobTKHD
            // 
            this.cobTKHD.FormattingEnabled = true;
            this.cobTKHD.Items.AddRange(new object[] {
            "Thông Tin Các Mặt Hàng Đã Bán",
            "Tổng Tiền Từng Hóa Đơn",
            "Tổng Doanh Thu",
            "Tổng Số Tiền Mua Của Từng Khách Hàng",
            "Tổng Số Khách Mua Hàng",
            " Lượt Mua Của Từng Khách Hàng"});
            this.cobTKHD.Location = new System.Drawing.Point(233, 44);
            this.cobTKHD.Margin = new System.Windows.Forms.Padding(4);
            this.cobTKHD.Name = "cobTKHD";
            this.cobTKHD.Size = new System.Drawing.Size(228, 21);
            this.cobTKHD.TabIndex = 29;
            // 
            // frm_Thong_Ke_HD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(970, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_ThongKe);
            this.Controls.Add(this.label3);
            this.Name = "frm_Thong_Ke_HD";
            this.Text = "frm_Thong_Ke_HD";
            this.Load += new System.EventHandler(this.frm_Thong_Ke_HD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_ThongKe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Nam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cobThang;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTKHD;
        private System.Windows.Forms.ComboBox cobTKHD;
    }
}