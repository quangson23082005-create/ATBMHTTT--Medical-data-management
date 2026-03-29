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
            this.tcRole.SuspendLayout();
            this.tpUser.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUser)).BeginInit();
            this.tpRole.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRole)).BeginInit();
            this.SuspendLayout();
            // 
            // tcRole
            // 
            this.tcRole.Controls.Add(this.tpUser);
            this.tcRole.Controls.Add(this.tpRole);
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
    }
}