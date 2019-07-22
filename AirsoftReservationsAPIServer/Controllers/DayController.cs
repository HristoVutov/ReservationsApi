using AirsoftReservationsAPI;
using AirsoftReservationsAPIServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AirsoftReservationsAPIServer.Controllers
{
    public class DayController : BaseController
    {
        // GET: Day
        public void Post(int month, int year)
        {
            var days = DateTime.DaysInMonth(year, month);

            for (int i = 1; i <= days; i++)
            {
                DateTime day = new DateTime(year, month, i);
                Day currentDay = new Day();
                currentDay.Date = day;
                int count = 0;
                context.Days.Add(currentDay);
                context.SaveChanges();
                for (int j = 0; j < 12; j++)                
                {
                    int hour = (j * 40) / 60;
                    int minutes = (j * 40) % 60;
                    DateTime GamesStart = new DateTime(day.Year, day.Month, day.Day, 14 + hour, minutes, 0);
                    DateTime GamesEnd = GamesStart.AddMinutes(30);
                    Game gameO = new Game()
                    {
                        GameStart = GamesStart,
                        GameEnd = GamesEnd,
                        DayId = currentDay.Id
                    };
                    context.Games.Add(gameO);
                    context.SaveChanges();
                }

            }
        }

        public DayVM Get(int day, int month, int year)
        {
            var date = new DateTime(year, month, day);
            var dayModel = context.Days.Where(d => d.Date == date)
                .Select(d => new DayVM {
                    Id = d.Id,
                    Date = d.Date.HasValue ? d.Date.Value : DateTime.Today,
                    Games = context.Games.Where(g => g.DayId.Value == d.Id).Select(g => new GameVM
                    {
                        GameId = g.Id,
                        GameStart = g.GameStart.HasValue ? g.GameStart.Value : new DateTime(),
                        GameEnd = g.GameEnd.HasValue ? g.GameEnd.Value : new DateTime(),
                    }).ToList()
                }
            ).FirstOrDefault();

            foreach (var game in dayModel.Games)
            {
                var reservations = context.Reservations.Where(r => r.GameId == game.GameId).ToList();

                if(reservations.Any())
                {
                    game.Reservations = context.Reservations.Where(r => r.GameId == game.GameId).Sum(r => r.NumberOfPeople.HasValue ? r.NumberOfPeople.Value : 0);
                }
            }

            return dayModel;
        }
    }
}