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
        
        private System.Collections.Generic.List<System.Data.DataRow> procFuncRowsCache = new System.Collections.Generic.List<System.Data.DataRow>();

        public fAdmin()
        {
            InitializeComponent();
        }

        private void fAdmin_Load(object sender, EventArgs e)
        {
            LoadUserList();
            // allow selecting multiple users for batch operations
            dtgvUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvUser.MultiSelect = true;
            LoadRoleList();

            this.bUserInsert.Click += bUserInsert_Click;
            this.bUserDelete.Click += bUserDelete_Click;
            this.bUserUpdate.Click += bUserUpdate_Click;
            this.bSearchUser.Click += bSearchUser_Click;

            this.bRoleInsert.Click += bRoleInsert_Click;
            this.bRoleDelete.Click += bRoleDelete_Click;
            this.bRoleUpdate.Click += bRoleUpdate_Click;

            // Role-management tab handlers
            this.btn_search3.Click += Btn_search3_Click;
            this.btn_grant3.Click += Btn_grant3_Click;
            this.btn_revoke3.Click += Btn_revoke3_Click;
            this.cb_role3.SelectedIndexChanged += Cb_role3_SelectedIndexChanged;
            this.cbFitterUser.CheckedChanged += CbFitterUser_CheckedChanged;

            // initialize role UI
            LoadRoleList();
            LoadUserRoleList();
            PopulateRoleComboBox();

            dtgvUserRole.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvUserRole.MultiSelect = true;

            // Privilege tab handlers
            this.btn_search.Click += Btn_search_Click;
            this.cb_chooseItem.SelectedIndexChanged += Cb_chooseItem_SelectedIndexChanged;
            this.btn_grant.Click += Btn_grant_Click;
            this.btn_revoke.Click += Btn_revoke_Click;
            this.rb_user.CheckedChanged += Radio_PrincipalTypeChanged;
            this.rb_role.CheckedChanged += Radio_PrincipalTypeChanged;

            // initialize privilege UI
            InitializePrivilegeObjects();

            // Advanced functions/procedures tab handlers
            this.btn_search2.Click += Btn_search2_Click;
            this.btn_grant2.Click += Btn_grant2_Click;
            this.btn_revoke2.Click += Btn_revoke2_Click;
            this.rb_user2.CheckedChanged += Radio_PrincipalType2Changed;
            this.rb_role2.CheckedChanged += Radio_PrincipalType2Changed;

            // populate combo for procedures/functions
            PopulateProcedureFunctionComboBox();

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

        private void bSearchUser_Click(object sender, EventArgs e)
        {
            try
            {
                string term = txbSearchUser.Text?.Trim() ?? "";

                // If term is empty, reload all users
                if (string.IsNullOrEmpty(term))
                {
                    LoadUserList();
                    return;
                }

                // Try to use DAO search if available
                List<UserDTO> users;
                try
                {
                    users = AccountDAO.Instance.GetUsersLike(term);
                }
                catch
                {
                    // Fallback to client-side filtering
                    users = AccountDAO.Instance.GetAllUsersDto()
                        .Where(u => (u.Username ?? "").IndexOf(term, StringComparison.OrdinalIgnoreCase) >= 0)
                        .ToList();
                }

                var bs = new BindingSource();
                bs.DataSource = users;
                dtgvUser.DataSource = bs;

                if (dtgvUser.Columns["Username"] != null) dtgvUser.Columns["Username"].HeaderText = "Username";
                if (dtgvUser.Columns["Status"] != null) dtgvUser.Columns["Status"].HeaderText = "Account Status";
                if (dtgvUser.Columns["CreatedDate"] != null) dtgvUser.Columns["CreatedDate"].HeaderText = "Created";
            }
            catch (Exception ex)
            {
                MessageBox.Show("User search failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            var usernames = GetSelectedUsernamesFromGrid();
            if (usernames == null || usernames.Count == 0)
            {
                MessageBox.Show("Select one or more users to drop.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show($"Drop selected users ({string.Join(", ", usernames)}) (CASCADE)?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            var failed = new List<string>();
            int successCount = 0;
            foreach (var username in usernames)
            {
                try
                {
                    AccountDAO.Instance.DropUser(username);
                    successCount++;
                }
                catch (Exception ex)
                {
                    failed.Add(username + ": " + ex.Message);
                }
            }

            if (failed.Count == 0)
            {
                MessageBox.Show(successCount == 1 ? "User dropped." : $"{successCount} users dropped.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var msg = $"Dropped {successCount} user(s).\nFailed to drop {failed.Count} user(s):\n" + string.Join("\n", failed);
                MessageBox.Show(msg, "Partial failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            LoadUserList();
        }

        private List<string> GetSelectedUsernamesFromGrid()
        {
            var usernames = new List<string>();

            // collect selected rows if any
            var rows = new List<DataGridViewRow>();
            if (dtgvUser.SelectedRows != null && dtgvUser.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow r in dtgvUser.SelectedRows)
                    rows.Add(r);
            }
            else if (dtgvUser.SelectedCells != null && dtgvUser.SelectedCells.Count > 0)
            {
                var set = new HashSet<int>();
                foreach (DataGridViewCell c in dtgvUser.SelectedCells)
                    set.Add(c.RowIndex);
                foreach (var ri in set)
                    rows.Add(dtgvUser.Rows[ri]);
            }

            foreach (var r in rows)
            {
                if (r == null) continue;
                var dto = r.DataBoundItem as UserDTO;
                if (dto != null && !string.IsNullOrEmpty(dto.Username))
                {
                    usernames.Add(dto.Username);
                    continue;
                }

                // try to find a Username column
                string found = null;
                for (int i = 0; i < r.Cells.Count; i++)
                {
                    var col = dtgvUser.Columns[i];
                    if (string.Equals(col.Name, "Username", StringComparison.OrdinalIgnoreCase) ||
                        string.Equals(col.HeaderText, "Username", StringComparison.OrdinalIgnoreCase))
                    {
                        var val = r.Cells[i].Value;
                        if (val != null)
                        {
                            found = val.ToString();
                            break;
                        }
                    }
                }

                if (!string.IsNullOrEmpty(found))
                {
                    usernames.Add(found);
                    continue;
                }

                // fallback to first cell
                var first = r.Cells.Count > 0 ? r.Cells[0].Value : null;
                if (first != null) usernames.Add(first.ToString());
            }

            return usernames.Distinct(StringComparer.OrdinalIgnoreCase).ToList();
        }

        private void bUserUpdate_Click(object sender, EventArgs e)
        {
            if (dtgvUser.CurrentRow == null) return;

            var dto = dtgvUser.CurrentRow.DataBoundItem as UserDTO;
            if (dto == null) return;
            string username = dto.Username;

            try
            {
                // Ask whether to change password
                var doChange = MessageBox.Show($"Change password for {username}?", "Change password", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (doChange == DialogResult.Yes)
                {
                    string newPass = Interaction.InputBox($"New password for {username}:", "Change password");
                    if (!string.IsNullOrEmpty(newPass))
                    {
                        AccountDAO.Instance.AlterUserPassword(username, newPass);
                        MessageBox.Show("Password updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                // Ask whether to change lock state
                var lockChoice = MessageBox.Show($"Lock account for {username}?\nYes = Lock, No = Unlock, Cancel = Leave as is.", "Lock/Unlock account", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (lockChoice == DialogResult.Yes)
                {
                    AccountDAO.Instance.LockUser(username);
                    MessageBox.Show("Account locked.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (lockChoice == DialogResult.No)
                {
                    AccountDAO.Instance.UnlockUser(username);
                    MessageBox.Show("Account unlocked.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadUserList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (dtgvRole.CurrentRow == null) return;
            var dto = dtgvRole.CurrentRow.DataBoundItem as RoleDTO;
            if (dto == null) return;
            string roleName = dto.RoleName;

            string newPass = Interaction.InputBox($"New password for role {roleName} (leave blank to cancel):", "Change role password");
            if (string.IsNullOrEmpty(newPass)) return;

            try
            {
                AccountDAO.Instance.AlterRolePassword(roleName, newPass);
                MessageBox.Show("Role password updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRoleList();
                InitializePrivilegeObjects();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Change role password failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Role management tab implementation

        private void LoadUserRoleList()
        {
            try
            {
                var dt = AccountDAO.Instance.GetUserRoleMapping();
                dtgvUserRole.DataSource = dt;
                if (dtgvUserRole.Columns["USERNAME"] != null) dtgvUserRole.Columns["USERNAME"].HeaderText = "Username";
                if (dtgvUserRole.Columns["ROLE"] != null) dtgvUserRole.Columns["ROLE"].HeaderText = "Role(s)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load user-role list failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateRoleComboBox()
        {
            try
            {
                cb_role3.Items.Clear();
                var roles = AccountDAO.Instance.GetAllRolesDto();
                foreach (var r in roles)
                    cb_role3.Items.Add(r.RoleName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load roles failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<string> GetSelectedUsernamesFromUserRoleGrid()
        {
            var names = new List<string>();
            var rows = new List<DataGridViewRow>();
            if (dtgvUserRole.SelectedRows != null && dtgvUserRole.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow r in dtgvUserRole.SelectedRows) rows.Add(r);
            }
            else if (dtgvUserRole.SelectedCells != null && dtgvUserRole.SelectedCells.Count > 0)
            {
                var set = new HashSet<int>();
                foreach (DataGridViewCell c in dtgvUserRole.SelectedCells) set.Add(c.RowIndex);
                foreach (var ri in set) rows.Add(dtgvUserRole.Rows[ri]);
            }

            foreach (var r in rows)
            {
                if (r == null) continue;
                var first = r.Cells[0].Value;
                if (first != null) names.Add(first.ToString());
            }

            return names.Distinct(StringComparer.OrdinalIgnoreCase).ToList();
        }

        private void Btn_search3_Click(object sender, EventArgs e)
        {
            try
            {
                string term = txtBox_searchBox3.Text?.Trim() ?? "";
                if (string.IsNullOrEmpty(term))
                {
                    LoadUserRoleList();
                    return;
                }

                // Reuse AccountDAO.GetUsersLike to find matching users, then filter mapping
                var users = AccountDAO.Instance.GetUsersLike(term).Select(u => u.Username).ToList();
                if (users.Count == 0)
                {
                    // fallback: simple query
                    var q = $"SELECT USERNAME FROM DBA_USERS WHERE COMMON = 'NO' AND UPPER(USERNAME) LIKE '%{term.ToUpper().Replace("'", "''")}%' ORDER BY USERNAME";
                    var dt = DataProvider.Instance.ExecuteQuery(q);
                    users = dt.Rows.Cast<DataRow>().Select(r => r[0].ToString()).ToList();
                }

                // build mapping for these users only
                var map = AccountDAO.Instance.GetUserRoleMapping();
                var filtered = map.AsEnumerable().Where(r => users.Contains(r.Field<string>("USERNAME"), StringComparer.OrdinalIgnoreCase)).CopyToDataTableOrEmpty();
                dtgvUserRole.DataSource = filtered;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbFitterUser_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbFitterUser.Checked)
                {
                    var dt = AccountDAO.Instance.GetUserRoleMapping();
                    var filtered = dt.AsEnumerable().Where(r => string.IsNullOrEmpty(r.Field<string>("ROLE"))).CopyToDataTableOrEmpty();
                    dtgvUserRole.DataSource = filtered;
                }
                else
                {
                    LoadUserRoleList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filter failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_grant3_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedUsers = GetSelectedUsernamesFromUserRoleGrid();
                if (selectedUsers.Count == 0)
                {
                    MessageBox.Show("Select one or more users to grant role.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (cb_role3.SelectedIndex < 0)
                {
                    MessageBox.Show("Select a role to grant.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var role = cb_role3.SelectedItem.ToString();
                var failed = new List<string>();
                int succ = 0;
                foreach (var u in selectedUsers)
                {
                    try
                    {
                        PrivilegeDAO.Instance.GrantPrivilege(u, "ROLE", null, role, new string[] { }, null, false, true);
                        succ++;
                    }
                    catch (Exception ex)
                    {
                        failed.Add(u + ": " + ex.Message);
                    }
                }

                if (failed.Count == 0)
                    MessageBox.Show(succ == 1 ? "Role granted." : $"{succ} users granted the role.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show($"Granted {succ}. Failed {failed.Count}:\n" + string.Join("\n", failed), "Partial failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                LoadUserRoleList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Grant role failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_revoke3_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedUsers = GetSelectedUsernamesFromUserRoleGrid();
                if (selectedUsers.Count == 0)
                {
                    MessageBox.Show("Select one or more users to revoke role.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var confirm = MessageBox.Show("Revoke role from selected users?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm != DialogResult.Yes) return;

                var failed = new List<string>();
                int succ = 0;
                foreach (var u in selectedUsers)
                {
                    try
                    {
                        var roles = AccountDAO.Instance.GetRolesForUser(u);
                        if (roles == null || roles.Count == 0) continue;
                        foreach (var r in roles)
                        {
                            PrivilegeDAO.Instance.RevokePrivilege(u, "ROLE", null, r, new string[] { }, null);
                        }
                        succ++;
                    }
                    catch (Exception ex)
                    {
                        failed.Add(u + ": " + ex.Message);
                    }
                }

                if (failed.Count == 0)
                    MessageBox.Show(succ == 1 ? "Role(s) revoked." : $"Role(s) revoked from {succ} user(s).", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show($"Revoked {succ}. Failed {failed.Count}:\n" + string.Join("\n", failed), "Partial failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                LoadUserRoleList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Revoke role failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cb_role3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // reserved for future direct behaviors
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

        private void PopulateProcedureFunctionComboBox()
        {
            try
            {
                cb_chooseItem2.Items.Clear();
                procFuncRowsCache.Clear();
                if (dtObjectsCache == null) return;
                foreach (DataRow r in dtObjectsCache.Rows)
                {
                    var type = (r["OBJECT_TYPE"] ?? "").ToString();
                    if (!string.Equals(type, "PROCEDURE", StringComparison.OrdinalIgnoreCase) &&
                        !string.Equals(type, "FUNCTION", StringComparison.OrdinalIgnoreCase))
                        continue;

                    var owner = (r["OWNER"] ?? "").ToString();
                    var name = (r["OBJECT_NAME"] ?? "").ToString();
                    string display = $"{owner}.{name} ({type})";
                    cb_chooseItem2.Items.Add(display);
                    procFuncRowsCache.Add(r);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load procedures/functions failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Radio_PrincipalType2Changed(object sender, EventArgs e)
        {
            // keep behavior simple: nothing special when switching principal type here
        }

        private void Btn_search2_Click(object sender, EventArgs e)
        {
            try
            {
                string term = txtBox_searchBox2.Text?.Trim() ?? "";
                bool searchingUsers = rb_user2.Checked;

                // get privileges for principals matching the term
                var dtPrivs = PrivilegeDAO.Instance.GetPrivilegesForGranteeLike(term, searchingUsers);

                // prepare result table listing procedures/functions and whether the grantee has EXECUTE
                var result = new DataTable();
                result.Columns.Add("OWNER", typeof(string));
                result.Columns.Add("OBJECT_NAME", typeof(string));
                result.Columns.Add("OBJECT_TYPE", typeof(string));
                result.Columns.Add("CAN_EXECUTE", typeof(string));

                if (procFuncRowsCache == null || procFuncRowsCache.Count == 0)
                {
                    PopulateProcedureFunctionComboBox();
                }

                foreach (var r in procFuncRowsCache)
                {
                    var owner = (r["OWNER"] ?? "").ToString();
                    var obj = (r["OBJECT_NAME"] ?? "").ToString();
                    var type = (r["OBJECT_TYPE"] ?? "").ToString();

                    bool hasExec = dtPrivs.AsEnumerable().Any(pr =>
                        string.Equals((pr.Field<string>("PRIVILEGE") ?? ""), "EXECUTE", StringComparison.OrdinalIgnoreCase)
                        && string.Equals((pr.Field<string>("OWNER") ?? ""), owner, StringComparison.OrdinalIgnoreCase)
                        && string.Equals((pr.Field<string>("TABLE_NAME") ?? ""), obj, StringComparison.OrdinalIgnoreCase)
                    );

                    result.Rows.Add(owner, obj, type, hasExec ? "YES" : "NO");
                }

                dtgvPrivileges2.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_grant2_Click(object sender, EventArgs e)
        {
            try
            {
                string grantee = txtBox_searchBox2.Text?.Trim();
                if (string.IsNullOrEmpty(grantee))
                {
                    MessageBox.Show("Enter a user or role in the search box (left) first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (cb_chooseItem2.SelectedIndex < 0)
                {
                    MessageBox.Show("Select a procedure or function from the right-hand list.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var row = procFuncRowsCache[cb_chooseItem2.SelectedIndex];
                var objectType = (row["OBJECT_TYPE"] ?? "").ToString();
                var owner = (row["OWNER"] ?? "").ToString();
                var objectName = (row["OBJECT_NAME"] ?? "").ToString();

                PrivilegeDAO.Instance.GrantPrivilege(grantee, objectType.ToUpper(), owner, objectName, new string[] { "EXECUTE" }, null, false, rb_user2.Checked);

                MessageBox.Show("Grant executed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Btn_search2_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Grant failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_revoke2_Click(object sender, EventArgs e)
        {
            try
            {
                string grantee = txtBox_searchBox2.Text?.Trim();
                if (string.IsNullOrEmpty(grantee))
                {
                    MessageBox.Show("Enter a user or role in the search box (left) first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (cb_chooseItem2.SelectedIndex < 0)
                {
                    MessageBox.Show("Select a procedure or function from the right-hand list.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var row = procFuncRowsCache[cb_chooseItem2.SelectedIndex];
                var objectType = (row["OBJECT_TYPE"] ?? "").ToString();
                var owner = (row["OWNER"] ?? "").ToString();
                var objectName = (row["OBJECT_NAME"] ?? "").ToString();

                var confirm = MessageBox.Show($"Revoke EXECUTE on {owner}.{objectName} from {grantee}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm != DialogResult.Yes) return;

                PrivilegeDAO.Instance.RevokePrivilege(grantee, objectType.ToUpper(), owner, objectName, new string[] { "EXECUTE" }, null);

                MessageBox.Show("Revoke executed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Btn_search2_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Revoke failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void bRoleDelete_Click_1(object sender, EventArgs e)
        {

        }

        private void tcRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtgvPrivileges_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tpUser_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bUserUpdate_Click_1(object sender, EventArgs e)
        {

        }

        private void bUserDelete_Click_1(object sender, EventArgs e)
        {

        }

        private void bUserInsert_Click_1(object sender, EventArgs e)
        {

        }

        private void tpRole_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgvRole_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bRoleUpdate_Click_1(object sender, EventArgs e)
        {

        }

        private void bRoleInsert_Click_1(object sender, EventArgs e)
        {

        }

        private void tpPrivilege_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clb_column_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_chooseItem_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btn_revoke_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_grant_Click_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_search_Click_1(object sender, EventArgs e)
        {

        }

        private void txtbox_searchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rb_role_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_user_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tpFunc_proc_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lb_choose_role_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}