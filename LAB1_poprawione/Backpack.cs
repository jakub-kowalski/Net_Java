using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LAB1_poprawione
{
    internal class Backpack
    {
        public int capacity;
        public List<Item> items;

        //Konstruktor klasy Backpack
        public Backpack(int capacity)
        {
            this.capacity = capacity;
            items = new List<Item>();
        }

        //Metoda dodająca obiekty klasy Item do listy obiektu Backpack
        public void AddItem(Item item)
        {
            items.Add(item);
        }

        //Metoda służąca do znajdowania rozwiązania problemu dla przedmiotów w danym plecaku
        public int[] Solve()
        {
            //Sortowanie przedmiotów w kolejności malejacej ich stosunku wartoości do wagi
            //Porównywane są sąsiednie elementy i na tej podstawie przesuwane w jedną lub drugą stronę
            items.Sort((x, y) => (y.value / y.weight).CompareTo(x.value / x.weight));
            int weightSum = 0;
            int valueSum = 0;
            //Przegląd po całej posortowanej liście
            foreach (Item item in items)
            {
                //Jeśli kolejny przedmiot zmieści się w plecaku, zostaje do niego dodany
                if (weightSum + item.weight <= capacity)
                {
                    weightSum += item.weight;
                    valueSum += item.value;
                }
            }
            //Zwracam tablicę z rozwiązaniem
            int[] solvedTab = new int[] { weightSum, valueSum };
            return solvedTab;
        }
    }
}
