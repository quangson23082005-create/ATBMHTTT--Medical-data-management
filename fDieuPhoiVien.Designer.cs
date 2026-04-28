using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QLBV
{
    partial class fDieuPhoiVien
    {
        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabBenhNhan = new System.Windows.Forms.TabPage();
            this.lblSoBN = new System.Windows.Forms.Label();
            this.txtTimBN = new System.Windows.Forms.TextBox();
            this.btnTimBN = new System.Windows.Forms.Button();
            this.btnThemBN = new System.Windows.Forms.Button();
            this.btnSuaBN = new System.Windows.Forms.Button();
            this.dgvBenhNhan = new System.Windows.Forms.DataGridView();
            this.panelFormBN = new System.Windows.Forms.Panel();
            this.lblFormBNTitle = new System.Windows.Forms.Label();
            this.lblMABN_F = new System.Windows.Forms.Label();
            this.txtMABN_Form = new System.Windows.Forms.TextBox();
            this.lblTENBN_F = new System.Windows.Forms.Label();
            this.txtTENBN_Form = new System.Windows.Forms.TextBox();
            this.lblPhai_F = new System.Windows.Forms.Label();
            this.cboPhaiBS = new System.Windows.Forms.ComboBox();
            this.lblNgaySinh_F = new System.Windows.Forms.Label();
            this.txtNgaySinhBN = new System.Windows.Forms.TextBox();
            this.lblCCCD_F = new System.Windows.Forms.Label();
            this.txtCCCD_Form = new System.Windows.Forms.TextBox();
            this.lblSoNha_F = new System.Windows.Forms.Label();
            this.txtSoNha = new System.Windows.Forms.TextBox();
            this.lblTenDuong_F = new System.Windows.Forms.Label();
            this.txtTenDuong = new System.Windows.Forms.TextBox();
            this.lblQuanHuyen_F = new System.Windows.Forms.Label();
            this.txtQuanHuyen = new System.Windows.Forms.TextBox();
            this.lblTinhTP_F = new System.Windows.Forms.Label();
            this.txtTinhTP = new System.Windows.Forms.TextBox();
            this.btnLuuBN = new System.Windows.Forms.Button();
            this.btnHuyBN = new System.Windows.Forms.Button();
            this.tabHSBA = new System.Windows.Forms.TabPage();
            this.lblSoHSBA = new System.Windows.Forms.Label();
            this.btnThemHSBA = new System.Windows.Forms.Button();
            this.dgvHSBA = new System.Windows.Forms.DataGridView();
            this.grpPhanCongBS = new System.Windows.Forms.GroupBox();
            this.lblChonBS = new System.Windows.Forms.Label();
            this.cboChonBS = new System.Windows.Forms.ComboBox();
            this.lblMaKhoa = new System.Windows.Forms.Label();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.btnPhanCongBS = new System.Windows.Forms.Button();
            this.panelFormHSBA = new System.Windows.Forms.Panel();
            this.lblFormHSBATitle = new System.Windows.Forms.Label();
            this.lblMAHSBA_F = new System.Windows.Forms.Label();
            this.txtMAHSBA_Form = new System.Windows.Forms.TextBox();
            this.lblMABN_HSBA_F = new System.Windows.Forms.Label();
            this.txtMABN_HSBA = new System.Windows.Forms.TextBox();
            this.lblNgayHSBA_F = new System.Windows.Forms.Label();
            this.txtNgayHSBA = new System.Windows.Forms.TextBox();
            this.lblMaKhoaNew_F = new System.Windows.Forms.Label();
            this.txtMaKhoaNew = new System.Windows.Forms.TextBox();
            this.btnLuuHSBA = new System.Windows.Forms.Button();
            this.btnHuyHSBA = new System.Windows.Forms.Button();
            this.tabKTV = new System.Windows.Forms.TabPage();
            this.lblSoDV = new System.Windows.Forms.Label();
            this.dgvHSBA_DV = new System.Windows.Forms.DataGridView();
            this.grpPhanCongKTV = new System.Windows.Forms.GroupBox();
            this.lblChonKTV = new System.Windows.Forms.Label();
            this.cboChonKTV = new System.Windows.Forms.ComboBox();
            this.btnPhanCongKTV = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabBenhNhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhNhan)).BeginInit();
            this.panelFormBN.SuspendLayout();
            this.tabHSBA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHSBA)).BeginInit();
            this.grpPhanCongBS.SuspendLayout();
            this.panelFormHSBA.SuspendLayout();
            this.tabKTV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHSBA_DV)).BeginInit();
            this.grpPhanCongKTV.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1459, 43);
            this.panelTop.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1459, 43);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DIEU PHOI VIEN - Quan ly he thong";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBottom.Controls.Add(this.btnLamMoi);
            this.panelBottom.Controls.Add(this.btnDangXuat);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 666);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1459, 39);
            this.panelBottom.TabIndex = 1;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(10, 7);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(86, 24);
            this.btnLamMoi.TabIndex = 0;
            this.btnLamMoi.Text = "Lam moi";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Location = new System.Drawing.Point(107, 7);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(86, 24);
            this.btnDangXuat.TabIndex = 1;
            this.btnDangXuat.Text = "Dang xuat";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabBenhNhan);
            this.tabControl.Controls.Add(this.tabHSBA);
            this.tabControl.Controls.Add(this.tabKTV);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tabControl.Location = new System.Drawing.Point(0, 43);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1459, 623);
            this.tabControl.TabIndex = 0;
            // 
            // tabBenhNhan
            // 
            this.tabBenhNhan.Controls.Add(this.panelFormBN);
            this.tabBenhNhan.Controls.Add(this.lblSoBN);
            this.tabBenhNhan.Controls.Add(this.txtTimBN);
            this.tabBenhNhan.Controls.Add(this.btnTimBN);
            this.tabBenhNhan.Controls.Add(this.btnThemBN);
            this.tabBenhNhan.Controls.Add(this.btnSuaBN);
            this.tabBenhNhan.Controls.Add(this.dgvBenhNhan);
            this.tabBenhNhan.Location = new System.Drawing.Point(4, 26);
            this.tabBenhNhan.Name = "tabBenhNhan";
            this.tabBenhNhan.Size = new System.Drawing.Size(1451, 526);
            this.tabBenhNhan.TabIndex = 0;
            this.tabBenhNhan.Text = "Quan ly Benh Nhan";
            this.tabBenhNhan.Click += new System.EventHandler(this.tabBenhNhan_Click);
            // 
            // lblSoBN
            // 
            this.lblSoBN.AutoSize = true;
            this.lblSoBN.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSoBN.ForeColor = System.Drawing.Color.Gray;
            this.lblSoBN.Location = new System.Drawing.Point(7, 7);
            this.lblSoBN.Name = "lblSoBN";
            this.lblSoBN.Size = new System.Drawing.Size(106, 15);
            this.lblSoBN.TabIndex = 0;
            this.lblSoBN.Text = "Tong: 0 benh nhan";
            // 
            // txtTimBN
            // 
            this.txtTimBN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimBN.ForeColor = System.Drawing.Color.Gray;
            this.txtTimBN.Location = new System.Drawing.Point(7, 24);
            this.txtTimBN.Name = "txtTimBN";
            this.txtTimBN.Size = new System.Drawing.Size(155, 23);
            this.txtTimBN.TabIndex = 1;
            this.txtTimBN.Text = "Tim kiem MABN hoac ten...";
            this.txtTimBN.GotFocus += new System.EventHandler(this.txtTimBN_GotFocus);
            this.txtTimBN.LostFocus += new System.EventHandler(this.txtTimBN_LostFocus);
            // 
            // btnTimBN
            // 
            this.btnTimBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnTimBN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimBN.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnTimBN.ForeColor = System.Drawing.Color.White;
            this.btnTimBN.Location = new System.Drawing.Point(167, 24);
            this.btnTimBN.Name = "btnTimBN";
            this.btnTimBN.Size = new System.Drawing.Size(56, 23);
            this.btnTimBN.TabIndex = 2;
            this.btnTimBN.Text = "Tim";
            this.btnTimBN.UseVisualStyleBackColor = false;
            this.btnTimBN.Click += new System.EventHandler(this.btnTimBN_Click);
            // 
            // btnThemBN
            // 
            this.btnThemBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnThemBN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemBN.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnThemBN.ForeColor = System.Drawing.Color.White;
            this.btnThemBN.Location = new System.Drawing.Point(231, 24);
            this.btnThemBN.Name = "btnThemBN";
            this.btnThemBN.Size = new System.Drawing.Size(69, 23);
            this.btnThemBN.TabIndex = 3;
            this.btnThemBN.Text = "Them BN";
            this.btnThemBN.UseVisualStyleBackColor = false;
            this.btnThemBN.Click += new System.EventHandler(this.btnThemBN_Click);
            // 
            // btnSuaBN
            // 
            this.btnSuaBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnSuaBN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaBN.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnSuaBN.ForeColor = System.Drawing.Color.White;
            this.btnSuaBN.Location = new System.Drawing.Point(307, 24);
            this.btnSuaBN.Name = "btnSuaBN";
            this.btnSuaBN.Size = new System.Drawing.Size(69, 23);
            this.btnSuaBN.TabIndex = 4;
            this.btnSuaBN.Text = "Sua BN";
            this.btnSuaBN.UseVisualStyleBackColor = false;
            this.btnSuaBN.Click += new System.EventHandler(this.btnSuaBN_Click);
            // 
            // dgvBenhNhan
            // 
            this.dgvBenhNhan.AllowUserToAddRows = false;
            this.dgvBenhNhan.AllowUserToDeleteRows = false;
            this.dgvBenhNhan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvBenhNhan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBenhNhan.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.dgvBenhNhan.Location = new System.Drawing.Point(7, 50);
            this.dgvBenhNhan.Name = "dgvBenhNhan";
            this.dgvBenhNhan.ReadOnly = true;
            this.dgvBenhNhan.RowHeadersVisible = false;
            this.dgvBenhNhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBenhNhan.Size = new System.Drawing.Size(1436, 461);
            this.dgvBenhNhan.TabIndex = 5;
            // 
            // panelFormBN
            // 
            this.panelFormBN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelFormBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panelFormBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFormBN.Controls.Add(this.lblFormBNTitle);
            this.panelFormBN.Controls.Add(this.lblMABN_F);
            this.panelFormBN.Controls.Add(this.txtMABN_Form);
            this.panelFormBN.Controls.Add(this.lblTENBN_F);
            this.panelFormBN.Controls.Add(this.txtTENBN_Form);
            this.panelFormBN.Controls.Add(this.lblPhai_F);
            this.panelFormBN.Controls.Add(this.cboPhaiBS);
            this.panelFormBN.Controls.Add(this.lblNgaySinh_F);
            this.panelFormBN.Controls.Add(this.txtNgaySinhBN);
            this.panelFormBN.Controls.Add(this.lblCCCD_F);
            this.panelFormBN.Controls.Add(this.txtCCCD_Form);
            this.panelFormBN.Controls.Add(this.lblSoNha_F);
            this.panelFormBN.Controls.Add(this.txtSoNha);
            this.panelFormBN.Controls.Add(this.lblTenDuong_F);
            this.panelFormBN.Controls.Add(this.txtTenDuong);
            this.panelFormBN.Controls.Add(this.lblQuanHuyen_F);
            this.panelFormBN.Controls.Add(this.txtQuanHuyen);
            this.panelFormBN.Controls.Add(this.lblTinhTP_F);
            this.panelFormBN.Controls.Add(this.txtTinhTP);
            this.panelFormBN.Controls.Add(this.btnLuuBN);
            this.panelFormBN.Controls.Add(this.btnHuyBN);
            this.panelFormBN.Location = new System.Drawing.Point(813, 50);
            this.panelFormBN.Name = "panelFormBN";
            this.panelFormBN.Size = new System.Drawing.Size(292, 461);
            this.panelFormBN.TabIndex = 6;
            this.panelFormBN.Visible = false;
            // 
            // lblFormBNTitle
            // 
            this.lblFormBNTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblFormBNTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFormBNTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblFormBNTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormBNTitle.Location = new System.Drawing.Point(0, 0);
            this.lblFormBNTitle.Name = "lblFormBNTitle";
            this.lblFormBNTitle.Size = new System.Drawing.Size(290, 26);
            this.lblFormBNTitle.TabIndex = 0;
            this.lblFormBNTitle.Text = "THEM BENH NHAN MOI";
            this.lblFormBNTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFormBNTitle.Click += new System.EventHandler(this.lblFormBNTitle_Click_1);
            // 
            // lblMABN_F
            // 
            this.lblMABN_F.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblMABN_F.Location = new System.Drawing.Point(9, 36);
            this.lblMABN_F.Name = "lblMABN_F";
            this.lblMABN_F.Size = new System.Drawing.Size(73, 16);
            this.lblMABN_F.TabIndex = 1;
            this.lblMABN_F.Text = "Ma BN:";
            // 
            // txtMABN_Form
            // 
            this.txtMABN_Form.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMABN_Form.Location = new System.Drawing.Point(86, 35);
            this.txtMABN_Form.Name = "txtMABN_Form";
            this.txtMABN_Form.Size = new System.Drawing.Size(189, 23);
            this.txtMABN_Form.TabIndex = 2;
            // 
            // lblTENBN_F
            // 
            this.lblTENBN_F.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTENBN_F.Location = new System.Drawing.Point(9, 63);
            this.lblTENBN_F.Name = "lblTENBN_F";
            this.lblTENBN_F.Size = new System.Drawing.Size(73, 16);
            this.lblTENBN_F.TabIndex = 3;
            this.lblTENBN_F.Text = "Ho ten:";
            // 
            // txtTENBN_Form
            // 
            this.txtTENBN_Form.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTENBN_Form.Location = new System.Drawing.Point(86, 62);
            this.txtTENBN_Form.Name = "txtTENBN_Form";
            this.txtTENBN_Form.Size = new System.Drawing.Size(189, 23);
            this.txtTENBN_Form.TabIndex = 4;
            // 
            // lblPhai_F
            // 
            this.lblPhai_F.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblPhai_F.Location = new System.Drawing.Point(9, 90);
            this.lblPhai_F.Name = "lblPhai_F";
            this.lblPhai_F.Size = new System.Drawing.Size(73, 16);
            this.lblPhai_F.TabIndex = 5;
            this.lblPhai_F.Text = "Phai:";
            // 
            // cboPhaiBS
            // 
            this.cboPhaiBS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhaiBS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboPhaiBS.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.cboPhaiBS.Location = new System.Drawing.Point(86, 88);
            this.cboPhaiBS.Name = "cboPhaiBS";
            this.cboPhaiBS.Size = new System.Drawing.Size(78, 23);
            this.cboPhaiBS.TabIndex = 6;
            // 
            // lblNgaySinh_F
            // 
            this.lblNgaySinh_F.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblNgaySinh_F.Location = new System.Drawing.Point(9, 117);
            this.lblNgaySinh_F.Name = "lblNgaySinh_F";
            this.lblNgaySinh_F.Size = new System.Drawing.Size(73, 16);
            this.lblNgaySinh_F.TabIndex = 7;
            this.lblNgaySinh_F.Text = "Ngay sinh:";
            // 
            // txtNgaySinhBN
            // 
            this.txtNgaySinhBN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNgaySinhBN.Location = new System.Drawing.Point(86, 115);
            this.txtNgaySinhBN.Name = "txtNgaySinhBN";
            this.txtNgaySinhBN.Size = new System.Drawing.Size(112, 23);
            this.txtNgaySinhBN.TabIndex = 8;
            // 
            // lblCCCD_F
            // 
            this.lblCCCD_F.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCCCD_F.Location = new System.Drawing.Point(9, 144);
            this.lblCCCD_F.Name = "lblCCCD_F";
            this.lblCCCD_F.Size = new System.Drawing.Size(73, 16);
            this.lblCCCD_F.TabIndex = 9;
            this.lblCCCD_F.Text = "CCCD:";
            // 
            // txtCCCD_Form
            // 
            this.txtCCCD_Form.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCCCD_Form.Location = new System.Drawing.Point(86, 142);
            this.txtCCCD_Form.Name = "txtCCCD_Form";
            this.txtCCCD_Form.Size = new System.Drawing.Size(189, 23);
            this.txtCCCD_Form.TabIndex = 10;
            // 
            // lblSoNha_F
            // 
            this.lblSoNha_F.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSoNha_F.Location = new System.Drawing.Point(9, 171);
            this.lblSoNha_F.Name = "lblSoNha_F";
            this.lblSoNha_F.Size = new System.Drawing.Size(73, 16);
            this.lblSoNha_F.TabIndex = 11;
            this.lblSoNha_F.Text = "So nha:";
            // 
            // txtSoNha
            // 
            this.txtSoNha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoNha.Location = new System.Drawing.Point(86, 169);
            this.txtSoNha.Name = "txtSoNha";
            this.txtSoNha.Size = new System.Drawing.Size(189, 23);
            this.txtSoNha.TabIndex = 12;
            // 
            // lblTenDuong_F
            // 
            this.lblTenDuong_F.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTenDuong_F.Location = new System.Drawing.Point(9, 198);
            this.lblTenDuong_F.Name = "lblTenDuong_F";
            this.lblTenDuong_F.Size = new System.Drawing.Size(73, 16);
            this.lblTenDuong_F.TabIndex = 13;
            this.lblTenDuong_F.Text = "Ten duong:";
            // 
            // txtTenDuong
            // 
            this.txtTenDuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenDuong.Location = new System.Drawing.Point(86, 196);
            this.txtTenDuong.Name = "txtTenDuong";
            this.txtTenDuong.Size = new System.Drawing.Size(189, 23);
            this.txtTenDuong.TabIndex = 14;
            // 
            // lblQuanHuyen_F
            // 
            this.lblQuanHuyen_F.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblQuanHuyen_F.Location = new System.Drawing.Point(9, 224);
            this.lblQuanHuyen_F.Name = "lblQuanHuyen_F";
            this.lblQuanHuyen_F.Size = new System.Drawing.Size(73, 16);
            this.lblQuanHuyen_F.TabIndex = 15;
            this.lblQuanHuyen_F.Text = "Quan/Huyen:";
            // 
            // txtQuanHuyen
            // 
            this.txtQuanHuyen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuanHuyen.Location = new System.Drawing.Point(86, 223);
            this.txtQuanHuyen.Name = "txtQuanHuyen";
            this.txtQuanHuyen.Size = new System.Drawing.Size(189, 23);
            this.txtQuanHuyen.TabIndex = 16;
            // 
            // lblTinhTP_F
            // 
            this.lblTinhTP_F.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTinhTP_F.Location = new System.Drawing.Point(9, 251);
            this.lblTinhTP_F.Name = "lblTinhTP_F";
            this.lblTinhTP_F.Size = new System.Drawing.Size(73, 16);
            this.lblTinhTP_F.TabIndex = 17;
            this.lblTinhTP_F.Text = "Tinh/TP:";
            // 
            // txtTinhTP
            // 
            this.txtTinhTP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTinhTP.Location = new System.Drawing.Point(86, 250);
            this.txtTinhTP.Name = "txtTinhTP";
            this.txtTinhTP.Size = new System.Drawing.Size(189, 23);
            this.txtTinhTP.TabIndex = 18;
            // 
            // btnLuuBN
            // 
            this.btnLuuBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnLuuBN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuBN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuuBN.ForeColor = System.Drawing.Color.White;
            this.btnLuuBN.Location = new System.Drawing.Point(9, 351);
            this.btnLuuBN.Name = "btnLuuBN";
            this.btnLuuBN.Size = new System.Drawing.Size(103, 24);
            this.btnLuuBN.TabIndex = 19;
            this.btnLuuBN.Text = "Luu";
            this.btnLuuBN.UseVisualStyleBackColor = false;
            this.btnLuuBN.Click += new System.EventHandler(this.btnLuuBN_Click);
            // 
            // btnHuyBN
            // 
            this.btnHuyBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnHuyBN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyBN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHuyBN.ForeColor = System.Drawing.Color.White;
            this.btnHuyBN.Location = new System.Drawing.Point(120, 351);
            this.btnHuyBN.Name = "btnHuyBN";
            this.btnHuyBN.Size = new System.Drawing.Size(86, 24);
            this.btnHuyBN.TabIndex = 20;
            this.btnHuyBN.Text = "Huy";
            this.btnHuyBN.UseVisualStyleBackColor = false;
            this.btnHuyBN.Click += new System.EventHandler(this.btnHuyBN_Click);
            // 
            // tabHSBA
            // 
            this.tabHSBA.Controls.Add(this.lblSoHSBA);
            this.tabHSBA.Controls.Add(this.btnThemHSBA);
            this.tabHSBA.Controls.Add(this.grpPhanCongBS);
            this.tabHSBA.Controls.Add(this.panelFormHSBA);
            this.tabHSBA.Controls.Add(this.dgvHSBA);
            this.tabHSBA.Location = new System.Drawing.Point(4, 26);
            this.tabHSBA.Name = "tabHSBA";
            this.tabHSBA.Size = new System.Drawing.Size(1451, 593);
            this.tabHSBA.TabIndex = 1;
            this.tabHSBA.Text = "Phan cong HSBA";
            // 
            // lblSoHSBA
            // 
            this.lblSoHSBA.AutoSize = true;
            this.lblSoHSBA.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSoHSBA.ForeColor = System.Drawing.Color.Gray;
            this.lblSoHSBA.Location = new System.Drawing.Point(7, 7);
            this.lblSoHSBA.Name = "lblSoHSBA";
            this.lblSoHSBA.Size = new System.Drawing.Size(78, 15);
            this.lblSoHSBA.TabIndex = 0;
            this.lblSoHSBA.Text = "Tong: 0 ho so";
            // 
            // btnThemHSBA
            // 
            this.btnThemHSBA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnThemHSBA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemHSBA.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnThemHSBA.ForeColor = System.Drawing.Color.White;
            this.btnThemHSBA.Location = new System.Drawing.Point(7, 24);
            this.btnThemHSBA.Name = "btnThemHSBA";
            this.btnThemHSBA.Size = new System.Drawing.Size(94, 28);
            this.btnThemHSBA.TabIndex = 1;
            this.btnThemHSBA.Text = "Tao HSBA moi";
            this.btnThemHSBA.UseVisualStyleBackColor = false;
            this.btnThemHSBA.Click += new System.EventHandler(this.btnThemHSBA_Click);
            // 
            // dgvHSBA
            // 
            this.dgvHSBA.AllowUserToAddRows = false;
            this.dgvHSBA.AllowUserToDeleteRows = false;
            this.dgvHSBA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHSBA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHSBA.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.dgvHSBA.Location = new System.Drawing.Point(8, 58);
            this.dgvHSBA.Name = "dgvHSBA";
            this.dgvHSBA.ReadOnly = true;
            this.dgvHSBA.RowHeadersVisible = false;
            this.dgvHSBA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHSBA.Size = new System.Drawing.Size(1433, 454);
            this.dgvHSBA.TabIndex = 2;
            // 
            // grpPhanCongBS
            // 
            this.grpPhanCongBS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPhanCongBS.Controls.Add(this.lblChonBS);
            this.grpPhanCongBS.Controls.Add(this.cboChonBS);
            this.grpPhanCongBS.Controls.Add(this.lblMaKhoa);
            this.grpPhanCongBS.Controls.Add(this.txtMaKhoa);
            this.grpPhanCongBS.Controls.Add(this.btnPhanCongBS);
            this.grpPhanCongBS.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.grpPhanCongBS.Location = new System.Drawing.Point(7, 510);
            this.grpPhanCongBS.Name = "grpPhanCongBS";
            this.grpPhanCongBS.Size = new System.Drawing.Size(1433, 48);
            this.grpPhanCongBS.TabIndex = 3;
            this.grpPhanCongBS.TabStop = false;
            this.grpPhanCongBS.Text = "Phan cong Bac Si cho HSBA dang chon";
            // 
            // lblChonBS
            // 
            this.lblChonBS.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblChonBS.Location = new System.Drawing.Point(9, 19);
            this.lblChonBS.Name = "lblChonBS";
            this.lblChonBS.Size = new System.Drawing.Size(47, 16);
            this.lblChonBS.TabIndex = 0;
            this.lblChonBS.Text = "Bac si:";
            // 
            // cboChonBS
            // 
            this.cboChonBS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChonBS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboChonBS.Location = new System.Drawing.Point(60, 17);
            this.cboChonBS.Name = "cboChonBS";
            this.cboChonBS.Size = new System.Drawing.Size(215, 23);
            this.cboChonBS.TabIndex = 1;
            // 
            // lblMaKhoa
            // 
            this.lblMaKhoa.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblMaKhoa.Location = new System.Drawing.Point(287, 19);
            this.lblMaKhoa.Name = "lblMaKhoa";
            this.lblMaKhoa.Size = new System.Drawing.Size(51, 16);
            this.lblMaKhoa.TabIndex = 2;
            this.lblMaKhoa.Text = "Ma khoa:";
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaKhoa.Location = new System.Drawing.Point(343, 17);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(95, 23);
            this.txtMaKhoa.TabIndex = 3;
            // 
            // btnPhanCongBS
            // 
            this.btnPhanCongBS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnPhanCongBS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhanCongBS.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnPhanCongBS.ForeColor = System.Drawing.Color.White;
            this.btnPhanCongBS.Location = new System.Drawing.Point(450, 16);
            this.btnPhanCongBS.Name = "btnPhanCongBS";
            this.btnPhanCongBS.Size = new System.Drawing.Size(120, 23);
            this.btnPhanCongBS.TabIndex = 4;
            this.btnPhanCongBS.Text = "Xac nhan phan cong";
            this.btnPhanCongBS.UseVisualStyleBackColor = false;
            this.btnPhanCongBS.Click += new System.EventHandler(this.btnPhanCongBS_Click);
            // 
            // panelFormHSBA
            // 
            this.panelFormHSBA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panelFormHSBA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFormHSBA.Controls.Add(this.lblFormHSBATitle);
            this.panelFormHSBA.Controls.Add(this.lblMAHSBA_F);
            this.panelFormHSBA.Controls.Add(this.txtMAHSBA_Form);
            this.panelFormHSBA.Controls.Add(this.lblMABN_HSBA_F);
            this.panelFormHSBA.Controls.Add(this.txtMABN_HSBA);
            this.panelFormHSBA.Controls.Add(this.lblNgayHSBA_F);
            this.panelFormHSBA.Controls.Add(this.txtNgayHSBA);
            this.panelFormHSBA.Controls.Add(this.lblMaKhoaNew_F);
            this.panelFormHSBA.Controls.Add(this.txtMaKhoaNew);
            this.panelFormHSBA.Controls.Add(this.btnLuuHSBA);
            this.panelFormHSBA.Controls.Add(this.btnHuyHSBA);
            this.panelFormHSBA.Location = new System.Drawing.Point(217, 58);
            this.panelFormHSBA.Name = "panelFormHSBA";
            this.panelFormHSBA.Size = new System.Drawing.Size(326, 208);
            this.panelFormHSBA.TabIndex = 4;
            this.panelFormHSBA.Visible = false;
            // 
            // lblFormHSBATitle
            // 
            this.lblFormHSBATitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblFormHSBATitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFormHSBATitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblFormHSBATitle.ForeColor = System.Drawing.Color.White;
            this.lblFormHSBATitle.Location = new System.Drawing.Point(0, 0);
            this.lblFormHSBATitle.Name = "lblFormHSBATitle";
            this.lblFormHSBATitle.Size = new System.Drawing.Size(324, 24);
            this.lblFormHSBATitle.TabIndex = 0;
            this.lblFormHSBATitle.Text = "TAO HO SO BENH AN MOI";
            this.lblFormHSBATitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMAHSBA_F
            // 
            this.lblMAHSBA_F.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblMAHSBA_F.Location = new System.Drawing.Point(9, 36);
            this.lblMAHSBA_F.Name = "lblMAHSBA_F";
            this.lblMAHSBA_F.Size = new System.Drawing.Size(73, 16);
            this.lblMAHSBA_F.TabIndex = 1;
            this.lblMAHSBA_F.Text = "Ma HSBA:";
            // 
            // txtMAHSBA_Form
            // 
            this.txtMAHSBA_Form.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMAHSBA_Form.Location = new System.Drawing.Point(86, 35);
            this.txtMAHSBA_Form.Name = "txtMAHSBA_Form";
            this.txtMAHSBA_Form.Size = new System.Drawing.Size(223, 23);
            this.txtMAHSBA_Form.TabIndex = 2;
            // 
            // lblMABN_HSBA_F
            // 
            this.lblMABN_HSBA_F.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblMABN_HSBA_F.Location = new System.Drawing.Point(9, 65);
            this.lblMABN_HSBA_F.Name = "lblMABN_HSBA_F";
            this.lblMABN_HSBA_F.Size = new System.Drawing.Size(73, 16);
            this.lblMABN_HSBA_F.TabIndex = 3;
            this.lblMABN_HSBA_F.Text = "Ma BN:";
            // 
            // txtMABN_HSBA
            // 
            this.txtMABN_HSBA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMABN_HSBA.Location = new System.Drawing.Point(86, 63);
            this.txtMABN_HSBA.Name = "txtMABN_HSBA";
            this.txtMABN_HSBA.Size = new System.Drawing.Size(223, 23);
            this.txtMABN_HSBA.TabIndex = 4;
            // 
            // lblNgayHSBA_F
            // 
            this.lblNgayHSBA_F.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblNgayHSBA_F.Location = new System.Drawing.Point(9, 94);
            this.lblNgayHSBA_F.Name = "lblNgayHSBA_F";
            this.lblNgayHSBA_F.Size = new System.Drawing.Size(73, 16);
            this.lblNgayHSBA_F.TabIndex = 5;
            this.lblNgayHSBA_F.Text = "Ngay (dd/MM/yyyy):";
            // 
            // txtNgayHSBA
            // 
            this.txtNgayHSBA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNgayHSBA.Location = new System.Drawing.Point(86, 92);
            this.txtNgayHSBA.Name = "txtNgayHSBA";
            this.txtNgayHSBA.Size = new System.Drawing.Size(112, 23);
            this.txtNgayHSBA.TabIndex = 6;
            // 
            // lblMaKhoaNew_F
            // 
            this.lblMaKhoaNew_F.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblMaKhoaNew_F.Location = new System.Drawing.Point(9, 122);
            this.lblMaKhoaNew_F.Name = "lblMaKhoaNew_F";
            this.lblMaKhoaNew_F.Size = new System.Drawing.Size(73, 16);
            this.lblMaKhoaNew_F.TabIndex = 7;
            this.lblMaKhoaNew_F.Text = "Ma khoa:";
            // 
            // txtMaKhoaNew
            // 
            this.txtMaKhoaNew.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaKhoaNew.Location = new System.Drawing.Point(86, 120);
            this.txtMaKhoaNew.Name = "txtMaKhoaNew";
            this.txtMaKhoaNew.Size = new System.Drawing.Size(112, 23);
            this.txtMaKhoaNew.TabIndex = 8;
            // 
            // btnLuuHSBA
            // 
            this.btnLuuHSBA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnLuuHSBA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuHSBA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuuHSBA.ForeColor = System.Drawing.Color.White;
            this.btnLuuHSBA.Location = new System.Drawing.Point(9, 173);
            this.btnLuuHSBA.Name = "btnLuuHSBA";
            this.btnLuuHSBA.Size = new System.Drawing.Size(86, 23);
            this.btnLuuHSBA.TabIndex = 9;
            this.btnLuuHSBA.Text = "Luu";
            this.btnLuuHSBA.UseVisualStyleBackColor = false;
            this.btnLuuHSBA.Click += new System.EventHandler(this.btnLuuHSBA_Click);
            // 
            // btnHuyHSBA
            // 
            this.btnHuyHSBA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnHuyHSBA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyHSBA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHuyHSBA.ForeColor = System.Drawing.Color.White;
            this.btnHuyHSBA.Location = new System.Drawing.Point(103, 173);
            this.btnHuyHSBA.Name = "btnHuyHSBA";
            this.btnHuyHSBA.Size = new System.Drawing.Size(77, 23);
            this.btnHuyHSBA.TabIndex = 10;
            this.btnHuyHSBA.Text = "Huy";
            this.btnHuyHSBA.UseVisualStyleBackColor = false;
            this.btnHuyHSBA.Click += new System.EventHandler(this.btnHuyHSBA_Click);
            // 
            // tabKTV
            // 
            this.tabKTV.Controls.Add(this.lblSoDV);
            this.tabKTV.Controls.Add(this.grpPhanCongKTV);
            this.tabKTV.Controls.Add(this.dgvHSBA_DV);
            this.tabKTV.Location = new System.Drawing.Point(4, 26);
            this.tabKTV.Name = "tabKTV";
            this.tabKTV.Size = new System.Drawing.Size(1451, 593);
            this.tabKTV.TabIndex = 2;
            this.tabKTV.Text = "Dieu phoi KTV";
            // 
            // lblSoDV
            // 
            this.lblSoDV.AutoSize = true;
            this.lblSoDV.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSoDV.ForeColor = System.Drawing.Color.Gray;
            this.lblSoDV.Location = new System.Drawing.Point(7, 7);
            this.lblSoDV.Name = "lblSoDV";
            this.lblSoDV.Size = new System.Drawing.Size(88, 15);
            this.lblSoDV.TabIndex = 0;
            this.lblSoDV.Text = "Tong: 0 dich vu";
            // 
            // dgvHSBA_DV
            // 
            this.dgvHSBA_DV.AllowUserToAddRows = false;
            this.dgvHSBA_DV.AllowUserToDeleteRows = false;
            this.dgvHSBA_DV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHSBA_DV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHSBA_DV.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.dgvHSBA_DV.Location = new System.Drawing.Point(7, 26);
            this.dgvHSBA_DV.Name = "dgvHSBA_DV";
            this.dgvHSBA_DV.ReadOnly = true;
            this.dgvHSBA_DV.RowHeadersVisible = false;
            this.dgvHSBA_DV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHSBA_DV.Size = new System.Drawing.Size(1433, 489);
            this.dgvHSBA_DV.TabIndex = 1;
            this.dgvHSBA_DV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHSBA_DV_CellContentClick);
            // 
            // grpPhanCongKTV
            // 
            this.grpPhanCongKTV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPhanCongKTV.Controls.Add(this.lblChonKTV);
            this.grpPhanCongKTV.Controls.Add(this.cboChonKTV);
            this.grpPhanCongKTV.Controls.Add(this.btnPhanCongKTV);
            this.grpPhanCongKTV.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.grpPhanCongKTV.Location = new System.Drawing.Point(7, 522);
            this.grpPhanCongKTV.Name = "grpPhanCongKTV";
            this.grpPhanCongKTV.Size = new System.Drawing.Size(1433, 48);
            this.grpPhanCongKTV.TabIndex = 2;
            this.grpPhanCongKTV.TabStop = false;
            this.grpPhanCongKTV.Text = "Dieu phoi KTV cho dich vu dang chon";
            // 
            // lblChonKTV
            // 
            this.lblChonKTV.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblChonKTV.Location = new System.Drawing.Point(9, 19);
            this.lblChonKTV.Name = "lblChonKTV";
            this.lblChonKTV.Size = new System.Drawing.Size(73, 16);
            this.lblChonKTV.TabIndex = 0;
            this.lblChonKTV.Text = "Ky thuat vien:";
            // 
            // cboChonKTV
            // 
            this.cboChonKTV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChonKTV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboChonKTV.Location = new System.Drawing.Point(86, 17);
            this.cboChonKTV.Name = "cboChonKTV";
            this.cboChonKTV.Size = new System.Drawing.Size(215, 23);
            this.cboChonKTV.TabIndex = 1;
            // 
            // btnPhanCongKTV
            // 
            this.btnPhanCongKTV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnPhanCongKTV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhanCongKTV.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnPhanCongKTV.ForeColor = System.Drawing.Color.White;
            this.btnPhanCongKTV.Location = new System.Drawing.Point(313, 16);
            this.btnPhanCongKTV.Name = "btnPhanCongKTV";
            this.btnPhanCongKTV.Size = new System.Drawing.Size(120, 23);
            this.btnPhanCongKTV.TabIndex = 2;
            this.btnPhanCongKTV.Text = "Xac nhan dieu phoi";
            this.btnPhanCongKTV.UseVisualStyleBackColor = false;
            this.btnPhanCongKTV.Click += new System.EventHandler(this.btnPhanCongKTV_Click);
            // 
            // fDieuPhoiVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 705);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.MinimumSize = new System.Drawing.Size(688, 482);
            this.Name = "fDieuPhoiVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dieu Phoi Vien";
            this.Load += new System.EventHandler(this.fDieuPhoiVien_Load);
            this.panelTop.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabBenhNhan.ResumeLayout(false);
            this.tabBenhNhan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhNhan)).EndInit();
            this.panelFormBN.ResumeLayout(false);
            this.panelFormBN.PerformLayout();
            this.tabHSBA.ResumeLayout(false);
            this.tabHSBA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHSBA)).EndInit();
            this.grpPhanCongBS.ResumeLayout(false);
            this.grpPhanCongBS.PerformLayout();
            this.panelFormHSBA.ResumeLayout(false);
            this.panelFormHSBA.PerformLayout();
            this.tabKTV.ResumeLayout(false);
            this.tabKTV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHSBA_DV)).EndInit();
            this.grpPhanCongKTV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        // ── Field declarations ────────────────────────────────────────────────
        private Panel panelTop;
        private Panel panelBottom;
        private Label lblTitle;
        private TabControl tabControl;
        private TabPage tabBenhNhan;
        private TabPage tabHSBA;
        private TabPage tabKTV;
        private Button btnLamMoi;
        private Button btnDangXuat;

        // Tab 1
        private Label lblSoBN;
        private TextBox txtTimBN;
        private Button btnTimBN;
        private Button btnThemBN;
        private Button btnSuaBN;
        private DataGridView dgvBenhNhan;
        private Panel panelFormBN;
        private Label lblFormBNTitle;
        private Label lblMABN_F;
        private TextBox txtMABN_Form;
        private Label lblTENBN_F;
        private TextBox txtTENBN_Form;
        private Label lblPhai_F;
        private ComboBox cboPhaiBS;
        private Label lblNgaySinh_F;
        private TextBox txtNgaySinhBN;
        private Label lblCCCD_F;
        private TextBox txtCCCD_Form;
        private Label lblSoNha_F;
        private TextBox txtSoNha;
        private Label lblTenDuong_F;
        private TextBox txtTenDuong;
        private Label lblQuanHuyen_F;
        private TextBox txtQuanHuyen;
        private Label lblTinhTP_F;
        private TextBox txtTinhTP;
        private Button btnLuuBN;
        private Button btnHuyBN;

        // Tab 2
        private Label lblSoHSBA;
        private Button btnThemHSBA;
        private DataGridView dgvHSBA;
        private GroupBox grpPhanCongBS;
        private Label lblChonBS;
        private ComboBox cboChonBS;
        private Label lblMaKhoa;
        private TextBox txtMaKhoa;
        private Button btnPhanCongBS;
        private Panel panelFormHSBA;
        private Label lblFormHSBATitle;
        private Label lblMAHSBA_F;
        private TextBox txtMAHSBA_Form;
        private Label lblMABN_HSBA_F;
        private TextBox txtMABN_HSBA;
        private Label lblNgayHSBA_F;
        private TextBox txtNgayHSBA;
        private Label lblMaKhoaNew_F;
        private TextBox txtMaKhoaNew;
        private Button btnLuuHSBA;
        private Button btnHuyHSBA;

        // Tab 3
        private Label lblSoDV;
        private DataGridView dgvHSBA_DV;
        private GroupBox grpPhanCongKTV;
        private Label lblChonKTV;
        private ComboBox cboChonKTV;
        private Button btnPhanCongKTV;
    }
}