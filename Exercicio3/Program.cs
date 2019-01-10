using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis
            int QuantMax, QuantMin, QuantMed;
            string Material;

            //Sistema solicita o nome do material e guarda na variavel material
            Console.WriteLine("Informe o nome do material:");
            Material = Console.ReadLine();

            //Sistema solicita a quantidade máxima e mínima do material
            Console.WriteLine("Informe a quantidade máxima para " + Material);
            QuantMax = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a quantidade mínima para " + Material);
            QuantMin = Convert.ToInt32(Console.ReadLine());

            //Sistema calcula a média do material e informa para o usuário
            QuantMed = (QuantMax+QuantMin)/2;
            Console.WriteLine(" A quantidade média do " + Material + " é de " + QuantMed);

        }
    }
}
