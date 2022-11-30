using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask
{
    class SumOfprime
    {
        static void Main(string[] args)
        {
            // write code for sum of prime from 1 to 10
            int count = 0;
            int sum = 0;
            for (int i = 2; i <= 10; i++)
            {
                count = 0;
                for (int j = 2; j <= i; j++)
                {

                    if (i % j == 0)
                    {
                        count++;
                    }

                }
                if (count < 2)
                {
                    sum = sum + i;
                    
                }


            }
            Console.WriteLine("sum of prime from 1 to 10 " + sum);

        }
    }
}
