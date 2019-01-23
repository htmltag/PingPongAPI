using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoreWebApp.BLL;

namespace CoreWebApp.Controllers
{
    [Produces("application/json")]
    [Route("api/Ping")]
    public class PingController : Controller
    {
        // GET: api/Ping
        [HttpGet]
        public string Get()
        {
            return new Ping().AnswerPing();
        }

        // GET: api/Ping/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return new Ping().GetPingPong(id);
        }
    }
}
