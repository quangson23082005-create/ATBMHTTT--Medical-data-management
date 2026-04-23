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
            this.components = new Container();

            // ── Khai bao controls ─────────────────────────────────────────────
            this.panelTop = new Panel();
            this.lblTitle = new Label();
            this.panelBottom = new Panel();
            this.btnLamMoi = new Button();
            this.btnDangXuat = new Button();
            this.tabControl = new TabControl();
            this.tabHSBA = new TabPage();
            this.tabDichVu = new TabPage();
            this.tabBenhNhan = new TabPage();
            this.tabDonThuoc = new TabPage();

            // Tab 1
            this.lblSoHSBA = new Label();
            this.dgvHSBA = new DataGridView();
            this.grpEditHSBA = new GroupBox();
            this.lblMaHSBA_E = new Label();
            this.txtMaHSBA_Edit = new TextBox();
            this.lblChanDoan = new Label();
            this.txtChanDoan = new TextBox();
            this.lblDieuTri = new Label();
            this.txtDieuTri = new TextBox();
            this.lblKetLuan = new Label();
            this.txtKetLuan = new TextBox();
            this.btnCapNhatHSBA = new Button();

            // Tab 2
            this.lblSoDV = new Label();
            this.dgvDichVu = new DataGridView();
            this.grpThemDV = new GroupBox();
            this.lblLoaiDV = new Label();
            this.txtLoaiDV = new TextBox();
            this.lblNgayDV = new Label();
            this.txtNgayDV = new TextBox();
            this.lblMaKTV = new Label();
            this.txtMaKTV = new TextBox();
            this.btnThemDV = new Button();
            this.btnXoaDV = new Button();

            // Tab 3
            this.dgvBenhNhan = new DataGridView();
            this.grpEditBN = new GroupBox();
            this.lblMaBN_E = new Label();
            this.txtMaBN_Edit = new TextBox();
            this.lblTienSuBenh = new Label();
            this.txtTienSuBenh = new TextBox();
            this.lblTienSuBenhGD = new Label();
            this.txtTienSuBenhGD = new TextBox();
            this.lblDiUngThuoc = new Label();
            this.txtDiUngThuoc = new TextBox();
            this.btnCapNhatBN = new Button();

            // Tab 4
            this.lblSoDonThuoc = new Label();
            this.dgvDonThuoc = new DataGridView();
            this.grpThemThuoc = new GroupBox();
            this.lblTenThuoc = new Label();
            this.txtTenThuoc = new TextBox();
            this.lblLieuDung = new Label();
            this.txtLieuDung = new TextBox();
            this.lblNgayDT = new Label();
            this.txtNgayDT = new TextBox();
            this.btnThemThuoc = new Button();
            this.btnSuaThuoc = new Button();
            this.btnXoaThuoc = new Button();

            // ── SuspendLayout ────────────────────────────────────────────────
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabHSBA.SuspendLayout();
            this.tabDichVu.SuspendLayout();
            this.tabBenhNhan.SuspendLayout();
            this.tabDonThuoc.SuspendLayout();
            this.grpEditHSBA.SuspendLayout();
            this.grpThemDV.SuspendLayout();
            this.grpEditBN.SuspendLayout();
            this.grpThemThuoc.SuspendLayout();
            ((ISupportInitialize)this.dgvHSBA).BeginInit();
            ((ISupportInitialize)this.dgvDichVu).BeginInit();
            ((ISupportInitialize)this.dgvBenhNhan).BeginInit();
            ((ISupportInitialize)this.dgvDonThuoc).BeginInit();
            this.SuspendLayout();

            // ════════════════════════════════════════════════════════════════
            // panelTop
            // ════════════════════════════════════════════════════════════════
            this.panelTop.BackColor = Color.FromArgb(22, 160, 133);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = DockStyle.Top;
            this.panelTop.Height = 60;
            this.panelTop.Name = "panelTop";

            this.lblTitle.AutoSize = false;
            this.lblTitle.Dock = DockStyle.Fill;
            this.lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "BAC SI / Y TA - Quan ly dieu tri";
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // ════════════════════════════════════════════════════════════════
            // panelBottom
            // ════════════════════════════════════════════════════════════════
            this.panelBottom.BackColor = Color.WhiteSmoke;
            this.panelBottom.Controls.Add(this.btnDangXuat);
            this.panelBottom.Controls.Add(this.btnLamMoi);
            this.panelBottom.Dock = DockStyle.Bottom;
            this.panelBottom.Height = 50;
            this.panelBottom.Name = "panelBottom";

            this.btnLamMoi.BackColor = Color.FromArgb(41, 128, 185);
            this.btnLamMoi.FlatStyle = FlatStyle.Flat;
            this.btnLamMoi.ForeColor = Color.White;
            this.btnLamMoi.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnLamMoi.Location = new Point(12, 10);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new Size(120, 30);
            this.btnLamMoi.Text = "Lam moi";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new EventHandler(this.btnLamMoi_Click);

            this.btnDangXuat.BackColor = Color.FromArgb(192, 57, 43);
            this.btnDangXuat.FlatStyle = FlatStyle.Flat;
            this.btnDangXuat.ForeColor = Color.White;
            this.btnDangXuat.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnDangXuat.Location = new Point(145, 10);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new Size(120, 30);
            this.btnDangXuat.Text = "Dang xuat";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new EventHandler(this.btnDangXuat_Click);

            // ════════════════════════════════════════════════════════════════
            // tabControl
            // ════════════════════════════════════════════════════════════════
            this.tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.tabControl.Controls.Add(this.tabHSBA);
            this.tabControl.Controls.Add(this.tabDichVu);
            this.tabControl.Controls.Add(this.tabBenhNhan);
            this.tabControl.Controls.Add(this.tabDonThuoc);
            this.tabControl.Font = new Font("Segoe UI", 10F);
            this.tabControl.Location = new Point(0, 60);
            this.tabControl.Name = "tabControl";
            this.tabControl.Size = new Size(1100, 590);
            this.tabControl.SelectedIndexChanged += new EventHandler(this.tabControl_SelectedIndexChanged);

            // ════════════════════════════════════════════════════════════════
            // TAB 1: HO SO BENH AN
            // ════════════════════════════════════════════════════════════════
            this.tabHSBA.Controls.Add(this.lblSoHSBA);
            this.tabHSBA.Controls.Add(this.dgvHSBA);
            this.tabHSBA.Controls.Add(this.grpEditHSBA);
            this.tabHSBA.Name = "tabHSBA";
            this.tabHSBA.Text = "Ho So Benh An cua toi";

            this.lblSoHSBA.AutoSize = true;
            this.lblSoHSBA.Font = new Font("Segoe UI", 9F);
            this.lblSoHSBA.ForeColor = Color.Gray;
            this.lblSoHSBA.Location = new Point(8, 8);
            this.lblSoHSBA.Name = "lblSoHSBA";
            this.lblSoHSBA.Text = "Tong: 0 ho so";

            this.dgvHSBA.AllowUserToAddRows = false;
            this.dgvHSBA.AllowUserToDeleteRows = false;
            this.dgvHSBA.ReadOnly = true;
            this.dgvHSBA.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvHSBA.BorderStyle = BorderStyle.None;
            this.dgvHSBA.Font = new Font("Segoe UI", 9F);
            this.dgvHSBA.Location = new Point(8, 30);
            this.dgvHSBA.Name = "dgvHSBA";
            this.dgvHSBA.RowHeadersVisible = false;
            this.dgvHSBA.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvHSBA.Size = new Size(1070, 280);
            this.dgvHSBA.SelectionChanged += new EventHandler(this.dgvHSBA_SelectionChanged);

            this.grpEditHSBA.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.grpEditHSBA.Controls.Add(this.lblMaHSBA_E);
            this.grpEditHSBA.Controls.Add(this.txtMaHSBA_Edit);
            this.grpEditHSBA.Controls.Add(this.lblChanDoan);
            this.grpEditHSBA.Controls.Add(this.txtChanDoan);
            this.grpEditHSBA.Controls.Add(this.lblDieuTri);
            this.grpEditHSBA.Controls.Add(this.txtDieuTri);
            this.grpEditHSBA.Controls.Add(this.lblKetLuan);
            this.grpEditHSBA.Controls.Add(this.txtKetLuan);
            this.grpEditHSBA.Controls.Add(this.btnCapNhatHSBA);
            this.grpEditHSBA.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.grpEditHSBA.Location = new Point(8, 318);
            this.grpEditHSBA.Name = "grpEditHSBA";
            this.grpEditHSBA.Size = new Size(1070, 200);
            this.grpEditHSBA.Text = "Cap nhat HSBA dang chon (chi sua Chan doan / Dieu tri / Ket luan)";

            this.lblMaHSBA_E.AutoSize = false;
            this.lblMaHSBA_E.Font = new Font("Segoe UI", 9F);
            this.lblMaHSBA_E.Location = new Point(10, 28);
            this.lblMaHSBA_E.Name = "lblMaHSBA_E";
            this.lblMaHSBA_E.Size = new Size(80, 20);
            this.lblMaHSBA_E.Text = "Ma HSBA:";

            this.txtMaHSBA_Edit.BackColor = Color.FromArgb(235, 235, 235);
            this.txtMaHSBA_Edit.Font = new Font("Segoe UI", 9.5F);
            this.txtMaHSBA_Edit.Location = new Point(95, 25);
            this.txtMaHSBA_Edit.Name = "txtMaHSBA_Edit";
            this.txtMaHSBA_Edit.ReadOnly = true;
            this.txtMaHSBA_Edit.Size = new Size(120, 24);

            this.lblChanDoan.AutoSize = false;
            this.lblChanDoan.Font = new Font("Segoe UI", 9F);
            this.lblChanDoan.Location = new Point(10, 63);
            this.lblChanDoan.Name = "lblChanDoan";
            this.lblChanDoan.Size = new Size(90, 20);
            this.lblChanDoan.Text = "Chan doan:";

            this.txtChanDoan.Font = new Font("Segoe UI", 9.5F);
            this.txtChanDoan.Location = new Point(95, 60);
            this.txtChanDoan.Name = "txtChanDoan";
            this.txtChanDoan.Size = new Size(450, 24);

            this.lblDieuTri.AutoSize = false;
            this.lblDieuTri.Font = new Font("Segoe UI", 9F);
            this.lblDieuTri.Location = new Point(10, 98);
            this.lblDieuTri.Name = "lblDieuTri";
            this.lblDieuTri.Size = new Size(90, 20);
            this.lblDieuTri.Text = "Dieu tri:";

            this.txtDieuTri.Font = new Font("Segoe UI", 9.5F);
            this.txtDieuTri.Location = new Point(95, 95);
            this.txtDieuTri.Name = "txtDieuTri";
            this.txtDieuTri.Size = new Size(450, 24);

            this.lblKetLuan.AutoSize = false;
            this.lblKetLuan.Font = new Font("Segoe UI", 9F);
            this.lblKetLuan.Location = new Point(10, 133);
            this.lblKetLuan.Name = "lblKetLuan";
            this.lblKetLuan.Size = new Size(90, 20);
            this.lblKetLuan.Text = "Ket luan:";

            this.txtKetLuan.Font = new Font("Segoe UI", 9.5F);
            this.txtKetLuan.Location = new Point(95, 130);
            this.txtKetLuan.Name = "txtKetLuan";
            this.txtKetLuan.Size = new Size(450, 24);

            this.btnCapNhatHSBA.BackColor = Color.FromArgb(22, 160, 133);
            this.btnCapNhatHSBA.FlatStyle = FlatStyle.Flat;
            this.btnCapNhatHSBA.ForeColor = Color.White;
            this.btnCapNhatHSBA.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnCapNhatHSBA.Location = new Point(10, 162);
            this.btnCapNhatHSBA.Name = "btnCapNhatHSBA";
            this.btnCapNhatHSBA.Size = new Size(180, 30);
            this.btnCapNhatHSBA.Text = "Cap nhat Chan doan / Dieu tri";
            this.btnCapNhatHSBA.UseVisualStyleBackColor = false;
            this.btnCapNhatHSBA.Click += new EventHandler(this.btnCapNhatHSBA_Click);

            // ════════════════════════════════════════════════════════════════
            // TAB 2: DICH VU
            // ════════════════════════════════════════════════════════════════
            this.tabDichVu.Controls.Add(this.lblSoDV);
            this.tabDichVu.Controls.Add(this.dgvDichVu);
            this.tabDichVu.Controls.Add(this.grpThemDV);
            this.tabDichVu.Name = "tabDichVu";
            this.tabDichVu.Text = "Dich vu ho tro chan doan";

            this.lblSoDV.AutoSize = true;
            this.lblSoDV.Font = new Font("Segoe UI", 9F);
            this.lblSoDV.ForeColor = Color.Gray;
            this.lblSoDV.Location = new Point(8, 8);
            this.lblSoDV.Name = "lblSoDV";
            this.lblSoDV.Text = "Tong: 0 dich vu (chon HSBA o Tab 1 truoc)";

            this.dgvDichVu.AllowUserToAddRows = false;
            this.dgvDichVu.AllowUserToDeleteRows = false;
            this.dgvDichVu.ReadOnly = true;
            this.dgvDichVu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvDichVu.BorderStyle = BorderStyle.None;
            this.dgvDichVu.Font = new Font("Segoe UI", 9F);
            this.dgvDichVu.Location = new Point(8, 30);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.RowHeadersVisible = false;
            this.dgvDichVu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvDichVu.Size = new Size(1070, 380);

            this.grpThemDV.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.grpThemDV.Controls.Add(this.lblLoaiDV);
            this.grpThemDV.Controls.Add(this.txtLoaiDV);
            this.grpThemDV.Controls.Add(this.lblNgayDV);
            this.grpThemDV.Controls.Add(this.txtNgayDV);
            this.grpThemDV.Controls.Add(this.lblMaKTV);
            this.grpThemDV.Controls.Add(this.txtMaKTV);
            this.grpThemDV.Controls.Add(this.btnThemDV);
            this.grpThemDV.Controls.Add(this.btnXoaDV);
            this.grpThemDV.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.grpThemDV.Location = new Point(8, 418);
            this.grpThemDV.Name = "grpThemDV";
            this.grpThemDV.Size = new Size(1070, 65);
            this.grpThemDV.Text = "Them / Xoa dich vu (cho HSBA dang chon o Tab 1)";

            this.lblLoaiDV.AutoSize = false;
            this.lblLoaiDV.Font = new Font("Segoe UI", 9F);
            this.lblLoaiDV.Location = new Point(10, 31);
            this.lblLoaiDV.Name = "lblLoaiDV";
            this.lblLoaiDV.Size = new Size(90, 20);
            this.lblLoaiDV.Text = "Loai DV:";

            this.txtLoaiDV.Font = new Font("Segoe UI", 9.5F);
            this.txtLoaiDV.Location = new Point(85, 28);
            this.txtLoaiDV.Name = "txtLoaiDV";
            this.txtLoaiDV.Size = new Size(160, 24);

            this.lblNgayDV.AutoSize = false;
            this.lblNgayDV.Font = new Font("Segoe UI", 9F);
            this.lblNgayDV.Location = new Point(258, 31);
            this.lblNgayDV.Name = "lblNgayDV";
            this.lblNgayDV.Size = new Size(140, 20);
            this.lblNgayDV.Text = "Ngay (dd/MM/yyyy):";

            this.txtNgayDV.Font = new Font("Segoe UI", 9.5F);
            this.txtNgayDV.Location = new Point(400, 28);
            this.txtNgayDV.Name = "txtNgayDV";
            this.txtNgayDV.Size = new Size(120, 24);

            this.lblMaKTV.AutoSize = false;
            this.lblMaKTV.Font = new Font("Segoe UI", 9F);
            this.lblMaKTV.Location = new Point(535, 31);
            this.lblMaKTV.Name = "lblMaKTV";
            this.lblMaKTV.Size = new Size(90, 20);
            this.lblMaKTV.Text = "Ma KTV:";

            this.txtMaKTV.Font = new Font("Segoe UI", 9.5F);
            this.txtMaKTV.Location = new Point(600, 28);
            this.txtMaKTV.Name = "txtMaKTV";
            this.txtMaKTV.Size = new Size(120, 24);

            this.btnThemDV.BackColor = Color.FromArgb(39, 174, 96);
            this.btnThemDV.FlatStyle = FlatStyle.Flat;
            this.btnThemDV.ForeColor = Color.White;
            this.btnThemDV.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnThemDV.Location = new Point(735, 23);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new Size(100, 28);
            this.btnThemDV.Text = "Them DV";
            this.btnThemDV.UseVisualStyleBackColor = false;
            this.btnThemDV.Click += new EventHandler(this.btnThemDV_Click);

            this.btnXoaDV.BackColor = Color.FromArgb(192, 57, 43);
            this.btnXoaDV.FlatStyle = FlatStyle.Flat;
            this.btnXoaDV.ForeColor = Color.White;
            this.btnXoaDV.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnXoaDV.Location = new Point(845, 23);
            this.btnXoaDV.Name = "btnXoaDV";
            this.btnXoaDV.Size = new Size(100, 28);
            this.btnXoaDV.Text = "Xoa DV";
            this.btnXoaDV.UseVisualStyleBackColor = false;
            this.btnXoaDV.Click += new EventHandler(this.btnXoaDV_Click);

            // ════════════════════════════════════════════════════════════════
            // TAB 3: BENH NHAN
            // ════════════════════════════════════════════════════════════════
            this.tabBenhNhan.Controls.Add(this.dgvBenhNhan);
            this.tabBenhNhan.Controls.Add(this.grpEditBN);
            this.tabBenhNhan.Name = "tabBenhNhan";
            this.tabBenhNhan.Text = "Cap nhat Benh Nhan";

            this.dgvBenhNhan.AllowUserToAddRows = false;
            this.dgvBenhNhan.AllowUserToDeleteRows = false;
            this.dgvBenhNhan.ReadOnly = true;
            this.dgvBenhNhan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvBenhNhan.BorderStyle = BorderStyle.None;
            this.dgvBenhNhan.Font = new Font("Segoe UI", 9F);
            this.dgvBenhNhan.Location = new Point(8, 8);
            this.dgvBenhNhan.Name = "dgvBenhNhan";
            this.dgvBenhNhan.RowHeadersVisible = false;
            this.dgvBenhNhan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvBenhNhan.Size = new Size(1070, 340);
            this.dgvBenhNhan.SelectionChanged += new EventHandler(this.dgvBenhNhan_SelectionChanged);

            this.grpEditBN.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.grpEditBN.Controls.Add(this.lblMaBN_E);
            this.grpEditBN.Controls.Add(this.txtMaBN_Edit);
            this.grpEditBN.Controls.Add(this.lblTienSuBenh);
            this.grpEditBN.Controls.Add(this.txtTienSuBenh);
            this.grpEditBN.Controls.Add(this.lblTienSuBenhGD);
            this.grpEditBN.Controls.Add(this.txtTienSuBenhGD);
            this.grpEditBN.Controls.Add(this.lblDiUngThuoc);
            this.grpEditBN.Controls.Add(this.txtDiUngThuoc);
            this.grpEditBN.Controls.Add(this.btnCapNhatBN);
            this.grpEditBN.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.grpEditBN.Location = new Point(8, 355);
            this.grpEditBN.Name = "grpEditBN";
            this.grpEditBN.Size = new Size(1070, 175);
            this.grpEditBN.Text = "Cap nhat 3 truong duoc phep (Tien su benh / Tien su benh GD / Di ung thuoc)";

            this.lblMaBN_E.AutoSize = false;
            this.lblMaBN_E.Font = new Font("Segoe UI", 9F);
            this.lblMaBN_E.Location = new Point(10, 28);
            this.lblMaBN_E.Name = "lblMaBN_E";
            this.lblMaBN_E.Size = new Size(80, 20);
            this.lblMaBN_E.Text = "Ma BN:";

            this.txtMaBN_Edit.BackColor = Color.FromArgb(235, 235, 235);
            this.txtMaBN_Edit.Font = new Font("Segoe UI", 9.5F);
            this.txtMaBN_Edit.Location = new Point(95, 25);
            this.txtMaBN_Edit.Name = "txtMaBN_Edit";
            this.txtMaBN_Edit.ReadOnly = true;
            this.txtMaBN_Edit.Size = new Size(120, 24);

            this.lblTienSuBenh.AutoSize = false;
            this.lblTienSuBenh.Font = new Font("Segoe UI", 9F);
            this.lblTienSuBenh.Location = new Point(10, 65);
            this.lblTienSuBenh.Name = "lblTienSuBenh";
            this.lblTienSuBenh.Size = new Size(90, 20);
            this.lblTienSuBenh.Text = "Tien su benh:";

            this.txtTienSuBenh.Font = new Font("Segoe UI", 9.5F);
            this.txtTienSuBenh.Location = new Point(95, 62);
            this.txtTienSuBenh.Name = "txtTienSuBenh";
            this.txtTienSuBenh.Size = new Size(450, 24);

            this.lblTienSuBenhGD.AutoSize = false;
            this.lblTienSuBenhGD.Font = new Font("Segoe UI", 9F);
            this.lblTienSuBenhGD.Location = new Point(10, 100);
            this.lblTienSuBenhGD.Name = "lblTienSuBenhGD";
            this.lblTienSuBenhGD.Size = new Size(90, 20);
            this.lblTienSuBenhGD.Text = "Tien su GD:";

            this.txtTienSuBenhGD.Font = new Font("Segoe UI", 9.5F);
            this.txtTienSuBenhGD.Location = new Point(95, 97);
            this.txtTienSuBenhGD.Name = "txtTienSuBenhGD";
            this.txtTienSuBenhGD.Size = new Size(450, 24);

            this.lblDiUngThuoc.AutoSize = false;
            this.lblDiUngThuoc.Font = new Font("Segoe UI", 9F);
            this.lblDiUngThuoc.Location = new Point(10, 135);
            this.lblDiUngThuoc.Name = "lblDiUngThuoc";
            this.lblDiUngThuoc.Size = new Size(90, 20);
            this.lblDiUngThuoc.Text = "Di ung thuoc:";

            this.txtDiUngThuoc.Font = new Font("Segoe UI", 9.5F);
            this.txtDiUngThuoc.Location = new Point(95, 132);
            this.txtDiUngThuoc.Name = "txtDiUngThuoc";
            this.txtDiUngThuoc.Size = new Size(450, 24);

            this.btnCapNhatBN.BackColor = Color.FromArgb(22, 160, 133);
            this.btnCapNhatBN.FlatStyle = FlatStyle.Flat;
            this.btnCapNhatBN.ForeColor = Color.White;
            this.btnCapNhatBN.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnCapNhatBN.Location = new Point(10, 140);
            this.btnCapNhatBN.Name = "btnCapNhatBN";
            this.btnCapNhatBN.Size = new Size(160, 28);
            this.btnCapNhatBN.Text = "Cap nhat benh nhan";
            this.btnCapNhatBN.UseVisualStyleBackColor = false;
            this.btnCapNhatBN.Click += new EventHandler(this.btnCapNhatBN_Click);

            // ════════════════════════════════════════════════════════════════
            // TAB 4: DON THUOC
            // ════════════════════════════════════════════════════════════════
            this.tabDonThuoc.Controls.Add(this.lblSoDonThuoc);
            this.tabDonThuoc.Controls.Add(this.dgvDonThuoc);
            this.tabDonThuoc.Controls.Add(this.grpThemThuoc);
            this.tabDonThuoc.Name = "tabDonThuoc";
            this.tabDonThuoc.Text = "Don Thuoc";

            this.lblSoDonThuoc.AutoSize = true;
            this.lblSoDonThuoc.Font = new Font("Segoe UI", 9F);
            this.lblSoDonThuoc.ForeColor = Color.Gray;
            this.lblSoDonThuoc.Location = new Point(8, 8);
            this.lblSoDonThuoc.Name = "lblSoDonThuoc";
            this.lblSoDonThuoc.Text = "Tong: 0 thuoc (chon HSBA o Tab 1 truoc)";

            this.dgvDonThuoc.AllowUserToAddRows = false;
            this.dgvDonThuoc.AllowUserToDeleteRows = false;
            this.dgvDonThuoc.ReadOnly = true;
            this.dgvDonThuoc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvDonThuoc.BorderStyle = BorderStyle.None;
            this.dgvDonThuoc.Font = new Font("Segoe UI", 9F);
            this.dgvDonThuoc.Location = new Point(8, 30);
            this.dgvDonThuoc.Name = "dgvDonThuoc";
            this.dgvDonThuoc.RowHeadersVisible = false;
            this.dgvDonThuoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonThuoc.Size = new Size(1070, 380);

            this.grpThemThuoc.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.grpThemThuoc.Controls.Add(this.lblTenThuoc);
            this.grpThemThuoc.Controls.Add(this.txtTenThuoc);
            this.grpThemThuoc.Controls.Add(this.lblLieuDung);
            this.grpThemThuoc.Controls.Add(this.txtLieuDung);
            this.grpThemThuoc.Controls.Add(this.lblNgayDT);
            this.grpThemThuoc.Controls.Add(this.txtNgayDT);
            this.grpThemThuoc.Controls.Add(this.btnThemThuoc);
            this.grpThemThuoc.Controls.Add(this.btnSuaThuoc);
            this.grpThemThuoc.Controls.Add(this.btnXoaThuoc);
            this.grpThemThuoc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.grpThemThuoc.Location = new Point(8, 418);
            this.grpThemThuoc.Name = "grpThemThuoc";
            this.grpThemThuoc.Size = new Size(1070, 65);
            this.grpThemThuoc.Text = "Them / Sua / Xoa Don thuoc (cho HSBA dang chon)";

            this.lblTenThuoc.AutoSize = false;
            this.lblTenThuoc.Font = new Font("Segoe UI", 9F);
            this.lblTenThuoc.Location = new Point(10, 31);
            this.lblTenThuoc.Name = "lblTenThuoc";
            this.lblTenThuoc.Size = new Size(90, 20);
            this.lblTenThuoc.Text = "Ten thuoc:";

            this.txtTenThuoc.Font = new Font("Segoe UI", 9.5F);
            this.txtTenThuoc.Location = new Point(90, 28);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new Size(200, 24);

            this.lblLieuDung.AutoSize = false;
            this.lblLieuDung.Font = new Font("Segoe UI", 9F);
            this.lblLieuDung.Location = new Point(305, 31);
            this.lblLieuDung.Name = "lblLieuDung";
            this.lblLieuDung.Size = new Size(90, 20);
            this.lblLieuDung.Text = "Lieu dung:";

            this.txtLieuDung.Font = new Font("Segoe UI", 9.5F);
            this.txtLieuDung.Location = new Point(385, 28);
            this.txtLieuDung.Name = "txtLieuDung";
            this.txtLieuDung.Size = new Size(200, 24);

            this.lblNgayDT.AutoSize = false;
            this.lblNgayDT.Font = new Font("Segoe UI", 9F);
            this.lblNgayDT.Location = new Point(600, 31);
            this.lblNgayDT.Name = "lblNgayDT";
            this.lblNgayDT.Size = new Size(145, 20);
            this.lblNgayDT.Text = "Ngay (dd/MM/yyyy):";

            this.txtNgayDT.Font = new Font("Segoe UI", 9.5F);
            this.txtNgayDT.Location = new Point(750, 28);
            this.txtNgayDT.Name = "txtNgayDT";
            this.txtNgayDT.Size = new Size(120, 24);

            this.btnThemThuoc.BackColor = Color.FromArgb(39, 174, 96);
            this.btnThemThuoc.FlatStyle = FlatStyle.Flat;
            this.btnThemThuoc.ForeColor = Color.White;
            this.btnThemThuoc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnThemThuoc.Location = new Point(882, 23);
            this.btnThemThuoc.Name = "btnThemThuoc";
            this.btnThemThuoc.Size = new Size(55, 28);
            this.btnThemThuoc.Text = "Them";
            this.btnThemThuoc.UseVisualStyleBackColor = false;
            this.btnThemThuoc.Click += new EventHandler(this.btnThemThuoc_Click);

            this.btnSuaThuoc.BackColor = Color.FromArgb(230, 126, 34);
            this.btnSuaThuoc.FlatStyle = FlatStyle.Flat;
            this.btnSuaThuoc.ForeColor = Color.White;
            this.btnSuaThuoc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnSuaThuoc.Location = new Point(945, 23);
            this.btnSuaThuoc.Name = "btnSuaThuoc";
            this.btnSuaThuoc.Size = new Size(55, 28);
            this.btnSuaThuoc.Text = "Sua";
            this.btnSuaThuoc.UseVisualStyleBackColor = false;
            this.btnSuaThuoc.Click += new EventHandler(this.btnSuaThuoc_Click);

            this.btnXoaThuoc.BackColor = Color.FromArgb(192, 57, 43);
            this.btnXoaThuoc.FlatStyle = FlatStyle.Flat;
            this.btnXoaThuoc.ForeColor = Color.White;
            this.btnXoaThuoc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnXoaThuoc.Location = new Point(1008, 23);
            this.btnXoaThuoc.Name = "btnXoaThuoc";
            this.btnXoaThuoc.Size = new Size(50, 28);
            this.btnXoaThuoc.Text = "Xoa";
            this.btnXoaThuoc.UseVisualStyleBackColor = false;
            this.btnXoaThuoc.Click += new EventHandler(this.btnXoaThuoc_Click);

            // ════════════════════════════════════════════════════════════════
            // fBacSi (Form)
            // ════════════════════════════════════════════════════════════════
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1100, 700);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.MinimumSize = new Size(900, 600);
            this.Name = "fBacSi";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Bac Si / Y Ta";
            this.Load += new EventHandler(this.fBacSi_Load);

            // ── ResumeLayout ─────────────────────────────────────────────────
            this.panelTop.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.grpEditHSBA.ResumeLayout(false);
            this.grpEditHSBA.PerformLayout();
            this.grpThemDV.ResumeLayout(false);
            this.grpThemDV.PerformLayout();
            this.grpEditBN.ResumeLayout(false);
            this.grpEditBN.PerformLayout();
            this.grpThemThuoc.ResumeLayout(false);
            this.grpThemThuoc.PerformLayout();
            this.tabHSBA.ResumeLayout(false);
            this.tabHSBA.PerformLayout();
            this.tabDichVu.ResumeLayout(false);
            this.tabDichVu.PerformLayout();
            this.tabBenhNhan.ResumeLayout(false);
            this.tabDonThuoc.ResumeLayout(false);
            this.tabDonThuoc.PerformLayout();
            this.tabControl.ResumeLayout(false);
            ((ISupportInitialize)this.dgvHSBA).EndInit();
            ((ISupportInitialize)this.dgvDichVu).EndInit();
            ((ISupportInitialize)this.dgvBenhNhan).EndInit();
            ((ISupportInitialize)this.dgvDonThuoc).EndInit();
            this.ResumeLayout(false);
        }

        // ── Field declarations ────────────────────────────────────────────────
        private Panel panelTop;
        private Panel panelBottom;
        private Label lblTitle;
        private TabControl tabControl;
        private TabPage tabHSBA;
        private TabPage tabDichVu;
        private TabPage tabBenhNhan;
        private TabPage tabDonThuoc;
        private Button btnLamMoi;
        private Button btnDangXuat;

        // Tab 1
        private Label lblSoHSBA;
        private DataGridView dgvHSBA;
        private GroupBox grpEditHSBA;
        private Label lblMaHSBA_E;
        private TextBox txtMaHSBA_Edit;
        private Label lblChanDoan;
        private TextBox txtChanDoan;
        private Label lblDieuTri;
        private TextBox txtDieuTri;
        private Label lblKetLuan;
        private TextBox txtKetLuan;
        private Button btnCapNhatHSBA;

        // Tab 2
        private Label lblSoDV;
        private DataGridView dgvDichVu;
        private GroupBox grpThemDV;
        private Label lblLoaiDV;
        private TextBox txtLoaiDV;
        private Label lblNgayDV;
        private TextBox txtNgayDV;
        private Label lblMaKTV;
        private TextBox txtMaKTV;
        private Button btnThemDV;
        private Button btnXoaDV;

        // Tab 3
        private DataGridView dgvBenhNhan;
        private GroupBox grpEditBN;
        private Label lblMaBN_E;
        private TextBox txtMaBN_Edit;
        private Label lblTienSuBenh;
        private TextBox txtTienSuBenh;
        private Label lblTienSuBenhGD;
        private TextBox txtTienSuBenhGD;
        private Label lblDiUngThuoc;
        private TextBox txtDiUngThuoc;
        private Button btnCapNhatBN;

        // Tab 4
        private Label lblSoDonThuoc;
        private DataGridView dgvDonThuoc;
        private GroupBox grpThemThuoc;
        private Label lblTenThuoc;
        private TextBox txtTenThuoc;
        private Label lblLieuDung;
        private TextBox txtLieuDung;
        private Label lblNgayDT;
        private TextBox txtNgayDT;
        private Button btnThemThuoc;
        private Button btnXoaThuoc;
        private Button btnSuaThuoc;
    }
}