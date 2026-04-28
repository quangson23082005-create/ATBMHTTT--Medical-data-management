// fBacSi_Designer.cs
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QLBV
{
    partial class fBacSi
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
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabHSBA = new System.Windows.Forms.TabPage();
            this.dgvHSBA = new System.Windows.Forms.DataGridView();
            this.grpEditHSBA = new System.Windows.Forms.GroupBox();
            this.lblMaHSBA_E = new System.Windows.Forms.Label();
            this.txtMaHSBA_Edit = new System.Windows.Forms.TextBox();
            this.lblChanDoan = new System.Windows.Forms.Label();
            this.txtChanDoan = new System.Windows.Forms.TextBox();
            this.lblDieuTri = new System.Windows.Forms.Label();
            this.txtDieuTri = new System.Windows.Forms.TextBox();
            this.lblKetLuan = new System.Windows.Forms.Label();
            this.txtKetLuan = new System.Windows.Forms.TextBox();
            this.btnCapNhatHSBA = new System.Windows.Forms.Button();
            this.panelHSBAInfo = new System.Windows.Forms.Panel();
            this.lblSoHSBA = new System.Windows.Forms.Label();
            this.lblHSBADangChon = new System.Windows.Forms.Label();
            this.tabDichVu = new System.Windows.Forms.TabPage();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.grpThemDV = new System.Windows.Forms.GroupBox();
            this.lblLoaiDV = new System.Windows.Forms.Label();
            this.txtLoaiDV = new System.Windows.Forms.TextBox();
            this.lblNgayDV = new System.Windows.Forms.Label();
            this.txtNgayDV = new System.Windows.Forms.TextBox();
            this.lblMaKTV = new System.Windows.Forms.Label();
            this.txtMaKTV = new System.Windows.Forms.TextBox();
            this.lblKetQuaDV = new System.Windows.Forms.Label();
            this.txtKetQuaDV = new System.Windows.Forms.TextBox();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.btnXoaDV = new System.Windows.Forms.Button();
            this.lblSoDV = new System.Windows.Forms.Label();
            this.tabBenhNhan = new System.Windows.Forms.TabPage();
            this.dgvBenhNhan = new System.Windows.Forms.DataGridView();
            this.grpEditBN = new System.Windows.Forms.GroupBox();
            this.lblMaBN_E = new System.Windows.Forms.Label();
            this.txtMaBN_Edit = new System.Windows.Forms.TextBox();
            this.lblTienSuBenh = new System.Windows.Forms.Label();
            this.txtTienSuBenh = new System.Windows.Forms.TextBox();
            this.lblTienSuBenhGD = new System.Windows.Forms.Label();
            this.txtTienSuBenhGD = new System.Windows.Forms.TextBox();
            this.lblDiUngThuoc = new System.Windows.Forms.Label();
            this.txtDiUngThuoc = new System.Windows.Forms.TextBox();
            this.btnCapNhatBN = new System.Windows.Forms.Button();
            this.tabDonThuoc = new System.Windows.Forms.TabPage();
            this.dgvDonThuoc = new System.Windows.Forms.DataGridView();
            this.grpThemThuoc = new System.Windows.Forms.GroupBox();
            this.lblTenThuoc = new System.Windows.Forms.Label();
            this.txtTenThuoc = new System.Windows.Forms.TextBox();
            this.lblLieuDung = new System.Windows.Forms.Label();
            this.txtLieuDung = new System.Windows.Forms.TextBox();
            this.lblNgayDT = new System.Windows.Forms.Label();
            this.txtNgayDT = new System.Windows.Forms.TextBox();
            this.btnThemThuoc = new System.Windows.Forms.Button();
            this.btnSuaThuoc = new System.Windows.Forms.Button();
            this.btnXoaThuoc = new System.Windows.Forms.Button();
            this.lblHuongDanThuoc = new System.Windows.Forms.Label();
            this.lblSoDonThuoc = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabHSBA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHSBA)).BeginInit();
            this.grpEditHSBA.SuspendLayout();
            this.panelHSBAInfo.SuspendLayout();
            this.tabDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            this.grpThemDV.SuspendLayout();
            this.tabBenhNhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhNhan)).BeginInit();
            this.grpEditBN.SuspendLayout();
            this.tabDonThuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonThuoc)).BeginInit();
            this.grpThemThuoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(943, 48);
            this.panelTop.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(943, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BAC SI / Y TA  -  Quan ly dieu tri";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBottom.Controls.Add(this.btnDangXuat);
            this.panelBottom.Controls.Add(this.btnLamMoi);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 607);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(943, 43);
            this.panelBottom.TabIndex = 1;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Location = new System.Drawing.Point(124, 9);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(103, 26);
            this.btnDangXuat.TabIndex = 0;
            this.btnDangXuat.Text = "Dang xuat";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(10, 9);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(103, 26);
            this.btnLamMoi.TabIndex = 1;
            this.btnLamMoi.Text = "Lam moi";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabHSBA);
            this.tabControl.Controls.Add(this.tabDichVu);
            this.tabControl.Controls.Add(this.tabBenhNhan);
            this.tabControl.Controls.Add(this.tabDonThuoc);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tabControl.Location = new System.Drawing.Point(0, 48);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(943, 559);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabHSBA
            // 
            this.tabHSBA.Controls.Add(this.dgvHSBA);
            this.tabHSBA.Controls.Add(this.grpEditHSBA);
            this.tabHSBA.Controls.Add(this.panelHSBAInfo);
            this.tabHSBA.Location = new System.Drawing.Point(4, 26);
            this.tabHSBA.Name = "tabHSBA";
            this.tabHSBA.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabHSBA.Size = new System.Drawing.Size(935, 529);
            this.tabHSBA.TabIndex = 0;
            this.tabHSBA.Text = "Ho So Benh An cua toi";
            // 
            // dgvHSBA
            // 
            this.dgvHSBA.AllowUserToAddRows = false;
            this.dgvHSBA.AllowUserToDeleteRows = false;
            this.dgvHSBA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHSBA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHSBA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvHSBA.Location = new System.Drawing.Point(3, 50);
            this.dgvHSBA.MultiSelect = false;
            this.dgvHSBA.Name = "dgvHSBA";
            this.dgvHSBA.RowHeadersVisible = false;
            this.dgvHSBA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHSBA.Size = new System.Drawing.Size(929, 285);
            this.dgvHSBA.TabIndex = 0;
            this.dgvHSBA.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHSBA_CellValueChanged);
            this.dgvHSBA.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvHSBA_CurrentCellDirtyStateChanged);
            // 
            // grpEditHSBA
            // 
            this.grpEditHSBA.Controls.Add(this.lblMaHSBA_E);
            this.grpEditHSBA.Controls.Add(this.txtMaHSBA_Edit);
            this.grpEditHSBA.Controls.Add(this.lblChanDoan);
            this.grpEditHSBA.Controls.Add(this.txtChanDoan);
            this.grpEditHSBA.Controls.Add(this.lblDieuTri);
            this.grpEditHSBA.Controls.Add(this.txtDieuTri);
            this.grpEditHSBA.Controls.Add(this.lblKetLuan);
            this.grpEditHSBA.Controls.Add(this.txtKetLuan);
            this.grpEditHSBA.Controls.Add(this.btnCapNhatHSBA);
            this.grpEditHSBA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpEditHSBA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpEditHSBA.Location = new System.Drawing.Point(3, 335);
            this.grpEditHSBA.Name = "grpEditHSBA";
            this.grpEditHSBA.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.grpEditHSBA.Size = new System.Drawing.Size(929, 191);
            this.grpEditHSBA.TabIndex = 1;
            this.grpEditHSBA.TabStop = false;
            this.grpEditHSBA.Text = "Cap nhat HSBA dang chon  [TC#3c - Audit ghi vet CHANDOAN / DIEUTRI / KETLUAN]";
            // 
            // lblMaHSBA_E
            // 
            this.lblMaHSBA_E.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaHSBA_E.Location = new System.Drawing.Point(7, 24);
            this.lblMaHSBA_E.Name = "lblMaHSBA_E";
            this.lblMaHSBA_E.Size = new System.Drawing.Size(62, 17);
            this.lblMaHSBA_E.TabIndex = 0;
            this.lblMaHSBA_E.Text = "Ma HSBA:";
            // 
            // txtMaHSBA_Edit
            // 
            this.txtMaHSBA_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtMaHSBA_Edit.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtMaHSBA_Edit.Location = new System.Drawing.Point(72, 22);
            this.txtMaHSBA_Edit.Name = "txtMaHSBA_Edit";
            this.txtMaHSBA_Edit.ReadOnly = true;
            this.txtMaHSBA_Edit.Size = new System.Drawing.Size(129, 24);
            this.txtMaHSBA_Edit.TabIndex = 1;
            // 
            // lblChanDoan
            // 
            this.lblChanDoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblChanDoan.Location = new System.Drawing.Point(7, 52);
            this.lblChanDoan.Name = "lblChanDoan";
            this.lblChanDoan.Size = new System.Drawing.Size(62, 17);
            this.lblChanDoan.TabIndex = 2;
            this.lblChanDoan.Text = "Chan doan:";
            // 
            // txtChanDoan
            // 
            this.txtChanDoan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChanDoan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtChanDoan.Location = new System.Drawing.Point(72, 49);
            this.txtChanDoan.Multiline = true;
            this.txtChanDoan.Name = "txtChanDoan";
            this.txtChanDoan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtChanDoan.Size = new System.Drawing.Size(1495, 33);
            this.txtChanDoan.TabIndex = 3;
            // 
            // lblDieuTri
            // 
            this.lblDieuTri.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDieuTri.Location = new System.Drawing.Point(7, 94);
            this.lblDieuTri.Name = "lblDieuTri";
            this.lblDieuTri.Size = new System.Drawing.Size(62, 17);
            this.lblDieuTri.TabIndex = 4;
            this.lblDieuTri.Text = "Dieu tri:";
            // 
            // txtDieuTri
            // 
            this.txtDieuTri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDieuTri.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDieuTri.Location = new System.Drawing.Point(72, 91);
            this.txtDieuTri.Multiline = true;
            this.txtDieuTri.Name = "txtDieuTri";
            this.txtDieuTri.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDieuTri.Size = new System.Drawing.Size(1495, 33);
            this.txtDieuTri.TabIndex = 5;
            // 
            // lblKetLuan
            // 
            this.lblKetLuan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKetLuan.Location = new System.Drawing.Point(7, 135);
            this.lblKetLuan.Name = "lblKetLuan";
            this.lblKetLuan.Size = new System.Drawing.Size(62, 17);
            this.lblKetLuan.TabIndex = 6;
            this.lblKetLuan.Text = "Ket luan:";
            // 
            // txtKetLuan
            // 
            this.txtKetLuan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKetLuan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtKetLuan.Location = new System.Drawing.Point(72, 133);
            this.txtKetLuan.Name = "txtKetLuan";
            this.txtKetLuan.Size = new System.Drawing.Size(1495, 24);
            this.txtKetLuan.TabIndex = 7;
            // 
            // btnCapNhatHSBA
            // 
            this.btnCapNhatHSBA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnCapNhatHSBA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatHSBA.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCapNhatHSBA.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatHSBA.Location = new System.Drawing.Point(7, 163);
            this.btnCapNhatHSBA.Name = "btnCapNhatHSBA";
            this.btnCapNhatHSBA.Size = new System.Drawing.Size(240, 24);
            this.btnCapNhatHSBA.TabIndex = 8;
            this.btnCapNhatHSBA.Text = "Luu (Chan doan / Dieu tri / Ket luan)";
            this.btnCapNhatHSBA.UseVisualStyleBackColor = false;
            this.btnCapNhatHSBA.Click += new System.EventHandler(this.btnCapNhatHSBA_Click);
            // 
            // panelHSBAInfo
            // 
            this.panelHSBAInfo.Controls.Add(this.lblSoHSBA);
            this.panelHSBAInfo.Controls.Add(this.lblHSBADangChon);
            this.panelHSBAInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHSBAInfo.Location = new System.Drawing.Point(3, 3);
            this.panelHSBAInfo.Name = "panelHSBAInfo";
            this.panelHSBAInfo.Size = new System.Drawing.Size(929, 47);
            this.panelHSBAInfo.TabIndex = 2;
            // 
            // lblSoHSBA
            // 
            this.lblSoHSBA.AutoSize = true;
            this.lblSoHSBA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSoHSBA.ForeColor = System.Drawing.Color.Gray;
            this.lblSoHSBA.Location = new System.Drawing.Point(0, 2);
            this.lblSoHSBA.Name = "lblSoHSBA";
            this.lblSoHSBA.Size = new System.Drawing.Size(271, 15);
            this.lblSoHSBA.TabIndex = 0;
            this.lblSoHSBA.Text = "Tong: 0 ho so  |  Tick chon de xem DV / Don thuoc";
            this.lblSoHSBA.Click += new System.EventHandler(this.lblSoHSBA_Click);
            // 
            // lblHSBADangChon
            // 
            this.lblHSBADangChon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.lblHSBADangChon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHSBADangChon.ForeColor = System.Drawing.Color.White;
            this.lblHSBADangChon.Location = new System.Drawing.Point(0, 23);
            this.lblHSBADangChon.Name = "lblHSBADangChon";
            this.lblHSBADangChon.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblHSBADangChon.Size = new System.Drawing.Size(343, 21);
            this.lblHSBADangChon.TabIndex = 1;
            this.lblHSBADangChon.Text = "Chua chon HSBA";
            this.lblHSBADangChon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabDichVu
            // 
            this.tabDichVu.Controls.Add(this.dgvDichVu);
            this.tabDichVu.Controls.Add(this.grpThemDV);
            this.tabDichVu.Controls.Add(this.lblSoDV);
            this.tabDichVu.Location = new System.Drawing.Point(4, 26);
            this.tabDichVu.Name = "tabDichVu";
            this.tabDichVu.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabDichVu.Size = new System.Drawing.Size(163, 57);
            this.tabDichVu.TabIndex = 1;
            this.tabDichVu.Text = "Dich vu chan doan";
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.AllowUserToAddRows = false;
            this.dgvDichVu.AllowUserToDeleteRows = false;
            this.dgvDichVu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDichVu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvDichVu.Location = new System.Drawing.Point(3, 24);
            this.dgvDichVu.MultiSelect = false;
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.ReadOnly = true;
            this.dgvDichVu.RowHeadersVisible = false;
            this.dgvDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDichVu.Size = new System.Drawing.Size(157, 0);
            this.dgvDichVu.TabIndex = 0;
            this.dgvDichVu.SelectionChanged += new System.EventHandler(this.dgvDichVu_SelectionChanged);
            // 
            // grpThemDV
            // 
            this.grpThemDV.Controls.Add(this.lblLoaiDV);
            this.grpThemDV.Controls.Add(this.txtLoaiDV);
            this.grpThemDV.Controls.Add(this.lblNgayDV);
            this.grpThemDV.Controls.Add(this.txtNgayDV);
            this.grpThemDV.Controls.Add(this.lblMaKTV);
            this.grpThemDV.Controls.Add(this.txtMaKTV);
            this.grpThemDV.Controls.Add(this.lblKetQuaDV);
            this.grpThemDV.Controls.Add(this.txtKetQuaDV);
            this.grpThemDV.Controls.Add(this.btnThemDV);
            this.grpThemDV.Controls.Add(this.btnXoaDV);
            this.grpThemDV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpThemDV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpThemDV.Location = new System.Drawing.Point(3, -85);
            this.grpThemDV.Name = "grpThemDV";
            this.grpThemDV.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.grpThemDV.Size = new System.Drawing.Size(157, 139);
            this.grpThemDV.TabIndex = 1;
            this.grpThemDV.TabStop = false;
            this.grpThemDV.Text = "Them / Xoa Dich vu  [TC#3b]";
            // 
            // lblLoaiDV
            // 
            this.lblLoaiDV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLoaiDV.Location = new System.Drawing.Point(7, 23);
            this.lblLoaiDV.Name = "lblLoaiDV";
            this.lblLoaiDV.Size = new System.Drawing.Size(51, 17);
            this.lblLoaiDV.TabIndex = 0;
            this.lblLoaiDV.Text = "Loai DV:";
            // 
            // txtLoaiDV
            // 
            this.txtLoaiDV.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtLoaiDV.Location = new System.Drawing.Point(62, 20);
            this.txtLoaiDV.Name = "txtLoaiDV";
            this.txtLoaiDV.Size = new System.Drawing.Size(155, 24);
            this.txtLoaiDV.TabIndex = 1;
            // 
            // lblNgayDV
            // 
            this.lblNgayDV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNgayDV.Location = new System.Drawing.Point(227, 23);
            this.lblNgayDV.Name = "lblNgayDV";
            this.lblNgayDV.Size = new System.Drawing.Size(94, 17);
            this.lblNgayDV.TabIndex = 2;
            this.lblNgayDV.Text = "Ngay (dd/MM/yyyy):";
            // 
            // txtNgayDV
            // 
            this.txtNgayDV.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNgayDV.Location = new System.Drawing.Point(324, 20);
            this.txtNgayDV.Name = "txtNgayDV";
            this.txtNgayDV.Size = new System.Drawing.Size(112, 24);
            this.txtNgayDV.TabIndex = 3;
            // 
            // lblMaKTV
            // 
            this.lblMaKTV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaKTV.Location = new System.Drawing.Point(449, 23);
            this.lblMaKTV.Name = "lblMaKTV";
            this.lblMaKTV.Size = new System.Drawing.Size(51, 17);
            this.lblMaKTV.TabIndex = 4;
            this.lblMaKTV.Text = "Ma KTV:";
            // 
            // txtMaKTV
            // 
            this.txtMaKTV.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtMaKTV.Location = new System.Drawing.Point(504, 20);
            this.txtMaKTV.Name = "txtMaKTV";
            this.txtMaKTV.Size = new System.Drawing.Size(112, 24);
            this.txtMaKTV.TabIndex = 5;
            // 
            // lblKetQuaDV
            // 
            this.lblKetQuaDV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKetQuaDV.Location = new System.Drawing.Point(7, 54);
            this.lblKetQuaDV.Name = "lblKetQuaDV";
            this.lblKetQuaDV.Size = new System.Drawing.Size(51, 17);
            this.lblKetQuaDV.TabIndex = 6;
            this.lblKetQuaDV.Text = "Ket qua:";
            // 
            // txtKetQuaDV
            // 
            this.txtKetQuaDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtKetQuaDV.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtKetQuaDV.Location = new System.Drawing.Point(62, 51);
            this.txtKetQuaDV.Name = "txtKetQuaDV";
            this.txtKetQuaDV.ReadOnly = true;
            this.txtKetQuaDV.Size = new System.Drawing.Size(498, 24);
            this.txtKetQuaDV.TabIndex = 7;
            // 
            // btnThemDV
            // 
            this.btnThemDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnThemDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemDV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThemDV.ForeColor = System.Drawing.Color.White;
            this.btnThemDV.Location = new System.Drawing.Point(7, 87);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(103, 28);
            this.btnThemDV.TabIndex = 8;
            this.btnThemDV.Text = "Them DV";
            this.btnThemDV.UseVisualStyleBackColor = false;
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            // 
            // btnXoaDV
            // 
            this.btnXoaDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnXoaDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaDV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoaDV.ForeColor = System.Drawing.Color.White;
            this.btnXoaDV.Location = new System.Drawing.Point(118, 87);
            this.btnXoaDV.Name = "btnXoaDV";
            this.btnXoaDV.Size = new System.Drawing.Size(120, 28);
            this.btnXoaDV.TabIndex = 9;
            this.btnXoaDV.Text = "Xoa DV da chon";
            this.btnXoaDV.UseVisualStyleBackColor = false;
            this.btnXoaDV.Click += new System.EventHandler(this.btnXoaDV_Click);
            // 
            // lblSoDV
            // 
            this.lblSoDV.AutoSize = true;
            this.lblSoDV.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSoDV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSoDV.ForeColor = System.Drawing.Color.Gray;
            this.lblSoDV.Location = new System.Drawing.Point(3, 3);
            this.lblSoDV.Name = "lblSoDV";
            this.lblSoDV.Padding = new System.Windows.Forms.Padding(2, 3, 0, 3);
            this.lblSoDV.Size = new System.Drawing.Size(90, 21);
            this.lblSoDV.TabIndex = 2;
            this.lblSoDV.Text = "Tong: 0 dich vu";
            // 
            // tabBenhNhan
            // 
            this.tabBenhNhan.Controls.Add(this.dgvBenhNhan);
            this.tabBenhNhan.Controls.Add(this.grpEditBN);
            this.tabBenhNhan.Location = new System.Drawing.Point(4, 26);
            this.tabBenhNhan.Name = "tabBenhNhan";
            this.tabBenhNhan.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabBenhNhan.Size = new System.Drawing.Size(163, 57);
            this.tabBenhNhan.TabIndex = 2;
            this.tabBenhNhan.Text = "Cap nhat Benh Nhan";
            // 
            // dgvBenhNhan
            // 
            this.dgvBenhNhan.AllowUserToAddRows = false;
            this.dgvBenhNhan.AllowUserToDeleteRows = false;
            this.dgvBenhNhan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBenhNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBenhNhan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvBenhNhan.Location = new System.Drawing.Point(3, 3);
            this.dgvBenhNhan.MultiSelect = false;
            this.dgvBenhNhan.Name = "dgvBenhNhan";
            this.dgvBenhNhan.ReadOnly = true;
            this.dgvBenhNhan.RowHeadersVisible = false;
            this.dgvBenhNhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBenhNhan.Size = new System.Drawing.Size(157, 0);
            this.dgvBenhNhan.TabIndex = 0;
            this.dgvBenhNhan.SelectionChanged += new System.EventHandler(this.dgvBenhNhan_SelectionChanged);
            // 
            // grpEditBN
            // 
            this.grpEditBN.Controls.Add(this.lblMaBN_E);
            this.grpEditBN.Controls.Add(this.txtMaBN_Edit);
            this.grpEditBN.Controls.Add(this.lblTienSuBenh);
            this.grpEditBN.Controls.Add(this.txtTienSuBenh);
            this.grpEditBN.Controls.Add(this.lblTienSuBenhGD);
            this.grpEditBN.Controls.Add(this.txtTienSuBenhGD);
            this.grpEditBN.Controls.Add(this.lblDiUngThuoc);
            this.grpEditBN.Controls.Add(this.txtDiUngThuoc);
            this.grpEditBN.Controls.Add(this.btnCapNhatBN);
            this.grpEditBN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpEditBN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpEditBN.Location = new System.Drawing.Point(3, -128);
            this.grpEditBN.Name = "grpEditBN";
            this.grpEditBN.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.grpEditBN.Size = new System.Drawing.Size(157, 182);
            this.grpEditBN.TabIndex = 1;
            this.grpEditBN.TabStop = false;
            this.grpEditBN.Text = "Cap nhat Benh Nhan  [TC#3d - chi sua: Tien su benh / Tien su GD / Di ung thuoc]";
            // 
            // lblMaBN_E
            // 
            this.lblMaBN_E.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaBN_E.Location = new System.Drawing.Point(7, 24);
            this.lblMaBN_E.Name = "lblMaBN_E";
            this.lblMaBN_E.Size = new System.Drawing.Size(50, 17);
            this.lblMaBN_E.TabIndex = 0;
            this.lblMaBN_E.Text = "Ma BN:";
            // 
            // txtMaBN_Edit
            // 
            this.txtMaBN_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtMaBN_Edit.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtMaBN_Edit.Location = new System.Drawing.Point(60, 22);
            this.txtMaBN_Edit.Name = "txtMaBN_Edit";
            this.txtMaBN_Edit.ReadOnly = true;
            this.txtMaBN_Edit.Size = new System.Drawing.Size(121, 24);
            this.txtMaBN_Edit.TabIndex = 1;
            // 
            // lblTienSuBenh
            // 
            this.lblTienSuBenh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTienSuBenh.Location = new System.Drawing.Point(7, 55);
            this.lblTienSuBenh.Name = "lblTienSuBenh";
            this.lblTienSuBenh.Size = new System.Drawing.Size(77, 17);
            this.lblTienSuBenh.TabIndex = 2;
            this.lblTienSuBenh.Text = "Tien su benh:";
            // 
            // txtTienSuBenh
            // 
            this.txtTienSuBenh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTienSuBenh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTienSuBenh.Location = new System.Drawing.Point(87, 53);
            this.txtTienSuBenh.Name = "txtTienSuBenh";
            this.txtTienSuBenh.Size = new System.Drawing.Size(586, 24);
            this.txtTienSuBenh.TabIndex = 3;
            // 
            // lblTienSuBenhGD
            // 
            this.lblTienSuBenhGD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTienSuBenhGD.Location = new System.Drawing.Point(7, 88);
            this.lblTienSuBenhGD.Name = "lblTienSuBenhGD";
            this.lblTienSuBenhGD.Size = new System.Drawing.Size(77, 17);
            this.lblTienSuBenhGD.TabIndex = 4;
            this.lblTienSuBenhGD.Text = "Tien su GD:";
            // 
            // txtTienSuBenhGD
            // 
            this.txtTienSuBenhGD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTienSuBenhGD.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTienSuBenhGD.Location = new System.Drawing.Point(87, 86);
            this.txtTienSuBenhGD.Name = "txtTienSuBenhGD";
            this.txtTienSuBenhGD.Size = new System.Drawing.Size(586, 24);
            this.txtTienSuBenhGD.TabIndex = 5;
            // 
            // lblDiUngThuoc
            // 
            this.lblDiUngThuoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDiUngThuoc.Location = new System.Drawing.Point(7, 121);
            this.lblDiUngThuoc.Name = "lblDiUngThuoc";
            this.lblDiUngThuoc.Size = new System.Drawing.Size(77, 17);
            this.lblDiUngThuoc.TabIndex = 6;
            this.lblDiUngThuoc.Text = "Di ung thuoc:";
            // 
            // txtDiUngThuoc
            // 
            this.txtDiUngThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiUngThuoc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDiUngThuoc.Location = new System.Drawing.Point(87, 119);
            this.txtDiUngThuoc.Name = "txtDiUngThuoc";
            this.txtDiUngThuoc.Size = new System.Drawing.Size(586, 24);
            this.txtDiUngThuoc.TabIndex = 7;
            // 
            // btnCapNhatBN
            // 
            this.btnCapNhatBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnCapNhatBN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatBN.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCapNhatBN.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatBN.Location = new System.Drawing.Point(7, 152);
            this.btnCapNhatBN.Name = "btnCapNhatBN";
            this.btnCapNhatBN.Size = new System.Drawing.Size(223, 24);
            this.btnCapNhatBN.TabIndex = 8;
            this.btnCapNhatBN.Text = "Luu Cap nhat";
            this.btnCapNhatBN.UseVisualStyleBackColor = false;
            this.btnCapNhatBN.Click += new System.EventHandler(this.btnCapNhatBN_Click);
            // 
            // tabDonThuoc
            // 
            this.tabDonThuoc.Controls.Add(this.dgvDonThuoc);
            this.tabDonThuoc.Controls.Add(this.grpThemThuoc);
            this.tabDonThuoc.Controls.Add(this.lblSoDonThuoc);
            this.tabDonThuoc.Location = new System.Drawing.Point(4, 26);
            this.tabDonThuoc.Name = "tabDonThuoc";
            this.tabDonThuoc.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabDonThuoc.Size = new System.Drawing.Size(163, 57);
            this.tabDonThuoc.TabIndex = 3;
            this.tabDonThuoc.Text = "Don Thuoc";
            // 
            // dgvDonThuoc
            // 
            this.dgvDonThuoc.AllowUserToAddRows = false;
            this.dgvDonThuoc.AllowUserToDeleteRows = false;
            this.dgvDonThuoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDonThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDonThuoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvDonThuoc.Location = new System.Drawing.Point(3, 24);
            this.dgvDonThuoc.MultiSelect = false;
            this.dgvDonThuoc.Name = "dgvDonThuoc";
            this.dgvDonThuoc.ReadOnly = true;
            this.dgvDonThuoc.RowHeadersVisible = false;
            this.dgvDonThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonThuoc.Size = new System.Drawing.Size(157, 0);
            this.dgvDonThuoc.TabIndex = 0;
            this.dgvDonThuoc.SelectionChanged += new System.EventHandler(this.dgvDonThuoc_SelectionChanged);
            // 
            // grpThemThuoc
            // 
            this.grpThemThuoc.Controls.Add(this.lblTenThuoc);
            this.grpThemThuoc.Controls.Add(this.txtTenThuoc);
            this.grpThemThuoc.Controls.Add(this.lblLieuDung);
            this.grpThemThuoc.Controls.Add(this.txtLieuDung);
            this.grpThemThuoc.Controls.Add(this.lblNgayDT);
            this.grpThemThuoc.Controls.Add(this.txtNgayDT);
            this.grpThemThuoc.Controls.Add(this.btnThemThuoc);
            this.grpThemThuoc.Controls.Add(this.btnSuaThuoc);
            this.grpThemThuoc.Controls.Add(this.btnXoaThuoc);
            this.grpThemThuoc.Controls.Add(this.lblHuongDanThuoc);
            this.grpThemThuoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpThemThuoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpThemThuoc.Location = new System.Drawing.Point(3, -85);
            this.grpThemThuoc.Name = "grpThemThuoc";
            this.grpThemThuoc.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.grpThemThuoc.Size = new System.Drawing.Size(157, 139);
            this.grpThemThuoc.TabIndex = 1;
            this.grpThemThuoc.TabStop = false;
            this.grpThemThuoc.Text = "Them / Sua / Xoa Don Thuoc  [TC#3e]";
            // 
            // lblTenThuoc
            // 
            this.lblTenThuoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTenThuoc.Location = new System.Drawing.Point(7, 23);
            this.lblTenThuoc.Name = "lblTenThuoc";
            this.lblTenThuoc.Size = new System.Drawing.Size(62, 17);
            this.lblTenThuoc.TabIndex = 0;
            this.lblTenThuoc.Text = "Ten thuoc:";
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTenThuoc.Location = new System.Drawing.Point(72, 20);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new System.Drawing.Size(198, 24);
            this.txtTenThuoc.TabIndex = 1;
            // 
            // lblLieuDung
            // 
            this.lblLieuDung.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLieuDung.Location = new System.Drawing.Point(283, 23);
            this.lblLieuDung.Name = "lblLieuDung";
            this.lblLieuDung.Size = new System.Drawing.Size(60, 17);
            this.lblLieuDung.TabIndex = 2;
            this.lblLieuDung.Text = "Lieu dung:";
            // 
            // txtLieuDung
            // 
            this.txtLieuDung.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtLieuDung.Location = new System.Drawing.Point(346, 20);
            this.txtLieuDung.Name = "txtLieuDung";
            this.txtLieuDung.Size = new System.Drawing.Size(198, 24);
            this.txtLieuDung.TabIndex = 3;
            // 
            // lblNgayDT
            // 
            this.lblNgayDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNgayDT.Location = new System.Drawing.Point(555, 23);
            this.lblNgayDT.Name = "lblNgayDT";
            this.lblNgayDT.Size = new System.Drawing.Size(94, 17);
            this.lblNgayDT.TabIndex = 4;
            this.lblNgayDT.Text = "Ngay (dd/MM/yyyy):";
            // 
            // txtNgayDT
            // 
            this.txtNgayDT.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNgayDT.Location = new System.Drawing.Point(653, 20);
            this.txtNgayDT.Name = "txtNgayDT";
            this.txtNgayDT.Size = new System.Drawing.Size(112, 24);
            this.txtNgayDT.TabIndex = 5;
            // 
            // btnThemThuoc
            // 
            this.btnThemThuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnThemThuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemThuoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThemThuoc.ForeColor = System.Drawing.Color.White;
            this.btnThemThuoc.Location = new System.Drawing.Point(7, 56);
            this.btnThemThuoc.Name = "btnThemThuoc";
            this.btnThemThuoc.Size = new System.Drawing.Size(94, 28);
            this.btnThemThuoc.TabIndex = 6;
            this.btnThemThuoc.Text = "Them";
            this.btnThemThuoc.UseVisualStyleBackColor = false;
            this.btnThemThuoc.Click += new System.EventHandler(this.btnThemThuoc_Click);
            // 
            // btnSuaThuoc
            // 
            this.btnSuaThuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnSuaThuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaThuoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSuaThuoc.ForeColor = System.Drawing.Color.White;
            this.btnSuaThuoc.Location = new System.Drawing.Point(110, 56);
            this.btnSuaThuoc.Name = "btnSuaThuoc";
            this.btnSuaThuoc.Size = new System.Drawing.Size(94, 28);
            this.btnSuaThuoc.TabIndex = 7;
            this.btnSuaThuoc.Text = "Sua";
            this.btnSuaThuoc.UseVisualStyleBackColor = false;
            this.btnSuaThuoc.Click += new System.EventHandler(this.btnSuaThuoc_Click);
            // 
            // btnXoaThuoc
            // 
            this.btnXoaThuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnXoaThuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaThuoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoaThuoc.ForeColor = System.Drawing.Color.White;
            this.btnXoaThuoc.Location = new System.Drawing.Point(213, 56);
            this.btnXoaThuoc.Name = "btnXoaThuoc";
            this.btnXoaThuoc.Size = new System.Drawing.Size(94, 28);
            this.btnXoaThuoc.TabIndex = 8;
            this.btnXoaThuoc.Text = "Xoa";
            this.btnXoaThuoc.UseVisualStyleBackColor = false;
            this.btnXoaThuoc.Click += new System.EventHandler(this.btnXoaThuoc_Click);
            // 
            // lblHuongDanThuoc
            // 
            this.lblHuongDanThuoc.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblHuongDanThuoc.ForeColor = System.Drawing.Color.Gray;
            this.lblHuongDanThuoc.Location = new System.Drawing.Point(7, 92);
            this.lblHuongDanThuoc.Name = "lblHuongDanThuoc";
            this.lblHuongDanThuoc.Size = new System.Drawing.Size(600, 16);
            this.lblHuongDanThuoc.TabIndex = 9;
            this.lblHuongDanThuoc.Text = "* Chon dong tren bang de dien thong tin, sau do nhan Them / Sua / Xoa.";
            // 
            // lblSoDonThuoc
            // 
            this.lblSoDonThuoc.AutoSize = true;
            this.lblSoDonThuoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSoDonThuoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSoDonThuoc.ForeColor = System.Drawing.Color.Gray;
            this.lblSoDonThuoc.Location = new System.Drawing.Point(3, 3);
            this.lblSoDonThuoc.Name = "lblSoDonThuoc";
            this.lblSoDonThuoc.Padding = new System.Windows.Forms.Padding(2, 3, 0, 3);
            this.lblSoDonThuoc.Size = new System.Drawing.Size(82, 21);
            this.lblSoDonThuoc.TabIndex = 2;
            this.lblSoDonThuoc.Text = "Tong: 0 thuoc";
            // 
            // fBacSi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 650);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.MinimumSize = new System.Drawing.Size(688, 569);
            this.Name = "fBacSi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bac Si / Y Ta";
            this.Load += new System.EventHandler(this.fBacSi_Load);
            this.panelTop.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabHSBA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHSBA)).EndInit();
            this.grpEditHSBA.ResumeLayout(false);
            this.grpEditHSBA.PerformLayout();
            this.panelHSBAInfo.ResumeLayout(false);
            this.panelHSBAInfo.PerformLayout();
            this.tabDichVu.ResumeLayout(false);
            this.tabDichVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.grpThemDV.ResumeLayout(false);
            this.grpThemDV.PerformLayout();
            this.tabBenhNhan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhNhan)).EndInit();
            this.grpEditBN.ResumeLayout(false);
            this.grpEditBN.PerformLayout();
            this.tabDonThuoc.ResumeLayout(false);
            this.tabDonThuoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonThuoc)).EndInit();
            this.grpThemThuoc.ResumeLayout(false);
            this.grpThemThuoc.PerformLayout();
            this.ResumeLayout(false);

        }

        // Field declarations
        private Panel panelTop, panelBottom;
        private Label lblTitle;
        private TabControl tabControl;
        private TabPage tabHSBA, tabDichVu, tabBenhNhan, tabDonThuoc;
        private Button btnLamMoi, btnDangXuat;
        // Tab 1
        private Label lblSoHSBA, lblHSBADangChon;
        private DataGridView dgvHSBA;
        private GroupBox grpEditHSBA;
        private Label lblMaHSBA_E, lblChanDoan, lblDieuTri, lblKetLuan;
        private TextBox txtMaHSBA_Edit, txtChanDoan, txtDieuTri, txtKetLuan;
        private Button btnCapNhatHSBA;
        // Tab 2
        private Label lblSoDV;
        private DataGridView dgvDichVu;
        private GroupBox grpThemDV;
        private Label lblLoaiDV, lblNgayDV, lblMaKTV, lblKetQuaDV;
        private TextBox txtLoaiDV, txtNgayDV, txtMaKTV, txtKetQuaDV;
        private Button btnThemDV, btnXoaDV;
        // Tab 3
        private DataGridView dgvBenhNhan;
        private GroupBox grpEditBN;
        private Label lblMaBN_E, lblTienSuBenh, lblTienSuBenhGD, lblDiUngThuoc;
        private TextBox txtMaBN_Edit, txtTienSuBenh, txtTienSuBenhGD, txtDiUngThuoc;
        private Button btnCapNhatBN;
        // Tab 4
        private Label lblSoDonThuoc;
        private DataGridView dgvDonThuoc;
        private GroupBox grpThemThuoc;
        private Label lblTenThuoc, lblLieuDung, lblNgayDT;
        private TextBox txtTenThuoc, txtLieuDung, txtNgayDT;
        private Button btnThemThuoc, btnSuaThuoc, btnXoaThuoc;
        private Panel panelHSBAInfo;
        private Label lblHuongDanThuoc;
    }
}