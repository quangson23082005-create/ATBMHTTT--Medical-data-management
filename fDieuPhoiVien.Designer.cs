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
            this.components = new Container();

            // ── Khai bao controls ─────────────────────────────────────────────
            this.panelTop = new Panel();
            this.lblTitle = new Label();
            this.panelBottom = new Panel();
            this.btnLamMoi = new Button();
            this.btnDangXuat = new Button();
            this.tabControl = new TabControl();
            this.tabBenhNhan = new TabPage();
            this.tabHSBA = new TabPage();
            this.tabKTV = new TabPage();

            // Tab 1: Benh nhan
            this.lblSoBN = new Label();
            this.txtTimBN = new TextBox();
            this.btnTimBN = new Button();
            this.btnThemBN = new Button();
            this.btnSuaBN = new Button();
            this.dgvBenhNhan = new DataGridView();
            this.panelFormBN = new Panel();
            this.lblFormBNTitle = new Label();
            this.lblMABN_F = new Label();
            this.txtMABN_Form = new TextBox();
            this.lblTENBN_F = new Label();
            this.txtTENBN_Form = new TextBox();
            this.lblPhai_F = new Label();
            this.cboPhaiBS = new ComboBox();
            this.lblNgaySinh_F = new Label();
            this.txtNgaySinhBN = new TextBox();
            this.lblCCCD_F = new Label();
            this.txtCCCD_Form = new TextBox();
            this.lblSoNha_F = new Label();
            this.txtSoNha = new TextBox();
            this.lblTenDuong_F = new Label();
            this.txtTenDuong = new TextBox();
            this.lblQuanHuyen_F = new Label();
            this.txtQuanHuyen = new TextBox();
            this.lblTinhTP_F = new Label();
            this.txtTinhTP = new TextBox();
            this.btnLuuBN = new Button();
            this.btnHuyBN = new Button();

            // Tab 2: HSBA
            this.lblSoHSBA = new Label();
            this.btnThemHSBA = new Button();
            this.dgvHSBA = new DataGridView();
            this.grpPhanCongBS = new GroupBox();
            this.lblChonBS = new Label();
            this.cboChonBS = new ComboBox();
            this.lblMaKhoa = new Label();
            this.txtMaKhoa = new TextBox();
            this.btnPhanCongBS = new Button();
            this.panelFormHSBA = new Panel();
            this.lblFormHSBATitle = new Label();
            this.lblMAHSBA_F = new Label();
            this.txtMAHSBA_Form = new TextBox();
            this.lblMABN_HSBA_F = new Label();
            this.txtMABN_HSBA = new TextBox();
            this.lblNgayHSBA_F = new Label();
            this.txtNgayHSBA = new TextBox();
            this.lblMaKhoaNew_F = new Label();
            this.txtMaKhoaNew = new TextBox();
            this.btnLuuHSBA = new Button();
            this.btnHuyHSBA = new Button();

            // Tab 3: KTV
            this.lblSoDV = new Label();
            this.dgvHSBA_DV = new DataGridView();
            this.grpPhanCongKTV = new GroupBox();
            this.lblChonKTV = new Label();
            this.cboChonKTV = new ComboBox();
            this.btnPhanCongKTV = new Button();

            // ── SuspendLayout ────────────────────────────────────────────────
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabBenhNhan.SuspendLayout();
            this.tabHSBA.SuspendLayout();
            this.tabKTV.SuspendLayout();
            this.panelFormBN.SuspendLayout();
            this.panelFormHSBA.SuspendLayout();
            this.grpPhanCongBS.SuspendLayout();
            this.grpPhanCongKTV.SuspendLayout();
            ((ISupportInitialize)this.dgvBenhNhan).BeginInit();
            ((ISupportInitialize)this.dgvHSBA).BeginInit();
            ((ISupportInitialize)this.dgvHSBA_DV).BeginInit();
            this.SuspendLayout();

            // ════════════════════════════════════════════════════════════════
            // panelTop
            // ════════════════════════════════════════════════════════════════
            this.panelTop.BackColor = Color.FromArgb(41, 128, 185);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = DockStyle.Top;
            this.panelTop.Height = 60;
            this.panelTop.Name = "panelTop";

            this.lblTitle.AutoSize = false;
            this.lblTitle.Dock = DockStyle.Fill;
            this.lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "DIEU PHOI VIEN - Quan ly he thong";
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // ════════════════════════════════════════════════════════════════
            // panelBottom
            // ════════════════════════════════════════════════════════════════
            this.panelBottom.BackColor = Color.WhiteSmoke;
            this.panelBottom.Controls.Add(this.btnLamMoi);
            this.panelBottom.Controls.Add(this.btnDangXuat);
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
            this.tabControl.Controls.Add(this.tabBenhNhan);
            this.tabControl.Controls.Add(this.tabHSBA);
            this.tabControl.Controls.Add(this.tabKTV);
            this.tabControl.Font = new Font("Segoe UI", 10F);
            this.tabControl.Location = new Point(0, 60);
            this.tabControl.Name = "tabControl";
            this.tabControl.Size = new Size(1100, 580);

            // ════════════════════════════════════════════════════════════════
            // TAB 1: QUAN LY BENH NHAN
            // ════════════════════════════════════════════════════════════════
            this.tabBenhNhan.Controls.Add(this.lblSoBN);
            this.tabBenhNhan.Controls.Add(this.txtTimBN);
            this.tabBenhNhan.Controls.Add(this.btnTimBN);
            this.tabBenhNhan.Controls.Add(this.btnThemBN);
            this.tabBenhNhan.Controls.Add(this.btnSuaBN);
            this.tabBenhNhan.Controls.Add(this.dgvBenhNhan);
            this.tabBenhNhan.Controls.Add(this.panelFormBN);
            this.tabBenhNhan.Name = "tabBenhNhan";
            this.tabBenhNhan.Text = "Quan ly Benh Nhan";

            this.lblSoBN.AutoSize = true;
            this.lblSoBN.Font = new Font("Segoe UI", 9F);
            this.lblSoBN.ForeColor = Color.Gray;
            this.lblSoBN.Location = new Point(8, 8);
            this.lblSoBN.Name = "lblSoBN";
            this.lblSoBN.Text = "Tong: 0 benh nhan";

            // txtTimBN — .NET 4.7.2 khong co PlaceholderText
            // Dung ForeColor gray + GotFocus/LostFocus xu ly o fDieuPhoiVien.cs
            this.txtTimBN.Font = new Font("Segoe UI", 9.5F);
            this.txtTimBN.ForeColor = Color.Gray;
            this.txtTimBN.Location = new Point(8, 30);
            this.txtTimBN.Name = "txtTimBN";
            this.txtTimBN.Size = new Size(220, 24);
            this.txtTimBN.Text = "Tim kiem MABN hoac ten...";
            this.txtTimBN.GotFocus += new EventHandler(this.txtTimBN_GotFocus);
            this.txtTimBN.LostFocus += new EventHandler(this.txtTimBN_LostFocus);

            this.btnTimBN.BackColor = Color.FromArgb(41, 128, 185);
            this.btnTimBN.FlatStyle = FlatStyle.Flat;
            this.btnTimBN.ForeColor = Color.White;
            this.btnTimBN.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnTimBN.Location = new Point(235, 30);
            this.btnTimBN.Name = "btnTimBN";
            this.btnTimBN.Size = new Size(80, 24);
            this.btnTimBN.Text = "Tim";
            this.btnTimBN.UseVisualStyleBackColor = false;
            this.btnTimBN.Click += new EventHandler(this.btnTimBN_Click);

            this.btnThemBN.BackColor = Color.FromArgb(39, 174, 96);
            this.btnThemBN.FlatStyle = FlatStyle.Flat;
            this.btnThemBN.ForeColor = Color.White;
            this.btnThemBN.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnThemBN.Location = new Point(325, 30);
            this.btnThemBN.Name = "btnThemBN";
            this.btnThemBN.Size = new Size(100, 24);
            this.btnThemBN.Text = "Them BN";
            this.btnThemBN.UseVisualStyleBackColor = false;
            this.btnThemBN.Click += new EventHandler(this.btnThemBN_Click);

            this.btnSuaBN.BackColor = Color.FromArgb(230, 126, 34);
            this.btnSuaBN.FlatStyle = FlatStyle.Flat;
            this.btnSuaBN.ForeColor = Color.White;
            this.btnSuaBN.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnSuaBN.Location = new Point(433, 30);
            this.btnSuaBN.Name = "btnSuaBN";
            this.btnSuaBN.Size = new Size(100, 24);
            this.btnSuaBN.Text = "Sua BN";
            this.btnSuaBN.UseVisualStyleBackColor = false;
            this.btnSuaBN.Click += new EventHandler(this.btnSuaBN_Click);

            this.dgvBenhNhan.AllowUserToAddRows = false;
            this.dgvBenhNhan.AllowUserToDeleteRows = false;
            this.dgvBenhNhan.ReadOnly = true;
            this.dgvBenhNhan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvBenhNhan.BorderStyle = BorderStyle.None;
            this.dgvBenhNhan.Font = new Font("Segoe UI", 9F);
            this.dgvBenhNhan.Location = new Point(8, 62);
            this.dgvBenhNhan.Name = "dgvBenhNhan";
            this.dgvBenhNhan.RowHeadersVisible = false;
            this.dgvBenhNhan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvBenhNhan.Size = new Size(700, 460);

            // ── panelFormBN ──────────────────────────────────────────────────
            this.panelFormBN.BackColor = Color.FromArgb(248, 249, 250);
            this.panelFormBN.BorderStyle = BorderStyle.FixedSingle;
            this.panelFormBN.Location = new Point(720, 62);
            this.panelFormBN.Name = "panelFormBN";
            this.panelFormBN.Size = new Size(350, 460);
            this.panelFormBN.Visible = false;
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

            this.lblFormBNTitle.AutoSize = false;
            this.lblFormBNTitle.BackColor = Color.FromArgb(41, 128, 185);
            this.lblFormBNTitle.Dock = DockStyle.Top;
            this.lblFormBNTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblFormBNTitle.ForeColor = Color.White;
            this.lblFormBNTitle.Height = 32;
            this.lblFormBNTitle.Name = "lblFormBNTitle";
            this.lblFormBNTitle.Text = "THEM BENH NHAN MOI";
            this.lblFormBNTitle.TextAlign = ContentAlignment.MiddleCenter;

            this.lblMABN_F.AutoSize = false;
            this.lblMABN_F.Font = new Font("Segoe UI", 9F);
            this.lblMABN_F.Location = new Point(10, 48);
            this.lblMABN_F.Name = "lblMABN_F";
            this.lblMABN_F.Size = new Size(100, 20);
            this.lblMABN_F.Text = "Ma BN:";

            this.txtMABN_Form.Font = new Font("Segoe UI", 9.5F);
            this.txtMABN_Form.Location = new Point(115, 45);
            this.txtMABN_Form.Name = "txtMABN_Form";
            this.txtMABN_Form.Size = new Size(210, 24);

            this.lblTENBN_F.AutoSize = false;
            this.lblTENBN_F.Font = new Font("Segoe UI", 9F);
            this.lblTENBN_F.Location = new Point(10, 83);
            this.lblTENBN_F.Name = "lblTENBN_F";
            this.lblTENBN_F.Size = new Size(100, 20);
            this.lblTENBN_F.Text = "Ho ten:";

            this.txtTENBN_Form.Font = new Font("Segoe UI", 9.5F);
            this.txtTENBN_Form.Location = new Point(115, 80);
            this.txtTENBN_Form.Name = "txtTENBN_Form";
            this.txtTENBN_Form.Size = new Size(210, 24);

            this.lblPhai_F.AutoSize = false;
            this.lblPhai_F.Font = new Font("Segoe UI", 9F);
            this.lblPhai_F.Location = new Point(10, 118);
            this.lblPhai_F.Name = "lblPhai_F";
            this.lblPhai_F.Size = new Size(100, 20);
            this.lblPhai_F.Text = "Phai:";

            this.cboPhaiBS.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboPhaiBS.Font = new Font("Segoe UI", 9.5F);
            this.cboPhaiBS.Items.AddRange(new object[] { "Nam", "Nu" });
            this.cboPhaiBS.Location = new Point(115, 115);
            this.cboPhaiBS.Name = "cboPhaiBS";
            this.cboPhaiBS.Size = new Size(100, 24);
            this.cboPhaiBS.SelectedIndex = 0;

            this.lblNgaySinh_F.AutoSize = false;
            this.lblNgaySinh_F.Font = new Font("Segoe UI", 9F);
            this.lblNgaySinh_F.Location = new Point(10, 153);
            this.lblNgaySinh_F.Name = "lblNgaySinh_F";
            this.lblNgaySinh_F.Size = new Size(100, 20);
            this.lblNgaySinh_F.Text = "Ngay sinh:";

            this.txtNgaySinhBN.Font = new Font("Segoe UI", 9.5F);
            this.txtNgaySinhBN.Location = new Point(115, 150);
            this.txtNgaySinhBN.Name = "txtNgaySinhBN";
            this.txtNgaySinhBN.Size = new Size(150, 24);

            this.lblCCCD_F.AutoSize = false;
            this.lblCCCD_F.Font = new Font("Segoe UI", 9F);
            this.lblCCCD_F.Location = new Point(10, 188);
            this.lblCCCD_F.Name = "lblCCCD_F";
            this.lblCCCD_F.Size = new Size(100, 20);
            this.lblCCCD_F.Text = "CCCD:";

            this.txtCCCD_Form.Font = new Font("Segoe UI", 9.5F);
            this.txtCCCD_Form.Location = new Point(115, 185);
            this.txtCCCD_Form.Name = "txtCCCD_Form";
            this.txtCCCD_Form.Size = new Size(210, 24);

            this.lblSoNha_F.AutoSize = false;
            this.lblSoNha_F.Font = new Font("Segoe UI", 9F);
            this.lblSoNha_F.Location = new Point(10, 223);
            this.lblSoNha_F.Name = "lblSoNha_F";
            this.lblSoNha_F.Size = new Size(100, 20);
            this.lblSoNha_F.Text = "So nha:";

            this.txtSoNha.Font = new Font("Segoe UI", 9.5F);
            this.txtSoNha.Location = new Point(115, 220);
            this.txtSoNha.Name = "txtSoNha";
            this.txtSoNha.Size = new Size(210, 24);

            this.lblTenDuong_F.AutoSize = false;
            this.lblTenDuong_F.Font = new Font("Segoe UI", 9F);
            this.lblTenDuong_F.Location = new Point(10, 258);
            this.lblTenDuong_F.Name = "lblTenDuong_F";
            this.lblTenDuong_F.Size = new Size(100, 20);
            this.lblTenDuong_F.Text = "Ten duong:";

            this.txtTenDuong.Font = new Font("Segoe UI", 9.5F);
            this.txtTenDuong.Location = new Point(115, 255);
            this.txtTenDuong.Name = "txtTenDuong";
            this.txtTenDuong.Size = new Size(210, 24);

            this.lblQuanHuyen_F.AutoSize = false;
            this.lblQuanHuyen_F.Font = new Font("Segoe UI", 9F);
            this.lblQuanHuyen_F.Location = new Point(10, 293);
            this.lblQuanHuyen_F.Name = "lblQuanHuyen_F";
            this.lblQuanHuyen_F.Size = new Size(100, 20);
            this.lblQuanHuyen_F.Text = "Quan/Huyen:";

            this.txtQuanHuyen.Font = new Font("Segoe UI", 9.5F);
            this.txtQuanHuyen.Location = new Point(115, 290);
            this.txtQuanHuyen.Name = "txtQuanHuyen";
            this.txtQuanHuyen.Size = new Size(210, 24);

            this.lblTinhTP_F.AutoSize = false;
            this.lblTinhTP_F.Font = new Font("Segoe UI", 9F);
            this.lblTinhTP_F.Location = new Point(10, 328);
            this.lblTinhTP_F.Name = "lblTinhTP_F";
            this.lblTinhTP_F.Size = new Size(100, 20);
            this.lblTinhTP_F.Text = "Tinh/TP:";

            this.txtTinhTP.Font = new Font("Segoe UI", 9.5F);
            this.txtTinhTP.Location = new Point(115, 325);
            this.txtTinhTP.Name = "txtTinhTP";
            this.txtTinhTP.Size = new Size(210, 24);

            this.btnLuuBN.BackColor = Color.FromArgb(39, 174, 96);
            this.btnLuuBN.FlatStyle = FlatStyle.Flat;
            this.btnLuuBN.ForeColor = Color.White;
            this.btnLuuBN.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnLuuBN.Location = new Point(10, 415);
            this.btnLuuBN.Name = "btnLuuBN";
            this.btnLuuBN.Size = new Size(130, 30);
            this.btnLuuBN.Text = "Luu";
            this.btnLuuBN.UseVisualStyleBackColor = false;
            this.btnLuuBN.Click += new EventHandler(this.btnLuuBN_Click);

            this.btnHuyBN.BackColor = Color.FromArgb(149, 165, 166);
            this.btnHuyBN.FlatStyle = FlatStyle.Flat;
            this.btnHuyBN.ForeColor = Color.White;
            this.btnHuyBN.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnHuyBN.Location = new Point(155, 415);
            this.btnHuyBN.Name = "btnHuyBN";
            this.btnHuyBN.Size = new Size(120, 30);
            this.btnHuyBN.Text = "Huy";
            this.btnHuyBN.UseVisualStyleBackColor = false;
            this.btnHuyBN.Click += new EventHandler(this.btnHuyBN_Click);

            // ════════════════════════════════════════════════════════════════
            // TAB 2: PHAN CONG HO SO BENH AN
            // ════════════════════════════════════════════════════════════════
            this.tabHSBA.Controls.Add(this.lblSoHSBA);
            this.tabHSBA.Controls.Add(this.btnThemHSBA);
            this.tabHSBA.Controls.Add(this.dgvHSBA);
            this.tabHSBA.Controls.Add(this.grpPhanCongBS);
            this.tabHSBA.Controls.Add(this.panelFormHSBA);
            this.tabHSBA.Name = "tabHSBA";
            this.tabHSBA.Text = "Phan cong Ho So Benh An";

            this.lblSoHSBA.AutoSize = true;
            this.lblSoHSBA.Font = new Font("Segoe UI", 9F);
            this.lblSoHSBA.ForeColor = Color.Gray;
            this.lblSoHSBA.Location = new Point(8, 8);
            this.lblSoHSBA.Name = "lblSoHSBA";
            this.lblSoHSBA.Text = "Tong: 0 ho so";

            this.btnThemHSBA.BackColor = Color.FromArgb(39, 174, 96);
            this.btnThemHSBA.FlatStyle = FlatStyle.Flat;
            this.btnThemHSBA.ForeColor = Color.White;
            this.btnThemHSBA.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnThemHSBA.Location = new Point(8, 30);
            this.btnThemHSBA.Name = "btnThemHSBA";
            this.btnThemHSBA.Size = new Size(120, 26);
            this.btnThemHSBA.Text = "Tao HSBA moi";
            this.btnThemHSBA.UseVisualStyleBackColor = false;
            this.btnThemHSBA.Click += new EventHandler(this.btnThemHSBA_Click);

            this.dgvHSBA.AllowUserToAddRows = false;
            this.dgvHSBA.AllowUserToDeleteRows = false;
            this.dgvHSBA.ReadOnly = true;
            this.dgvHSBA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvHSBA.BorderStyle = BorderStyle.None;
            this.dgvHSBA.Font = new Font("Segoe UI", 9F);
            this.dgvHSBA.Location = new Point(8, 62);
            this.dgvHSBA.Name = "dgvHSBA";
            this.dgvHSBA.RowHeadersVisible = false;
            this.dgvHSBA.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvHSBA.Size = new Size(1060, 340);

            // grpPhanCongBS
            this.grpPhanCongBS.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.grpPhanCongBS.Controls.Add(this.lblChonBS);
            this.grpPhanCongBS.Controls.Add(this.cboChonBS);
            this.grpPhanCongBS.Controls.Add(this.lblMaKhoa);
            this.grpPhanCongBS.Controls.Add(this.txtMaKhoa);
            this.grpPhanCongBS.Controls.Add(this.btnPhanCongBS);
            this.grpPhanCongBS.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.grpPhanCongBS.Location = new Point(8, 410);
            this.grpPhanCongBS.Name = "grpPhanCongBS";
            this.grpPhanCongBS.Size = new Size(1060, 60);
            this.grpPhanCongBS.Text = "Phan cong Bac Si cho HSBA dang chon";

            this.lblChonBS.AutoSize = false;
            this.lblChonBS.Font = new Font("Segoe UI", 9F);
            this.lblChonBS.Location = new Point(10, 25);
            this.lblChonBS.Name = "lblChonBS";
            this.lblChonBS.Size = new Size(70, 20);
            this.lblChonBS.Text = "Bac si:";

            this.cboChonBS.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboChonBS.Font = new Font("Segoe UI", 9.5F);
            this.cboChonBS.Location = new Point(85, 22);
            this.cboChonBS.Name = "cboChonBS";
            this.cboChonBS.Size = new Size(280, 24);

            this.lblMaKhoa.AutoSize = false;
            this.lblMaKhoa.Font = new Font("Segoe UI", 9F);
            this.lblMaKhoa.Location = new Point(380, 25);
            this.lblMaKhoa.Name = "lblMaKhoa";
            this.lblMaKhoa.Size = new Size(60, 20);
            this.lblMaKhoa.Text = "Ma khoa:";

            this.txtMaKhoa.Font = new Font("Segoe UI", 9.5F);
            this.txtMaKhoa.Location = new Point(445, 22);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new Size(120, 24);

            this.btnPhanCongBS.BackColor = Color.FromArgb(41, 128, 185);
            this.btnPhanCongBS.FlatStyle = FlatStyle.Flat;
            this.btnPhanCongBS.ForeColor = Color.White;
            this.btnPhanCongBS.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnPhanCongBS.Location = new Point(580, 20);
            this.btnPhanCongBS.Name = "btnPhanCongBS";
            this.btnPhanCongBS.Size = new Size(150, 28);
            this.btnPhanCongBS.Text = "Xac nhan phan cong";
            this.btnPhanCongBS.UseVisualStyleBackColor = false;
            this.btnPhanCongBS.Click += new EventHandler(this.btnPhanCongBS_Click);

            // panelFormHSBA
            this.panelFormHSBA.BackColor = Color.FromArgb(248, 249, 250);
            this.panelFormHSBA.BorderStyle = BorderStyle.FixedSingle;
            this.panelFormHSBA.Location = new Point(8, 62);
            this.panelFormHSBA.Name = "panelFormHSBA";
            this.panelFormHSBA.Size = new Size(400, 250);
            this.panelFormHSBA.Visible = false;
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

            this.lblFormHSBATitle.AutoSize = false;
            this.lblFormHSBATitle.BackColor = Color.FromArgb(39, 174, 96);
            this.lblFormHSBATitle.Dock = DockStyle.Top;
            this.lblFormHSBATitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblFormHSBATitle.ForeColor = Color.White;
            this.lblFormHSBATitle.Height = 32;
            this.lblFormHSBATitle.Name = "lblFormHSBATitle";
            this.lblFormHSBATitle.Text = "TAO HO SO BENH AN MOI";
            this.lblFormHSBATitle.TextAlign = ContentAlignment.MiddleCenter;

            this.lblMAHSBA_F.AutoSize = false;
            this.lblMAHSBA_F.Font = new Font("Segoe UI", 9F);
            this.lblMAHSBA_F.Location = new Point(10, 48);
            this.lblMAHSBA_F.Name = "lblMAHSBA_F";
            this.lblMAHSBA_F.Size = new Size(100, 20);
            this.lblMAHSBA_F.Text = "Ma HSBA:";

            this.txtMAHSBA_Form.Font = new Font("Segoe UI", 9.5F);
            this.txtMAHSBA_Form.Location = new Point(115, 45);
            this.txtMAHSBA_Form.Name = "txtMAHSBA_Form";
            this.txtMAHSBA_Form.Size = new Size(250, 24);

            this.lblMABN_HSBA_F.AutoSize = false;
            this.lblMABN_HSBA_F.Font = new Font("Segoe UI", 9F);
            this.lblMABN_HSBA_F.Location = new Point(10, 83);
            this.lblMABN_HSBA_F.Name = "lblMABN_HSBA_F";
            this.lblMABN_HSBA_F.Size = new Size(100, 20);
            this.lblMABN_HSBA_F.Text = "Ma BN:";

            this.txtMABN_HSBA.Font = new Font("Segoe UI", 9.5F);
            this.txtMABN_HSBA.Location = new Point(115, 80);
            this.txtMABN_HSBA.Name = "txtMABN_HSBA";
            this.txtMABN_HSBA.Size = new Size(250, 24);

            this.lblNgayHSBA_F.AutoSize = false;
            this.lblNgayHSBA_F.Font = new Font("Segoe UI", 9F);
            this.lblNgayHSBA_F.Location = new Point(10, 118);
            this.lblNgayHSBA_F.Name = "lblNgayHSBA_F";
            this.lblNgayHSBA_F.Size = new Size(100, 20);
            this.lblNgayHSBA_F.Text = "Ngay (dd/MM/yyyy):";

            this.txtNgayHSBA.Font = new Font("Segoe UI", 9.5F);
            this.txtNgayHSBA.Location = new Point(115, 115);
            this.txtNgayHSBA.Name = "txtNgayHSBA";
            this.txtNgayHSBA.Size = new Size(150, 24);

            this.lblMaKhoaNew_F.AutoSize = false;
            this.lblMaKhoaNew_F.Font = new Font("Segoe UI", 9F);
            this.lblMaKhoaNew_F.Location = new Point(10, 153);
            this.lblMaKhoaNew_F.Name = "lblMaKhoaNew_F";
            this.lblMaKhoaNew_F.Size = new Size(100, 20);
            this.lblMaKhoaNew_F.Text = "Ma khoa:";

            this.txtMaKhoaNew.Font = new Font("Segoe UI", 9.5F);
            this.txtMaKhoaNew.Location = new Point(115, 150);
            this.txtMaKhoaNew.Name = "txtMaKhoaNew";
            this.txtMaKhoaNew.Size = new Size(150, 24);

            this.btnLuuHSBA.BackColor = Color.FromArgb(39, 174, 96);
            this.btnLuuHSBA.FlatStyle = FlatStyle.Flat;
            this.btnLuuHSBA.ForeColor = Color.White;
            this.btnLuuHSBA.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnLuuHSBA.Location = new Point(10, 210);
            this.btnLuuHSBA.Name = "btnLuuHSBA";
            this.btnLuuHSBA.Size = new Size(110, 28);
            this.btnLuuHSBA.Text = "Luu";
            this.btnLuuHSBA.UseVisualStyleBackColor = false;
            this.btnLuuHSBA.Click += new EventHandler(this.btnLuuHSBA_Click);

            this.btnHuyHSBA.BackColor = Color.FromArgb(149, 165, 166);
            this.btnHuyHSBA.FlatStyle = FlatStyle.Flat;
            this.btnHuyHSBA.ForeColor = Color.White;
            this.btnHuyHSBA.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnHuyHSBA.Location = new Point(130, 210);
            this.btnHuyHSBA.Name = "btnHuyHSBA";
            this.btnHuyHSBA.Size = new Size(100, 28);
            this.btnHuyHSBA.Text = "Huy";
            this.btnHuyHSBA.UseVisualStyleBackColor = false;
            this.btnHuyHSBA.Click += new EventHandler(this.btnHuyHSBA_Click);

            // ════════════════════════════════════════════════════════════════
            // TAB 3: DIEU PHOI KY THUAT VIEN
            // ════════════════════════════════════════════════════════════════
            this.tabKTV.Controls.Add(this.lblSoDV);
            this.tabKTV.Controls.Add(this.dgvHSBA_DV);
            this.tabKTV.Controls.Add(this.grpPhanCongKTV);
            this.tabKTV.Name = "tabKTV";
            this.tabKTV.Text = "Dieu phoi Ky Thuat Vien";

            this.lblSoDV.AutoSize = true;
            this.lblSoDV.Font = new Font("Segoe UI", 9F);
            this.lblSoDV.ForeColor = Color.Gray;
            this.lblSoDV.Location = new Point(8, 8);
            this.lblSoDV.Name = "lblSoDV";
            this.lblSoDV.Text = "Tong: 0 dich vu";

            this.dgvHSBA_DV.AllowUserToAddRows = false;
            this.dgvHSBA_DV.AllowUserToDeleteRows = false;
            this.dgvHSBA_DV.ReadOnly = true;
            this.dgvHSBA_DV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvHSBA_DV.BorderStyle = BorderStyle.None;
            this.dgvHSBA_DV.Font = new Font("Segoe UI", 9F);
            this.dgvHSBA_DV.Location = new Point(8, 30);
            this.dgvHSBA_DV.Name = "dgvHSBA_DV";
            this.dgvHSBA_DV.RowHeadersVisible = false;
            this.dgvHSBA_DV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvHSBA_DV.Size = new Size(1060, 420);

            this.grpPhanCongKTV.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.grpPhanCongKTV.Controls.Add(this.lblChonKTV);
            this.grpPhanCongKTV.Controls.Add(this.cboChonKTV);
            this.grpPhanCongKTV.Controls.Add(this.btnPhanCongKTV);
            this.grpPhanCongKTV.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.grpPhanCongKTV.Location = new Point(8, 458);
            this.grpPhanCongKTV.Name = "grpPhanCongKTV";
            this.grpPhanCongKTV.Size = new Size(1060, 60);
            this.grpPhanCongKTV.Text = "Dieu phoi KTV cho dich vu dang chon";

            this.lblChonKTV.AutoSize = false;
            this.lblChonKTV.Font = new Font("Segoe UI", 9F);
            this.lblChonKTV.Location = new Point(10, 25);
            this.lblChonKTV.Name = "lblChonKTV";
            this.lblChonKTV.Size = new Size(100, 20);
            this.lblChonKTV.Text = "Ky thuat vien:";

            this.cboChonKTV.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboChonKTV.Font = new Font("Segoe UI", 9.5F);
            this.cboChonKTV.Location = new Point(115, 22);
            this.cboChonKTV.Name = "cboChonKTV";
            this.cboChonKTV.Size = new Size(280, 24);

            this.btnPhanCongKTV.BackColor = Color.FromArgb(41, 128, 185);
            this.btnPhanCongKTV.FlatStyle = FlatStyle.Flat;
            this.btnPhanCongKTV.ForeColor = Color.White;
            this.btnPhanCongKTV.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnPhanCongKTV.Location = new Point(410, 20);
            this.btnPhanCongKTV.Name = "btnPhanCongKTV";
            this.btnPhanCongKTV.Size = new Size(160, 28);
            this.btnPhanCongKTV.Text = "Xac nhan dieu phoi";
            this.btnPhanCongKTV.UseVisualStyleBackColor = false;
            this.btnPhanCongKTV.Click += new EventHandler(this.btnPhanCongKTV_Click);

            // ════════════════════════════════════════════════════════════════
            // fDieuPhoiVien (Form)
            // ════════════════════════════════════════════════════════════════
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1100, 700);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.MinimumSize = new Size(900, 600);
            this.Name = "fDieuPhoiVien";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Dieu Phoi Vien";
            this.Load += new EventHandler(this.fDieuPhoiVien_Load);

            // ── ResumeLayout ─────────────────────────────────────────────────
            this.panelTop.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelFormBN.ResumeLayout(false);
            this.panelFormBN.PerformLayout();
            this.panelFormHSBA.ResumeLayout(false);
            this.panelFormHSBA.PerformLayout();
            this.grpPhanCongBS.ResumeLayout(false);
            this.grpPhanCongBS.PerformLayout();
            this.grpPhanCongKTV.ResumeLayout(false);
            this.grpPhanCongKTV.PerformLayout();
            this.tabBenhNhan.ResumeLayout(false);
            this.tabBenhNhan.PerformLayout();
            this.tabHSBA.ResumeLayout(false);
            this.tabHSBA.PerformLayout();
            this.tabKTV.ResumeLayout(false);
            this.tabKTV.PerformLayout();
            this.tabControl.ResumeLayout(false);
            ((ISupportInitialize)this.dgvBenhNhan).EndInit();
            ((ISupportInitialize)this.dgvHSBA).EndInit();
            ((ISupportInitialize)this.dgvHSBA_DV).EndInit();
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