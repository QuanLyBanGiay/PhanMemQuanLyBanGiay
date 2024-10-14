namespace GUI
{
    partial class Frm_LapHoaDon
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
        ///
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCustomColor1 = new DangNhapControl.ButtonCustomColor();
            this.dtGV_HD = new DangNhapControl.DataGridViewCustom();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_HD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xin chào mọi người";
            // 
            // buttonCustomColor1
            // 
            this.buttonCustomColor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.buttonCustomColor1.BorderColor = System.Drawing.Color.White;
            this.buttonCustomColor1.BorderSize = 2;
            this.buttonCustomColor1.FlatAppearance.BorderSize = 0;
            this.buttonCustomColor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomColor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.buttonCustomColor1.ForeColor = System.Drawing.Color.White;
            this.buttonCustomColor1.HoverBorderColor = System.Drawing.Color.Blue;
            this.buttonCustomColor1.Location = new System.Drawing.Point(53, 56);
            this.buttonCustomColor1.Name = "buttonCustomColor1";
            this.buttonCustomColor1.Size = new System.Drawing.Size(150, 33);
            this.buttonCustomColor1.TabIndex = 1;
            this.buttonCustomColor1.Text = "buttonCustomColor1";
            this.buttonCustomColor1.UseVisualStyleBackColor = false;
            // 
            // dtGV_HD
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dtGV_HD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGV_HD.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGV_HD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtGV_HD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGV_HD.EnableHeadersVisualStyles = false;
            this.dtGV_HD.GridColor = System.Drawing.Color.Blue;
            this.dtGV_HD.Location = new System.Drawing.Point(44, 126);
            this.dtGV_HD.Name = "dtGV_HD";
            this.dtGV_HD.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dtGV_HD.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtGV_HD.RowTemplate.Height = 24;
            this.dtGV_HD.Size = new System.Drawing.Size(661, 289);
            this.dtGV_HD.TabIndex = 2;
            // 
            // Frm_LapHoaDon
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(915, 690);
            this.Controls.Add(this.dtGV_HD);
            this.Controls.Add(this.buttonCustomColor1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_LapHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_HD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DangNhapControl.ButtonCustomColor buttonCustomColor1;
        private DangNhapControl.DataGridViewCustom dtGV_HD;
    }

}