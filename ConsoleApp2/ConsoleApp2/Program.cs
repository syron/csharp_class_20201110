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
            Console.WriteLine("Välkommen butiksägare!");
            Console.Write("Hur många personer får det vara i din butik? ");
            string questionResult = Console.ReadLine();



            int maxNumberOfItems = 0;
            try
            {
                maxNumberOfItems = int.Parse(questionResult);
            }
            catch (FormatException fex)
            {
                Console.WriteLine("Input not a number"); 
                return;
            }
            catch (OverflowException oex)
            {
                Console.WriteLine("Input was too large"); 
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Det du skrev var felaktig!");
                return;
            }


            LimitedList<string> ll = new LimitedList<string>(maxNumberOfItems);

            try
            {
                ll.Add("hello world!");
                ll.Add("Robert");
                ll.Add("har");
                ll.Add("en");
                ll.Add("torktumlare");
                ll.Add("som");
                ll.Add("fungerar");
            }
            catch (ListIsFullException lifex)
            {
                Console.WriteLine("Red Alert: Too many people in our venues");
            }
            catch (Exception)
            {
                Console.WriteLine("Error occurred");
            }

            // en lista som innehåller max 5 items.
            // Robert: kommer det alltid vara 5 items? JA!

            // LINQ

            // så fort vi försöker att lägga till ett 11:e item, 
            // så ska det fångas upp som ett fel

            Console.WriteLine("Listan innehåller " + ll.Count() + " items");
        }
    }
}
