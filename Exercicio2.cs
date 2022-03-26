using System;

class Program {
  public static void Main (string[] args)
        {
            double raio = 0.0, area = 0.0;

            Console.WriteLine("Insira o valor do raio: ");
            raio = Double.Parse(Console.ReadLine());

            area = 3.14159 * (raio * raio);

            Console.WriteLine("\r\nO valor da área do círculo é " + Math.Round(area, 2).ToString());
        }
}