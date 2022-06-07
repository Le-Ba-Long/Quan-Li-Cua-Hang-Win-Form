
namespace GUI
{
    partial class frm_NhaSanXuat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtg_NhaCC = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_QuayLai = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_TK = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txttenNhaSX = new System.Windows.Forms.TextBox();
            this.txtmaNhaSX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_NhaCC)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_NhaCC
            // 
            this.dtg_NhaCC.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_NhaCC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_NhaCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_NhaCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_NhaCC.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_NhaCC.Location = new System.Drawing.Point(188, 329);
            this.dtg_NhaCC.Name = "dtg_NhaCC";
            this.dtg_NhaCC.Size = new System.Drawing.Size(595, 232);
            this.dtg_NhaCC.TabIndex = 68;
            this.dtg_NhaCC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_NhaCC_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaNhaSX";
            this.Column1.HeaderText = "Mã Nhà Sản Xuất";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenNhaSX";
            this.Column2.HeaderText = "Tên Nhà Sản Xuất";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DiaChi";
            this.Column3.HeaderText = "Địa Chỉ";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SDT";
            this.Column4.HeaderText = "SDT";
            this.Column4.Name = "Column4";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.Blue;
            this.btn_Xoa.Image = global::GUI.Properties.Resources.iconfinder_Remove_278742;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xoa.Location = new System.Drawing.Point(518, 270);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(95, 36);
            this.btn_Xoa.TabIndex = 67;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.Blue;
            this.btn_Sua.Image = global::GUI.Properties.Resources.iconfinder_Save_278762;
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sua.Location = new System.Drawing.Point(393, 270);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(95, 36);
            this.btn_Sua.TabIndex = 66;
            this.btn_Sua.Text = "Sửa ";
            this.btn_Sua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.Blue;
            this.btn_Them.Image = global::GUI.Properties.Resources.iconfinder_Stock_Index_Up_278812;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Them.Location = new System.Drawing.Point(253, 270);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(95, 36);
            this.btn_Them.TabIndex = 65;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.Blue;
            this.btn_Reset.Image = global::GUI.Properties.Resources.iconfinder_Synchronize_278832;
            this.btn_Reset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Reset.Location = new System.Drawing.Point(109, 270);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(95, 36);
            this.btn_Reset.TabIndex = 64;
            this.btn_Reset.Text = "Làm Mới";
            this.btn_Reset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(308, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 36);
            this.label1.TabIndex = 55;
            this.label1.Text = "Thông Tin Nhà Sản Xuất";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.Blue;
            this.btn_Thoat.Location = new System.Drawing.Point(792, 270);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(95, 36);
            this.btn_Thoat.TabIndex = 71;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_QuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuayLai.ForeColor = System.Drawing.Color.Blue;
            this.btn_QuayLai.Image = global::GUI.Properties.Resources.iconfinder_Undo_278852;
            this.btn_QuayLai.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_QuayLai.Location = new System.Drawing.Point(651, 270);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(95, 36);
            this.btn_QuayLai.TabIndex = 70;
            this.btn_QuayLai.Text = "Quay Lại";
            this.btn_QuayLai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuayLai.UseVisualStyleBackColor = false;
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_QuayLai_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Aqua;
            this.groupBox1.Controls.Add(this.txt_TK);
            this.groupBox1.Controls.Add(this.btn_TimKiem);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDC);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txttenNhaSX);
            this.groupBox1.Controls.Add(this.txtmaNhaSX);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(932, 189);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            // 
            // txt_TK
            // 
            this.txt_TK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TK.Location = new System.Drawing.Point(698, 104);
            this.txt_TK.Name = "txt_TK";
            this.txt_TK.Size = new System.Drawing.Size(169, 23);
            this.txt_TK.TabIndex = 82;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.ForeColor = System.Drawing.Color.Blue;
            this.btn_TimKiem.Image = global::GUI.Properties.Resources.iconfinder_Zoom_In_278881;
            this.btn_TimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TimKiem.Location = new System.Drawing.Point(726, 34);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(108, 40);
            this.btn_TimKiem.TabIndex = 81;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(348, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 18);
            this.label6.TabIndex = 80;
            this.label6.Text = "Địa Chỉ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(348, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 79;
            this.label5.Text = "SDT :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 18);
            this.label3.TabIndex = 78;
            this.label3.Text = "Tên Nhà Sản Xuất:";
            // 
            // txtDC
            // 
            this.txtDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDC.Location = new System.Drawing.Point(418, 44);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(169, 23);
            this.txtDC.TabIndex = 77;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(418, 123);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(169, 23);
            this.txtSDT.TabIndex = 76;
            // 
            // txttenNhaSX
            // 
            this.txttenNhaSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenNhaSX.Location = new System.Drawing.Point(150, 119);
            this.txttenNhaSX.Name = "txttenNhaSX";
            this.txttenNhaSX.Size = new System.Drawing.Size(154, 23);
            this.txttenNhaSX.TabIndex = 75;
            // 
            // txtmaNhaSX
            // 
            this.txtmaNhaSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaNhaSX.Location = new System.Drawing.Point(150, 46);
            this.txtmaNhaSX.Name = "txtmaNhaSX";
            this.txtmaNhaSX.Size = new System.Drawing.Size(154, 23);
            this.txtmaNhaSX.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 73;
            this.label2.Text = "Mã Nhà Sản Xuất:";
            // 
            // frm_NhaSanXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(956, 579);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_QuayLai);
            this.Controls.Add(this.dtg_NhaCC);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.label1);
            this.Name = "frm_NhaSanXuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_NhaSanXuat";
            this.Load += new System.EventHandler(this.frm_NhaSanXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_NhaCC)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtg_NhaCC;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_QuayLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_TK;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txttenNhaSX;
        private System.Windows.Forms.TextBox txtmaNhaSX;
        private System.Windows.Forms.Label label2;
    }
}