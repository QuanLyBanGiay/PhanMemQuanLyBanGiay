namespace GUI
{
    partial class frm_DangNhap
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
            this.dangNhapControl1 = new DangNhapControl.DangNhapControl();
            this.SuspendLayout();
            // 
            // dangNhapControl1
            // 
            this.dangNhapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dangNhapControl1.Location = new System.Drawing.Point(0, 0);
            this.dangNhapControl1.Name = "dangNhapControl1";
            this.dangNhapControl1.Size = new System.Drawing.Size(534, 466);
            this.dangNhapControl1.TabIndex = 0;
            // 
            // frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 466);
            this.Controls.Add(this.dangNhapControl1);
            this.Name = "frm_DangNhap";
            this.Text = "frm_DangNhap";
            this.ResumeLayout(false);

        }

        #endregion

        private DangNhapControl.DangNhapControl dangNhapControl1;
    }
}