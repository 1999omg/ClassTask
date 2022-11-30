using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask
{
    class SimplePattern
    {
        static void Main(string[] args )
        {
            // print simple star pattern 
            for (int i=1;i<5;i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
