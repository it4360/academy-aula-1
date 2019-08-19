using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o 1º número:");
            string numeroStr1 = Console.ReadLine();

            Console.WriteLine("Digite o 2º número:");
            string numeroStr2 = Console.ReadLine();

            int numero1 = Convert.ToInt32(numeroStr1);
            int numero2 = Convert.ToInt32(numeroStr2);

            if (numero1 == numero2)
            {
                Console.WriteLine("Os números digitados são iguais");
            }
            else if (numero1 > numero2)
            {
                Console.WriteLine("O maior número digitado " + numero2);
            }
            else
            {
                Console.WriteLine("O maior número digitado " + numero2);
            }
        }
    }
}
