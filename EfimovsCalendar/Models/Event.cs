using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EfimovsCalendar.Models
{
    public class CalendarEvent
    {
        private string color;
        private string name;

        public string Color { get => color; set => color = value; }
        public string Name { get => name; set => name = value; }
    }
}