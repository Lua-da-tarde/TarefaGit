using System;

namespace Exercicio2emCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Double raio = 0.0;
            Double area = 0.0;
            Console.Write("Raio : ");
            raio = Double.Parse(Console.ReadLine());
            area = Math.PI * Math.Pow(raio, 2);
            Console.WriteLine("Area : {0:F4}", area);
        }
    }
}
