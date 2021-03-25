﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropertyWebAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PropertyWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly DataContext dc;
        
        public CityController(DataContext dc)
        {
            this.dc = dc;
        }
        
        [HttpGet]
        public IActionResult GetCities()
        {
            var cities = dc.Cities.ToList();
            return Ok(cities);
        }

    }
}
