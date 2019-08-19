using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            string numeroStr = Console.ReadLine();
            int numero = Convert.ToInt32(numeroStr);
            if (numero % 2 == 0)
            {
                Console.WriteLine("O número digitado é par");
            }
            else
            {
                Console.WriteLine("O número digitado é ímpar");
            }
        }
    }
}
