using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask
{
    class Table1to5
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                int num = 1;
                for (int j = 1; j <= 5; j++)
                {
                    num = num * i;
                    Console.Write( "  "+num);
                }
                Console.WriteLine();
          
            }
        }
    }
}
