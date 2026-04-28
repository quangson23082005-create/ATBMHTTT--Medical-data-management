using QLBV.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLBV
{
    public partial class fBacSi : Form
    {
        // MAHSBA duoc chon boi checkbox o Tab 1
        private string _selectedMaHSBA = string.Empty;

        public fBacSi()
        {
            InitializeComponent();
        }

        // ════════════════════════════════════════════════════════════════════
        // KHOI DONG
        // ════════════════════════════════════════════════════════════════════
        private void fBacSi_Load(object sender, EventArgs e)
        {
            ConfigureGrids();
            LoadHSBA();
            // Khi moi mo: hien thi tat ca DV va don thuoc cua bac si (VPD tu loc)
            LoadHSBA_DV(string.Empty);
            LoadDonThuoc(string.Empty);
        }

        private void ConfigureGrids()
        {
            // dgvHSBA: them cot checkbox o dau
            dgvHSBA.ReadOnly            = false;   // can false de checkbox click duoc
            dgvHSBA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHSBA.RowHeadersVisible   = false;
            dgvHSBA.SelectionMode       = DataGridViewSelectionMode.FullRowSelect;
            dgvHSBA.AllowUserToAddRows  = false;
            dgvHSBA.MultiSelect         = false;

            foreach (DataGridView dgv in new[] { dgvDichVu, dgvBenhNhan, dgvDonThuoc })
            {
                dgv.ReadOnly            = true;
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv.RowHeadersVisible   = false;
                dgv.SelectionMode       = DataGridViewSelectionMode.FullRowSelect;
                dgv.AllowUserToAddRows  = false;
                dgv.MultiSelect         = false;
            }
        }

        // ════════════════════════════════════════════════════════════════════
        // TAB 1: HO SO BENH AN
        // VPD tu loc MABS = SESSION_USER
        // Co 1 cot CheckBox de chon HSBA → Tab2 & Tab4 reload theo HSBA do
        // ════════════════════════════════════════════════════════════════════
        private void LoadHSBA()
        {
            try
            {
                DataTable dt = BacSiDAO.Instance.GetHSBACuaToi();

                // Them cot CHON (checkbox) vao DataTable truoc khi bind
                if (!dt.Columns.Contains("CHON"))
                    dt.Columns.Add("CHON", typeof(bool));

                // Mac dinh tat ca chua chon
                foreach (DataRow r in dt.Rows)
                    r["CHON"] = false;

                dgvHSBA.DataSource = dt;

                // Dat cot CHON len dau, nho
                if (dgvHSBA.Columns.Contains("CHON"))
                {
                    dgvHSBA.Columns["CHON"].DisplayIndex = 0;
                    dgvHSBA.Columns["CHON"].Width        = 50;
                    dgvHSBA.Columns["CHON"].HeaderText   = "Chon";
                    dgvHSBA.Columns["CHON"].ReadOnly     = false;
                    // Cac cot data: readonly
                    foreach (DataGridViewColumn col in dgvHSBA.Columns)
                        if (col.Name != "CHON") col.ReadOnly = true;
                }

                lblSoHSBA.Text = $"Tong: {dt.Rows.Count} ho so  |  Tick chon de xem DV / Don thuoc";

                // Reset trang thai
                _selectedMaHSBA     = string.Empty;
                lblHSBADangChon.Text = "Chua chon HSBA";
                ClearFormHSBA();
            }
            catch (Exception ex) { ShowError(ex); }
        }

        // Khi nguoi dung tick / untick checkbox
        private void dgvHSBA_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvHSBA.Columns[e.ColumnIndex].Name != "CHON") return;

            bool ticked = Convert.ToBoolean(dgvHSBA.Rows[e.RowIndex].Cells["CHON"].Value);

            if (ticked)
            {
                // Untick tat ca cac dong khac (chi chon 1 HSBA tai 1 thoi diem)
                foreach (DataGridViewRow row in dgvHSBA.Rows)
                {
                    if (row.Index != e.RowIndex)
                        row.Cells["CHON"].Value = false;
                }

                // Lay MAHSBA cua dong duoc chon
                _selectedMaHSBA = dgvHSBA.Rows[e.RowIndex].Cells["MAHSBA"].Value?.ToString() ?? string.Empty;
                lblHSBADangChon.Text = $"Dang chon: {_selectedMaHSBA}";

                // Dien thong tin vao form chinh sua
                DataGridViewRow r = dgvHSBA.Rows[e.RowIndex];
                txtMaHSBA_Edit.Text = _selectedMaHSBA;
                txtChanDoan.Text    = r.Cells["CHANDOAN"].Value?.ToString() ?? string.Empty;
                txtDieuTri.Text     = r.Cells["DIEUTRI"].Value?.ToString() ?? string.Empty;
                txtKetLuan.Text     = r.Cells["KETLUAN"].Value?.ToString() ?? string.Empty;

                // Reload Tab2 va Tab4 theo HSBA vua chon
                LoadHSBA_DV(_selectedMaHSBA);
                LoadDonThuoc(_selectedMaHSBA);
            }
            else
            {
                // Nguoi dung bo tick → reset ve hien thi tat ca
                _selectedMaHSBA      = string.Empty;
                lblHSBADangChon.Text = "Chua chon HSBA";
                ClearFormHSBA();
                LoadHSBA_DV(string.Empty);
                LoadDonThuoc(string.Empty);
            }
        }

        // Can su kien nay de checkbox phan hoi ngay khi click
        private void dgvHSBA_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvHSBA.IsCurrentCellDirty)
                dgvHSBA.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void ClearFormHSBA()
        {
            txtMaHSBA_Edit.Text = string.Empty;
            txtChanDoan.Text    = string.Empty;
            txtDieuTri.Text     = string.Empty;
            txtKetLuan.Text     = string.Empty;
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
                // Giu nguyen tick va reload
                string mahsbaGiu = _selectedMaHSBA;
                LoadHSBA();
                // Re-tick dong cu sau khi reload
                ReTickHSBA(mahsbaGiu);
            }
            catch (Exception ex) { ShowError(ex); }
        }

        /// <summary>Sau khi reload grid, tu dong tick lai dong co MAHSBA cho truoc.</summary>
        private void ReTickHSBA(string mahsba)
        {
            if (string.IsNullOrEmpty(mahsba)) return;
            foreach (DataGridViewRow row in dgvHSBA.Rows)
            {
                if (row.Cells["MAHSBA"].Value?.ToString() == mahsba)
                {
                    row.Cells["CHON"].Value = true;
                    break;
                }
            }
        }

        // ════════════════════════════════════════════════════════════════════
        // TAB 2: DICH VU (TC#3b)
        // ════════════════════════════════════════════════════════════════════
        private void LoadHSBA_DV(string mahsba)
        {
            try
            {
                DataTable dt;
                if (string.IsNullOrEmpty(mahsba))
                {
                    dt = BacSiDAO.Instance.GetAllHSBA_DV();
                    lblSoDV.Text = $"Tong: {dt.Rows.Count} dich vu  (tat ca HSBA cua ban)";
                }
                else
                {
                    dt = BacSiDAO.Instance.GetHSBA_DV(mahsba);
                    lblSoDV.Text = $"Tong: {dt.Rows.Count} dich vu  (HSBA: {mahsba})";
                }
                dgvDichVu.DataSource = dt;
            }
            catch (Exception ex) { ShowError(ex); }
        }

        private void dgvDichVu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDichVu.CurrentRow == null) return;
            DataGridViewRow row = dgvDichVu.CurrentRow;
            txtLoaiDV.Text   = row.Cells["LOAIDV"].Value?.ToString() ?? string.Empty;
            txtNgayDV.Text   = row.Cells["NGAYDV"].Value?.ToString() ?? string.Empty;
            txtMaKTV.Text    = row.Cells["MAKTV"].Value?.ToString() ?? string.Empty;
            txtKetQuaDV.Text = row.Cells["KETQUA"].Value?.ToString() ?? string.Empty;
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            if (!ValidateHSBASelected("Tick chon HSBA o Tab 1 truoc!")) return;

            string loaidv = txtLoaiDV.Text.Trim();
            string ngaydv = txtNgayDV.Text.Trim();
            if (string.IsNullOrEmpty(loaidv) || string.IsNullOrEmpty(ngaydv))
            {
                ShowWarning("Nhap day du Loai DV va Ngay!");
                return;
            }
            try
            {
                BacSiDAO.Instance.ThemHSBA_DV(_selectedMaHSBA, loaidv, ngaydv, txtMaKTV.Text.Trim());
                ShowInfo("Them dich vu thanh cong!");
                LoadHSBA_DV(_selectedMaHSBA);
                txtLoaiDV.Text = txtNgayDV.Text = txtMaKTV.Text = txtKetQuaDV.Text = string.Empty;
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
        // TAB 3: BENH NHAN — REVERT VE DUNG CODE GOC
        // Chi doc 4 cot: MABN, TIENSUBENH, TIENSUBENHGD, DIUNGTHUOC
        // Tu V_BENHNHAN_EDIT (VPD tu loc BN thuoc HSBA cua minh)
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

            // Dung dung 4 cot cua V_BENHNHAN_EDIT, giong code goc
            txtMaBN_Edit.Text    = dgvBenhNhan.CurrentRow.Cells["MABN"].Value?.ToString();
            txtTienSuBenh.Text   = dgvBenhNhan.CurrentRow.Cells["TIENSUBENH"].Value?.ToString();
            txtTienSuBenhGD.Text = dgvBenhNhan.CurrentRow.Cells["TIENSUBENHGD"].Value?.ToString();
            txtDiUngThuoc.Text   = dgvBenhNhan.CurrentRow.Cells["DIUNGTHUOC"].Value?.ToString();
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
        // TAB 4: DON THUOC (TC#3e)
        // ════════════════════════════════════════════════════════════════════
        private void LoadDonThuoc(string mahsba)
        {
            try
            {
                DataTable dt;
                if (string.IsNullOrEmpty(mahsba))
                {
                    dt = BacSiDAO.Instance.GetAllDonThuoc();
                    lblSoDonThuoc.Text = $"Tong: {dt.Rows.Count} thuoc  (tat ca HSBA cua ban)";
                }
                else
                {
                    dt = BacSiDAO.Instance.GetDonThuoc(mahsba);
                    lblSoDonThuoc.Text = $"Tong: {dt.Rows.Count} thuoc  (HSBA: {mahsba})";
                }
                dgvDonThuoc.DataSource = dt;
            }
            catch (Exception ex) { ShowError(ex); }
        }

        private void dgvDonThuoc_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDonThuoc.CurrentRow == null) return;
            DataGridViewRow row = dgvDonThuoc.CurrentRow;
            txtTenThuoc.Text = row.Cells["TENTHUOC"].Value?.ToString() ?? string.Empty;
            txtLieuDung.Text = row.Cells["LIEUDUNG"].Value?.ToString() ?? string.Empty;
            txtNgayDT.Text   = row.Cells["NGAYDT"].Value?.ToString() ?? string.Empty;
        }

        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            if (!ValidateHSBASelected("Tick chon HSBA o Tab 1 truoc!")) return;

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
        // SHARED
        // ════════════════════════════════════════════════════════════════════
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            string mahsbaGiu = _selectedMaHSBA;
            LoadHSBA();
            LoadHSBA_DV(string.Empty);
            LoadDonThuoc(string.Empty);
            if (!string.IsNullOrEmpty(mahsbaGiu))
                ReTickHSBA(mahsbaGiu);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (ConfirmAction("Ban co muon dang xuat?"))
                this.Close();
        }

        // ── Helpers ──────────────────────────────────────────────────────────
        private bool ValidateHSBASelected(string msg = "Tick chon HSBA o Tab 1 truoc!")
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

        private void lblSoHSBA_Click(object sender, EventArgs e)
        {

        }
    }
}