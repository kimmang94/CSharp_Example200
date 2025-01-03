using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("int.MaxValue = {0}", int.MaxValue);
            int x = int.MaxValue, y = 0;
            y = x + 10;
            Console.WriteLine("int.MaxValue + 10 = {0}", y);
        }
    }
}
