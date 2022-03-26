using System;

class Program {
  public static void Main (string[] args)
        {
            double a = 0.0, b = 0.0, c = 0.0;
            double areac = 0.0, areat = 0.0, areatrap = 0.0, areaq = 0.0, arearet = 0.0;

            Console.WriteLine("Insira um valor: ");
            a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Insira outro valor: ");
            b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Insira um último valor: ");
            c = Double.Parse(Console.ReadLine());

            areat = a * c / 2;
            areac = Math.PI * (c * c);
            areatrap = ((a + b) * c) / 2;
            areaq = b * b;
            arearet = a * b;

            Console.WriteLine("\r\n A area do triangulo eh igual a " + areat);
            Console. WriteLine(" A area do circulo eh igual a " + Math.Round(areac, 2).ToString());
            Console.WriteLine(" A area do trapezio eh igual a " + areatrap);
            Console.WriteLine(" A area do quadrado eh igual a " + areaq);
            Console.WriteLine(" A area do retangulo eh igual a " + arearet);

        }
}