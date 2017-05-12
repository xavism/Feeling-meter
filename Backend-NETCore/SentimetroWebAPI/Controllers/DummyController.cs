using Microsoft.AspNetCore.Mvc;
using SentimetroWebAPI.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentimetroWebAPI.Controllers
{
    public class DummyController : Controller
    {
        private VoteDbContext _ctx;

        public DummyController(VoteDbContext ctx)
        {
            this._ctx = ctx;
        }

        [HttpGet]
        [Route("api/testdatabase")]
        public ActionResult TestDatabase()
        {
            return Ok();
        }
    }
}
