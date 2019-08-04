using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirsoftReservationsAPIServer.Models
{
    public class UserVM
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }
    }
}