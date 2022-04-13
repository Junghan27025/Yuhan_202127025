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
            Human h1 = new Human();
            h1.ppp(172, 70);
            h1.ppp("남성");
            Console.ReadLine();
        }
    }
}
class Human
{
    public void ppp(int height, int weight)
    {
        Console.WriteLine("키: {0}", height);
        Console.WriteLine($"무게: {weight}");
    }
    public void ppp(string gender)
    {
        Console.WriteLine($"성별은:{gender}");
    }
}
