using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace PropExample
{
    class Item
    {
        private static int count;
        public readonly int id = -1;
        public string name;
        public int price;

        public Item(string name, int price)
        {
            id = count++;
            this.name = name;
            this.price = price;
        }
    }
}
