using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using src.Dto;
using dotnet_ef_marvel.src.Entities;
using Microsoft.AspNetCore.Mvc;
using src.Context;
using Microsoft.EntityFrameworkCore;

namespace src.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class HeroController : ControllerBase
    {
        private DataContext _context;
        public HeroController(DataContext context)
        {
            _context=context;
        }

        [HttpPost("")]
        public ActionResult<CreateHero> PostHeros(CreateHero hero)
        {        
             Hero newhero= new Hero(hero);
            _context.Add(newhero);
            _context.SaveChanges();
            return StatusCode(200);
        }
        [HttpGet] 
        public  async Task<ActionResult<List<Hero>>> List()
        {
            var hero = await _context.Heroes.ToListAsync();
            return StatusCode(200,hero);
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Hero>> Select(int id)
        {
            var hero = await _context.Heroes.FirstOrDefaultAsync(h=> h.Id==id);
            return StatusCode(200,hero);
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Hero>> Delete(int id)
        {   
             var hero = await _context.Heroes.FirstOrDefaultAsync(h=> h.Id==id);
            _context.Heroes.Remove(hero);
            return StatusCode(200,"Excluído");
        }
    }
}