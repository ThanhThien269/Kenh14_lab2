using System;
using System.Collections.Generic;


namespace Kenh14_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // instance object
            Item item1 = new Item() { Name = "Ferrari", Accessories = "Động cơ", PhotoURL = "Ferrari.jpg", Price = "12$" };
            Item item2 = new Item() { Name = "Lamborghini", Accessories = "Bánh xe", PhotoURL = "Ferrari.jpg", Price = "13$" };


            Console.WriteLine("Name: {0} Price: {1} Accessories: {2} PhotoURL: {3}", item1.Name, item1.Price, item1.Accessories, item1.PhotoURL);
            // list
            List<Item> lst = new List<Item>()
            {
                new Item() { Name = "Audi", Accessories = "Bánh xe", PhotoURL = "Ferrari.jpg", Price = "15$" },

            };

            // print
            foreach (Item item in lst)
            {
                Console.WriteLine("Name: {0} Price: {1} Accessories: {2} PhotoURL: {3}", item1.Name, item1.Price, item1.Accessories, item1.PhotoURL);

            }

            //lst.Add(item1);
            //lst.Add(item2);
            //lst.Add(item3);
            Console.WriteLine("count : {0}", lst.Count);

            //item.ItemName = "KIWI";
            //item.Image = "1.jpg";
            //item.Price = 12;
        }
    }
}