using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202127025_LJH
{
    //Overriding
    internal class Program
    {
        static void Main(string[] args)
        {
            Human h1 = new Human();
            man h2 = new man();
            h1.pop();
            h2.pop();
            Console.ReadLine();
        }
    }
}
class Human
{
    public virtual void pop()
    {
        Console.WriteLine("사람입니다.");
    }
}
class man : Human
{
    public void pop()
    {
        Console.WriteLine("남자 입니다.");
    }
}