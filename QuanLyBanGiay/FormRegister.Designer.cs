﻿namespace QuanLyBanGiay
{
    partial class FormRegister
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
            this.registerControl1 = new LoginControlLibrary.RegisterControl();
            this.SuspendLayout();
            // 
            // registerControl1
            // 
            this.registerControl1.Location = new System.Drawing.Point(34, 40);
            this.registerControl1.Name = "registerControl1";
            this.registerControl1.Size = new System.Drawing.Size(1239, 363);
            this.registerControl1.TabIndex = 0;
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 442);
            this.Controls.Add(this.registerControl1);
            this.Name = "FormRegister";
            this.Text = "FormRegister";
            this.ResumeLayout(false);

        }

        #endregion

        private LoginControlLibrary.RegisterControl registerControl1;
    }
}