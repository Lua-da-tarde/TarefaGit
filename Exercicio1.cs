using System;

class Program {
  public static void Main (string[] args)
        {
            int valor1, valor2, soma;

            Console.WriteLine("Escreva um valor: ");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva outro valor: ");
            valor2 = int.Parse(Console.ReadLine());

            soma = valor1 + valor2;
            Console.WriteLine("A soma dos dois valores eh igual a " + soma);
            
        }
    }