using IoCOrnek.DAL;
using IoCOrnek.Factory;
using IoCOrnek.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoCOrnek.Helper
{
    public class ConnectionHelper
    {
        private IConnection _connection;
        public ConnectionHelper(IConnection connection)
        {
            _connection = connection;
        }
        public string GetData()
        {
            return _connection.GetData();
        }
    }
}
