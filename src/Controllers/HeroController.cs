using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using src.Dto;
using dotnet_ef_marvel.src.Entities;
using Microsoft.AspNetCore.Mvc;

namespace src.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class HeroController : ControllerBase
    {
        public HeroController()
        {
        }

        [HttpPost("")]
        public ActionResult<CreateHero> PostTModel(CreateHero hero)
        {
            return hero; 
        }
    }
}