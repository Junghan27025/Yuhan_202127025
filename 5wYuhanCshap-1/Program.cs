using System;

namespace _202127025_LJH
{
    class ConstEx
    {
    public const int number = 3;
    }

    class ReadonlyEx
    {
        public readonly int number = 10;
        public ReadonlyEx()
        {
            number = 20;
        }
        public ReadonlyEx(int n)
        {
            number = n;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // const 사용
            Console.WriteLine(ConstEx.number);

            // readonly 사용
            ReadonlyEx instl = new ReadonlyEx();
            Console.WriteLine(instl.number);

            ReadonlyEx inst2 = new ReadonlyEx(100);
            Console.WriteLine(inst2.number);
        }
    }

}


