using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o 1º número:");
            string numeroStr1 = Console.ReadLine();

            Console.WriteLine("Digite o 2º número:");
            string numeroStr2 = Console.ReadLine();

            Console.WriteLine("Digite o 3º número:");
            string numeroStr3 = Console.ReadLine();

            int numero1 = Convert.ToInt32(numeroStr1);
            int numero2 = Convert.ToInt32(numeroStr2);
            int numero3 = Convert.ToInt32(numeroStr3);
            int aux = 0;

            if (numero1 > numero2)
            {
                aux = numero2;
                numero2 = numero1;
                numero1 = aux;
            }
            if (numero2 > numero3)
            {
                aux = numero3;
                numero3 = numero2;
                numero2 = aux;
            }
            if (numero1 > numero2)
            {
                aux = numero2;
                numero2 = numero1;
                numero1 = aux;
            }

            Console.WriteLine("A order dos números é: " +
                numero1 + ", " +
                numero2 + ", " +
                numero3);

        }
    }
}
