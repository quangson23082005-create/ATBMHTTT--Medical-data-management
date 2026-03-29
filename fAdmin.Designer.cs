namespace QLBV
{
    partial class fAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcRole = new System.Windows.Forms.TabControl();
            this.tpUser = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvUser = new System.Windows.Forms.DataGridView();
            this.bUserUpdate = new System.Windows.Forms.Button();
            this.bUserDelete = new System.Windows.Forms.Button();
            this.bUserInsert = new System.Windows.Forms.Button();
            this.tpRole = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvRole = new System.Windows.Forms.DataGridView();
            this.bRoleUpdate = new System.Windows.Forms.Button();
            this.bRoleDelete = new System.Windows.Forms.Button();
            this.bRoleInsert = new System.Windows.Forms.Button();
            this.tpPrivilege = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgvPrivileges = new System.Windows.Forms.DataGridView();
            this.rb_user = new System.Windows.Forms.RadioButton();
            this.rb_role = new System.Windows.Forms.RadioButton();
            this.txtbox_searchBox = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.clb_CRUD = new System.Windows.Forms.CheckedListBox();
            this.cb_grantOption = new System.Windows.Forms.CheckBox();
            this.btn_grant = new System.Windows.Forms.Button();
            this.btn_revoke = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tcRole.SuspendLayout();
            this.tpUser.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUser)).BeginInit();
            this.tpRole.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRole)).BeginInit();
            this.tpPrivilege.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPrivileges)).BeginInit();
            this.SuspendLayout();
            // 
            // tcRole
            // 
            this.tcRole.Controls.Add(this.tpUser);
            this.tcRole.Controls.Add(this.tpRole);
            this.tcRole.Controls.Add(this.tpPrivilege);
            this.tcRole.Location = new System.Drawing.Point(12, 12);
            this.tcRole.Name = "tcRole";
            this.tcRole.SelectedIndex = 0;
            this.tcRole.Size = new System.Drawing.Size(992, 485);
            this.tcRole.TabIndex = 0;
            // 
            // tpUser
            // 
            this.tpUser.Controls.Add(this.panel1);
            this.tpUser.Location = new System.Drawing.Point(4, 25);
            this.tpUser.Name = "tpUser";
            this.tpUser.Padding = new System.Windows.Forms.Padding(3);
            this.tpUser.Size = new System.Drawing.Size(984, 456);
            this.tpUser.TabIndex = 0;
            this.tpUser.Text = "Quản lý user";
            this.tpUser.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvUser);
            this.panel1.Controls.Add(this.bUserUpdate);
            this.panel1.Controls.Add(this.bUserDelete);
            this.panel1.Controls.Add(this.bUserInsert);
            this.panel1.Location = new System.Drawing.Point(19, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 413);
            this.panel1.TabIndex = 0;
            // 
            // dtgvUser
            // 
            this.dtgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUser.Location = new System.Drawing.Point(25, 120);
            this.dtgvUser.Name = "dtgvUser";
            this.dtgvUser.RowHeadersWidth = 51;
            this.dtgvUser.RowTemplate.Height = 24;
            this.dtgvUser.Size = new System.Drawing.Size(440, 276);
            this.dtgvUser.TabIndex = 3;
            // 
            // bUserUpdate
            // 
            this.bUserUpdate.Location = new System.Drawing.Point(375, 23);
            this.bUserUpdate.Name = "bUserUpdate";
            this.bUserUpdate.Size = new System.Drawing.Size(105, 62);
            this.bUserUpdate.TabIndex = 2;
            this.bUserUpdate.Text = "Sửa";
            this.bUserUpdate.UseVisualStyleBackColor = true;
            // 
            // bUserDelete
            // 
            this.bUserDelete.Location = new System.Drawing.Point(190, 23);
            this.bUserDelete.Name = "bUserDelete";
            this.bUserDelete.Size = new System.Drawing.Size(105, 62);
            this.bUserDelete.TabIndex = 1;
            this.bUserDelete.Text = "Xoá";
            this.bUserDelete.UseVisualStyleBackColor = true;
            // 
            // bUserInsert
            // 
            this.bUserInsert.Location = new System.Drawing.Point(25, 23);
            this.bUserInsert.Name = "bUserInsert";
            this.bUserInsert.Size = new System.Drawing.Size(105, 62);
            this.bUserInsert.TabIndex = 0;
            this.bUserInsert.Text = "Thêm";
            this.bUserInsert.UseVisualStyleBackColor = true;
            // 
            // tpRole
            // 
            this.tpRole.Controls.Add(this.panel2);
            this.tpRole.Location = new System.Drawing.Point(4, 25);
            this.tpRole.Name = "tpRole";
            this.tpRole.Padding = new System.Windows.Forms.Padding(3);
            this.tpRole.Size = new System.Drawing.Size(984, 456);
            this.tpRole.TabIndex = 1;
            this.tpRole.Text = "Quản lý role";
            this.tpRole.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvRole);
            this.panel2.Controls.Add(this.bRoleUpdate);
            this.panel2.Controls.Add(this.bRoleDelete);
            this.panel2.Controls.Add(this.bRoleInsert);
            this.panel2.Location = new System.Drawing.Point(19, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(947, 413);
            this.panel2.TabIndex = 1;
            // 
            // dtgvRole
            // 
            this.dtgvRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRole.Location = new System.Drawing.Point(25, 120);
            this.dtgvRole.Name = "dtgvRole";
            this.dtgvRole.RowHeadersWidth = 51;
            this.dtgvRole.RowTemplate.Height = 24;
            this.dtgvRole.Size = new System.Drawing.Size(440, 276);
            this.dtgvRole.TabIndex = 3;
            // 
            // bRoleUpdate
            // 
            this.bRoleUpdate.Location = new System.Drawing.Point(375, 23);
            this.bRoleUpdate.Name = "bRoleUpdate";
            this.bRoleUpdate.Size = new System.Drawing.Size(105, 62);
            this.bRoleUpdate.TabIndex = 2;
            this.bRoleUpdate.Text = "Sửa";
            this.bRoleUpdate.UseVisualStyleBackColor = true;
            // 
            // bRoleDelete
            // 
            this.bRoleDelete.Location = new System.Drawing.Point(190, 23);
            this.bRoleDelete.Name = "bRoleDelete";
            this.bRoleDelete.Size = new System.Drawing.Size(105, 62);
            this.bRoleDelete.TabIndex = 1;
            this.bRoleDelete.Text = "Xoá";
            this.bRoleDelete.UseVisualStyleBackColor = true;
            // 
            // bRoleInsert
            // 
            this.bRoleInsert.Location = new System.Drawing.Point(25, 23);
            this.bRoleInsert.Name = "bRoleInsert";
            this.bRoleInsert.Size = new System.Drawing.Size(105, 62);
            this.bRoleInsert.TabIndex = 0;
            this.bRoleInsert.Text = "Thêm";
            this.bRoleInsert.UseVisualStyleBackColor = true;
            // 
            // tpPrivilege
            // 
            this.tpPrivilege.Controls.Add(this.panel4);
            this.tpPrivilege.Controls.Add(this.panel3);
            this.tpPrivilege.Location = new System.Drawing.Point(4, 25);
            this.tpPrivilege.Name = "tpPrivilege";
            this.tpPrivilege.Padding = new System.Windows.Forms.Padding(3);
            this.tpPrivilege.Size = new System.Drawing.Size(984, 456);
            this.tpPrivilege.TabIndex = 2;
            this.tpPrivilege.Text = "Quản lý quyền";
            this.tpPrivilege.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_search);
            this.panel3.Controls.Add(this.txtbox_searchBox);
            this.panel3.Controls.Add(this.rb_role);
            this.panel3.Controls.Add(this.rb_user);
            this.panel3.Controls.Add(this.dtgvPrivileges);
            this.panel3.Location = new System.Drawing.Point(6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(681, 444);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.checkedListBox1);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.btn_revoke);
            this.panel4.Controls.Add(this.btn_grant);
            this.panel4.Controls.Add(this.cb_grantOption);
            this.panel4.Controls.Add(this.clb_CRUD);
            this.panel4.Location = new System.Drawing.Point(693, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(285, 444);
            this.panel4.TabIndex = 1;
            // 
            // dtgvPrivileges
            // 
            this.dtgvPrivileges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPrivileges.Location = new System.Drawing.Point(3, 67);
            this.dtgvPrivileges.Name = "dtgvPrivileges";
            this.dtgvPrivileges.RowHeadersWidth = 51;
            this.dtgvPrivileges.RowTemplate.Height = 24;
            this.dtgvPrivileges.Size = new System.Drawing.Size(672, 374);
            this.dtgvPrivileges.TabIndex = 0;
            // 
            // rb_user
            // 
            this.rb_user.AutoSize = true;
            this.rb_user.Location = new System.Drawing.Point(618, 15);
            this.rb_user.Name = "rb_user";
            this.rb_user.Size = new System.Drawing.Size(57, 20);
            this.rb_user.TabIndex = 1;
            this.rb_user.TabStop = true;
            this.rb_user.Text = "User";
            this.rb_user.UseVisualStyleBackColor = true;
            // 
            // rb_role
            // 
            this.rb_role.AutoSize = true;
            this.rb_role.Location = new System.Drawing.Point(618, 41);
            this.rb_role.Name = "rb_role";
            this.rb_role.Size = new System.Drawing.Size(57, 20);
            this.rb_role.TabIndex = 2;
            this.rb_role.TabStop = true;
            this.rb_role.Text = "Role";
            this.rb_role.UseVisualStyleBackColor = true;
            // 
            // txtbox_searchBox
            // 
            this.txtbox_searchBox.Location = new System.Drawing.Point(17, 15);
            this.txtbox_searchBox.Name = "txtbox_searchBox";
            this.txtbox_searchBox.Size = new System.Drawing.Size(277, 22);
            this.txtbox_searchBox.TabIndex = 3;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(309, 15);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // clb_CRUD
            // 
            this.clb_CRUD.FormattingEnabled = true;
            this.clb_CRUD.Items.AddRange(new object[] {
            "INSERT",
            "DELETE",
            "UPDATE",
            "SELECT"});
            this.clb_CRUD.Location = new System.Drawing.Point(42, 275);
            this.clb_CRUD.Name = "clb_CRUD";
            this.clb_CRUD.Size = new System.Drawing.Size(202, 89);
            this.clb_CRUD.TabIndex = 0;
            this.clb_CRUD.ThreeDCheckBoxes = true;
            this.clb_CRUD.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_CRUD_SelectedIndexChanged);
            // 
            // cb_grantOption
            // 
            this.cb_grantOption.AutoSize = true;
            this.cb_grantOption.Location = new System.Drawing.Point(61, 370);
            this.cb_grantOption.Name = "cb_grantOption";
            this.cb_grantOption.Size = new System.Drawing.Size(169, 20);
            this.cb_grantOption.TabIndex = 1;
            this.cb_grantOption.Text = "WITH GRANT OPTION";
            this.cb_grantOption.UseVisualStyleBackColor = true;
            this.cb_grantOption.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn_grant
            // 
            this.btn_grant.Location = new System.Drawing.Point(61, 418);
            this.btn_grant.Name = "btn_grant";
            this.btn_grant.Size = new System.Drawing.Size(75, 23);
            this.btn_grant.TabIndex = 2;
            this.btn_grant.Text = "Grant";
            this.btn_grant.UseVisualStyleBackColor = true;
            // 
            // btn_revoke
            // 
            this.btn_revoke.Location = new System.Drawing.Point(144, 418);
            this.btn_revoke.Name = "btn_revoke";
            this.btn_revoke.Size = new System.Drawing.Size(75, 23);
            this.btn_revoke.TabIndex = 3;
            this.btn_revoke.Text = "Revoke";
            this.btn_revoke.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(13, 67);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(269, 174);
            this.checkedListBox1.TabIndex = 5;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 509);
            this.Controls.Add(this.tcRole);
            this.Name = "fAdmin";
            this.Text = "Admin dashboard";
            this.Load += new System.EventHandler(this.fAdmin_Load);
            this.tcRole.ResumeLayout(false);
            this.tpUser.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUser)).EndInit();
            this.tpRole.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRole)).EndInit();
            this.tpPrivilege.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPrivileges)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcRole;
        private System.Windows.Forms.TabPage tpUser;
        private System.Windows.Forms.TabPage tpRole;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvUser;
        private System.Windows.Forms.Button bUserUpdate;
        private System.Windows.Forms.Button bUserDelete;
        private System.Windows.Forms.Button bUserInsert;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvRole;
        private System.Windows.Forms.Button bRoleUpdate;
        private System.Windows.Forms.Button bRoleDelete;
        private System.Windows.Forms.Button bRoleInsert;
        private System.Windows.Forms.TabPage tpPrivilege;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvPrivileges;
        private System.Windows.Forms.CheckBox cb_grantOption;
        private System.Windows.Forms.CheckedListBox clb_CRUD;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txtbox_searchBox;
        private System.Windows.Forms.RadioButton rb_role;
        private System.Windows.Forms.RadioButton rb_user;
        private System.Windows.Forms.Button btn_grant;
        private System.Windows.Forms.Button btn_revoke;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}