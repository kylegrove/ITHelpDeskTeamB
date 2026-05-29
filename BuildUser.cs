using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITHelpDeskTeamB
{
    internal class BuildUser
    {
        private int userID;
        private string firstName;
        private string lastName; 
        private string userName;
        private string userPassword;
        private string userEmail;
        private string userPhone;
        private string userType;

        public BuildUser(int id, string username, string fname, string lname, string userpassword, string usertype, string useremail, string userphone)
        {
            userID = id;
            firstName = fname; 
            lastName = lname;
            userName = username;
            userPassword = userpassword;
            userType = usertype;
            userPhone = userphone;
            userEmail = useremail;
        }


        public User CreateUserObject()
        {
            if (userType == "Admin")
            {
                return new Admin(userID, userName, firstName, lastName, userPassword, userEmail, userPhone);
            }

            else if (userType == "IT Support Member")
            {
                return new ITSupportMember(userID, userName, firstName, lastName, userPassword, userEmail, userPhone);
            }

            else if (userType == "Project Member")
            {
                return new ProjectMember(userID, userName, firstName, lastName, userPassword, userEmail, userPhone);
            }

            else if (userType == "Report Manager")
            {
                return new ReportManager(userID, userName, firstName, lastName, userPassword, userEmail, userPhone);
            }

            throw new ArgumentException($"Unknown user type: {userType}");
        }
    }
}
   