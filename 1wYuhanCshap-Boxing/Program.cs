using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202127025_LJH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //boxing
            int num1 = 10;
            object obj = num1;

            //unboxing
            int num2 = (int)obj;

            Console.WriteLine(num1);
            Console.WriteLine(obj);
            Console.WriteLine(num2);

            //Console.ReadLine();
        }
    }
}