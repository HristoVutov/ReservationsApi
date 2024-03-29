﻿using AirsoftReservationsAPI;
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
            if (!string.IsNullOrEmpty(model.Password) && !string.IsNullOrEmpty(model.ConfirmPassword))
            {
                if (model.ConfirmPassword != model.Password)
                {
                    return BadRequest("Passwords do not match!");
                }
            }
            else
            {
                return BadRequest("All fields are required!");
            }

            var userCheck = context.Users.Where(c => c.Name.Equals(model.Username)).Any();

            if (userCheck)
            {
                return BadRequest("User already exists!");
            }

            var user = new User
            {
                Name = model.Username,
                Password = model.Password,
                RoleId = 2
            };

            context.Users.Add(user);
            context.SaveChanges();

            return Ok("User created successfully!");
        }
    }
}