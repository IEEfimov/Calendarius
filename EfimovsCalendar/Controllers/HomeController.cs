﻿using EfimovsCalendar.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EfimovsCalendar.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int? year, int? month)
        {
            List<CalendarCell> cells;
            if (year.HasValue && month.HasValue)
            {
                cells = getList(new DateTime((int)year, (int)month, 1));
            }
            else
            {
                cells = getList(DateTime.Now);
            }
            ViewBag.CurrentMonth = cells[7].Date.Month;
            ViewBag.CurrentYear = cells[7].Date.Year;
            ViewBag.CMonth = cells[7].Date.ToString("MMMM", CultureInfo.CreateSpecificCulture("en"));
            ViewBag.Cells = cells;
            return View();

        }

        public List<CalendarCell> getList(DateTime date) {
            var cells = new List<CalendarCell>();

            if (date.Day != 1) date = date.AddDays(-date.Day + 1);
            int dayOfWeek = (int) date.DayOfWeek;
            dayOfWeek = dayOfWeek < 1 ? 6 : dayOfWeek - 1; // Monday is 0 now;
                       
            for (int i = -dayOfWeek; i < 35 - dayOfWeek; i++)
            {
                var tempDay = date.AddDays(i);
                CalendarCell temp = new CalendarCell(tempDay,i);
                cells.Add(temp);
                
                if (isSimilarDate(tempDay,DateTime.Now)) temp.ClassName = "today ";
                if (temp.Date.Month != date.Month)
                    temp.ClassName = "wrongMonth ";
            }

            return cells;
        }

        public bool isSimilarDate(DateTime a, DateTime b)
        {
            if (a.Day != b.Day) return false;
            if (a.Month != b.Month) return false;
            if (a.Year != b.Year) return false;

            return true;
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