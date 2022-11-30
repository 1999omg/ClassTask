using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask
{
    class TrimNum
    {
        static void Main(string[] args)
        {
            // write code for chek number is trim or not 
            Console.WriteLine("enter number is trim or not  ");
            int num = int.Parse(Console.ReadLine());
            int power = num * num * num;
            int rem = power % 10;
            if (rem == num)
            {
                Console.WriteLine(num + "  is a trim number");
            }
            else
                 Console.WriteLine(num + "  is not trim");
            
        }
    }
}
