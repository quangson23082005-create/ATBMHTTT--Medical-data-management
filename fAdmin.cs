using Microsoft.VisualBasic;
using QLBV.DAO;
using QLBV.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBV
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
        }

        private void fAdmin_Load(object sender, EventArgs e)
        {
            LoadUserList();
            LoadRoleList();

            this.bUserInsert.Click += bUserInsert_Click;
            this.bUserDelete.Click += bUserDelete_Click;
            this.bUserUpdate.Click += bUserUpdate_Click;

            this.bRoleInsert.Click += bRoleInsert_Click;
            this.bRoleDelete.Click += bRoleDelete_Click;
            this.bRoleUpdate.Click += bRoleUpdate_Click;

            // Privilege tab handlers
            this.btn_search.Click += Btn_search_Click;
            this.cb_chooseItem.SelectedIndexChanged += Cb_chooseItem_SelectedIndexChanged;
            this.btn_grant.Click += Btn_grant_Click;
            this.btn_revoke.Click += Btn_revoke_Click;
            this.rb_user.CheckedChanged += Radio_PrincipalTypeChanged;
            this.rb_role.CheckedChanged += Radio_PrincipalTypeChanged;

            // initialize privilege UI
            InitializePrivilegeObjects();

            // Default: user selected
            rb_user.Checked = true;

            // allow admin to decide whether the grantee can further grant — enabled for both user and role
            cb_grantOption.Enabled = true;
            cb_grantOption.Checked = false;
        }

        #region Users / Roles existing code (unchanged)
        private void LoadUserList()
        {
            try
            {
                List<UserDTO> users = AccountDAO.Instance.GetAllUsersDto();
                var bs = new BindingSource();
                bs.DataSource = users;
                dtgvUser.DataSource = bs;

                if (dtgvUser.Columns["Username"] != null) dtgvUser.Columns["Username"].HeaderText = "Username";
                if (dtgvUser.Columns["Status"] != null) dtgvUser.Columns["Status"].HeaderText = "Account Status";
                if (dtgvUser.Columns["CreatedDate"] != null) dtgvUser.Columns["CreatedDate"].HeaderText = "Created";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot load users: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadRoleList()
        {
            try
            {
                List<RoleDTO> roles = AccountDAO.Instance.GetAllRolesDto();
                var bs = new BindingSource();
                bs.DataSource = roles;
                dtgvRole.DataSource = bs;

                if (dtgvRole.Columns["RoleName"] != null) dtgvRole.Columns["RoleName"].HeaderText = "Role";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot load roles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bUserInsert_Click(object sender, EventArgs e)
        {
            string username = Interaction.InputBox("Enter new username:", "Create user");
            if (string.IsNullOrWhiteSpace(username)) return;
            string password = Interaction.InputBox("Enter password for user:", "Create user");
            try
            {
                AccountDAO.Instance.CreateUser(username, password);
                MessageBox.Show("User created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUserList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Create user failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bUserDelete_Click(object sender, EventArgs e)
        {
            if (dtgvUser.CurrentRow == null) return;

            var dto = dtgvUser.CurrentRow.DataBoundItem as UserDTO;
            if (dto == null) return;
            string username = dto.Username;

            var confirm = MessageBox.Show($"Drop user {username} (CASCADE)?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            try
            {
                AccountDAO.Instance.DropUser(username);
                MessageBox.Show("User dropped.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUserList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Drop user failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bUserUpdate_Click(object sender, EventArgs e)
        {
            if (dtgvUser.CurrentRow == null) return;

            var dto = dtgvUser.CurrentRow.DataBoundItem as UserDTO;
            if (dto == null) return;
            string username = dto.Username;

            string newPass = Interaction.InputBox($"New password for {username}:", "Change password");
            if (string.IsNullOrEmpty(newPass)) return;

            try
            {
                AccountDAO.Instance.AlterUserPassword(username, newPass);
                MessageBox.Show("Password updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUserList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Change password failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bRoleInsert_Click(object sender, EventArgs e)
        {
            string roleName = Interaction.InputBox("Enter role name:", "Create role");
            if (string.IsNullOrWhiteSpace(roleName)) return;
            string password = Interaction.InputBox("Enter password for role (leave blank for none):", "Create role");

            try
            {
                AccountDAO.Instance.CreateRole(roleName, string.IsNullOrEmpty(password) ? null : password);
                MessageBox.Show("Role created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRoleList();
                InitializePrivilegeObjects();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Create role failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bRoleDelete_Click(object sender, EventArgs e)
        {
            if (dtgvRole.CurrentRow == null) return;

            var dto = dtgvRole.CurrentRow.DataBoundItem as RoleDTO;
            if (dto == null) return;
            string roleName = dto.RoleName;

            var confirm = MessageBox.Show($"Drop role {roleName}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            try
            {
                AccountDAO.Instance.DropRole(roleName);
                MessageBox.Show("Role dropped.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRoleList();
                InitializePrivilegeObjects();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Drop role failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bRoleUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Role modification (beyond create/drop) is not implemented.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Privilege tab implementation

        private DataTable dtObjectsCache;

        private void InitializePrivilegeObjects()
        {
            try
            {
                dtObjectsCache = PrivilegeDAO.Instance.GetDbObjects();
                cb_chooseItem.Items.Clear();
                foreach (DataRow r in dtObjectsCache.Rows)
                {
                    var type = r["OBJECT_TYPE"]?.ToString();
                    var owner = r["OWNER"]?.ToString();
                    var name = r["OBJECT_NAME"]?.ToString();
                    string display;
                    if (string.Equals(type, "ROLE", StringComparison.OrdinalIgnoreCase))
                        display = $"{name} (ROLE)";
                    else
                        display = $"{owner}.{name} ({type})";
                    cb_chooseItem.Items.Add(display);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load DB objects failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cb_chooseItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            clb_column.Items.Clear();
            if (cb_chooseItem.SelectedIndex < 0) return;
            var sel = dtObjectsCache.Rows[cb_chooseItem.SelectedIndex];
            var type = sel["OBJECT_TYPE"]?.ToString();
            var owner = sel["OWNER"]?.ToString();
            var name = sel["OBJECT_NAME"]?.ToString();

            if (type != null && (type.Equals("TABLE", StringComparison.OrdinalIgnoreCase) || type.Equals("VIEW", StringComparison.OrdinalIgnoreCase)))
            {
                try
                {
                    var dtCols = PrivilegeDAO.Instance.GetColumns(owner, name);
                    foreach (DataRow c in dtCols.Rows)
                    {
                        var col = c["COLUMN_NAME"]?.ToString();
                        clb_column.Items.Add(col);
                    }
                    clb_column.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot load columns: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                clb_column.Visible = false;
            }

            AdjustCrudOptionsForObjectType(type);
        }

        private void AdjustCrudOptionsForObjectType(string objectType)
        {
            if (string.IsNullOrEmpty(objectType)) return;

            if (objectType.Equals("PROCEDURE", StringComparison.OrdinalIgnoreCase) || objectType.Equals("FUNCTION", StringComparison.OrdinalIgnoreCase))
            {
                clb_CRUD.Items.Clear();
                clb_CRUD.Items.Add("EXECUTE");
                clb_column.Visible = false;
            }
            else if (objectType.Equals("ROLE", StringComparison.OrdinalIgnoreCase))
            {
                clb_CRUD.Items.Clear();
                clb_CRUD.Items.Add("ROLE");
                clb_column.Visible = false;
            }
            else
            {
                clb_CRUD.Items.Clear();
                clb_CRUD.Items.AddRange(new object[] { "INSERT", "DELETE", "UPDATE", "SELECT" });
            }
        }

        private void Radio_PrincipalTypeChanged(object sender, EventArgs e)
        {
            // Searching mode (search only users or only roles) is handled in Btn_search
            // cb_grantOption remains enabled so admin can choose to give grant ability to either user or role
            cb_grantOption.Enabled = true;
        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
            string term = txtbox_searchBox.Text?.Trim() ?? "";
            bool searchingUsers = rb_user.Checked;
            try
            {
                var dt = PrivilegeDAO.Instance.GetPrivilegesForGranteeLike(term, searchingUsers);
                if (dt.Rows.Count == 0)
                {
                    DataTable fallback;
                    if (searchingUsers)
                    {
                        var q = $"SELECT USERNAME AS NAME FROM DBA_USERS WHERE COMMON = 'NO' AND UPPER(USERNAME) LIKE '%{term.ToUpper().Replace("'", "''")}%' ORDER BY USERNAME";
                        fallback = DataProvider.Instance.ExecuteQuery(q);
                    }
                    else
                    {
                        var q = $"SELECT ROLE AS NAME FROM DBA_ROLES WHERE COMMON = 'NO' AND UPPER(ROLE) LIKE '%{term.ToUpper().Replace("'", "''")}%'";
                        fallback = DataProvider.Instance.ExecuteQuery(q);
                    }

                    dtgvPrivileges.DataSource = fallback;
                }
                else
                {
                    dtgvPrivileges.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetSelectedGranteeFromGrid()
        {
            if (dtgvPrivileges.CurrentRow == null) return null;
            var row = dtgvPrivileges.CurrentRow;
            foreach (DataGridViewColumn c in dtgvPrivileges.Columns)
            {
                if (string.Equals(c.Name, "GRANTEE", StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(c.HeaderText, "GRANTEE", StringComparison.OrdinalIgnoreCase))
                {
                    var val = row.Cells[c.Index].Value;
                    if (val != null) return val.ToString();
                }
            }

            foreach (DataGridViewColumn c in dtgvPrivileges.Columns)
            {
                if (string.Equals(c.Name, "NAME", StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(c.HeaderText, "NAME", StringComparison.OrdinalIgnoreCase))
                {
                    var val = row.Cells[c.Index].Value;
                    if (val != null) return val.ToString();
                }
            }

            var first = row.Cells[0].Value;
            return first?.ToString();
        }

        private void Btn_grant_Click(object sender, EventArgs e)
        {
            try
            {
                string grantee = GetSelectedGranteeFromGrid();
                if (string.IsNullOrEmpty(grantee))
                {
                    MessageBox.Show("Select a user or role in the search results first (choose the grantee).", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (cb_chooseItem.SelectedIndex < 0)
                {
                    MessageBox.Show("Select an object or role from the right-hand list (cb_chooseItem).", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var sel = dtObjectsCache.Rows[cb_chooseItem.SelectedIndex];
                var objectType = sel["OBJECT_TYPE"]?.ToString();
                var owner = sel["OWNER"]?.ToString();
                var objectName = sel["OBJECT_NAME"]?.ToString();

                var selectedPrivs = clb_CRUD.CheckedItems.Cast<object>().Select(o => o.ToString()).ToArray();
                if (selectedPrivs.Length == 0)
                {
                    MessageBox.Show("Choose at least one privilege (in the CRUD checklist).", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string[] selectedCols = null;
                if (clb_column.Visible)
                {
                    selectedCols = clb_column.CheckedItems.Cast<object>().Select(o => o.ToString()).ToArray();
                }

                // Pass checkbox value directly so admin can choose to give grant ability to either user or role
                bool withGrant = cb_grantOption.Checked;

                PrivilegeDAO.Instance.GrantPrivilege(grantee, objectType.ToUpper(), owner, objectName, selectedPrivs, selectedCols, withGrant, rb_user.Checked);

                MessageBox.Show("Grant executed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Btn_search_Click(null, null);
            }
            catch (Exception ex)
            {
                var oracleDetail = ex.InnerException != null ? ex.InnerException.Message : null;
                var full = ex.ToString();
                MessageBox.Show("Grant failed: " + ex.Message
                    + (oracleDetail != null ? Environment.NewLine + "Oracle detail: " + oracleDetail : "")
                    + Environment.NewLine + Environment.NewLine + "Full error (for debugging):" + Environment.NewLine + full,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_revoke_Click(object sender, EventArgs e)
        {
            try
            {
                string grantee = GetSelectedGranteeFromGrid();
                if (string.IsNullOrEmpty(grantee))
                {
                    MessageBox.Show("Select a user or role in the search results first (choose the grantee).", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (cb_chooseItem.SelectedIndex < 0)
                {
                    MessageBox.Show("Select an object or role from the right-hand list (cb_chooseItem).", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var sel = dtObjectsCache.Rows[cb_chooseItem.SelectedIndex];
                var objectType = sel["OBJECT_TYPE"]?.ToString();
                var owner = sel["OWNER"]?.ToString();
                var objectName = sel["OBJECT_NAME"]?.ToString();

                var selectedPrivs = clb_CRUD.CheckedItems.Cast<object>().Select(o => o.ToString()).ToArray();
                if (selectedPrivs.Length == 0)
                {
                    MessageBox.Show("Choose at least one privilege to revoke.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string[] selectedCols = null;
                if (clb_column.Visible)
                {
                    selectedCols = clb_column.CheckedItems.Cast<object>().Select(o => o.ToString()).ToArray();
                }

                // Confirm destructive revoke
                var confirm = MessageBox.Show("Revoke will remove selected privileges (column-level revokes will drop any created view). Continue?", "Confirm revoke", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm != DialogResult.Yes) return;

                PrivilegeDAO.Instance.RevokePrivilege(grantee, objectType.ToUpper(), owner, objectName, selectedPrivs, selectedCols);

                MessageBox.Show("Revoke executed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Btn_search_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Revoke failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // reserved
        }

        private void checkedListBox_CRUD_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool hideColumns = false;
            foreach (var it in clb_CRUD.CheckedItems)
            {
                var s = it.ToString().ToUpper();
                if (s == "INSERT" || s == "DELETE")
                {
                    hideColumns = true;
                    break;
                }
            }

            clb_column.Visible = clb_column.Visible && !hideColumns;

            if (hideColumns)
            {
                for (int i = 0; i < clb_column.Items.Count; i++)
                    clb_column.SetItemChecked(i, false);
            }
        }
    }
}