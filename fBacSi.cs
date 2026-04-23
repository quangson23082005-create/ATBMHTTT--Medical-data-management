// fBacSi.cs  —  Logic (code-behind)
// Tai cau truc: tach ro tung vung chuc nang, bo comment du thua,
// dung guard clause nhat quan, dung string interpolation.
using QLBV.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLBV
{
    public partial class fBacSi : Form
    {
        // ── Trang thai noi bo ─────────────────────────────────────────────────
        private string _selectedMaHSBA = string.Empty;

        public fBacSi()
        {
            InitializeComponent();
        }

        // ════════════════════════════════════════════════════════════════════
        // KHOI DONG FORM
        // ════════════════════════════════════════════════════════════════════
        private void fBacSi_Load(object sender, EventArgs e)
        {
            ConfigureGrids();
            LoadHSBA();
        }

        /// <summary>
        /// Cau hinh chung cho cac DataGridView (goi 1 lan duy nhat khi Load).
        /// Cac thiet lap UI thuoc ve day, khong dat trong Designer.
        /// </summary>
        private void ConfigureGrids()
        {
            foreach (DataGridView dgv in new[] { dgvHSBA, dgvDichVu, dgvBenhNhan, dgvDonThuoc })
            {
                dgv.ReadOnly = true;
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv.RowHeadersVisible = false;
            }
        }

        // ════════════════════════════════════════════════════════════════════
        // TAB 1: HO SO BENH AN CUA TOI
        // VPD tu loc mabs = SESSION_USER → chi thay HSBA cua minh
        // ════════════════════════════════════════════════════════════════════
        private void LoadHSBA()
        {
            try
            {
                DataTable dt = BacSiDAO.Instance.GetHSBACuaToi();
                dgvHSBA.DataSource = dt;
                lblSoHSBA.Text = $"Tong: {dt.Rows.Count} ho so";
            }
            catch (Exception ex) { ShowError(ex); }
        }

        private void dgvHSBA_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHSBA.CurrentRow == null) return;

            DataGridViewRow row = dgvHSBA.CurrentRow;
            _selectedMaHSBA = row.Cells["MAHSBA"].Value?.ToString() ?? string.Empty;

            txtMaHSBA_Edit.Text = _selectedMaHSBA;
            txtChanDoan.Text = row.Cells["CHANDOAN"].Value?.ToString();
            txtDieuTri.Text = row.Cells["DIEUTRI"].Value?.ToString();
            txtKetLuan.Text = row.Cells["KETLUAN"].Value?.ToString();

            LoadHSBA_DV(_selectedMaHSBA);
            LoadDonThuoc(_selectedMaHSBA);
        }

        private void btnCapNhatHSBA_Click(object sender, EventArgs e)
        {
            if (!ValidateHSBASelected()) return;

            try
            {
                BacSiDAO.Instance.CapNhatHSBA(
                    _selectedMaHSBA,
                    txtChanDoan.Text,
                    txtDieuTri.Text,
                    txtKetLuan.Text);

                ShowInfo("Cap nhat HSBA thanh cong!");
                LoadHSBA();
            }
            catch (Exception ex) { ShowError(ex); }
        }

        // ════════════════════════════════════════════════════════════════════
        // TAB 2: DICH VU (HSBA_DV)
        // VPD fn_dr_on_hsbadv → chi thay DV lien quan HSBA cua minh
        // ════════════════════════════════════════════════════════════════════
        private void LoadHSBA_DV(string mahsba)
        {
            try
            {
                dgvDichVu.DataSource = BacSiDAO.Instance.GetHSBA_DV(mahsba);
                lblSoDV.Text = $"Tong: {dgvDichVu.RowCount} dich vu";
            }
            catch (Exception ex) { ShowError(ex); }
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            if (!ValidateHSBASelected("Chon HSBA o tab 1 truoc!")) return;

            string loaidv = txtLoaiDV.Text.Trim();
            string ngaydv = txtNgayDV.Text.Trim();
            string maktv = txtMaKTV.Text.Trim();

            if (string.IsNullOrEmpty(loaidv) || string.IsNullOrEmpty(ngaydv))
            {
                ShowWarning("Nhap day du Loai DV va Ngay!");
                return;
            }

            try
            {
                BacSiDAO.Instance.ThemHSBA_DV(_selectedMaHSBA, loaidv, ngaydv, maktv);
                ShowInfo("Them dich vu thanh cong!");
                LoadHSBA_DV(_selectedMaHSBA);
                txtLoaiDV.Text = txtNgayDV.Text = txtMaKTV.Text = string.Empty;
            }
            catch (Exception ex) { ShowError(ex); }
        }

        private void btnXoaDV_Click(object sender, EventArgs e)
        {
            if (dgvDichVu.CurrentRow == null) return;

            DataGridViewRow row = dgvDichVu.CurrentRow;
            string mahsba = row.Cells["MAHSBA"].Value?.ToString();
            string loaidv = row.Cells["LOAIDV"].Value?.ToString();
            string ngaydv = row.Cells["NGAYDV"].Value?.ToString();

            if (!ConfirmAction($"Xac nhan xoa dich vu '{loaidv}'?")) return;

            try
            {
                BacSiDAO.Instance.XoaHSBA_DV(mahsba, loaidv, ngaydv);
                LoadHSBA_DV(_selectedMaHSBA);
            }
            catch (Exception ex) { ShowError(ex); }
        }

        // ════════════════════════════════════════════════════════════════════
        // TAB 3: BENH NHAN
        // VPD fn_dr_on_view_benhnhan → chi thay BN lien quan HSBA cua minh
        // ════════════════════════════════════════════════════════════════════
        private void LoadBenhNhan()
        {
            try
            {
                dgvBenhNhan.DataSource = BacSiDAO.Instance.GetBenhNhanCuaToi();
            }
            catch (Exception ex) { ShowError(ex); }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabBenhNhan)
                LoadBenhNhan();
        }

        private void dgvBenhNhan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBenhNhan.CurrentRow == null) return;

            DataGridViewRow row = dgvBenhNhan.CurrentRow;
            txtMaBN_Edit.Text = row.Cells["MABN"].Value?.ToString();
            txtTienSuBenh.Text = row.Cells["TIENSUBENH"].Value?.ToString();
            txtTienSuBenhGD.Text = row.Cells["TIENSUBENHGD"].Value?.ToString();
            txtDiUngThuoc.Text = row.Cells["DIUNGTHUOC"].Value?.ToString();
        }

        private void btnCapNhatBN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaBN_Edit.Text))
            {
                ShowWarning("Chon benh nhan truoc!");
                return;
            }

            try
            {
                BacSiDAO.Instance.CapNhatBenhNhan(
                    txtMaBN_Edit.Text,
                    txtTienSuBenh.Text,
                    txtTienSuBenhGD.Text,
                    txtDiUngThuoc.Text);

                ShowInfo("Cap nhat thanh cong!");
                LoadBenhNhan();
            }
            catch (Exception ex) { ShowError(ex); }
        }

        // ════════════════════════════════════════════════════════════════════
        // TAB 4: DON THUOC
        // VPD fn_dr_on_donthuoc → chi thao tac HSBA cua minh
        // ════════════════════════════════════════════════════════════════════
        private void LoadDonThuoc(string mahsba)
        {
            try
            {
                dgvDonThuoc.DataSource = BacSiDAO.Instance.GetDonThuoc(mahsba);
                lblSoDonThuoc.Text = $"Tong: {dgvDonThuoc.RowCount} thuoc";
            }
            catch (Exception ex) { ShowError(ex); }
        }

        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            if (!ValidateHSBASelected("Chon HSBA o tab 1 truoc!")) return;

            string tenthuoc = txtTenThuoc.Text.Trim();
            if (string.IsNullOrEmpty(tenthuoc))
            {
                ShowWarning("Nhap ten thuoc!");
                return;
            }

            try
            {
                BacSiDAO.Instance.ThemDonThuoc(
                    _selectedMaHSBA,
                    txtNgayDT.Text.Trim(),
                    tenthuoc,
                    txtLieuDung.Text.Trim());

                ShowInfo("Them don thuoc thanh cong!");
                LoadDonThuoc(_selectedMaHSBA);
                txtTenThuoc.Text = txtLieuDung.Text = string.Empty;
            }
            catch (Exception ex) { ShowError(ex); }
        }

        private void btnSuaThuoc_Click(object sender, EventArgs e)
        {
            if (dgvDonThuoc.CurrentRow == null) return;

            string tenthuocMoi = txtTenThuoc.Text.Trim();
            if (string.IsNullOrEmpty(tenthuocMoi))
            {
                ShowWarning("Nhap ten thuoc moi!");
                return;
            }

            string tenthuocCu = dgvDonThuoc.CurrentRow.Cells["TENTHUOC"].Value?.ToString();

            try
            {
                BacSiDAO.Instance.CapNhatDonThuoc(
                    _selectedMaHSBA,
                    tenthuocCu,
                    tenthuocMoi,
                    txtLieuDung.Text.Trim());

                ShowInfo("Cap nhat don thuoc thanh cong!");
                LoadDonThuoc(_selectedMaHSBA);
            }
            catch (Exception ex) { ShowError(ex); }
        }

        private void btnXoaThuoc_Click(object sender, EventArgs e)
        {
            if (dgvDonThuoc.CurrentRow == null) return;

            string tenthuoc = dgvDonThuoc.CurrentRow.Cells["TENTHUOC"].Value?.ToString();
            if (!ConfirmAction($"Xac nhan xoa '{tenthuoc}'?")) return;

            try
            {
                BacSiDAO.Instance.XoaDonThuoc(_selectedMaHSBA, tenthuoc);
                LoadDonThuoc(_selectedMaHSBA);
            }
            catch (Exception ex) { ShowError(ex); }
        }

        // ════════════════════════════════════════════════════════════════════
        // SHARED ACTIONS
        // ════════════════════════════════════════════════════════════════════
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadHSBA();
            if (!string.IsNullOrEmpty(_selectedMaHSBA))
            {
                LoadHSBA_DV(_selectedMaHSBA);
                LoadDonThuoc(_selectedMaHSBA);
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (ConfirmAction("Ban co muon dang xuat?"))
                this.Close();
        }

        // ════════════════════════════════════════════════════════════════════
        // HELPER METHODS  (giam trung lap MessageBox)
        // ════════════════════════════════════════════════════════════════════
        private bool ValidateHSBASelected(string msg = "Chon HSBA truoc!")
        {
            if (!string.IsNullOrEmpty(_selectedMaHSBA)) return true;
            ShowWarning(msg);
            return false;
        }

        private bool ConfirmAction(string question)
            => MessageBox.Show(question, "Xac nhan",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;

        private void ShowInfo(string msg)
            => MessageBox.Show(msg, "Thong bao",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);

        private void ShowWarning(string msg)
            => MessageBox.Show(msg, "Thong bao",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);

        private void ShowError(Exception ex)
            => MessageBox.Show("Loi: " + ex.Message, "Loi",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}