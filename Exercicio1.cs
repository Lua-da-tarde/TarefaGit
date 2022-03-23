using System;

namespace Exercicio1emCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 v1, v2;
            Console.Write("Valor 1: ");
            v1 = Int32.Parse(Console.ReadLine());
            Console.Write("Valor 2: ");
            v2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Soma = {0}", (v1 + v2));
        }
    }
}
