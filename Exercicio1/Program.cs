using System;

namespace Exercicio1
{
    class Program
    {  static void Main(string[] args)
        {
            int numero1, numero2, resultado;

            //Solicita ao usuário a informação de um número
            Console.WriteLine ("Informe um numero: ");
            //Converte oque o usuario digitou em int32 e coloca na variavel numero1
            numero1 = Convert.ToInt32(Console.ReadLine());
            //Solicita outro número para o usuário
            Console.Write ("Infome outro numero: ");
            //Converte o'que o usuario digitou em int32 e coloca na variavel numero2
            numero2 = Convert.ToInt32(Console.ReadLine());
            //Calcula a soma entre os 2 numeros que foram digitados e multiplicar a soma pelo o primeiro numero
            resultado = (numero1 + numero2) * numero1;
            //Exibe na tela o resultado do calculo efetuado em cima
            Console.WriteLine (" A soma de " + numero1 + " + " + numero2 + " multiplicado por " + numero1 + " é " + resultado);
        }
    }
}