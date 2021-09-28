using System;
using static AS2.Status;

namespace AS2
{
    public class StatusController
    {
        public Status status(DateTime startDate, DateTime currentDate)
        {   
            var studentTimeSpan = currentDate.Subtract(startDate);
            
            if (studentTimeSpan.TotalHours < yearToHours(3) && studentTimeSpan.Days > 0)
            {
                return Status.Active;
            }
            if (studentTimeSpan.TotalHours > yearToHours(3))
            {
                return Status.Graduated;
            }
            if (studentTimeSpan.TotalDays < 0)
            {
                return Status.New;
            }
            return Status.Dropout;
        }

        public int yearToHours(int years)
        {
            return 24 * 365 * years;
        }
    }
}