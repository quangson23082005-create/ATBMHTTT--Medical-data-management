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
            this.bSearchUser = new System.Windows.Forms.Button();
            this.txbSearchUser = new System.Windows.Forms.TextBox();
            this.dtgvUser = new System.Windows.Forms.DataGridView();
            this.bUserUpdate = new System.Windows.Forms.Button();
            this.bUserDelete = new System.Windows.Forms.Button();
            this.bUserInsert = new System.Windows.Forms.Button();
            this.tpRole = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbFitterUser = new System.Windows.Forms.CheckBox();
            this.btn_search3 = new System.Windows.Forms.Button();
            this.txtBox_searchBox3 = new System.Windows.Forms.TextBox();
            this.lb_choose_role = new System.Windows.Forms.Label();
            this.btn_revoke3 = new System.Windows.Forms.Button();
            this.cb_role3 = new System.Windows.Forms.ComboBox();
            this.btn_grant3 = new System.Windows.Forms.Button();
            this.dtgvUserRole = new System.Windows.Forms.DataGridView();
            this.dtgvRole = new System.Windows.Forms.DataGridView();
            this.bRoleUpdate = new System.Windows.Forms.Button();
            this.bRoleDelete = new System.Windows.Forms.Button();
            this.bRoleInsert = new System.Windows.Forms.Button();
            this.tpPrivilege = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.clb_column = new System.Windows.Forms.CheckedListBox();
            this.cb_chooseItem = new System.Windows.Forms.ComboBox();
            this.btn_revoke = new System.Windows.Forms.Button();
            this.btn_grant = new System.Windows.Forms.Button();
            this.cb_grantOption = new System.Windows.Forms.CheckBox();
            this.clb_CRUD = new System.Windows.Forms.CheckedListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.txtbox_searchBox = new System.Windows.Forms.TextBox();
            this.rb_role = new System.Windows.Forms.RadioButton();
            this.rb_user = new System.Windows.Forms.RadioButton();
            this.dtgvPrivileges = new System.Windows.Forms.DataGridView();
            this.tpFunc_proc = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_revoke2 = new System.Windows.Forms.Button();
            this.btn_grant2 = new System.Windows.Forms.Button();
            this.cb_chooseItem2 = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rb_role2 = new System.Windows.Forms.RadioButton();
            this.rb_user2 = new System.Windows.Forms.RadioButton();
            this.btn_search2 = new System.Windows.Forms.Button();
            this.txtBox_searchBox2 = new System.Windows.Forms.TextBox();
            this.dtgvPrivileges2 = new System.Windows.Forms.DataGridView();
            this.tcRole.SuspendLayout();
            this.tpUser.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUser)).BeginInit();
            this.tpRole.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUserRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRole)).BeginInit();
            this.tpPrivilege.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPrivileges)).BeginInit();
            this.tpFunc_proc.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPrivileges2)).BeginInit();
            this.SuspendLayout();
            // 
            // tcRole
            // 
            this.tcRole.Controls.Add(this.tpUser);
            this.tcRole.Controls.Add(this.tpRole);
            this.tcRole.Controls.Add(this.tpPrivilege);
            this.tcRole.Controls.Add(this.tpFunc_proc);
            this.tcRole.Location = new System.Drawing.Point(12, 12);
            this.tcRole.Name = "tcRole";
            this.tcRole.SelectedIndex = 0;
            this.tcRole.Size = new System.Drawing.Size(992, 485);
            this.tcRole.TabIndex = 0;
            this.tcRole.SelectedIndexChanged += new System.EventHandler(this.tcRole_SelectedIndexChanged);
            // 
            // tpUser
            // 
            this.tpUser.Controls.Add(this.panel1);
            this.tpUser.Location = new System.Drawing.Point(4, 25);
            this.tpUser.Name = "tpUser";
            this.tpUser.Padding = new System.Windows.Forms.Padding(3);
            this.tpUser.Size = new System.Drawing.Size(984, 456);
            this.tpUser.TabIndex = 0;
            this.tpUser.Text = "User Management";
            this.tpUser.UseVisualStyleBackColor = true;
            this.tpUser.Click += new System.EventHandler(this.tpUser_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bSearchUser);
            this.panel1.Controls.Add(this.txbSearchUser);
            this.panel1.Controls.Add(this.dtgvUser);
            this.panel1.Controls.Add(this.bUserUpdate);
            this.panel1.Controls.Add(this.bUserDelete);
            this.panel1.Controls.Add(this.bUserInsert);
            this.panel1.Location = new System.Drawing.Point(19, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 413);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bSearchUser
            // 
            this.bSearchUser.Location = new System.Drawing.Point(795, 23);
            this.bSearchUser.Name = "bSearchUser";
            this.bSearchUser.Size = new System.Drawing.Size(75, 23);
            this.bSearchUser.TabIndex = 5;
            this.bSearchUser.Text = "Search";
            this.bSearchUser.UseVisualStyleBackColor = true;
            // 
            // txbSearchUser
            // 
            this.txbSearchUser.Location = new System.Drawing.Point(570, 23);
            this.txbSearchUser.Name = "txbSearchUser";
            this.txbSearchUser.Size = new System.Drawing.Size(195, 22);
            this.txbSearchUser.TabIndex = 4;
            // 
            // dtgvUser
            // 
            this.dtgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUser.Location = new System.Drawing.Point(46, 118);
            this.dtgvUser.Name = "dtgvUser";
            this.dtgvUser.RowHeadersWidth = 51;
            this.dtgvUser.RowTemplate.Height = 24;
            this.dtgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvUser.Size = new System.Drawing.Size(824, 276);
            this.dtgvUser.TabIndex = 3;
            this.dtgvUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvUser_CellContentClick);
            // 
            // bUserUpdate
            // 
            this.bUserUpdate.Location = new System.Drawing.Point(387, 23);
            this.bUserUpdate.Name = "bUserUpdate";
            this.bUserUpdate.Size = new System.Drawing.Size(105, 62);
            this.bUserUpdate.TabIndex = 2;
            this.bUserUpdate.Text = "Update";
            this.bUserUpdate.UseVisualStyleBackColor = true;
            this.bUserUpdate.Click += new System.EventHandler(this.bUserUpdate_Click_1);
            // 
            // bUserDelete
            // 
            this.bUserDelete.Location = new System.Drawing.Point(212, 23);
            this.bUserDelete.Name = "bUserDelete";
            this.bUserDelete.Size = new System.Drawing.Size(105, 62);
            this.bUserDelete.TabIndex = 1;
            this.bUserDelete.Text = "Delete";
            this.bUserDelete.UseVisualStyleBackColor = true;
            this.bUserDelete.Click += new System.EventHandler(this.bUserDelete_Click_1);
            // 
            // bUserInsert
            // 
            this.bUserInsert.Location = new System.Drawing.Point(46, 23);
            this.bUserInsert.Name = "bUserInsert";
            this.bUserInsert.Size = new System.Drawing.Size(105, 62);
            this.bUserInsert.TabIndex = 0;
            this.bUserInsert.Text = "Insert";
            this.bUserInsert.UseVisualStyleBackColor = true;
            this.bUserInsert.Click += new System.EventHandler(this.bUserInsert_Click_1);
            // 
            // tpRole
            // 
            this.tpRole.Controls.Add(this.panel2);
            this.tpRole.Location = new System.Drawing.Point(4, 25);
            this.tpRole.Name = "tpRole";
            this.tpRole.Padding = new System.Windows.Forms.Padding(3);
            this.tpRole.Size = new System.Drawing.Size(984, 456);
            this.tpRole.TabIndex = 1;
            this.tpRole.Text = "Role Management";
            this.tpRole.UseVisualStyleBackColor = true;
            this.tpRole.Click += new System.EventHandler(this.tpRole_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbFitterUser);
            this.panel2.Controls.Add(this.btn_search3);
            this.panel2.Controls.Add(this.txtBox_searchBox3);
            this.panel2.Controls.Add(this.lb_choose_role);
            this.panel2.Controls.Add(this.btn_revoke3);
            this.panel2.Controls.Add(this.cb_role3);
            this.panel2.Controls.Add(this.btn_grant3);
            this.panel2.Controls.Add(this.dtgvUserRole);
            this.panel2.Controls.Add(this.dtgvRole);
            this.panel2.Controls.Add(this.bRoleUpdate);
            this.panel2.Controls.Add(this.bRoleDelete);
            this.panel2.Controls.Add(this.bRoleInsert);
            this.panel2.Location = new System.Drawing.Point(19, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(947, 413);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cbFitterUser
            // 
            this.cbFitterUser.AutoSize = true;
            this.cbFitterUser.Location = new System.Drawing.Point(701, 53);
            this.cbFitterUser.Name = "cbFitterUser";
            this.cbFitterUser.Size = new System.Drawing.Size(234, 20);
            this.cbFitterUser.TabIndex = 14;
            this.cbFitterUser.Text = "Filter users who do not have a role.";
            this.cbFitterUser.UseVisualStyleBackColor = true;
            this.cbFitterUser.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // btn_search3
            // 
            this.btn_search3.Location = new System.Drawing.Point(549, 53);
            this.btn_search3.Name = "btn_search3";
            this.btn_search3.Size = new System.Drawing.Size(75, 23);
            this.btn_search3.TabIndex = 12;
            this.btn_search3.Text = "Search";
            this.btn_search3.UseVisualStyleBackColor = true;
            // 
            // txtBox_searchBox3
            // 
            this.txtBox_searchBox3.Location = new System.Drawing.Point(334, 53);
            this.txtBox_searchBox3.Name = "txtBox_searchBox3";
            this.txtBox_searchBox3.Size = new System.Drawing.Size(209, 22);
            this.txtBox_searchBox3.TabIndex = 11;
            // 
            // lb_choose_role
            // 
            this.lb_choose_role.AutoSize = true;
            this.lb_choose_role.Location = new System.Drawing.Point(767, 167);
            this.lb_choose_role.Name = "lb_choose_role";
            this.lb_choose_role.Size = new System.Drawing.Size(80, 16);
            this.lb_choose_role.TabIndex = 10;
            this.lb_choose_role.Text = "Choose role";
            this.lb_choose_role.Click += new System.EventHandler(this.lb_choose_role_Click);
            // 
            // btn_revoke3
            // 
            this.btn_revoke3.Location = new System.Drawing.Point(821, 246);
            this.btn_revoke3.Name = "btn_revoke3";
            this.btn_revoke3.Size = new System.Drawing.Size(86, 42);
            this.btn_revoke3.TabIndex = 8;
            this.btn_revoke3.Text = "Revoke";
            this.btn_revoke3.UseVisualStyleBackColor = true;
            this.btn_revoke3.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_role3
            // 
            this.cb_role3.FormattingEnabled = true;
            this.cb_role3.Location = new System.Drawing.Point(770, 197);
            this.cb_role3.Name = "cb_role3";
            this.cb_role3.Size = new System.Drawing.Size(165, 24);
            this.cb_role3.TabIndex = 7;
            // 
            // btn_grant3
            // 
            this.btn_grant3.Location = new System.Drawing.Point(821, 312);
            this.btn_grant3.Name = "btn_grant3";
            this.btn_grant3.Size = new System.Drawing.Size(86, 42);
            this.btn_grant3.TabIndex = 6;
            this.btn_grant3.Text = "Grant";
            this.btn_grant3.UseVisualStyleBackColor = true;
            // 
            // dtgvUserRole
            // 
            this.dtgvUserRole.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvUserRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUserRole.Location = new System.Drawing.Point(334, 120);
            this.dtgvUserRole.Name = "dtgvUserRole";
            this.dtgvUserRole.RowHeadersWidth = 51;
            this.dtgvUserRole.RowTemplate.Height = 24;
            this.dtgvUserRole.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvUserRole.Size = new System.Drawing.Size(420, 276);
            this.dtgvUserRole.TabIndex = 4;
            // 
            // dtgvRole
            // 
            this.dtgvRole.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRole.Location = new System.Drawing.Point(25, 120);
            this.dtgvRole.Name = "dtgvRole";
            this.dtgvRole.RowHeadersWidth = 51;
            this.dtgvRole.RowTemplate.Height = 24;
            this.dtgvRole.Size = new System.Drawing.Size(270, 276);
            this.dtgvRole.TabIndex = 3;
            this.dtgvRole.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvRole_CellContentClick);
            // 
            // bRoleUpdate
            // 
            this.bRoleUpdate.Location = new System.Drawing.Point(204, 23);
            this.bRoleUpdate.Name = "bRoleUpdate";
            this.bRoleUpdate.Size = new System.Drawing.Size(91, 62);
            this.bRoleUpdate.TabIndex = 2;
            this.bRoleUpdate.Text = "Update";
            this.bRoleUpdate.UseVisualStyleBackColor = true;
            this.bRoleUpdate.Click += new System.EventHandler(this.bRoleUpdate_Click_1);
            // 
            // bRoleDelete
            // 
            this.bRoleDelete.Location = new System.Drawing.Point(106, 23);
            this.bRoleDelete.Name = "bRoleDelete";
            this.bRoleDelete.Size = new System.Drawing.Size(92, 62);
            this.bRoleDelete.TabIndex = 1;
            this.bRoleDelete.Text = "Delete";
            this.bRoleDelete.UseVisualStyleBackColor = true;
            this.bRoleDelete.Click += new System.EventHandler(this.bRoleDelete_Click_1);
            // 
            // bRoleInsert
            // 
            this.bRoleInsert.Location = new System.Drawing.Point(16, 23);
            this.bRoleInsert.Name = "bRoleInsert";
            this.bRoleInsert.Size = new System.Drawing.Size(84, 62);
            this.bRoleInsert.TabIndex = 0;
            this.bRoleInsert.Text = "Insert";
            this.bRoleInsert.UseVisualStyleBackColor = true;
            this.bRoleInsert.Click += new System.EventHandler(this.bRoleInsert_Click_1);
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
            this.tpPrivilege.Text = "Privilege Management";
            this.tpPrivilege.UseVisualStyleBackColor = true;
            this.tpPrivilege.Click += new System.EventHandler(this.tpPrivilege_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.clb_column);
            this.panel4.Controls.Add(this.cb_chooseItem);
            this.panel4.Controls.Add(this.btn_revoke);
            this.panel4.Controls.Add(this.btn_grant);
            this.panel4.Controls.Add(this.cb_grantOption);
            this.panel4.Controls.Add(this.clb_CRUD);
            this.panel4.Location = new System.Drawing.Point(693, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(285, 444);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // clb_column
            // 
            this.clb_column.FormattingEnabled = true;
            this.clb_column.Location = new System.Drawing.Point(13, 67);
            this.clb_column.Name = "clb_column";
            this.clb_column.Size = new System.Drawing.Size(269, 174);
            this.clb_column.TabIndex = 5;
            this.clb_column.SelectedIndexChanged += new System.EventHandler(this.clb_column_SelectedIndexChanged);
            // 
            // cb_chooseItem
            // 
            this.cb_chooseItem.FormattingEnabled = true;
            this.cb_chooseItem.Location = new System.Drawing.Point(13, 11);
            this.cb_chooseItem.Name = "cb_chooseItem";
            this.cb_chooseItem.Size = new System.Drawing.Size(255, 24);
            this.cb_chooseItem.TabIndex = 4;
            this.cb_chooseItem.SelectedIndexChanged += new System.EventHandler(this.cb_chooseItem_SelectedIndexChanged_1);
            // 
            // btn_revoke
            // 
            this.btn_revoke.Location = new System.Drawing.Point(144, 418);
            this.btn_revoke.Name = "btn_revoke";
            this.btn_revoke.Size = new System.Drawing.Size(75, 23);
            this.btn_revoke.TabIndex = 3;
            this.btn_revoke.Text = "Revoke";
            this.btn_revoke.UseVisualStyleBackColor = true;
            this.btn_revoke.Click += new System.EventHandler(this.btn_revoke_Click_1);
            // 
            // btn_grant
            // 
            this.btn_grant.Location = new System.Drawing.Point(61, 418);
            this.btn_grant.Name = "btn_grant";
            this.btn_grant.Size = new System.Drawing.Size(75, 23);
            this.btn_grant.TabIndex = 2;
            this.btn_grant.Text = "Grant";
            this.btn_grant.UseVisualStyleBackColor = true;
            this.btn_grant.Click += new System.EventHandler(this.btn_grant_Click_1);
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
            // clb_CRUD
            // 
            this.clb_CRUD.CheckOnClick = true;
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
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(309, 15);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click_1);
            // 
            // txtbox_searchBox
            // 
            this.txtbox_searchBox.Location = new System.Drawing.Point(17, 15);
            this.txtbox_searchBox.Name = "txtbox_searchBox";
            this.txtbox_searchBox.Size = new System.Drawing.Size(277, 22);
            this.txtbox_searchBox.TabIndex = 3;
            this.txtbox_searchBox.TextChanged += new System.EventHandler(this.txtbox_searchBox_TextChanged);
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
            this.rb_role.CheckedChanged += new System.EventHandler(this.rb_role_CheckedChanged);
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
            this.rb_user.CheckedChanged += new System.EventHandler(this.rb_user_CheckedChanged);
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
            this.dtgvPrivileges.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPrivileges_CellContentClick);
            // 
            // tpFunc_proc
            // 
            this.tpFunc_proc.Controls.Add(this.panel6);
            this.tpFunc_proc.Controls.Add(this.panel5);
            this.tpFunc_proc.Location = new System.Drawing.Point(4, 25);
            this.tpFunc_proc.Name = "tpFunc_proc";
            this.tpFunc_proc.Padding = new System.Windows.Forms.Padding(3);
            this.tpFunc_proc.Size = new System.Drawing.Size(984, 456);
            this.tpFunc_proc.TabIndex = 3;
            this.tpFunc_proc.Text = "Execute Management";
            this.tpFunc_proc.UseVisualStyleBackColor = true;
            this.tpFunc_proc.Click += new System.EventHandler(this.tpFunc_proc_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_revoke2);
            this.panel6.Controls.Add(this.btn_grant2);
            this.panel6.Controls.Add(this.cb_chooseItem2);
            this.panel6.Location = new System.Drawing.Point(691, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(287, 444);
            this.panel6.TabIndex = 1;
            // 
            // btn_revoke2
            // 
            this.btn_revoke2.Location = new System.Drawing.Point(163, 407);
            this.btn_revoke2.Name = "btn_revoke2";
            this.btn_revoke2.Size = new System.Drawing.Size(75, 23);
            this.btn_revoke2.TabIndex = 2;
            this.btn_revoke2.Text = "Revoke";
            this.btn_revoke2.UseVisualStyleBackColor = true;
            // 
            // btn_grant2
            // 
            this.btn_grant2.Location = new System.Drawing.Point(55, 407);
            this.btn_grant2.Name = "btn_grant2";
            this.btn_grant2.Size = new System.Drawing.Size(75, 23);
            this.btn_grant2.TabIndex = 1;
            this.btn_grant2.Text = "Grant";
            this.btn_grant2.UseVisualStyleBackColor = true;
            // 
            // cb_chooseItem2
            // 
            this.cb_chooseItem2.FormattingEnabled = true;
            this.cb_chooseItem2.Location = new System.Drawing.Point(16, 20);
            this.cb_chooseItem2.Name = "cb_chooseItem2";
            this.cb_chooseItem2.Size = new System.Drawing.Size(250, 24);
            this.cb_chooseItem2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rb_role2);
            this.panel5.Controls.Add(this.rb_user2);
            this.panel5.Controls.Add(this.btn_search2);
            this.panel5.Controls.Add(this.txtBox_searchBox2);
            this.panel5.Controls.Add(this.dtgvPrivileges2);
            this.panel5.Location = new System.Drawing.Point(6, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(679, 444);
            this.panel5.TabIndex = 0;
            // 
            // rb_role2
            // 
            this.rb_role2.AutoSize = true;
            this.rb_role2.Location = new System.Drawing.Point(573, 29);
            this.rb_role2.Name = "rb_role2";
            this.rb_role2.Size = new System.Drawing.Size(57, 20);
            this.rb_role2.TabIndex = 4;
            this.rb_role2.TabStop = true;
            this.rb_role2.Text = "Role";
            this.rb_role2.UseVisualStyleBackColor = true;
            // 
            // rb_user2
            // 
            this.rb_user2.AutoSize = true;
            this.rb_user2.Location = new System.Drawing.Point(573, 3);
            this.rb_user2.Name = "rb_user2";
            this.rb_user2.Size = new System.Drawing.Size(57, 20);
            this.rb_user2.TabIndex = 3;
            this.rb_user2.TabStop = true;
            this.rb_user2.Text = "User";
            this.rb_user2.UseVisualStyleBackColor = true;
            // 
            // btn_search2
            // 
            this.btn_search2.Location = new System.Drawing.Point(315, 22);
            this.btn_search2.Name = "btn_search2";
            this.btn_search2.Size = new System.Drawing.Size(75, 23);
            this.btn_search2.TabIndex = 2;
            this.btn_search2.Text = "Search";
            this.btn_search2.UseVisualStyleBackColor = true;
            // 
            // txtBox_searchBox2
            // 
            this.txtBox_searchBox2.Location = new System.Drawing.Point(15, 22);
            this.txtBox_searchBox2.Name = "txtBox_searchBox2";
            this.txtBox_searchBox2.Size = new System.Drawing.Size(282, 22);
            this.txtBox_searchBox2.TabIndex = 1;
            // 
            // dtgvPrivileges2
            // 
            this.dtgvPrivileges2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPrivileges2.Location = new System.Drawing.Point(3, 65);
            this.dtgvPrivileges2.Name = "dtgvPrivileges2";
            this.dtgvPrivileges2.RowHeadersWidth = 51;
            this.dtgvPrivileges2.RowTemplate.Height = 24;
            this.dtgvPrivileges2.Size = new System.Drawing.Size(673, 376);
            this.dtgvPrivileges2.TabIndex = 0;
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
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUser)).EndInit();
            this.tpRole.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUserRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRole)).EndInit();
            this.tpPrivilege.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPrivileges)).EndInit();
            this.tpFunc_proc.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPrivileges2)).EndInit();
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
        private System.Windows.Forms.CheckedListBox clb_column;
        private System.Windows.Forms.ComboBox cb_chooseItem;
        private System.Windows.Forms.TabPage tpFunc_proc;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dtgvPrivileges2;
        private System.Windows.Forms.Button btn_revoke2;
        private System.Windows.Forms.Button btn_grant2;
        private System.Windows.Forms.ComboBox cb_chooseItem2;
        private System.Windows.Forms.Button btn_search2;
        private System.Windows.Forms.TextBox txtBox_searchBox2;
        private System.Windows.Forms.RadioButton rb_role2;
        private System.Windows.Forms.RadioButton rb_user2;
        private System.Windows.Forms.Button btn_grant3;
        private System.Windows.Forms.DataGridView dtgvUserRole;
        private System.Windows.Forms.ComboBox cb_role3;
        private System.Windows.Forms.Button btn_revoke3;
        private System.Windows.Forms.Label lb_choose_role;
        private System.Windows.Forms.TextBox txtBox_searchBox3;
        private System.Windows.Forms.Button btn_search3;
        private System.Windows.Forms.CheckBox cbFitterUser;
        private System.Windows.Forms.Button bSearchUser;
        private System.Windows.Forms.TextBox txbSearchUser;
    }
}