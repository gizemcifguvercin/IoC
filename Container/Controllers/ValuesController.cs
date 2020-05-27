using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IoCOrnek.DAL;
using Microsoft.AspNetCore.Mvc;

namespace IoCContainerOrnek.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IConnection _connection;
        public ValuesController(IConnection connection)
        {
            _connection = connection;
        }
        [HttpGet]
        public ActionResult<string> Get()
        {
          return  _connection.GetData();
        } 
    }
}
