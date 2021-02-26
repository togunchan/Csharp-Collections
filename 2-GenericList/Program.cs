using System;
using System.Collections.Generic;

namespace _2_GenericList
{
    class Product
    {
        public string name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int>();
            sayilar.Add(10);
            sayilar.Add(20);
            sayilar.Add(30);

            List<string> isimler = new List<string>();
            isimler.Add("ali");
            isimler.Add("ahmet");
            isimler.Add("yağmur");
            isimler.Add(null);

            List<Product> urunler1 = new List<Product>()
            {
                new Product(){name="Samsung S5"},
                new Product(){name="Samsung S6"},
                new Product(){name="Samsung S7"},
                new Product(){name="Samsung S8"}
            };

            List<Product> urunler2 = new List<Product>()
            {
                new Product(){name="Iphone 6"},
                new Product(){name="Iphone 7"},
                new Product(){name="Iphone 8"},
                new Product(){name="Iphone 9"}
            };

                urunler1.AddRange(urunler2);

                // foreach (var urun in urunler1)
                // {
                //     Console.WriteLine(urun.name);
                // }

                urunler1.ForEach(p =>{
                    Console.WriteLine(p.name);
                    });

                int count = urunler1.Count;
                Console.WriteLine(count);

                

        }
    }
}
