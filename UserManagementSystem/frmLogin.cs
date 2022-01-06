using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManagementSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        /* Login button, input validation and verify data from database */
        private void btnRegister_Click(object sender, EventArgs e)
        {
            while (true)
            {
                if (txtUsername.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Do not leave any field empty, Enter your E-mail and password.", "Sign in failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                else if (!Database.verifyUserName(txtUsername.Text))
                {
                    txtUsername.Clear();
                    txtPassword.Clear();
                    MessageBox.Show("User does not exist, try again.", "Wrong Username!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                }
                else if (!Database.verifyPassword(txtPassword.Text))
                {
                    txtPassword.Clear();
                    MessageBox.Show("Password does not match!", "Wrong Password!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                }
                else
                {
                    Database.LoginNameSave(txtUsername.Text);
                    var frm = new content();
                    frm.Show();
                    this.Hide();
                    break;
                }
            }
        }

        /* Show/Hide Password */
        private void chBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {

            if (chBoxShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        /* Clear fields */
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnLoginExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
