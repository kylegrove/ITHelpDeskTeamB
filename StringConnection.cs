using System;
using System.Collections.Generic;
using System.Text;

namespace ITHelpDeskTeamB
{
    internal class StringConnection
    {
        public string connection{ get; set; }

        public StringConnection()
        {
            connection = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\dominic03\source\repos\klgrove\ITHelpDeskTeamB\ITDatabase.mdf";
        }
    }
}
