using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LimitedList<Person> myLimitedList = new LimitedList<Person>(7);

            LimitedList<string> ll = new LimitedList<string>(10);
            ll.Add("hello world!");
            ll.Add("Robert");
            ll.Add("har");
            ll.Add("en");
            ll.Add("torktumlare");
            ll.Add("som");
            ll.Add("fungerar");

            // en lista som innehåller max 5 items.
            // Robert: kommer det alltid vara 5 items? JA!

            // LINQ

            Console.WriteLine("Listan innehåller " + ll.Count() + " items");
        }
    }
}
