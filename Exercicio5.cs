using System;

class Program {
  public static void Main (string[] args)
        {
            int cp1, qnt1, cp2, qnt2;
            float valor1, valor2, total;

            Console.WriteLine("Digite o codigo da primeira peca: ");
            cp1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade da peca 1: ");
            qnt1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor unitario da peca 1: ");
            valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o codigo da segunda peca: ");
            cp2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade da peca 2: ");
            qnt2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor unitario da peca 2: ");
            valor2 = float.Parse(Console.ReadLine());

            total = (qnt1 * valor1) + (qnt2 * valor2);
            Console.WriteLine("\r\n O codigo e valor da primeira peca são " + cp1 + " e " + valor1);
            Console.WriteLine(" O codigo e valor da segunda peca são " + cp2 + " e " + valor2);
            Console.WriteLine("\r\n O valor da compra eh " + total);

        }
}