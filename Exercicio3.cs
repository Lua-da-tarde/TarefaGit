using System;

class Program {
  public static void Main (string[] args)
        {
            int a, b, c, d, dif;

            Console.WriteLine("Insira um valor: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira um valor: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira um valor: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira um valor: ");
            d = int.Parse(Console.ReadLine());

            dif = (a * b) - (c * d);
            Console.WriteLine("\r\nA diferenca eh igual a " + dif);

        }
}