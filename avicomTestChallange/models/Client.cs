using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avicomTestChallange.models
{
    class Client
    {

        private int id { get; set; }
        private string name, status, manager;

        public Client() { }
        public Client(string name, string status, string manager)
        {
            this.name = name;
            this.status = status;
            this.manager = manager;
        }

    }
}
