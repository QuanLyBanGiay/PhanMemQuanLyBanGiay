namespace GUI
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_LapHoaDon = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_LapPhieuDichVu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_PhieuNhapHang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_LapPhieuNhapKho = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_LapThongKeBaoCao = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_HoaDon = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_DichVu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_NhaCC = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_KhachHang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_Kho = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_DonDatHang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_NhanVien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_BackUp = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_Restore = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.mainPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accordionControlElement2,
            this.accordionControlElement3});
            this.accordionControl1.Location = new System.Drawing.Point(0, 32);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(265, 660);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btn_LapHoaDon,
            this.btn_LapPhieuDichVu,
            this.btn_PhieuNhapHang,
            this.btn_LapPhieuNhapKho,
            this.btn_LapThongKeBaoCao});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement1.ImageOptions.Image")));
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "MENU";
            this.accordionControlElement1.Click += new System.EventHandler(this.accordionControlElement1_Click);
            // 
            // btn_LapHoaDon
            // 
            this.btn_LapHoaDon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_LapHoaDon.ImageOptions.Image")));
            this.btn_LapHoaDon.Name = "btn_LapHoaDon";
            this.btn_LapHoaDon.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_LapHoaDon.Text = "Lập Hoá Đơn";
            this.btn_LapHoaDon.Click += new System.EventHandler(this.btn_LapHoaDon_Click);
            // 
            // btn_LapPhieuDichVu
            // 
            this.btn_LapPhieuDichVu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_LapPhieuDichVu.ImageOptions.Image")));
            this.btn_LapPhieuDichVu.Name = "btn_LapPhieuDichVu";
            this.btn_LapPhieuDichVu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_LapPhieuDichVu.Text = "Lập phiếu dịch vụ";
            this.btn_LapPhieuDichVu.Click += new System.EventHandler(this.accordionControlElement6_Click);
            // 
            // btn_PhieuNhapHang
            // 
            this.btn_PhieuNhapHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_PhieuNhapHang.ImageOptions.Image")));
            this.btn_PhieuNhapHang.Name = "btn_PhieuNhapHang";
            this.btn_PhieuNhapHang.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_PhieuNhapHang.Text = "Lập phiếu nhập hàng";
            this.btn_PhieuNhapHang.Click += new System.EventHandler(this.accordionControlElement4_Click);
            // 
            // btn_LapPhieuNhapKho
            // 
            this.btn_LapPhieuNhapKho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_LapPhieuNhapKho.ImageOptions.Image")));
            this.btn_LapPhieuNhapKho.Name = "btn_LapPhieuNhapKho";
            this.btn_LapPhieuNhapKho.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_LapPhieuNhapKho.Text = "Lập phiếu nhập kho";
            this.btn_LapPhieuNhapKho.Click += new System.EventHandler(this.accordionControlElement7_Click);
            // 
            // btn_LapThongKeBaoCao
            // 
            this.btn_LapThongKeBaoCao.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_LapThongKeBaoCao.ImageOptions.Image")));
            this.btn_LapThongKeBaoCao.Name = "btn_LapThongKeBaoCao";
            this.btn_LapThongKeBaoCao.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_LapThongKeBaoCao.Text = "Lập thống kê báo cáo";
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btn_HoaDon,
            this.btn_DichVu,
            this.btn_NhaCC,
            this.btn_KhachHang,
            this.btn_Kho,
            this.btn_DonDatHang,
            this.btn_NhanVien});
            this.accordionControlElement2.Expanded = true;
            this.accordionControlElement2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement2.ImageOptions.Image")));
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "Hệ Thống";
            // 
            // btn_HoaDon
            // 
            this.btn_HoaDon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_HoaDon.ImageOptions.Image")));
            this.btn_HoaDon.Name = "btn_HoaDon";
            this.btn_HoaDon.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_HoaDon.Text = "Quản lý hoá đơn";
            // 
            // btn_DichVu
            // 
            this.btn_DichVu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DichVu.ImageOptions.Image")));
            this.btn_DichVu.Name = "btn_DichVu";
            this.btn_DichVu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_DichVu.Text = "Quản lý dịch vụ";
            // 
            // btn_NhaCC
            // 
            this.btn_NhaCC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_NhaCC.ImageOptions.Image")));
            this.btn_NhaCC.Name = "btn_NhaCC";
            this.btn_NhaCC.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_NhaCC.Text = "Quản lý nhà cung cấp";
            // 
            // btn_KhachHang
            // 
            this.btn_KhachHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_KhachHang.ImageOptions.Image")));
            this.btn_KhachHang.Name = "btn_KhachHang";
            this.btn_KhachHang.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_KhachHang.Text = "Quản lý khách hàng";
            // 
            // btn_Kho
            // 
            this.btn_Kho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Kho.ImageOptions.Image")));
            this.btn_Kho.Name = "btn_Kho";
            this.btn_Kho.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_Kho.Text = "Quản lý kho hàng";
            // 
            // btn_DonDatHang
            // 
            this.btn_DonDatHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DonDatHang.ImageOptions.Image")));
            this.btn_DonDatHang.Name = "btn_DonDatHang";
            this.btn_DonDatHang.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_DonDatHang.Text = "Quản lý đơn đặt hàng";
            // 
            // btn_NhanVien
            // 
            this.btn_NhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_NhanVien.ImageOptions.Image")));
            this.btn_NhanVien.Name = "btn_NhanVien";
            this.btn_NhanVien.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_NhanVien.Text = "Quản lý nhân viên";
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btn_BackUp,
            this.btn_Restore});
            this.accordionControlElement3.Expanded = true;
            this.accordionControlElement3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement3.ImageOptions.Image")));
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Text = "Setting";
            // 
            // btn_BackUp
            // 
            this.btn_BackUp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_BackUp.ImageOptions.Image")));
            this.btn_BackUp.Name = "btn_BackUp";
            this.btn_BackUp.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_BackUp.Text = "Back up";
            // 
            // btn_Restore
            // 
            this.btn_Restore.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Restore.ImageOptions.Image")));
            this.btn_Restore.Name = "btn_Restore";
            this.btn_Restore.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_Restore.Text = "Restore";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1,
            this.barButtonItem1});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1117, 31);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem1.Caption = "Hoàng Đức Quân";
            this.barStaticItem1.Id = 0;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1,
            this.barButtonItem1});
            this.fluentFormDefaultManager1.MaxItemId = 2;
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Location = new System.Drawing.Point(259, 32);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(858, 660);
            this.mainPanel.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 691);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.NavigationControl = this.accordionControl1;
            this.Text = "Hệ thống quản lý bán hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_HoaDon;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_LapHoaDon;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_LapPhieuDichVu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_LapPhieuNhapKho;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_DichVu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_NhaCC;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_KhachHang;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_Kho;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_DonDatHang;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_NhanVien;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_BackUp;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_Restore;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_LapThongKeBaoCao;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_PhieuNhapHang;
        private System.Windows.Forms.Panel mainPanel;
    }
}