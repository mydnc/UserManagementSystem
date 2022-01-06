
namespace UserManagementSystem
{
    partial class editUser
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chBoxEditShowPassword = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxEditPriv = new System.Windows.Forms.ComboBox();
            this.txtEditUserPass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEditUser = new System.Windows.Forms.TextBox();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNewPriv = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNewUsername = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOldPriv = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblOldUsername = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightCyan;
            this.groupBox2.Controls.Add(this.chBoxEditShowPassword);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cBoxEditPriv);
            this.groupBox2.Controls.Add(this.txtEditUserPass);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtEditUser);
            this.groupBox2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(15)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1087, 173);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit User";
            // 
            // chBoxEditShowPassword
            // 
            this.chBoxEditShowPassword.AutoSize = true;
            this.chBoxEditShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chBoxEditShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chBoxEditShowPassword.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.chBoxEditShowPassword.Location = new System.Drawing.Point(523, 105);
            this.chBoxEditShowPassword.Name = "chBoxEditShowPassword";
            this.chBoxEditShowPassword.Size = new System.Drawing.Size(151, 27);
            this.chBoxEditShowPassword.TabIndex = 29;
            this.chBoxEditShowPassword.Text = "Show Password";
            this.chBoxEditShowPassword.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(738, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Privilage";
            // 
            // cBoxEditPriv
            // 
            this.cBoxEditPriv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cBoxEditPriv.Font = new System.Drawing.Font("MS UI Gothic", 16.2F);
            this.cBoxEditPriv.FormattingEnabled = true;
            this.cBoxEditPriv.Items.AddRange(new object[] {
            "Admin",
            "Moderator",
            "Standart",
            "Guest"});
            this.cBoxEditPriv.Location = new System.Drawing.Point(742, 63);
            this.cBoxEditPriv.Name = "cBoxEditPriv";
            this.cBoxEditPriv.Size = new System.Drawing.Size(336, 35);
            this.cBoxEditPriv.TabIndex = 27;
            // 
            // txtEditUserPass
            // 
            this.txtEditUserPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtEditUserPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEditUserPass.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditUserPass.Location = new System.Drawing.Point(368, 63);
            this.txtEditUserPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditUserPass.Multiline = true;
            this.txtEditUserPass.Name = "txtEditUserPass";
            this.txtEditUserPass.Size = new System.Drawing.Size(306, 35);
            this.txtEditUserPass.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(7, 36);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "Username";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(364, 36);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Password";
            // 
            // txtEditUser
            // 
            this.txtEditUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtEditUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEditUser.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditUser.Location = new System.Drawing.Point(11, 63);
            this.txtEditUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditUser.Multiline = true;
            this.txtEditUser.Name = "txtEditUser";
            this.txtEditUser.Size = new System.Drawing.Size(307, 35);
            this.txtEditUser.TabIndex = 22;
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(92)))));
            this.btnSaveEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveEdit.FlatAppearance.BorderSize = 0;
            this.btnSaveEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveEdit.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSaveEdit.ForeColor = System.Drawing.Color.White;
            this.btnSaveEdit.Location = new System.Drawing.Point(754, 365);
            this.btnSaveEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(345, 43);
            this.btnSaveEdit.TabIndex = 25;
            this.btnSaveEdit.Text = "SAVE";
            this.btnSaveEdit.UseVisualStyleBackColor = false;
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.BackColor = System.Drawing.Color.White;
            this.btnCancelEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelEdit.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCancelEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(92)))));
            this.btnCancelEdit.Location = new System.Drawing.Point(12, 365);
            this.btnCancelEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(318, 43);
            this.btnCancelEdit.TabIndex = 34;
            this.btnCancelEdit.Text = "CANCEL";
            this.btnCancelEdit.UseVisualStyleBackColor = false;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightCyan;
            this.groupBox1.Controls.Add(this.lblNewPriv);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblNewUsername);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblOldPriv);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblOldUsername);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(15)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1087, 167);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected User";
            // 
            // lblNewPriv
            // 
            this.lblNewPriv.AutoSize = true;
            this.lblNewPriv.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblNewPriv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblNewPriv.Location = new System.Drawing.Point(771, 111);
            this.lblNewPriv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewPriv.Name = "lblNewPriv";
            this.lblNewPriv.Size = new System.Drawing.Size(89, 23);
            this.lblNewPriv.TabIndex = 38;
            this.lblNewPriv.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(606, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 23);
            this.label3.TabIndex = 37;
            this.label3.Text = "New Privilage:";
            // 
            // lblNewUsername
            // 
            this.lblNewUsername.AutoSize = true;
            this.lblNewUsername.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblNewUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblNewUsername.Location = new System.Drawing.Point(413, 111);
            this.lblNewUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewUsername.Name = "lblNewUsername";
            this.lblNewUsername.Size = new System.Drawing.Size(89, 23);
            this.lblNewUsername.TabIndex = 36;
            this.lblNewUsername.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(239, 111);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 23);
            this.label5.TabIndex = 35;
            this.label5.Text = "New Username:";
            // 
            // lblOldPriv
            // 
            this.lblOldPriv.AutoSize = true;
            this.lblOldPriv.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblOldPriv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblOldPriv.Location = new System.Drawing.Point(771, 36);
            this.lblOldPriv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOldPriv.Name = "lblOldPriv";
            this.lblOldPriv.Size = new System.Drawing.Size(89, 23);
            this.lblOldPriv.TabIndex = 34;
            this.lblOldPriv.Text = "Username";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(606, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 23);
            this.label7.TabIndex = 33;
            this.label7.Text = "Previous Privilage:";
            // 
            // lblOldUsername
            // 
            this.lblOldUsername.AutoSize = true;
            this.lblOldUsername.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblOldUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblOldUsername.Location = new System.Drawing.Point(413, 36);
            this.lblOldUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOldUsername.Name = "lblOldUsername";
            this.lblOldUsername.Size = new System.Drawing.Size(89, 23);
            this.lblOldUsername.TabIndex = 31;
            this.lblOldUsername.Text = "Username";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(239, 36);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 23);
            this.label11.TabIndex = 30;
            this.label11.Text = "Previous Username:";
            // 
            // editUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1110, 422);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelEdit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSaveEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "editUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "editUser";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chBoxEditShowPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxEditPriv;
        private System.Windows.Forms.TextBox txtEditUserPass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEditUser;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblOldPriv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblOldUsername;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblNewPriv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNewUsername;
        private System.Windows.Forms.Label label5;
    }
}