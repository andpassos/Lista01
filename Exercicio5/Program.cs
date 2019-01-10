using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração das variáveis
            double celsius, fahrenheit;
            Console.Write ("Digite o valor para a converção em Fahrenheit:");
            celsius = Convert.ToDouble(Console.ReadLine());

            fahrenheit = (1.8 * celsius) + 32;

            Console.WriteLine("O valor de " +celsius+ " celsius em fahrenheit é :" +fahrenheit);
        }
    }
}
