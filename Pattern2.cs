﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InTerview
{
          
     
     
            
    class Pattern2
    {
        /*     
                 SSSSSSSSSS *
                 SSSSSSSSS * *
                 SSSSSSSS * * *
                 SSSSSSS * * * *
                 SSSSSS * * * * *
                 SSSSS * * * * * *
                 SSSS * * * * * * *
                 SSS * * * * * * * *
                 SS * * * * * * * * *
                 S * * * * * * * * * *
        */

        static void patter2(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = num; j >= i; j--)
                {
                    Console.Write("S");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
        public static void Main(string[] arg)
        {
            Pattern2.patter2(10);
            Console.ReadLine();
        }
    }
}
