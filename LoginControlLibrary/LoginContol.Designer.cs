namespace LoginControlLibrary
{
    partial class LoginContol
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDetail1 = new CustomControlsLIbrary.LabelDetail();
            this.txtTenDN = new CustomControlsLibrary.TextBoxLogin();
            this.labelDetail2 = new CustomControlsLIbrary.LabelDetail();
            this.txtMatKhau = new CustomControlsLIbrary.TextBoxPassword();
            this.btnDangNhap = new CustomControlsLIbrary.ButtonLogin();
            this.btnDangKy = new CustomControlsLIbrary.ButtonLogin();
            this.btnThoat = new CustomControlsLIbrary.ButtonLogin();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMatKhau);
            this.panel1.Controls.Add(this.labelDetail2);
            this.panel1.Controls.Add(this.txtTenDN);
            this.panel1.Controls.Add(this.labelDetail1);
            this.panel1.Location = new System.Drawing.Point(22, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 235);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnDangKy);
            this.panel2.Controls.Add(this.btnDangNhap);
            this.panel2.Location = new System.Drawing.Point(22, 263);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 110);
            this.panel2.TabIndex = 1;
            // 
            // labelDetail1
            // 
            this.labelDetail1.AutoSize = true;
            this.labelDetail1.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.labelDetail1.Location = new System.Drawing.Point(64, 70);
            this.labelDetail1.Name = "labelDetail1";
            this.labelDetail1.Size = new System.Drawing.Size(121, 20);
            this.labelDetail1.TabIndex = 0;
            this.labelDetail1.Text = "Tên đăng nhâp:";
            // 
            // txtTenDN
            // 
            this.txtTenDN.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.txtTenDN.Location = new System.Drawing.Point(212, 63);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(245, 27);
            this.txtTenDN.TabIndex = 1;
            // 
            // labelDetail2
            // 
            this.labelDetail2.AutoSize = true;
            this.labelDetail2.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.labelDetail2.Location = new System.Drawing.Point(64, 151);
            this.labelDetail2.Name = "labelDetail2";
            this.labelDetail2.Size = new System.Drawing.Size(82, 20);
            this.labelDetail2.TabIndex = 2;
            this.labelDetail2.Text = "Mật khẩu:";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.txtMatKhau.Location = new System.Drawing.Point(212, 144);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(245, 27);
            this.txtMatKhau.TabIndex = 3;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btnDangNhap.Location = new System.Drawing.Point(30, 23);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(128, 64);
            this.btnDangNhap.TabIndex = 0;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btnDangKy.Location = new System.Drawing.Point(195, 23);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(128, 64);
            this.btnDangKy.TabIndex = 1;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btnThoat.Location = new System.Drawing.Point(362, 23);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(128, 64);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // LoginContol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "LoginContol";
            this.Size = new System.Drawing.Size(564, 394);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CustomControlsLIbrary.TextBoxPassword txtMatKhau;
        private CustomControlsLIbrary.LabelDetail labelDetail2;
        private CustomControlsLibrary.TextBoxLogin txtTenDN;
        private CustomControlsLIbrary.LabelDetail labelDetail1;
        private System.Windows.Forms.Panel panel2;
        private CustomControlsLIbrary.ButtonLogin btnThoat;
        private CustomControlsLIbrary.ButtonLogin btnDangKy;
        private CustomControlsLIbrary.ButtonLogin btnDangNhap;
    }
}
