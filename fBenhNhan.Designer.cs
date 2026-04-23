namespace QLBV
{
    partial class fBenhNhan
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabThongTin = new System.Windows.Forms.TabPage();
            this.tabHSBA = new System.Windows.Forms.TabPage();
            this.grpReadOnly = new System.Windows.Forms.GroupBox();
            this.lblMABN = new System.Windows.Forms.Label();
            this.txtMABN = new System.Windows.Forms.TextBox();
            this.lblTENBN = new System.Windows.Forms.Label();
            this.txtTENBN = new System.Windows.Forms.TextBox();
            this.lblPHAI = new System.Windows.Forms.Label();
            this.txtPHAI = new System.Windows.Forms.TextBox();
            this.lblNGAYSINH = new System.Windows.Forms.Label();
            this.txtNGAYSINH = new System.Windows.Forms.TextBox();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.grpEditable = new System.Windows.Forms.GroupBox();
            this.lblSONHA = new System.Windows.Forms.Label();
            this.txtSONHA = new System.Windows.Forms.TextBox();
            this.lblTENDUONG = new System.Windows.Forms.Label();
            this.txtTENDUONG = new System.Windows.Forms.TextBox();
            this.lblQUANHUYEN = new System.Windows.Forms.Label();
            this.txtQUANHUYEN = new System.Windows.Forms.TextBox();
            this.lblTINHTP = new System.Windows.Forms.Label();
            this.txtTINHTP = new System.Windows.Forms.TextBox();
            this.lblTIENSUBENH = new System.Windows.Forms.Label();
            this.txtTIENSUBENH = new System.Windows.Forms.TextBox();
            this.lblTIENSUBENHGD = new System.Windows.Forms.Label();
            this.txtTIENSUBENHGD = new System.Windows.Forms.TextBox();
            this.lblDIUNGTHUOC = new System.Windows.Forms.Label();
            this.txtDIUNGTHUOC = new System.Windows.Forms.TextBox();
            this.btnLuuThongTin = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.lblSoHoSo = new System.Windows.Forms.Label();
            this.dgvHSBA = new System.Windows.Forms.DataGridView();

            this.panelTop.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabThongTin.SuspendLayout();
            this.tabHSBA.SuspendLayout();
            this.grpReadOnly.SuspendLayout();
            this.grpEditable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHSBA)).BeginInit();
            this.SuspendLayout();

            // ── panelTop ──────────────────────────────────────────
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 60;
            this.panelTop.Name = "panelTop";

            // ── lblTitle ──────────────────────────────────────────
            this.lblTitle.AutoSize = false;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "BENH NHAN - Thong tin ca nhan";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── tabControl ────────────────────────────────────────
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right));
            this.tabControl.Controls.Add(this.tabThongTin);
            this.tabControl.Controls.Add(this.tabHSBA);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl.Location = new System.Drawing.Point(0, 60);
            this.tabControl.Name = "tabControl";
            this.tabControl.Size = new System.Drawing.Size(984, 541);

            // ── tabThongTin ───────────────────────────────────────
            this.tabThongTin.Controls.Add(this.grpReadOnly);
            this.tabThongTin.Controls.Add(this.grpEditable);
            this.tabThongTin.Controls.Add(this.btnLuuThongTin);
            this.tabThongTin.Controls.Add(this.btnLamMoi);
            this.tabThongTin.Controls.Add(this.btnDangXuat);
            this.tabThongTin.Name = "tabThongTin";
            this.tabThongTin.Padding = new System.Windows.Forms.Padding(10);
            this.tabThongTin.Text = "Thong tin ca nhan";

            // ── grpReadOnly ───────────────────────────────────────
            this.grpReadOnly.Controls.Add(this.lblMABN);
            this.grpReadOnly.Controls.Add(this.txtMABN);
            this.grpReadOnly.Controls.Add(this.lblTENBN);
            this.grpReadOnly.Controls.Add(this.txtTENBN);
            this.grpReadOnly.Controls.Add(this.lblPHAI);
            this.grpReadOnly.Controls.Add(this.txtPHAI);
            this.grpReadOnly.Controls.Add(this.lblNGAYSINH);
            this.grpReadOnly.Controls.Add(this.txtNGAYSINH);
            this.grpReadOnly.Controls.Add(this.lblCCCD);
            this.grpReadOnly.Controls.Add(this.txtCCCD);
            this.grpReadOnly.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.grpReadOnly.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpReadOnly.Location = new System.Drawing.Point(15, 15);
            this.grpReadOnly.Name = "grpReadOnly";
            this.grpReadOnly.Size = new System.Drawing.Size(940, 110);
            this.grpReadOnly.Text = "Thong tin co dinh (khong the thay doi)";

            // lblMABN
            this.lblMABN.AutoSize = false;
            this.lblMABN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMABN.Location = new System.Drawing.Point(10, 28);
            this.lblMABN.Name = "lblMABN";
            this.lblMABN.Size = new System.Drawing.Size(95, 20);
            this.lblMABN.Text = "Ma benh nhan:";

            // txtMABN
            this.txtMABN.BackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            this.txtMABN.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtMABN.Location = new System.Drawing.Point(110, 25);
            this.txtMABN.Name = "txtMABN";
            this.txtMABN.ReadOnly = true;
            this.txtMABN.Size = new System.Drawing.Size(150, 24);

            // lblTENBN
            this.lblTENBN.AutoSize = false;
            this.lblTENBN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTENBN.Location = new System.Drawing.Point(320, 28);
            this.lblTENBN.Name = "lblTENBN";
            this.lblTENBN.Size = new System.Drawing.Size(95, 20);
            this.lblTENBN.Text = "Ho ten:";

            // txtTENBN
            this.txtTENBN.BackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            this.txtTENBN.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTENBN.Location = new System.Drawing.Point(420, 25);
            this.txtTENBN.Name = "txtTENBN";
            this.txtTENBN.ReadOnly = true;
            this.txtTENBN.Size = new System.Drawing.Size(180, 24);

            // lblPHAI
            this.lblPHAI.AutoSize = false;
            this.lblPHAI.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPHAI.Location = new System.Drawing.Point(630, 28);
            this.lblPHAI.Name = "lblPHAI";
            this.lblPHAI.Size = new System.Drawing.Size(55, 20);
            this.lblPHAI.Text = "Phai:";

            // txtPHAI
            this.txtPHAI.BackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            this.txtPHAI.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtPHAI.Location = new System.Drawing.Point(690, 25);
            this.txtPHAI.Name = "txtPHAI";
            this.txtPHAI.ReadOnly = true;
            this.txtPHAI.Size = new System.Drawing.Size(70, 24);

            // lblNGAYSINH
            this.lblNGAYSINH.AutoSize = false;
            this.lblNGAYSINH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNGAYSINH.Location = new System.Drawing.Point(10, 68);
            this.lblNGAYSINH.Name = "lblNGAYSINH";
            this.lblNGAYSINH.Size = new System.Drawing.Size(95, 20);
            this.lblNGAYSINH.Text = "Ngay sinh:";

            // txtNGAYSINH
            this.txtNGAYSINH.BackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            this.txtNGAYSINH.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNGAYSINH.Location = new System.Drawing.Point(110, 65);
            this.txtNGAYSINH.Name = "txtNGAYSINH";
            this.txtNGAYSINH.ReadOnly = true;
            this.txtNGAYSINH.Size = new System.Drawing.Size(150, 24);

            // lblCCCD
            this.lblCCCD.AutoSize = false;
            this.lblCCCD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCCCD.Location = new System.Drawing.Point(320, 68);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(95, 20);
            this.lblCCCD.Text = "CCCD:";

            // txtCCCD
            this.txtCCCD.BackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            this.txtCCCD.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtCCCD.Location = new System.Drawing.Point(420, 65);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.ReadOnly = true;
            this.txtCCCD.Size = new System.Drawing.Size(180, 24);

            // ── grpEditable ───────────────────────────────────────
            this.grpEditable.Controls.Add(this.lblSONHA);
            this.grpEditable.Controls.Add(this.txtSONHA);
            this.grpEditable.Controls.Add(this.lblTENDUONG);
            this.grpEditable.Controls.Add(this.txtTENDUONG);
            this.grpEditable.Controls.Add(this.lblQUANHUYEN);
            this.grpEditable.Controls.Add(this.txtQUANHUYEN);
            this.grpEditable.Controls.Add(this.lblTINHTP);
            this.grpEditable.Controls.Add(this.txtTINHTP);
            this.grpEditable.Controls.Add(this.lblTIENSUBENH);
            this.grpEditable.Controls.Add(this.txtTIENSUBENH);
            this.grpEditable.Controls.Add(this.lblTIENSUBENHGD);
            this.grpEditable.Controls.Add(this.txtTIENSUBENHGD);
            this.grpEditable.Controls.Add(this.lblDIUNGTHUOC);
            this.grpEditable.Controls.Add(this.txtDIUNGTHUOC);
            this.grpEditable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpEditable.Location = new System.Drawing.Point(15, 135);
            this.grpEditable.Name = "grpEditable";
            this.grpEditable.Size = new System.Drawing.Size(940, 220);
            this.grpEditable.Text = "Thong tin co the cap nhat";

            // lblSONHA
            this.lblSONHA.AutoSize = false;
            this.lblSONHA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSONHA.Location = new System.Drawing.Point(10, 28);
            this.lblSONHA.Name = "lblSONHA";
            this.lblSONHA.Size = new System.Drawing.Size(95, 20);
            this.lblSONHA.Text = "So nha:";

            // txtSONHA
            this.txtSONHA.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSONHA.Location = new System.Drawing.Point(110, 25);
            this.txtSONHA.Name = "txtSONHA";
            this.txtSONHA.Size = new System.Drawing.Size(150, 24);

            // lblTENDUONG
            this.lblTENDUONG.AutoSize = false;
            this.lblTENDUONG.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTENDUONG.Location = new System.Drawing.Point(10, 63);
            this.lblTENDUONG.Name = "lblTENDUONG";
            this.lblTENDUONG.Size = new System.Drawing.Size(95, 20);
            this.lblTENDUONG.Text = "Ten duong:";

            // txtTENDUONG
            this.txtTENDUONG.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTENDUONG.Location = new System.Drawing.Point(110, 60);
            this.txtTENDUONG.Name = "txtTENDUONG";
            this.txtTENDUONG.Size = new System.Drawing.Size(150, 24);

            // lblQUANHUYEN
            this.lblQUANHUYEN.AutoSize = false;
            this.lblQUANHUYEN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblQUANHUYEN.Location = new System.Drawing.Point(10, 98);
            this.lblQUANHUYEN.Name = "lblQUANHUYEN";
            this.lblQUANHUYEN.Size = new System.Drawing.Size(95, 20);
            this.lblQUANHUYEN.Text = "Quan/huyen:";

            // txtQUANHUYEN
            this.txtQUANHUYEN.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtQUANHUYEN.Location = new System.Drawing.Point(110, 95);
            this.txtQUANHUYEN.Name = "txtQUANHUYEN";
            this.txtQUANHUYEN.Size = new System.Drawing.Size(150, 24);

            // lblTINHTP
            this.lblTINHTP.AutoSize = false;
            this.lblTINHTP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTINHTP.Location = new System.Drawing.Point(10, 133);
            this.lblTINHTP.Name = "lblTINHTP";
            this.lblTINHTP.Size = new System.Drawing.Size(95, 20);
            this.lblTINHTP.Text = "Tinh/TP:";

            // txtTINHTP
            this.txtTINHTP.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTINHTP.Location = new System.Drawing.Point(110, 130);
            this.txtTINHTP.Name = "txtTINHTP";
            this.txtTINHTP.Size = new System.Drawing.Size(150, 24);

            // lblTIENSUBENH
            this.lblTIENSUBENH.AutoSize = false;
            this.lblTIENSUBENH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTIENSUBENH.Location = new System.Drawing.Point(320, 28);
            this.lblTIENSUBENH.Name = "lblTIENSUBENH";
            this.lblTIENSUBENH.Size = new System.Drawing.Size(110, 20);
            this.lblTIENSUBENH.Text = "Tien su benh:";

            // txtTIENSUBENH
            this.txtTIENSUBENH.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTIENSUBENH.Location = new System.Drawing.Point(435, 25);
            this.txtTIENSUBENH.Name = "txtTIENSUBENH";
            this.txtTIENSUBENH.Size = new System.Drawing.Size(480, 24);

            // lblTIENSUBENHGD
            this.lblTIENSUBENHGD.AutoSize = false;
            this.lblTIENSUBENHGD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTIENSUBENHGD.Location = new System.Drawing.Point(320, 63);
            this.lblTIENSUBENHGD.Name = "lblTIENSUBENHGD";
            this.lblTIENSUBENHGD.Size = new System.Drawing.Size(110, 20);
            this.lblTIENSUBENHGD.Text = "Tien su benh GD:";

            // txtTIENSUBENHGD
            this.txtTIENSUBENHGD.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTIENSUBENHGD.Location = new System.Drawing.Point(435, 60);
            this.txtTIENSUBENHGD.Name = "txtTIENSUBENHGD";
            this.txtTIENSUBENHGD.Size = new System.Drawing.Size(480, 24);

            // lblDIUNGTHUOC
            this.lblDIUNGTHUOC.AutoSize = false;
            this.lblDIUNGTHUOC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDIUNGTHUOC.Location = new System.Drawing.Point(320, 98);
            this.lblDIUNGTHUOC.Name = "lblDIUNGTHUOC";
            this.lblDIUNGTHUOC.Size = new System.Drawing.Size(110, 20);
            this.lblDIUNGTHUOC.Text = "Di ung thuoc:";

            // txtDIUNGTHUOC
            this.txtDIUNGTHUOC.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDIUNGTHUOC.Location = new System.Drawing.Point(435, 95);
            this.txtDIUNGTHUOC.Name = "txtDIUNGTHUOC";
            this.txtDIUNGTHUOC.Size = new System.Drawing.Size(480, 24);

            // ── Buttons ───────────────────────────────────────────
            this.btnLuuThongTin.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnLuuThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuThongTin.ForeColor = System.Drawing.Color.White;
            this.btnLuuThongTin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuuThongTin.Location = new System.Drawing.Point(15, 370);
            this.btnLuuThongTin.Name = "btnLuuThongTin";
            this.btnLuuThongTin.Size = new System.Drawing.Size(160, 36);
            this.btnLuuThongTin.Text = "Luu thong tin";
            this.btnLuuThongTin.UseVisualStyleBackColor = false;
            this.btnLuuThongTin.Click += new System.EventHandler(this.btnLuuThongTin_Click);

            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.Location = new System.Drawing.Point(190, 370);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(130, 36);
            this.btnLamMoi.Text = "Lam moi";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDangXuat.Location = new System.Drawing.Point(335, 370);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(120, 36);
            this.btnDangXuat.Text = "Dang xuat";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);

            // ── tabHSBA ───────────────────────────────────────────
            this.tabHSBA.Controls.Add(this.lblSoHoSo);
            this.tabHSBA.Controls.Add(this.dgvHSBA);
            this.tabHSBA.Name = "tabHSBA";
            this.tabHSBA.Padding = new System.Windows.Forms.Padding(10);
            this.tabHSBA.Text = "Ho so benh an";

            this.lblSoHoSo.AutoSize = true;
            this.lblSoHoSo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSoHoSo.ForeColor = System.Drawing.Color.Gray;
            this.lblSoHoSo.Location = new System.Drawing.Point(5, 5);
            this.lblSoHoSo.Name = "lblSoHoSo";
            this.lblSoHoSo.Text = "So ho so benh an: 0";

            this.dgvHSBA.AllowUserToAddRows = false;
            this.dgvHSBA.AllowUserToDeleteRows = false;
            this.dgvHSBA.ReadOnly = true;
            this.dgvHSBA.Anchor = ((System.Windows.Forms.AnchorStyles)(
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right));
            this.dgvHSBA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHSBA.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvHSBA.Location = new System.Drawing.Point(5, 30);
            this.dgvHSBA.Name = "dgvHSBA";
            this.dgvHSBA.RowHeadersVisible = false;
            this.dgvHSBA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHSBA.Size = new System.Drawing.Size(960, 460);

            // ── fBenhNhan (Form) ──────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 601);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelTop);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "fBenhNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Benh Nhan";
            this.Load += new System.EventHandler(this.fBenhNhan_Load);

            this.panelTop.ResumeLayout(false);
            this.grpReadOnly.ResumeLayout(false);
            this.grpReadOnly.PerformLayout();
            this.grpEditable.ResumeLayout(false);
            this.grpEditable.PerformLayout();
            this.tabThongTin.ResumeLayout(false);
            this.tabHSBA.ResumeLayout(false);
            this.tabHSBA.PerformLayout();
            this.tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHSBA)).EndInit();
            this.ResumeLayout(false);
        }

        // ── Field declarations ────────────────────────────────────
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabThongTin;
        private System.Windows.Forms.TabPage tabHSBA;
        private System.Windows.Forms.GroupBox grpReadOnly;
        private System.Windows.Forms.GroupBox grpEditable;
        private System.Windows.Forms.Label lblMABN;
        private System.Windows.Forms.TextBox txtMABN;
        private System.Windows.Forms.Label lblTENBN;
        private System.Windows.Forms.TextBox txtTENBN;
        private System.Windows.Forms.Label lblPHAI;
        private System.Windows.Forms.TextBox txtPHAI;
        private System.Windows.Forms.Label lblNGAYSINH;
        private System.Windows.Forms.TextBox txtNGAYSINH;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label lblSONHA;
        private System.Windows.Forms.TextBox txtSONHA;
        private System.Windows.Forms.Label lblTENDUONG;
        private System.Windows.Forms.TextBox txtTENDUONG;
        private System.Windows.Forms.Label lblQUANHUYEN;
        private System.Windows.Forms.TextBox txtQUANHUYEN;
        private System.Windows.Forms.Label lblTINHTP;
        private System.Windows.Forms.TextBox txtTINHTP;
        private System.Windows.Forms.Label lblTIENSUBENH;
        private System.Windows.Forms.TextBox txtTIENSUBENH;
        private System.Windows.Forms.Label lblTIENSUBENHGD;
        private System.Windows.Forms.TextBox txtTIENSUBENHGD;
        private System.Windows.Forms.Label lblDIUNGTHUOC;
        private System.Windows.Forms.TextBox txtDIUNGTHUOC;
        private System.Windows.Forms.Button btnLuuThongTin;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Label lblSoHoSo;
        private System.Windows.Forms.DataGridView dgvHSBA;
    }
}