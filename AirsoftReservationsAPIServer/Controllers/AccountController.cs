using AirsoftReservationsAPI;
using AirsoftReservationsAPIServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace AirsoftReservationsAPIServer.Controllers
{
    public class AccountController : BaseController
    {
        // GET: Account     
        [System.Web.Mvc.Route("Register")]
        public async Task<IHttpActionResult> Register(RegisterViewModel model)
        {
           

            var user = new User
            {
                Name = model.Username,
                Password = model.Password,
            };

            context.Users.Add(user);
            context.SaveChanges();

            return Ok();
        }
    }
}