using System;

namespace Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração das variaveis que serão utilizadas
            int num1, num2, num3, num4, num5, media;

            //Solicitando informações ao usuário e leitura dos dados
            Console.WriteLine("Informe o primeiro número: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Informe o segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o terceiro número: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o quarto número: ");
            num4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o quinto número: ");
            num5 = Convert.ToInt32(Console.ReadLine());

            //Calculo da média dos valores informados pelo usuário
            media = (num1+num2+num3+num4+num5)/5;

            Console.WriteLine("A média dos valores informados é: " + media);

        }
    }
}
