﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 2147483647;
            long bigNum = num;
            Console.WriteLine(bigNum);

            double x = 1234.5;
            int a;
            a = (int)x;
            Console.WriteLine(a);
        }
    }
}
