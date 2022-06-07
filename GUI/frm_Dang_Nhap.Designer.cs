
namespace GUI
{
    partial class frm_Dang_Nhap
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
            this.txt_mat_khau = new System.Windows.Forms.TextBox();
            this.txt_tai_khoan = new System.Windows.Forms.TextBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_dang_nhap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_mat_khau
            // 
            this.txt_mat_khau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mat_khau.Location = new System.Drawing.Point(238, 144);
            this.txt_mat_khau.Name = "txt_mat_khau";
            this.txt_mat_khau.PasswordChar = '♥';
            this.txt_mat_khau.Size = new System.Drawing.Size(162, 26);
            this.txt_mat_khau.TabIndex = 17;
            // 
            // txt_tai_khoan
            // 
            this.txt_tai_khoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tai_khoan.Location = new System.Drawing.Point(238, 92);
            this.txt_tai_khoan.Name = "txt_tai_khoan";
            this.txt_tai_khoan.Size = new System.Drawing.Size(162, 26);
            this.txt_tai_khoan.TabIndex = 16;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.Peru;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.Navy;
            this.btn_thoat.Location = new System.Drawing.Point(285, 266);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(115, 33);
            this.btn_thoat.TabIndex = 15;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_dang_nhap
            // 
            this.btn_dang_nhap.BackColor = System.Drawing.Color.Peru;
            this.btn_dang_nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dang_nhap.ForeColor = System.Drawing.Color.Navy;
            this.btn_dang_nhap.Location = new System.Drawing.Point(96, 266);
            this.btn_dang_nhap.Name = "btn_dang_nhap";
            this.btn_dang_nhap.Size = new System.Drawing.Size(115, 33);
            this.btn_dang_nhap.TabIndex = 14;
            this.btn_dang_nhap.Text = "Đăng Nhập";
            this.btn_dang_nhap.UseVisualStyleBackColor = false;
            this.btn_dang_nhap.Click += new System.EventHandler(this.btn_dang_nhap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Chocolate;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mật Khẩu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Chocolate;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tài Khoản :";
            // 
            // frm_Dang_Nhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.Anh_nen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(525, 390);
            this.Controls.Add(this.txt_mat_khau);
            this.Controls.Add(this.txt_tai_khoan);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_dang_nhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_Dang_Nhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Dang_Nhap";
            this.Load += new System.EventHandler(this.frm_Dang_Nhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_mat_khau;
        private System.Windows.Forms.TextBox txt_tai_khoan;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_dang_nhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}