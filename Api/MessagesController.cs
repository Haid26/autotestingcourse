using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ArcadiaCourse.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ArcadiaCourse.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly CrudExampleContext _context;
        
        public MessagesController (CrudExampleContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            var result = _context.Messages.Where(m => m.IsDeleted.HasValue && !m.IsDeleted.Value).ToList();
            return Ok(result);
        }
    }
}
