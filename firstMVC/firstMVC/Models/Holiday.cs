using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace firstMVC.Models
{
    public class Holiday
    {
        public string Name { get; set; }
        public DateTime HolidayDate { get; set; }
        public string Picture { get; set; }

        public Holiday(string name, DateTime date, string picture)
        {
            Name = name;
            HolidayDate = date;
            Picture = picture;
        }

        public string getDaysUntil()
        {
            DateTime currentDate = DateTime.Today;

            if (HolidayDate.DayOfYear < currentDate.DayOfYear)
            {
                HolidayDate = HolidayDate.AddYears(1);
            }

            int numDays = (HolidayDate - currentDate).Days;
            return Convert.ToString(numDays);
        }
    }
}