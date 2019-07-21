using AirsoftReservationsAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AirsoftReservationsAPIServer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            
            return View();
        }

        //[HttpPost]
        //public ActionResult CreateMonthData(int month,int year)
        //{
        //    var days = DateTime.DaysInMonth(month, year);

        //    for (int i = 1; i <= days; i++)
        //    {
        //        DateTime day = new DateTime(year, month, i);
        //        Day currentDay = new Day();
        //        currentDay.Date = day;
        //        int count = 0;
        //        foreach (var game in currentDay.Games)
        //        {
        //            count++;
        //            int hour = (count * 40) / 60;
        //            int minutes = (count * 40) % 60;
        //            DateTime GamesStart = new DateTime(day.Year, day.Month, day.Day, 14 + hour, minutes, 0);
        //            DateTime GamesEnd = new DateTime(day.Year, day.Month, day.Day, 14 + hour, 30 + minutes, 0);
        //            Game gameO = new Game();
        //            gameO.GameStart = GamesStart;
        //            gameO.GameEnd = GamesEnd;
        //            gameO.DayId = currentDay.Id;
        //            context.Games.Add(gameO);
        //        }

        //        context.Days.Add(currentDay);
        //    }

        //    return Json("success", JsonRequestBehavior.AllowGet);
        //}

        //[HttpGet]
        //public ActionResult GetDayData(int day, int month, int year)
        //{
        //    var date = new DateTime(year, month, day);
        //    var games = context.Days.Where(d => d.Date.Value.Equals(date)).Select(d => d.Games.Select(g => new {
        //        GameStart = g.GameStart,
        //        GameEnd = g.GameEnd,
        //        Reservations = g.Reservations.Count
        //    }).ToList()
        //    ).FirstOrDefault();

        //    return Json(games, JsonRequestBehavior.AllowGet);
        //}
    }
}
