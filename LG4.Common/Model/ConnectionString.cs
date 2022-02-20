using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG4.Common.Model {
    public class ConnectionString {

        public String server { get; private set; }
        public String username { get; private set; }
        public String password { get; private set; }
        public int port { get; private set; }
        public String database { get; private set; }

        public ConnectionString(string server, string username, string password, int port, string database) {
            this.server = server;
            this.username = username;
            this.password = password;
            this.port = port;
            this.database = database;
        }

    }
}
