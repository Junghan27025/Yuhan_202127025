﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202127025_LJH
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 0; i < args.Length; i++)
            {
                sum += i;
                if (sum >= 10000)
                {
                    Console.WriteLine("1~{0}의 합 = {1}", i, sum);
                    break;
                }
            }

            sum = 0;
            int index = 1;
            for (; sum < 10000; index++)
            {
                sum += index;
            }
            Console.WriteLine("1~{0}의 합 = {1}", index - index, sum);
        }
    }
}