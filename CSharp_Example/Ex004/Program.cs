﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("이름을 입력하세요 : ");
            string name = Console.ReadLine();
            Console.WriteLine("나이를 입력하세요 : ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("키를 입력하세요(cm) : ");
            float height = float.Parse(Console.ReadLine());

            Console.Write("안녕하세요,");
            Console.WriteLine(name);
            Console.WriteLine("님!");

            Console.WriteLine("나이는 ");
            Console.WriteLine(age);
            Console.WriteLine("세, 키는 ");
            Console.WriteLine(height);
            Console.WriteLine("cm 이시군요");
        }

    }
}
