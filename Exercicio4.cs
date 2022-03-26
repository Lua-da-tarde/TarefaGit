using System;

class Program {
  public static void Main (string[] args)
        {
            int func, hr;
            float recebe, salario;

            Console.WriteLine("Insira o seu numero: ");
            func = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas horas voce trabalhou este mes? ");
            hr = int.Parse(Console.ReadLine());
            Console.WriteLine("QUanto voce recebe por hora? ");
            recebe = float.Parse(Console.ReadLine());

            salario = recebe * hr;
            Console.WriteLine("\r\nNumero: " + func + "\r\nSalario: " + salario);

        }
}