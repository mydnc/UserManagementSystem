using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagementSystem
{
    public class User
    {
        public string m_Username { get; set; }
        public string m_Password { get; set; }
        public string m_Privilage { get; set; }

        /* To store logged in username */
        public User(string username)
        {
            m_Username = username;
        }

        public User(string username, string password, string privilage)
        {
            m_Username = username;
            m_Password = password;
            m_Privilage = privilage;
        }

        public override string ToString()
        {
            return this.m_Username + " " + this.m_Privilage;
        }

        
    }
}
