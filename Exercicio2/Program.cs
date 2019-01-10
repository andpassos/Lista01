using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração das variaveis que serão utilizadas, double para notas e média e string para o nome do aluno
            double nota1, nota2, nota3, nota4, nota5, media;
            string NomeAluno;
            
            //Solicita o nome do aluno e guarda na variavel NomeAluno
            Console.WriteLine("Informe o nome do aluno:");
            NomeAluno = Console.ReadLine();
            
            //Solicita as notas do aluno e guarda em suas variaveis
            Console.WriteLine("Informe a primeira nota do aluno " + NomeAluno);
            nota1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Informe a segunda nota do aluno " + NomeAluno);
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a terceira nota do aluno " + NomeAluno);
            nota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a quarta nota do aluno " + NomeAluno);
            nota4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a quinta nota do aluno " + NomeAluno);
            nota5 = Convert.ToDouble(Console.ReadLine());

            //Sistema faz o cáculo da média
            media = (nota1+nota2+nota3+nota4+nota5)/5;

            //Programa informa a média do aluno
            Console.WriteLine("A média do aluno " + NomeAluno + " é " + media);
        }
    }
}
