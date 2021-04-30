using System;

namespace ExemploConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício da Média\n");

            Console.WriteLine("Qual é a primeira nota?");
            double primeiraNota = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual é a segunda nota?");
            double segundaNota = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual é a terceira nota?");
            double terceiraNota = double.Parse(Console.ReadLine());

            double media = ((primeiraNota + segundaNota + terceiraNota) /3);

            Console.WriteLine("A média das notas foi: " + media.ToString("N1"));

            if (media > 5)
            {
                Console.WriteLine("O aluno foi aprovado :D");
            } else {
                Console.WriteLine("O aluno foi reprovado D:");
            }
        }
    }
}
