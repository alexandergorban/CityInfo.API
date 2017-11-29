﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CityInfo.API.Controllers
{
    public class CitiesController : Controller
    {
        [HttpGet("api/cities")]
        public JsonResult GetCities()
        {
            return new JsonResult(new List<object>
            {
                new { id = 1, Name = "New York City" },
                new { id = 2, Name = "Antwerp" }
            });
        }
    }
}
