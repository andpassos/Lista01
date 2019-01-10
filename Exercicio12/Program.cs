using System;

namespace Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variaveis
            double salario, reajuste, salarioReajuste;

            //Solicitando ao usuário o salário atual e leitura dos dados informado
            Console.WriteLine("Digite o valor do salario");
            salario = Convert.ToDouble(Console.ReadLine());

            //Solicitando ao usuário o reajuste que será aplicado e leitura dos dados informado 
            Console.WriteLine("Digite o valor do reajuste");
            reajuste = Convert.ToDouble(Console.ReadLine());
            
            //Calculo para o reajsute
            salarioReajuste = salario * (reajuste/100) + salario;
            
            //Escrevendo na tela o resultado do calculo
            Console.WriteLine("O valor do salario com o ajuste será: R$" + salarioReajuste);
        }
    }
}
