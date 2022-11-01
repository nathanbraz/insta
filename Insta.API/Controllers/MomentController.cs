using System;
using Insta.API.Data;
using Insta.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Insta.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MomentController : Controller
    {
        private InstaContext context;
        public MomentController(InstaContext context)
        {
            this.context = context;
        }

        [HttpGet("Teste")]
        public async Task<IActionResult> Index()
        {
            var moment = await context.Moment.ToListAsync();

            var data = new Result<Moment>()
            {
                Data = moment,
                Message = "Funcionou"
            };
            return Ok(data);
        }


    }

    public class Result<T>
    {
        public string? Message { get; set; }
        public List<T> Data { get; set; }
    }
}
