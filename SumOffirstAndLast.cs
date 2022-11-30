using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask
{
    class SumOffirstAndLast
    {
        static void Main(string[] args)
        {
            // write code for sum of first and last digit of a number 
            Console.WriteLine("enter number ");

            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int rem1 = 0;
            while (temp > 0)
            {
               int  rem = 0;
                temp = temp / 10;
                rem = temp % 10;
                rem1 = rem;
            }
            int rem2 = num % 10;
            int sum = rem1 + rem2;
            Console.WriteLine(sum);


        }
    }
}
