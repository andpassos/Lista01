using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
             //Declaração de variáveis A, B, C. A recebeu 999, B recebeu 555 e C sem valor inicialmente
            int A = 999, B = 555, C;
            //Exibindo os valores para o usuário
            Console.WriteLine ("Valores de A = " + A + ", B = " + B);
            //Transfere o valor de A para C
            C = A;
            //Tranferindo o valor de B para A
            A = B;
            //Transferindo o valor de C para B
            B = C;
            //Exibindo os novos valores para o usuário
            Console.WriteLine ("Os valores atualizados são, A = " + A + ", B = " + B);
        } 
    } 
}
