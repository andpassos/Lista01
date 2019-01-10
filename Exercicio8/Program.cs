using System;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variaveis
            int mes;

            //Solitando a informação ao usuário
            Console.WriteLine("Informe a quantidade de meses para serem calculados:");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A quantidade solicitada tem " + mes*30 + " de Dias.");

        }
    }
}
