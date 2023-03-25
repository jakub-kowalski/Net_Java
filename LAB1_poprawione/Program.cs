using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LAB1_poprawione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Wczytanie pojemności plecaka oraz liczby przedmiotów do wygenerowania
            Console.Write("Wprowadz pojemnosc plecaka: ");
            int capacity = int.Parse(Console.ReadLine());
            Console.Write("Wprowadz ilosc przedmiotow do wygenerowania: ");
            int numItems = int.Parse(Console.ReadLine());

            //Stworzenie obiektów
            Random random = new Random(1);
            Backpack backpack = new Backpack(capacity);

            //Wypisanie listy wygenerowanych przedmiotów
            Console.WriteLine("Wygenerowane przedmioty:");
            Console.WriteLine("ID\tWaga\tWartosc");

            //Tworzenie plecaka
            for (int i = 0; i < numItems; i++)
            {
                //Generowanie pseudolosowych wag oraz wartości
                int weight = random.Next(1, 10);
                int value = random.Next(1, 20);
                //Tworzenie obiektów klasy Item
                Item item = new Item(i, weight, value);
                //Dodawanie przedmiotów do plecaka
                backpack.AddItem(item);
                Console.WriteLine(item.id + "\t" + weight + "\t" + value);
            }
            //Znalezienie rozwiązania metodą Solve klasy Backpack
            int weightSum = backpack.Solve()[0];
            int valueSum = backpack.Solve()[1];
            //Wypisanie rozwiązania
            Console.WriteLine("\nW plecaku o pojemnosci " + capacity + " zmieszczono przedmioty o wartosci: " + valueSum + " i wadze: " + weightSum);
            Console.Read();
        }
    }
}
