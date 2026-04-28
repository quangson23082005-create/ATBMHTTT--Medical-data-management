// fDieuPhoiVien.cs  —  Logic (code-behind)
// Tai cau truc: tach ro tung vung chuc nang, bo comment du thua,
// dung guard clause nhat quan, helper method giam trung lap MessageBox.
using QLBV.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLBV
{
    public partial class fDieuPhoiVien : Form
    {
        // ── Trang thai noi bo ─────────────────────────────────────────────────
        private bool _isEditBN = false;
        private const string PLACEHOLDER_TIMBN = "Tim kiem MABN hoac ten...";

        public fDieuPhoiVien()
        {
            InitializeComponent();
        }

        // ════════════════════════════════════════════════════════════════════
        // KHOI DONG FORM
        // ════════════════════════════════════════════════════════════════════
        private void fDieuPhoiVien_Load(object sender, EventArgs e)
        {
            ConfigureGrids();
            LoadBenhNhan();
            LoadHSBA();
            LoadHSBA_DV();
            LoadComboBoxBacSi();
            LoadComboBoxKTV();
        }

        /// <summary>Cau hinh chung cho DataGridView, goi 1 lan khi Load.</summary>
        private void ConfigureGrids()
        {
            foreach (DataGridView dgv in new[] { dgvBenhNhan, dgvHSBA, dgvHSBA_DV })
            {
                dgv.ReadOnly = true;
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv.RowHeadersVisible = false;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv.AllowUserToAddRows = false;
                dgv.AllowUserToDeleteRows = false;
            }
        }

        // ════════════════════════════════════════════════════════════════════
        // PLACEHOLDER WORKAROUND (.NET 4.7.2 khong co PlaceholderText)
        // ════════════════════════════════════════════════════════════════════
        private void txtTimBN_GotFocus(object sender, EventArgs e)
        {
            if (txtTimBN.Text == PLACEHOLDER_TIMBN)
            {
                txtTimBN.Text = string.Empty;
                txtTimBN.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtTimBN_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimBN.Text))
            {
                txtTimBN.Text = PLACEHOLDER_TIMBN;
                txtTimBN.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private string GetSearchText()
        {
            string t = txtTimBN.Text.Trim();
            return t == PLACEHOLDER_TIMBN ? string.Empty : t;
        }

        // ════════════════════════════════════════════════════════════════════
        // TAB 1: QUAN LY BENH NHAN
        // ════════════════════════════════════════════════════════════════════
        private void LoadBenhNhan(string search = "")
        {
            try
            {
                dgvBenhNhan.DataSource = DieuPhoiVienDAO.Instance.GetAllBenhNhan(search);
                lblSoBN.Text = $"Tong: {dgvBenhNhan.RowCount} benh nhan";
            }
            catch (Exception ex) { ShowError(ex); }
        }

        private void btnTimBN_Click(object sender, EventArgs e)
        {
            LoadBenhNhan(GetSearchText());
        }

        private void btnThemBN_Click(object sender, EventArgs e)
        {
            _isEditBN = false;
            lblFormBNTitle.Text = "THEM BENH NHAN MOI";
            txtMABN_Form.ReadOnly = false;
            ClearFormBN();
            panelFormBN.Visible = true;
        }

        private void btnSuaBN_Click(object sender, EventArgs e)
        {
            if (dgvBenhNhan.CurrentRow == null) return;

            _isEditBN = true;
            lblFormBNTitle.Text = "SUA THONG TIN BENH NHAN";
            txtMABN_Form.ReadOnly = true;
            panelFormBN.Visible = true;

            DataGridViewRow row = dgvBenhNhan.CurrentRow;
            txtMABN_Form.Text = row.Cells["MABN"].Value?.ToString();
            txtTENBN_Form.Text = row.Cells["TENBN"].Value?.ToString();
            cboPhaiBS.Text = row.Cells["PHAI"].Value?.ToString();
            txtNgaySinhBN.Text = row.Cells["NGAYSINH"].Value?.ToString();
            txtCCCD_Form.Text = row.Cells["CCCD"].Value?.ToString();
            txtSoNha.Text = row.Cells["SONHA"].Value?.ToString();
            txtTenDuong.Text = row.Cells["TENDUONG"].Value?.ToString();
            txtQuanHuyen.Text = row.Cells["QUANHUYEN"].Value?.ToString();
            txtTinhTP.Text = row.Cells["TINHTP"].Value?.ToString();
        }

        private void btnLuuBN_Click(object sender, EventArgs e)
        {
            try
            {
                if (_isEditBN)
                    DieuPhoiVienDAO.Instance.SuaBenhNhan(
                        txtMABN_Form.Text, txtTENBN_Form.Text, cboPhaiBS.Text,
                        txtNgaySinhBN.Text, txtCCCD_Form.Text, txtSoNha.Text,
                        txtTenDuong.Text, txtQuanHuyen.Text, txtTinhTP.Text,
                        string.Empty, string.Empty, string.Empty);
                else
                    DieuPhoiVienDAO.Instance.ThemBenhNhan(
                        txtMABN_Form.Text, txtTENBN_Form.Text, cboPhaiBS.Text,
                        txtNgaySinhBN.Text, txtCCCD_Form.Text, txtSoNha.Text,
                        txtTenDuong.Text, txtQuanHuyen.Text, txtTinhTP.Text,
                        string.Empty, string.Empty, string.Empty);

                ShowInfo("Luu thanh cong!");
                panelFormBN.Visible = false;
                LoadBenhNhan();
            }
            catch (Exception ex) { ShowError(ex); }
        }

        private void btnHuyBN_Click(object sender, EventArgs e)
        {
            panelFormBN.Visible = false;
        }

        private void ClearFormBN()
        {
            txtMABN_Form.Text = string.Empty;
            txtTENBN_Form.Text = string.Empty;
            txtNgaySinhBN.Text = string.Empty;
            txtCCCD_Form.Text = string.Empty;
            txtSoNha.Text = string.Empty;
            txtTenDuong.Text = string.Empty;
            txtQuanHuyen.Text = string.Empty;
            txtTinhTP.Text = string.Empty;
            if (cboPhaiBS.Items.Count > 0)
                cboPhaiBS.SelectedIndex = 0;
        }

        // ════════════════════════════════════════════════════════════════════
        // TAB 2: PHAN CONG HO SO BENH AN
        // ════════════════════════════════════════════════════════════════════
        private void LoadHSBA()
        {
            try
            {
                dgvHSBA.DataSource = DieuPhoiVienDAO.Instance.GetAllHSBA();
                lblSoHSBA.Text = $"Tong: {dgvHSBA.RowCount} ho so";
            }
            catch (Exception ex) { ShowError(ex); }
        }

        private void LoadComboBoxBacSi()
        {
            try
            {
                DataTable dt = DieuPhoiVienDAO.Instance.GetDanhSachBacSi();
                cboChonBS.DataSource = dt;
                cboChonBS.DisplayMember = "HOTEN";
                cboChonBS.ValueMember = "MANV";
            }
            catch { /* ComboBox se trong neu khong load duoc */ }
        }

        private void btnThemHSBA_Click(object sender, EventArgs e)
        {
            lblFormHSBATitle.Text = "TAO HO SO BENH AN MOI";
            panelFormHSBA.Visible = true;
            ClearFormHSBA();
        }

        private void btnPhanCongBS_Click(object sender, EventArgs e)
        {
            if (dgvHSBA.CurrentRow == null) return;

            string mabs = cboChonBS.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(mabs))
            {
                ShowWarning("Chon bac si truoc!");
                return;
            }

            string mahsba = dgvHSBA.CurrentRow.Cells["MAHSBA"].Value?.ToString();
            string makhoa = txtMaKhoa.Text.Trim();

            try
            {
                DieuPhoiVienDAO.Instance.CapNhatPhanCong(mahsba, mabs, makhoa);
                ShowInfo("Phan cong bac si thanh cong!");
                LoadHSBA();
            }
            catch (Exception ex) { ShowError(ex); }
        }

        private void btnLuuHSBA_Click(object sender, EventArgs e)
        {
            try
            {
                DieuPhoiVienDAO.Instance.ThemHSBA(
                    txtMAHSBA_Form.Text, txtMABN_HSBA.Text,
                    txtNgayHSBA.Text,
                    string.Empty, string.Empty, string.Empty,
                    txtMaKhoaNew.Text, string.Empty);

                ShowInfo("Tao ho so thanh cong!");
                panelFormHSBA.Visible = false;
                LoadHSBA();
            }
            catch (Exception ex) { ShowError(ex); }
        }

        private void btnHuyHSBA_Click(object sender, EventArgs e)
        {
            panelFormHSBA.Visible = false;
        }

        private void ClearFormHSBA()
        {
            txtMAHSBA_Form.Text = string.Empty;
            txtMABN_HSBA.Text = string.Empty;
            txtNgayHSBA.Text = string.Empty;
            txtMaKhoaNew.Text = string.Empty;
        }

        // ════════════════════════════════════════════════════════════════════
        // TAB 3: DIEU PHOI KY THUAT VIEN
        // ════════════════════════════════════════════════════════════════════
        private void LoadHSBA_DV()
        {
            try
            {
                dgvHSBA_DV.DataSource = DieuPhoiVienDAO.Instance.GetHSBA_DV();
                lblSoDV.Text = $"Tong: {dgvHSBA_DV.RowCount} dich vu";
            }
            catch (Exception ex) { ShowError(ex); }
        }

        private void LoadComboBoxKTV()
        {
            try
            {
                DataTable dt = DieuPhoiVienDAO.Instance.GetDanhSachKTV();
                cboChonKTV.DataSource = dt;
                cboChonKTV.DisplayMember = "HOTEN";
                cboChonKTV.ValueMember = "MANV";
            }
            catch { /* ComboBox se trong neu khong load duoc */ }
        }

        private void btnPhanCongKTV_Click(object sender, EventArgs e)
        {
            if (dgvHSBA_DV.CurrentRow == null) return;

            string maktv = cboChonKTV.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(maktv))
            {
                ShowWarning("Chon ky thuat vien truoc!");
                return;
            }

            DataGridViewRow row = dgvHSBA_DV.CurrentRow;
            string mahsba = row.Cells["MAHSBA"].Value?.ToString();
            string loaidv = row.Cells["LOAIDV"].Value?.ToString();
            string ngaydv = row.Cells["NGAYDV"].Value?.ToString();

            try
            {
                DieuPhoiVienDAO.Instance.CapNhatKTV(mahsba, loaidv, ngaydv, maktv);
                ShowInfo("Dieu phoi KTV thanh cong!");
                LoadHSBA_DV();
            }
            catch (Exception ex) { ShowError(ex); }
        }

        // ════════════════════════════════════════════════════════════════════
        // SHARED ACTIONS
        // ════════════════════════════════════════════════════════════════════
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadBenhNhan();
            LoadHSBA();
            LoadHSBA_DV();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (ConfirmAction("Ban co muon dang xuat?"))
                this.Close();
        }

        // ════════════════════════════════════════════════════════════════════
        // HELPER METHODS  (giam trung lap MessageBox)
        // ════════════════════════════════════════════════════════════════════
        private bool ConfirmAction(string question)
            => MessageBox.Show(question, "Xac nhan",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

        private void ShowInfo(string msg)
            => MessageBox.Show(msg, "Thong bao",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);

        private void ShowWarning(string msg)
            => MessageBox.Show(msg, "Thong bao",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);

        private void ShowError(Exception ex)
            => MessageBox.Show("Loi: " + ex.Message, "Loi",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);

        private void tabBenhNhan_Click(object sender, EventArgs e)
        {

        }

        private void lblFormBNTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblFormBNTitle_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvHSBA_DV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}