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
    public partial class editUser : Form
    {
        public editUser()
        {
            InitializeComponent();
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            var frm = new content();
            frm.Show();
            this.Close();
        }
    }
}
