using QLBV.DAO;
using QLBV.DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLBV
{
    public partial class fBenhNhan : Form
    {
        public fBenhNhan()
        {
            InitializeComponent();
        }

        // ════════════════════════════════════════════════════════════════════════
        // KHOI DONG FORM
        // ════════════════════════════════════════════════════════════════════════
        private void fBenhNhan_Load(object sender, EventArgs e)
        {
            ConfigureGrid();
            LoadThongTinCaNhan();
            LoadHSBA();
        }

        /// <summary>
        /// Cau hinh DataGridView — chi goi 1 lan khi Load.
        /// </summary>
        private void ConfigureGrid()
        {
            dgvHSBA.ReadOnly = true;
            dgvHSBA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHSBA.RowHeadersVisible = false;
        }

        // ════════════════════════════════════════════════════════════════════════
        // LOAD DATA
        // ════════════════════════════════════════════════════════════════════════
        private void LoadThongTinCaNhan()
        {
            try
            {
                DataTable dt = BenhNhanDAO.Instance.GetThongTinCaNhan();
                if (dt.Rows.Count == 0) return;

                DataRow row = dt.Rows[0];

                // Chi doc
                txtMABN.Text     = row["MABN"]?.ToString();
                txtTENBN.Text    = row["TENBN"]?.ToString();
                txtPHAI.Text     = row["PHAI"]?.ToString();
                txtNGAYSINH.Text = row["NGAYSINH"] != DBNull.Value
                    ? Convert.ToDateTime(row["NGAYSINH"]).ToString("dd/MM/yyyy") : "";
                txtCCCD.Text     = row["CCCD"]?.ToString();

                // Duoc phep sua
                txtSONHA.Text        = row["SONHA"]?.ToString();
                txtTENDUONG.Text     = row["TENDUONG"]?.ToString();
                txtQUANHUYEN.Text    = row["QUANHUYEN"]?.ToString();
                txtTINHTP.Text       = row["TINHTP"]?.ToString();
                txtTIENSUBENH.Text   = row["TIENSUBENH"]?.ToString();
                txtTIENSUBENHGD.Text = row["TIENSUBENHGD"]?.ToString();
                txtDIUNGTHUOC.Text   = row["DIUNGTHUOC"]?.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi tai thong tin: " + ex.Message, "Loi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadHSBA()
        {
            try
            {
                DataTable dt = BenhNhanDAO.Instance.GetHSBA();
                dgvHSBA.DataSource = dt;

                // Dat header text sau khi DataSource duoc gan
                if (dt.Columns.Contains("MAHSBA"))   dgvHSBA.Columns["MAHSBA"].HeaderText   = "Ma HSBA";
                if (dt.Columns.Contains("MABN"))     dgvHSBA.Columns["MABN"].HeaderText     = "Ma BN";
                if (dt.Columns.Contains("NGAY"))     dgvHSBA.Columns["NGAY"].HeaderText     = "Ngay";
                if (dt.Columns.Contains("CHANDOAN")) dgvHSBA.Columns["CHANDOAN"].HeaderText = "Chan doan";
                if (dt.Columns.Contains("DIEUTRI"))  dgvHSBA.Columns["DIEUTRI"].HeaderText  = "Dieu tri";
                if (dt.Columns.Contains("KETLUAN"))  dgvHSBA.Columns["KETLUAN"].HeaderText  = "Ket luan";

                lblSoHoSo.Text = $"So ho so benh an: {dt.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi tai HSBA: " + ex.Message, "Loi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ════════════════════════════════════════════════════════════════════════
        // XU LY SU KIEN
        // ════════════════════════════════════════════════════════════════════════
        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            var dto = new BenhNhanDTO
            {
                SoNha        = txtSONHA.Text.Trim(),
                TenDuong     = txtTENDUONG.Text.Trim(),
                QuanHuyen    = txtQUANHUYEN.Text.Trim(),
                TinhTP       = txtTINHTP.Text.Trim(),
                TienSuBenh   = txtTIENSUBENH.Text.Trim(),
                TienSuBenhGD = txtTIENSUBENHGD.Text.Trim(),
                DiUngThuoc   = txtDIUNGTHUOC.Text.Trim()
            };

            try
            {
                int affected = BenhNhanDAO.Instance.CapNhatThongTin(dto);
                if (affected > 0)
                    MessageBox.Show("Cap nhat thong tin thanh cong!", "Thong bao",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Khong co thay doi nao duoc luu.", "Thong bao",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi cap nhat: " + ex.Message, "Loi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadThongTinCaNhan();
            LoadHSBA();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co muon dang xuat?", "Xac nhan",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
