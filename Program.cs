using System;

namespace Variáveis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de dados

            Console.WriteLine("Soma de dois números");
            Console.WriteLine("--------------------");
            Console.WriteLine("Digite o primeiro valor:");
            int valorUm = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            int valorDois = int.Parse(Console.ReadLine());

            //Processamento

            int soma = valorUm + valorDois;

            //Exibir

            Console.WriteLine("A soma de " +valorUm+ " + " +valorDois+ " é igual a " +soma);
        }
    }
}
