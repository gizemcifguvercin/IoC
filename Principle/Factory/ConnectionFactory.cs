using IoCOrnek.DAL;
using IoCOrnek.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoCOrnek.Factory
{
    public class ConnectionFactory
    {
        public static IConnection GetCon()
        {
            return new OracleConnection();
        }
    }
}
