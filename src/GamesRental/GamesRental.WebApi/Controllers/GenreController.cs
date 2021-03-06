﻿using GamesRental.Entities.Enuns;
using GamesRental.Util;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace GamesRental.WebApi.Controllers
{
    [Route("v1/Genre")]
    [Authorize(Roles = nameof(RoleUser.Administrator))]
    public class GenreController : Controller
    {
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            var enums = Enum.GetValues(typeof(GenreGame)).Cast<GenreGame>().Select(c => new { Value = (int)c, Name = c.ToString(), Description = c.GetDescription() }).ToList();

            return Ok(enums);
        }
    }
}
