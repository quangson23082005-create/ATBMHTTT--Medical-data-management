using Microsoft.VisualBasic;
using QLBV.DAO;
using QLBV.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//namespace QLBV
//{
//    public partial class fAdmin : Form
//    {
//        public fAdmin()
//        {
//            InitializeComponent();
//        }

//        private void fAdmin_Load(object sender, EventArgs e)
//        {
//            LoadUserList();
//            LoadRoleList();
//            this.bUserInsert.Click += bUserInsert_Click;
//            this.bUserDelete.Click += bUserDelete_Click;
//            this.bUserUpdate.Click += bUserUpdate_Click;

//            this.bRoleInsert.Click += bRoleInsert_Click;
//            this.bRoleDelete.Click += bRoleDelete_Click;
//            this.bRoleUpdate.Click += bRoleUpdate_Click;
//        }

//        private void LoadUserList()
//        {
//            try
//            {
//                DataTable users = AccountDAO.Instance.GetAllUsers();
//                dtgvUser.DataSource = users;
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Cannot load users: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void LoadRoleList()
//        {
//            try
//            {
//                DataTable roles = AccountDAO.Instance.GetAllRoles();
//                dtgvRole.DataSource = roles;
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Cannot load roles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        // User button handlers
//        private void bUserInsert_Click(object sender, EventArgs e)
//        {
//            string username = Interaction.InputBox("Enter new username:", "Create user");
//            if (string.IsNullOrWhiteSpace(username)) return;
//            string password = Interaction.InputBox("Enter password for user:", "Create user");
//            try
//            {
//                AccountDAO.Instance.CreateUser(username, password);
//                MessageBox.Show("User created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                LoadUserList();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Create user failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void bUserDelete_Click(object sender, EventArgs e)
//        {
//            if (dtgvUser.CurrentRow == null) return;
//            var usernameObj = dtgvUser.CurrentRow.Cells["USERNAME"].Value;
//            if (usernameObj == null) return;
//            string username = usernameObj.ToString();

//            var confirm = MessageBox.Show($"Drop user {username} (CASCADE)?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
//            if (confirm != DialogResult.Yes) return;

//            try
//            {
//                AccountDAO.Instance.DropUser(username);
//                MessageBox.Show("User dropped.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                LoadUserList();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Drop user failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void bUserUpdate_Click(object sender, EventArgs e)
//        {
//            if (dtgvUser.CurrentRow == null) return;
//            var usernameObj = dtgvUser.CurrentRow.Cells["USERNAME"].Value;
//            if (usernameObj == null) return;
//            string username = usernameObj.ToString();

//            string newPass = Interaction.InputBox($"New password for {username}:", "Change password");
//            if (string.IsNullOrEmpty(newPass)) return;

//            try
//            {
//                AccountDAO.Instance.AlterUserPassword(username, newPass);
//                MessageBox.Show("Password updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                LoadUserList();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Change password failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        // Role button handlers
//        private void bRoleInsert_Click(object sender, EventArgs e)
//        {
//            string roleName = Interaction.InputBox("Enter role name:", "Create role");
//            if (string.IsNullOrWhiteSpace(roleName)) return;
//            // optional password
//            string password = Interaction.InputBox("Enter password for role (leave blank for none):", "Create role");

//            try
//            {
//                AccountDAO.Instance.CreateRole(roleName, string.IsNullOrEmpty(password) ? null : password);
//                MessageBox.Show("Role created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                LoadRoleList();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Create role failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void bRoleDelete_Click(object sender, EventArgs e)
//        {
//            if (dtgvRole.CurrentRow == null) return;
//            var roleObj = dtgvRole.CurrentRow.Cells[0].Value;
//            if (roleObj == null) return;
//            string roleName = roleObj.ToString();

//            var confirm = MessageBox.Show($"Drop role {roleName}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
//            if (confirm != DialogResult.Yes) return;

//            try
//            {
//                AccountDAO.Instance.DropRole(roleName);
//                MessageBox.Show("Role dropped.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                LoadRoleList();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Drop role failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void bRoleUpdate_Click(object sender, EventArgs e)
//        {
//            MessageBox.Show("Role modification (beyond create/drop) is not implemented in this quick helper.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
//        }

//    }
//}

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
        }

        private void LoadUserList()
        {
            try
            {
                List<UserDTO> users = AccountDAO.Instance.GetAllUsersDto();
                var bs = new BindingSource();
                bs.DataSource = users;
                dtgvUser.DataSource = bs;

                // Improve column headers
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

        // User button handlers
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

        // Role button handlers
        private void bRoleInsert_Click(object sender, EventArgs e)
        {
            string roleName = Interaction.InputBox("Enter role name:", "Create role");
            if (string.IsNullOrWhiteSpace(roleName)) return;
            // optional password
            string password = Interaction.InputBox("Enter password for role (leave blank for none):", "Create role");

            try
            {
                AccountDAO.Instance.CreateRole(roleName, string.IsNullOrEmpty(password) ? null : password);
                MessageBox.Show("Role created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRoleList();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Drop role failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bRoleUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Role modification (beyond create/drop) is not implemented in this quick helper.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox_CRUD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}