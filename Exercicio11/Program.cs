using System;

namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
           //Declaração de variaveis
            double juros, capital, taxaEmprestimo, periodo;

            //Solicitando ao usuário informação do capital
            Console.WriteLine("Digite o capital");
            capital = Convert.ToDouble(Console.ReadLine());

            //Solicitando ao usuário informação da taxa
            Console.WriteLine("Digite a taxa do empresitimo");
            taxaEmprestimo = Convert.ToDouble(Console.ReadLine());

            //Solicitando ao usuário informação do periodo
            Console.WriteLine("Dite o periodo total");
            periodo = Convert.ToDouble(Console.ReadLine());

            //Calculando o valor do juros
            juros = (capital*(taxaEmprestimo/100)*periodo);

            //Exibindo o valor ao usuário
            Console.WriteLine("O vaor do juros será: R$"+juros);
        }
    }
}
