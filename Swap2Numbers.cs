﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap2NumbersConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, temp;
            Console.WriteLine("\n type first number : ");
            number1=int.Parse(Console.ReadLine());
            Console.WriteLine("\n type second number : ");
            number2 = int.Parse(Console.ReadLine());
            temp = number1;
            number1= number2;
            number2=temp;
            Console.WriteLine("\n After swapping :");
            Console.WriteLine("\n first number :");
            Console.WriteLine(number1);
            //Console.ReadLine();
            Console.WriteLine("\n Second number :");
            Console.WriteLine(number2);
            //Console.ReadLine();
        }
    }
}
