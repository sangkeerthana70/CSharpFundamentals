using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class SpeedingIfElse
    {
        int speed { get; set; }

        

        public static string IssueSpeedTicket(int speed)
        {
            string ticket;
            if (speed <= 60)
            {
                ticket = "No ticket";
            }
            else if ((speed >= 61) && (speed <= 80))
            {
                ticket = "Small ticket";
            }
            else 
            {
                ticket = "Big ticket";

            }

            
            return ticket;

        }
    }
}
