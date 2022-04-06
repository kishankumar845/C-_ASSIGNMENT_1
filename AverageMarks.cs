using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arr = { 45, 55, 50, 69, 89 };
            double maxNumber = 0;
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]>maxNumber)
                {
                    maxNumber = arr[i];
                }    
            }
            Console.WriteLine("Maximum marks is = ", +maxNumber);
            Console.ReadLine();
        }
    }
}
