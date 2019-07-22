using AirsoftReservationsAPI;
using AirsoftReservationsAPIServer.Models;
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
        // GET: Reservation
        public OkResult Post(ReservationVM model)
        {
            var reservation = new Reservation()
            {
                GameId = model.GameId,
                NumberOfGuns = model.NumberOfGuns,
                NumberOfMagazines = model.NumberOfMagazines,
                NumberOfPeople = model.NumberOfPeople,
                ReservationBy = model.ReservationBy
            };
            context.Reservations.Add(reservation);
            context.SaveChanges();

            return Ok();
        }
    }
}