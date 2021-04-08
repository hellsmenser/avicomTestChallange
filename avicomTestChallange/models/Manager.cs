using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avicomTestChallange.models
{
    class Manager
    {
        private int id { get; set; }
        private string name;

        public Manager() { }
        public Manager(string name)
        {
            this.name = name;
        }


    }
}
