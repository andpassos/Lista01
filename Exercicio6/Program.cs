using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
             //Declaração das variáveis
            int numero, antecessor, sucessor;
            //Solicitando ao usuario digitar um numero
            Console.WriteLine("Digite um numero");
           
            //Sistema guarda valor na variável numero
            numero = Convert.ToInt32(Console.ReadLine());
            
            //Subtraindo -1 do numero digitado
            antecessor = numero -1;
            
            //Somando +1 no numero digitado
            sucessor = numero +1;
            
            //Exibindo na tela
            Console.WriteLine("O numero escolhido é " + numero + " o antecessor dele é " +antecessor + " e o sucessor é " + sucessor);
        }
    }
}
