﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book1ConsoleApp1
{
    public enum BookType
    {
        Magazine = 1,
        Novel = 2,
        Reference_Book = 3,
        Miscellaneous = 4
    }
    internal class Program
    {
        struct book
        {
            public int bid { get; set; }
            public String title { get; set; }
            public float price { get; set; }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\n Enter a valid credential to view Book of your choice:");
            Console.ReadLine();
            book b1 = new book();
            b1.bid = 1;
           // Console.WriteLine("\n");
            b1.title = "Titanic";
           // Console.WriteLine("\n");
            b1.price = 800;
           // Console.WriteLine("\n");
            int enumValue = 2;
            String enumName=Enum.GetName(typeof(BookType), enumValue);
            Console.WriteLine($"{ b1.bid}{b1.title}{b1.price}");
            Console.WriteLine(enumName);

            book b2 = new book();
            b2.bid = 2;
            b2.title = "Leveraging Inner Health";
            b2.price = 1500;
            enumValue= 3;
            enumName=Enum.GetName(typeof(BookType), enumValue);
            Console.WriteLine($"{b2.bid}{b2.title}{b2.price}");
            Console.WriteLine(enumName);
             
        }
    }
}
