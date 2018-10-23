using EfimovsCalendar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EfimovsCalendar.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var currentDay = DateTime.Now.AddMonths(0);
            var firstDay = currentDay.AddDays(-currentDay.Day + 1);
            var dayOfWeek = firstDay.DayOfWeek;
            int nDay = (int)dayOfWeek;
            nDay = nDay < 1 ? 6 : nDay-1;

            List<CalendarCell> cells = new List<CalendarCell>();

            for (int i = nDay; i>0; i--)
            {
                var tempDay = firstDay.AddDays(-i);
                CalendarCell temp = new CalendarCell();
                temp.Date = tempDay;
                temp.ClassName = "wrongMonth ";
                cells.Add(temp);
                
            }

            for (int i = 0; i < 35-nDay; i++)
            {
                CalendarCell temp = new CalendarCell();
                temp.Date = firstDay.AddDays(i);
                cells.Add(temp);
                if (temp.Date == DateTime.Now) temp.ClassName = "today ";
                if (temp.Date.Month != DateTime.Now.Month)
                    temp.ClassName = "wrongMonth ";
            }
            for (int i=0; i < 8; i++)
            {
                CalendarEvent tempEvent = new CalendarEvent();
                tempEvent.Color = "#ddeeff";
                tempEvent.Name = $"Событие {i}";
                cells[4].Events.Add(tempEvent);
            }
            ViewBag.Cells = cells;
            return View();

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}