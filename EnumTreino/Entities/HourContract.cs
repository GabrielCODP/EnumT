using System;
using System.Collections.Generic;
using System.Text;

namespace EnumTreino.Entities
{
    class HourContract
    {
        public DateTime Date { get; private set; }
        public double PerHour { get; private set; }
        public int Hours { get; private set; }
        public HourContract(DateTime date, double perHour, int hours)
        {
            Date = date;
            PerHour = perHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return PerHour * Hours;
        }
    }
}
