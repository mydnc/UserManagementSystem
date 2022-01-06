using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManagementSystem
{
    class Database
    {
        private static BindingList<User> users = new BindingList<User>();
        private static User loggedInUser;

        /* Sample Data */
        static Database()
        {
            users.Add(new User("fatih", "1234", "Admin"));
            users.Add(new User("Jiří", "admin", "Admin"));
            users.Add(new User("RitaNeRazbita", "yezizek", "Moderator"));
            users.Add(new User("Kofcuk", "food", "Guest"));
            users.Add(new User("KralOyun-DJ_Emsalsiz", "yaramicerde1234", "Standart"));
        }

        public static BindingList<User> LoadData()
        {
            return users;
        }

        /*Method to verify entered username from database and return bool value in case of successs of match or failure.*/
        public static bool verifyUserName(string username)
        {
            foreach(User tempName in users )
            {
                if (username == tempName.m_Username)
                {
                    return true;
                }
            }
            return false;
        }

        /*Method to verify entered password from database and return bool value in case of successs of match or failure.*/
        public static bool verifyPassword(string password)
        {
            foreach (User tempPassword in users)
            {
                if (password == tempPassword.m_Password)
                {
                    return true;
                }
            }
            return false;
        }

        /*Method to find user by username and return  it with bounded user as User object*/
        public static BindingList<User> FindByUsername(string username)
        {
            var temp = from a in users
                           where a.m_Username == username
                           select a;

            return new BindingList<User>(temp.ToList<User>());
        }

        /*Method to add User into database*/
        public static void AddUser(string username, string password, string privilage)
        {
            users.Add(new User(username, password, privilage));
        }

        public static void DeleteUser(int index)
        {
           users.RemoveAt(index);
        }

        /*Update user with new username and delete previous one */
        public static void UpdateUser(int oldUser, string username, string password, string privilage)
        {
            //find user
            if(!verifyUserName(username))
            {
                //Delete previous user
                DeleteUser(oldUser);

                //Change users parameters
                AddUser(username, password, privilage);
            }
            else
            {
                MessageBox.Show("This username is taken, try different user name.", "Username conflict!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /* Logged in user to show it after login */
        public static void LoginNameSave(string username)
        {
            loggedInUser = new User(username);
        }

        public static string GetLoggedInAccount()
        {
            return loggedInUser.m_Username;
        }
    }
}
