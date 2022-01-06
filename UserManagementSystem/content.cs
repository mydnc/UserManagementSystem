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
    public partial class content : Form
    {
        public content()
        {
            InitializeComponent();
            string loggedInAccount = Database.GetLoggedInAccount();
            lblLoginName.Text = loggedInAccount;
            dataGridUserList.DataSource = Database.LoadData();

            dataGridUserList.EndEdit();
        }

        /* Clearout the fields in Add user area */
        private void cleanAddUserFields()
        {
            txtAddUser.Clear();
            txtAddUserPass.Clear();
            cBoxPriv.ResetText();
        }

        /* Add User to database after validations*/
        private void button3_Click(object sender, EventArgs e)
        {
            while (true)
            {
                if (txtAddUser.Text == "" || txtAddUserPass.Text == "" || (string)cBoxPriv.SelectedItem == null)
                {
                    MessageBox.Show("Fill all of the required fields for registration.", "Missing information!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                else if (txtAddUser.Text.Length < 6)
                {
                    MessageBox.Show("Username must contain more than 6 characters.", "Username is too short!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                else if (txtAddUserPass.Text.Length < 8)
                {
                    MessageBox.Show("Password must contain more than 8 characters.", "Password is too short!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                else if (Database.verifyUserName(txtAddUser.Text))
                {
                    MessageBox.Show("Username already exist, try something else.", "User registiration failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                else
                {
                    Database.AddUser(txtAddUser.Text, txtAddUserPass.Text, (string)cBoxPriv.SelectedItem);
                    cleanAddUserFields();
                    break;
                }
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /* Event to transfer data from grid to txtbox */ 
        private void dataGridUserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dataGridUserList.Rows[e.RowIndex];
                txtEditUser.Text = dgvRow.Cells[0].Value.ToString();
                txtEditUserPass.Text = dgvRow.Cells[1].Value.ToString();
                cBoxEditPriv.SelectedItem = dgvRow.Cells[2].Value.ToString();
            }
        }

        /* Hide password */
        private void dataGridUserList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.Value != null)
            {
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }

        /* Clearout the fields */
        private void btnAddUserClear_Click(object sender, EventArgs e)
        {
            txtAddUser.Clear();
            txtAddUserPass.Clear();
            cBoxPriv.ResetText();
        }

        /* Show/Hide Add User Password */
        private void chBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxShowPassword.Checked)
            {
                txtAddUserPass.PasswordChar = '\0';
            }
            else
            {
                txtAddUserPass.PasswordChar = '*';
            }
        }

        /* Show/Hide Edit User Password */
        private void chBoxEditShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxEditShowPassword.Checked)
            {
                txtEditUserPass.PasswordChar = '\0';
            }
            else
            {
                txtEditUserPass.PasswordChar = '*';
            }
        }

        /* Update user */
        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            if (txtEditUser.Text == "" || txtEditUserPass.Text == "" || (string)cBoxEditPriv.SelectedItem == null)
            {
                MessageBox.Show("Fill all of the required fields for update user information.", "Missing information!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtEditUser.Text.Length < 6)
            {
                MessageBox.Show("Username must contain more than 6 characters.", "Username is too short!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtEditUserPass.Text.Length < 8)
            {
                MessageBox.Show("Password must contain more than 8 characters.", "Password is too short!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Database.UpdateUser(dataGridUserList.CurrentCell.RowIndex, txtEditUser.Text, txtEditUserPass.Text, (string)cBoxEditPriv.SelectedItem);
                txtEditUser.Clear();
                txtEditUserPass.Clear();
                cBoxEditPriv.SelectedItem = null;
            }
        }

        /* Delete User */
        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete user?", "Delete User", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Database.DeleteUser(dataGridUserList.CurrentCell.RowIndex);
                txtEditUser.Clear();
                txtEditUserPass.Clear();
                cBoxEditPriv.SelectedItem = null;
            }
        }
    }
}
