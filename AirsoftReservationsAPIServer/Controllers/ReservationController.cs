using AirsoftReservationsAPI;
using AirsoftReservationsAPIServer.Models;
using AirsoftReservationsAPIServer.Models.Reservation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace AirsoftReservationsAPIServer.Controllers
{
    public class ReservationController : BaseController
    {
        // Post: Reservation
        [HttpPost]
        [Authorize]
        public OkResult Post(ReservationVM model)
        {
            var userId = context.Users.Where(c => c.Name == User.Identity.Name).Select(c => c.Id).FirstOrDefault();
            var reservation = new Reservation()
            {
                
                GameId = model.GameId,
                NumberOfGuns = model.NumberOfGuns,
                NumberOfMagazines = model.NumberOfMagazines,
                NumberOfPeople = model.NumberOfPeople,
                ReservationBy = userId
            };
            context.Reservations.Add(reservation);
            context.SaveChanges();

            return Ok();
        }

        [Authorize]
        public List<ReservationGet> Get(int id)
        {
            var userRole = context.Users.Where(c => c.Name == User.Identity.Name).Select(c => c.RoleId).FirstOrDefault();

            
            var reservation = context.Reservations.Where(c => c.GameId == id).Select(c => new ReservationGet
            {
                Id = c.Id,
                NumberOfGuns = c.NumberOfGuns != null ? c.NumberOfGuns.Value : 0,
                NumberOfMagazines = c.NumberOfMagazines != null ? c.NumberOfGuns.Value : 0,
                NumberOfPeople = c.NumberOfPeople != null ? c.NumberOfPeople.Value : 0,
            }).ToList();

            return reservation;
        }
    }
}