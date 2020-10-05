using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InTerview
{
    class Pattern3
    {
        /*
            s * * * * *
            ss * * * *
            sss * * *
            ssss * *
            sssss *
         
         */
        public static void Main(string[] arg)
        {
            int n = 5;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("s");
                }
                for(int k = n; k > i; k--)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
