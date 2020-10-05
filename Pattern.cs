using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InTerview
{
    
    class Pattern
    {
         /*     *
                **
                ***
                ****
                *****
                ******
                *******
                ********         */
        static void TrianglePattern(int num)
        {
            for(int i = 1; i <= num; i++)
            {
                for (int j = 1;  j<=i ; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void Main(string[] arg)
        {
            Pattern.TrianglePattern(8);
            Console.ReadLine();
        }
    }
}
