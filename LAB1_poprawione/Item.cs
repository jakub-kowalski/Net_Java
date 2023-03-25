using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LAB1_poprawione
{
    internal class Item
    {
        public int id;
        public int weight;
        public int value;

        //Konstruktor obiektu klasy Item
        public Item(int id, int weight, int value)
        {
            this.id = id;
            this.weight = weight;
            this.value = value;
        }
    }
}
