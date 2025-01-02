using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello ");
            Console.WriteLine("World");
            Console.WriteLine("이름을 입력하세요 : ");

            string name = Console.ReadLine(); // 이름을 입력받습니다.
            Console.WriteLine("안녕하세요, ");
            Console.WriteLine(name);
            Console.WriteLine("님!");
        }
    }
}
