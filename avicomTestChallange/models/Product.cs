using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avicomTestChallange.models
{
    class Product
    {

        private int id { get; set; }
        private string name, type, period;
        private int price;

        Product() { }
        Product(string name, string type, string period, int price)
        {
            this.name = name;
            this.type = type;
            this.period = period;
            this.price = price;
        }
    }
}
