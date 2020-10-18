using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DXwand.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DXwand.Controllers
{
    [Route("api/RMessage/[action]")]
    [ApiController]
    public class RMesaageServiceController : ControllerBase
    {
        private readonly IRMessageRep rep;

        public RMesaageServiceController(IRMessageRep rep)
        {
            this.rep = rep;
        }

        [HttpGet("{MId}")]
        public ActionResult GetData(int MId)
        {
            var data = rep.GetById(MId);
            return Ok(data);

        }
    }
}
