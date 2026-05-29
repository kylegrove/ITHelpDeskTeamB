using System;
using System.Collections.Generic;
using System.Text;

namespace ITHelpDeskTeamB
{
    // Admin inherits everything from User
    public class Admin : User
    {
        

        public Admin(int userID, string userName, string firstName, string lastName, string userPassword, string userEmail, string userPhone)
            : base(userID, userName, firstName, lastName, userPassword, "admin", userEmail, userPhone)
        {

        }

        public string getType()
        {
            return userType; // Accesses the userType property defined in User.cs
        }
    }
}