using System;

namespace Exercicio3emCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 a, b, c, d;
            Console.Write("A : ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("B : ");
            b = Int32.Parse(Console.ReadLine());
            Console.Write("C : ");
            c = Int32.Parse(Console.ReadLine());
            Console.Write("D : ");
            d = Int32.Parse(Console.ReadLine());
            Console.WriteLine("DIFERENÇA = {0}", (a * b) - (c * d));
        }
    }
}
