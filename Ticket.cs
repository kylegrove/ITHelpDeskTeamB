using System;
using System.Collections.Generic;
using System.Text;

namespace ITHelpDeskTeamB
{
    public class Ticket
    {
        private int ticketID;
        private string ticketDate;
        private string ticketDescription;
        private string ticketStatus;
        private int ticketPriority;
        private string ticketSolution;
        private int userID;

        public Ticket(int ticketID, string ticketDate, string ticketDescription, string ticketStatus, int ticketPriority, string ticketSolution, int userID )
        {
            this.ticketID = ticketID;
            this.ticketDate = ticketDate;
            this.ticketDescription = ticketDescription;
            this.ticketStatus = ticketStatus;
            this.ticketPriority = ticketPriority;
            this.ticketSolution = ticketSolution;
            this.userID = userID;
        }


    }
}
