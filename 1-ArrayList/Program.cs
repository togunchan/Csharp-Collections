﻿using System;
using System.Collections;

namespace _1_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {

            //ArrayList
            ArrayList myList = new ArrayList();
            
            myList.Add(10);
            myList.Add("10");
            myList.Add("abc");
            myList.Add(10.5);

            ArrayList myList2 = new ArrayList(){"*******","10","abc",10.5};

            //Accessing Items

            //Console.WriteLine(myList[0]);
            int sayi = (int)myList[0];

            // myList.Insert(1,20);
            // myList.InsertRange(3,myList2);

            //Remove Items
            
            // myList.Remove(10);
            // myList.RemoveAt(2);
            myList.RemoveRange(0,2);

            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

            // Console.WriteLine(myList.Contains(10));

            ArrayList sayilar = new ArrayList(){10,5,460};

            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }

            sayilar.Sort();

            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }
        }
    }
}
