using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace EfimovsCalendar.Models
{
    public class CalendarEvent
    {
        private Color color;
        private string name;
              
        public string Name { get => name; set => name = value; }
        public string getColorStyle()
        {
            return color.Name;
        }

        public void setColor(int color)
        {
            switch (color)
            {
                case 0:
                    this.color = Color.CornflowerBlue;
                    break;
                case 2:
                    this.color = Color.Gainsboro;
                    break;
                default:
                    this.color = Color.FromArgb(221,238,255);
                    break;
            }
        }

        public CalendarEvent(string name, int color = 0)
        {
            Name = name;
            setColor(color);
        }
    }
}