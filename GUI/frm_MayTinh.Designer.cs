
namespace GUI
{
    partial class frm_MayTinh
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
            this.dtg_TT_May_Tinh = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_QuayLai = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_TK = new System.Windows.Forms.TextBox();
            this.btnTK = new System.Windows.Forms.Button();
            this.cob_Ma_NhaCC = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtdonGia = new System.Windows.Forms.TextBox();
            this.txttenMT = new System.Windows.Forms.TextBox();
            this.txtmaMT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_TT_May_Tinh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_TT_May_Tinh
            // 
            this.dtg_TT_May_Tinh.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_TT_May_Tinh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_TT_May_Tinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_TT_May_Tinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_TT_May_Tinh.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_TT_May_Tinh.Location = new System.Drawing.Point(132, 342);
            this.dtg_TT_May_Tinh.Name = "dtg_TT_May_Tinh";
            this.dtg_TT_May_Tinh.Size = new System.Drawing.Size(695, 218);
            this.dtg_TT_May_Tinh.TabIndex = 56;
            this.dtg_TT_May_Tinh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_TT_May_Tinh_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaMT";
            this.Column1.HeaderText = "Mã Máy Tính";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenMT";
            this.Column2.HeaderText = "Tên Máy Tính";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SL";
            this.Column3.HeaderText = "Số Lượng";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GiaBan";
            this.Column4.HeaderText = "Giá";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MaNhaSX";
            this.Column5.HeaderText = "Mã Nhà Sản Xuất";
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.Blue;
            this.btn_Thoat.Location = new System.Drawing.Point(785, 271);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(94, 41);
            this.btn_Thoat.TabIndex = 55;
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
            this.btn_QuayLai.Location = new System.Drawing.Point(627, 271);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(106, 41);
            this.btn_QuayLai.TabIndex = 54;
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
            this.btn_Xoa.Location = new System.Drawing.Point(491, 271);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(94, 41);
            this.btn_Xoa.TabIndex = 53;
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
            this.btn_Sua.Location = new System.Drawing.Point(338, 271);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(94, 41);
            this.btn_Sua.TabIndex = 52;
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
            this.btn_Them.Location = new System.Drawing.Point(202, 271);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(94, 41);
            this.btn_Them.TabIndex = 51;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.Blue;
            this.btn_Reset.Image = global::GUI.Properties.Resources.iconfinder_Synchronize_278832;
            this.btn_Reset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Reset.Location = new System.Drawing.Point(54, 271);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(94, 41);
            this.btn_Reset.TabIndex = 50;
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
            this.label1.Location = new System.Drawing.Point(351, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 36);
            this.label1.TabIndex = 39;
            this.label1.Text = "Thông Tin Máy Tính";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Aqua;
            this.groupBox1.Controls.Add(this.txt_TK);
            this.groupBox1.Controls.Add(this.btnTK);
            this.groupBox1.Controls.Add(this.cob_Ma_NhaCC);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSL);
            this.groupBox1.Controls.Add(this.txtdonGia);
            this.groupBox1.Controls.Add(this.txttenMT);
            this.groupBox1.Controls.Add(this.txtmaMT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(34, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 181);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            // 
            // txt_TK
            // 
            this.txt_TK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TK.Location = new System.Drawing.Point(718, 140);
            this.txt_TK.Name = "txt_TK";
            this.txt_TK.Size = new System.Drawing.Size(148, 23);
            this.txt_TK.TabIndex = 71;
            // 
            // btnTK
            // 
            this.btnTK.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.ForeColor = System.Drawing.Color.Blue;
            this.btnTK.Image = global::GUI.Properties.Resources.iconfinder_Zoom_In_278881;
            this.btnTK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTK.Location = new System.Drawing.Point(728, 49);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(109, 46);
            this.btnTK.TabIndex = 70;
            this.btnTK.Text = "Tìm Kiếm";
            this.btnTK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTK.UseVisualStyleBackColor = false;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click_1);
            // 
            // cob_Ma_NhaCC
            // 
            this.cob_Ma_NhaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cob_Ma_NhaCC.FormattingEnabled = true;
            this.cob_Ma_NhaCC.Location = new System.Drawing.Point(165, 139);
            this.cob_Ma_NhaCC.Name = "cob_Ma_NhaCC";
            this.cob_Ma_NhaCC.Size = new System.Drawing.Size(148, 24);
            this.cob_Ma_NhaCC.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(389, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 68;
            this.label6.Text = "Số Lượng :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(389, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 67;
            this.label5.Text = "Đơn Giá :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 18);
            this.label4.TabIndex = 66;
            this.label4.Text = "Mã Nhà Sản Xuất:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 65;
            this.label3.Text = "Tên Máy Tính :";
            // 
            // txtSL
            // 
            this.txtSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.Location = new System.Drawing.Point(488, 42);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(148, 23);
            this.txtSL.TabIndex = 64;
            // 
            // txtdonGia
            // 
            this.txtdonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdonGia.Location = new System.Drawing.Point(488, 139);
            this.txtdonGia.Name = "txtdonGia";
            this.txtdonGia.Size = new System.Drawing.Size(148, 23);
            this.txtdonGia.TabIndex = 63;
            // 
            // txttenMT
            // 
            this.txttenMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenMT.Location = new System.Drawing.Point(165, 95);
            this.txttenMT.Name = "txttenMT";
            this.txttenMT.Size = new System.Drawing.Size(148, 23);
            this.txttenMT.TabIndex = 62;
            // 
            // txtmaMT
            // 
            this.txtmaMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaMT.Location = new System.Drawing.Point(165, 37);
            this.txtmaMT.Name = "txtmaMT";
            this.txtmaMT.Size = new System.Drawing.Size(148, 23);
            this.txtmaMT.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 60;
            this.label2.Text = "Mã Máy Tính :";
            // 
            // frm_MayTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(945, 571);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtg_TT_May_Tinh);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_QuayLai);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.label1);
            this.Name = "frm_MayTinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_MayTinh";
            this.Load += new System.EventHandler(this.frm_MayTinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_TT_May_Tinh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtg_TT_May_Tinh;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_QuayLai;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_TK;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.ComboBox cob_Ma_NhaCC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtdonGia;
        private System.Windows.Forms.TextBox txttenMT;
        private System.Windows.Forms.TextBox txtmaMT;
        private System.Windows.Forms.Label label2;
    }
}