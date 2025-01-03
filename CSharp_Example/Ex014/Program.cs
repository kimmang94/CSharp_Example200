﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int value;

            Console.WriteLine("1. int로 변환할 문자열을 입력하세요:");
            input = Console.ReadLine();
            bool result = Int32.TryParse(input, out value);

            if (!result)
            {
                Console.WriteLine("'{0}' 는 int로 변환될 수 없습니다. \n", input);
            }
            else
            {
                Console.WriteLine("int '{0}'으로 변환되었습니다.\n",value);
            }

            Console.WriteLine("2. double로 변환할 문자열을 입력하세요! ");
            input = Console.ReadLine();
            try
            {
                double m = Double.Parse(input);
                Console.WriteLine("double '{0}' 으로 변환되었습니다. \n", m);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
