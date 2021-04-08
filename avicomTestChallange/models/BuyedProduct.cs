using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avicomTestChallange.models
{
    class BuyedProduct
    {
        private int client, product;

        BuyedProduct() { }
        BuyedProduct(int client, int product)
        {
            this.client = client;
            this.product = product;
        }
    }
}
