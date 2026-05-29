using System;
using System.Collections.Generic;
using System.Text;

namespace ITHelpDeskTeamB
{
    public class User
    {
        public int userID { get; private set; }
        public string userName { get; private set; }
        public string userFirstName { get; private set; }
        public string userLastName { get; private set; }
        public string userPassword { get; private set; }
        public string userType { get; private set; }
        public string userEmail { get; private set; }
        public string userPhone{ get; private set; }

        public User(int ID, string name, string FirstName, string LastName, string password, string Type, string email,string phone)
        {
            userID = ID;
            userName = name;
            userFirstName = FirstName;
            userLastName = LastName;
            userPassword = password;
            userType = Type;
            userEmail = email;
            userPhone = phone;
        }

        public int getUserID()
        {
            return userID;
        }
    }
}
