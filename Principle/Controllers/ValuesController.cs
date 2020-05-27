using IoCOrnek.DAL;
using IoCOrnek.Helper;
using IoCOrnek.Model;
using Microsoft.AspNetCore.Mvc;

namespace IoCOrnek.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private ConnectionHelper _connectionHelper;
        public ValuesController()
        {
            _connectionHelper = new ConnectionHelper(new MsSQLConnection());
        }
        [HttpGet]
        public ActionResult<string> Get()
        {
            return _connectionHelper.GetData();
        }

    }
}
