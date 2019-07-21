using AirsoftReservationsAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace AirsoftReservationsAPIServer.Controllers
{
    public abstract partial class BaseController : ApiController
    {
        public AirsoftReservationsEntities context;

        public BaseController()
        {
            context = new AirsoftReservationsEntities();
        }
       
    }
}