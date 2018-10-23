using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EfimovsCalendar.Models
{
    public class CalendarCell
    {
        List<CalendarEvent> events = new List<CalendarEvent>();
        DateTime date;
        String className = "";

        public DateTime Date { get => date; set => date = value; }
        public List<CalendarEvent> Events { get => events; set => events = value; }
        public string ClassName { get => className; set => className = value; }
    }
}