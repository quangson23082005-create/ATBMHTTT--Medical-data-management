namespace QLBV
{
    partial class fKyThuatVien
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle      = new System.Windows.Forms.Label();
            this.lblTongSo     = new System.Windows.Forms.Label();
            this.dgvDichVu     = new System.Windows.Forms.DataGridView();
            this.btnLuuKetQua  = new System.Windows.Forms.Button();
            this.btnLamMoi     = new System.Windows.Forms.Button();
            this.btnDangXuat   = new System.Windows.Forms.Button();
            this.panelTop      = new System.Windows.Forms.Panel();
            this.panelBottom   = new System.Windows.Forms.Panel();

            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();

            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 60;

            // lblTitle
            this.lblTitle.AutoSize = false;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Text = "KỸ THUẬT VIÊN - Danh sách dịch vụ được giao";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblTongSo
            this.lblTongSo.AutoSize = true;
            this.lblTongSo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTongSo.ForeColor = System.Drawing.Color.Gray;
            this.lblTongSo.Location = new System.Drawing.Point(12, 68);
            this.lblTongSo.Text = "Tổng số dịch vụ: 0";

            // dgvDichVu
            this.dgvDichVu.AllowUserToAddRows    = false;
            this.dgvDichVu.AllowUserToDeleteRows = false;
            this.dgvDichVu.BorderStyle  = System.Windows.Forms.BorderStyle.None;
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Location     = new System.Drawing.Point(12, 90);
            this.dgvDichVu.Size         = new System.Drawing.Size(960, 440);
            this.dgvDichVu.Anchor       = System.Windows.Forms.AnchorStyles.Top
                                        | System.Windows.Forms.AnchorStyles.Bottom
                                        | System.Windows.Forms.AnchorStyles.Left
                                        | System.Windows.Forms.AnchorStyles.Right;
            this.dgvDichVu.RowHeadersVisible = false;
            this.dgvDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDichVu.Font = new System.Drawing.Font("Segoe UI", 9.5F);

            // panelBottom
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Height = 55;
            this.panelBottom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBottom.Controls.Add(this.btnDangXuat);
            this.panelBottom.Controls.Add(this.btnLamMoi);
            this.panelBottom.Controls.Add(this.btnLuuKetQua);

            // btnLuuKetQua
            this.btnLuuKetQua.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnLuuKetQua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuKetQua.ForeColor = System.Drawing.Color.White;
            this.btnLuuKetQua.Font      = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLuuKetQua.Location  = new System.Drawing.Point(12, 12);
            this.btnLuuKetQua.Size      = new System.Drawing.Size(160, 32);
            this.btnLuuKetQua.Text      = "💾 Lưu kết quả";
            this.btnLuuKetQua.Click    += new System.EventHandler(this.btnLuuKetQua_Click);

            // btnLamMoi
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Font      = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.Location  = new System.Drawing.Point(185, 12);
            this.btnLamMoi.Size      = new System.Drawing.Size(130, 32);
            this.btnLamMoi.Text      = "🔄 Làm mới";
            this.btnLamMoi.Click    += new System.EventHandler(this.btnLamMoi_Click);

            // btnDangXuat
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Font      = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDangXuat.Location  = new System.Drawing.Point(328, 12);
            this.btnDangXuat.Size      = new System.Drawing.Size(120, 32);
            this.btnDangXuat.Text      = "🚪 Đăng xuất";
            this.btnDangXuat.Click    += new System.EventHandler(this.btnDangXuat_Click);

            // fKyThuatVien
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(984, 601);
            this.Controls.Add(this.dgvDichVu);
            this.Controls.Add(this.lblTongSo);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.MinimumSize         = new System.Drawing.Size(800, 500);
            this.Name                = "fKyThuatVien";
            this.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text                = "Kỹ Thuật Viên";
            this.Load               += new System.EventHandler(this.fKyThuatVien_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTongSo;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.Button btnLuuKetQua;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
    }
}
