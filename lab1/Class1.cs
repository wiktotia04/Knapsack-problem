using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Item
    {
        public int weight;
        public int value;
        public double wsp;
        public int x;


        public Item(int value, int weight, int x)
        {
            this.weight = weight;
            this.value = value;
            this.wsp = value / weight;
            this.x = x;
           
        }

        
    }
}
