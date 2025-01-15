using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webApi.Data;
using webApi.Models;

namespace webApi.Controllers
{
    public class AccountController:ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

       [Route("api/welcome")]
       [HttpGet]
        public IActionResult Get()
        {
           var posts = _context.Posts.ToList();
            return Ok(posts);
        }
        
    }
}