using IoCOrnek.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoCOrnek.Model
{
    public class MsSQLConnection : IConnection
    {
        public string GetData()
        {
            return "MsSQL";
        }
    }
}
