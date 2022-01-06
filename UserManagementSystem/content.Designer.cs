
namespace UserManagementSystem
{
    partial class content
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
            this.btnDel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddUserClear = new System.Windows.Forms.Button();
            this.chBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxPriv = new System.Windows.Forms.ComboBox();
            this.txtAddUserPass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddUser = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.chBoxEditShowPassword = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cBoxEditPriv = new System.Windows.Forms.ComboBox();
            this.txtEditUserPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEditUser = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridUserList = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Privilage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLoginName = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.White;
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(3)))), ((int)(((byte)(30)))));
            this.btnDel.Location = new System.Drawing.Point(383, 712);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(337, 43);
            this.btnDel.TabIndex = 24;
            this.btnDel.Text = "DELETE USER";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightCyan;
            this.groupBox2.Controls.Add(this.btnAddUserClear);
            this.groupBox2.Controls.Add(this.chBoxShowPassword);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cBoxPriv);
            this.groupBox2.Controls.Add(this.txtAddUserPass);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtAddUser);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(15)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1082, 198);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add User";
            // 
            // btnAddUserClear
            // 
            this.btnAddUserClear.BackColor = System.Drawing.Color.White;
            this.btnAddUserClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUserClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUserClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(92)))));
            this.btnAddUserClear.Location = new System.Drawing.Point(7, 148);
            this.btnAddUserClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddUserClear.Name = "btnAddUserClear";
            this.btnAddUserClear.Size = new System.Drawing.Size(308, 43);
            this.btnAddUserClear.TabIndex = 34;
            this.btnAddUserClear.Text = "CLEAR";
            this.btnAddUserClear.UseVisualStyleBackColor = false;
            this.btnAddUserClear.Click += new System.EventHandler(this.btnAddUserClear_Click);
            // 
            // chBoxShowPassword
            // 
            this.chBoxShowPassword.AutoSize = true;
            this.chBoxShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chBoxShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chBoxShowPassword.Location = new System.Drawing.Point(519, 110);
            this.chBoxShowPassword.Name = "chBoxShowPassword";
            this.chBoxShowPassword.Size = new System.Drawing.Size(151, 27);
            this.chBoxShowPassword.TabIndex = 29;
            this.chBoxShowPassword.Text = "Show Password";
            this.chBoxShowPassword.UseVisualStyleBackColor = true;
            this.chBoxShowPassword.CheckedChanged += new System.EventHandler(this.chBoxShowPassword_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(735, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Privilage";
            // 
            // cBoxPriv
            // 
            this.cBoxPriv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cBoxPriv.Font = new System.Drawing.Font("MS UI Gothic", 16.2F);
            this.cBoxPriv.FormattingEnabled = true;
            this.cBoxPriv.Items.AddRange(new object[] {
            "Admin",
            "Moderator",
            "Standart",
            "Guest"});
            this.cBoxPriv.Location = new System.Drawing.Point(738, 68);
            this.cBoxPriv.Name = "cBoxPriv";
            this.cBoxPriv.Size = new System.Drawing.Size(336, 35);
            this.cBoxPriv.TabIndex = 27;
            // 
            // txtAddUserPass
            // 
            this.txtAddUserPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtAddUserPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddUserPass.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddUserPass.Location = new System.Drawing.Point(364, 68);
            this.txtAddUserPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddUserPass.MaxLength = 16;
            this.txtAddUserPass.Multiline = true;
            this.txtAddUserPass.Name = "txtAddUserPass";
            this.txtAddUserPass.PasswordChar = '*';
            this.txtAddUserPass.Size = new System.Drawing.Size(306, 35);
            this.txtAddUserPass.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(3, 41);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(303, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "Username (Min 6, Max 12 Character)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(360, 41);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(298, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Password (Min 8, Max 16 Character)";
            // 
            // txtAddUser
            // 
            this.txtAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtAddUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddUser.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddUser.Location = new System.Drawing.Point(7, 68);
            this.txtAddUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddUser.MaxLength = 12;
            this.txtAddUser.Multiline = true;
            this.txtAddUser.Name = "txtAddUser";
            this.txtAddUser.Size = new System.Drawing.Size(306, 35);
            this.txtAddUser.TabIndex = 22;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(92)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(737, 148);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(337, 43);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gray;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(757, 712);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(337, 43);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "LOGOUT (EXIT)";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightCyan;
            this.groupBox3.Controls.Add(this.btnSaveEdit);
            this.groupBox3.Controls.Add(this.chBoxEditShowPassword);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cBoxEditPriv);
            this.groupBox3.Controls.Add(this.txtEditUserPass);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtEditUser);
            this.groupBox3.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(15)))), ((int)(((byte)(64)))));
            this.groupBox3.Location = new System.Drawing.Point(12, 246);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(337, 432);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Edit Selected User";
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(92)))));
            this.btnSaveEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveEdit.FlatAppearance.BorderSize = 0;
            this.btnSaveEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveEdit.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSaveEdit.ForeColor = System.Drawing.Color.White;
            this.btnSaveEdit.Location = new System.Drawing.Point(9, 376);
            this.btnSaveEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(306, 43);
            this.btnSaveEdit.TabIndex = 46;
            this.btnSaveEdit.Text = "SAVE CHANGES";
            this.btnSaveEdit.UseVisualStyleBackColor = false;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // chBoxEditShowPassword
            // 
            this.chBoxEditShowPassword.AutoSize = true;
            this.chBoxEditShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chBoxEditShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chBoxEditShowPassword.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.chBoxEditShowPassword.Location = new System.Drawing.Point(164, 174);
            this.chBoxEditShowPassword.Name = "chBoxEditShowPassword";
            this.chBoxEditShowPassword.Size = new System.Drawing.Size(151, 27);
            this.chBoxEditShowPassword.TabIndex = 45;
            this.chBoxEditShowPassword.Text = "Show Password";
            this.chBoxEditShowPassword.UseVisualStyleBackColor = true;
            this.chBoxEditShowPassword.CheckedChanged += new System.EventHandler(this.chBoxEditShowPassword_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(5, 192);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 23);
            this.label6.TabIndex = 44;
            this.label6.Text = "Privilage";
            // 
            // cBoxEditPriv
            // 
            this.cBoxEditPriv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cBoxEditPriv.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.cBoxEditPriv.FormattingEnabled = true;
            this.cBoxEditPriv.Items.AddRange(new object[] {
            "Admin",
            "Moderator",
            "Standart",
            "Guest"});
            this.cBoxEditPriv.Location = new System.Drawing.Point(9, 218);
            this.cBoxEditPriv.Name = "cBoxEditPriv";
            this.cBoxEditPriv.Size = new System.Drawing.Size(306, 38);
            this.cBoxEditPriv.TabIndex = 43;
            // 
            // txtEditUserPass
            // 
            this.txtEditUserPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtEditUserPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEditUserPass.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txtEditUserPass.Location = new System.Drawing.Point(7, 132);
            this.txtEditUserPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditUserPass.MaxLength = 16;
            this.txtEditUserPass.Multiline = true;
            this.txtEditUserPass.Name = "txtEditUserPass";
            this.txtEditUserPass.PasswordChar = '*';
            this.txtEditUserPass.Size = new System.Drawing.Size(306, 35);
            this.txtEditUserPass.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(5, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 41;
            this.label4.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(5, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 39;
            this.label2.Text = "New Username";
            // 
            // txtEditUser
            // 
            this.txtEditUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtEditUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEditUser.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txtEditUser.Location = new System.Drawing.Point(9, 53);
            this.txtEditUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditUser.MaxLength = 12;
            this.txtEditUser.Multiline = true;
            this.txtEditUser.Name = "txtEditUser";
            this.txtEditUser.Size = new System.Drawing.Size(306, 35);
            this.txtEditUser.TabIndex = 40;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LightCyan;
            this.groupBox4.Controls.Add(this.dataGridUserList);
            this.groupBox4.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(15)))), ((int)(((byte)(64)))));
            this.groupBox4.Location = new System.Drawing.Point(383, 246);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(711, 432);
            this.groupBox4.TabIndex = 47;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Edit Selected User";
            // 
            // dataGridUserList
            // 
            this.dataGridUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUserList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Password,
            this.Privilage});
            this.dataGridUserList.Location = new System.Drawing.Point(9, 26);
            this.dataGridUserList.MultiSelect = false;
            this.dataGridUserList.Name = "dataGridUserList";
            this.dataGridUserList.RowHeadersWidth = 51;
            this.dataGridUserList.RowTemplate.Height = 24;
            this.dataGridUserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridUserList.Size = new System.Drawing.Size(694, 393);
            this.dataGridUserList.TabIndex = 30;
            this.dataGridUserList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUserList_CellClick);
            this.dataGridUserList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridUserList_CellFormatting);
            // 
            // Username
            // 
            this.Username.DataPropertyName = "m_Username";
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 60;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Username.Width = 220;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "m_Password";
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Password.Width = 210;
            // 
            // Privilage
            // 
            this.Privilage.DataPropertyName = "m_Privilage";
            this.Privilage.HeaderText = "Privilage";
            this.Privilage.MinimumWidth = 6;
            this.Privilage.Name = "Privilage";
            this.Privilage.ReadOnly = true;
            this.Privilage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Privilage.Width = 210;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 726);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 23);
            this.label3.TabIndex = 48;
            this.label3.Text = "Logged In User:";
            // 
            // lblLoginName
            // 
            this.lblLoginName.AutoSize = true;
            this.lblLoginName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblLoginName.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblLoginName.ForeColor = System.Drawing.Color.White;
            this.lblLoginName.Location = new System.Drawing.Point(153, 726);
            this.lblLoginName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(0, 23);
            this.lblLoginName.TabIndex = 49;
            // 
            // content
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1105, 772);
            this.Controls.Add(this.lblLoginName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDel);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "content";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "content";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAddUserPass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAddUser;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxPriv;
        private System.Windows.Forms.CheckBox chBoxShowPassword;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEditUser;
        private System.Windows.Forms.TextBox txtEditUserPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cBoxEditPriv;
        private System.Windows.Forms.CheckBox chBoxEditShowPassword;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridUserList;
        private System.Windows.Forms.Button btnAddUserClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Privilage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLoginName;
    }
}