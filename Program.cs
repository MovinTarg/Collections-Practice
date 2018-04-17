using System;
using System.Collections.Generic;

namespace Collections_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            int[] newArray = {0,1,2,3,4,5,6,7,8,9};
            string[] newArray2 = {"Tim", "Martin", "Nikki", "Sara"};
            bool[] newArray3 = {true, false, true, false, true, false, true, false, true, false};
            int[,] newArray4 = new int[10,10];
            for (int i = 1; i <= 10; i++) {
                for (int l = 1; l <= 10; l++){
                    newArray4[i-1,l-1] = i*l;
                }
            }
            Console.WriteLine(newArray4);

            List<string> iceCream = new List<string>();
            iceCream.Add("Fragola");
            iceCream.Add("Chocolate");
            iceCream.Add("Vanilla");
            iceCream.Add("Cafe");
            iceCream.Add("Pistacio");
            iceCream.Add("Rocky Road");
            iceCream.Add("Dolche de Leche");
            iceCream.Add("Oreo");
            iceCream.Add("Mint Chocolate Chip");
            iceCream.Add("Taro");
            // Console.WriteLine(iceCream.Count);
            // Console.WriteLine(iceCream[3]);
            // iceCream.RemoveAt(3);
            // Console.WriteLine(iceCream.Count);
            // Console.WriteLine(iceCream[3]);

            Random rand = new Random();
            Dictionary<string,string> favorites = new Dictionary<string,string>();
            foreach (string name in newArray2){
                favorites[name] = iceCream[rand.Next(iceCream.Count)];
            }
            foreach (KeyValuePair<string,string> entry in favorites){
                // Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }
    }
}
