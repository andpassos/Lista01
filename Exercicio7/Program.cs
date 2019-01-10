using System;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração das variáveis
            int valor1,valor2,valor3,media;

            //Sistema solicita valores ao usário
            Console.WriteLine("Informo o pimeiro valor:");
            valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informo o segundo valor:");
            valor2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informo o terceiro valor:");
            valor3 = Convert.ToInt32(Console.ReadLine());

            //Sistema calcula a média dos valores informaddos
            media = (valor1+valor2+valor3)/3;

            //Sistema informa ao usuário a média dos valores informado
            Console.WriteLine(" A média dos valores informados é : " + media);
        }
    }
}
