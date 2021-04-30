using System;

namespace Exercício_C__2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Descobridor de idades 2000 \n");

            int anoCalendario = DateTime.Now.Year;

            Console.WriteLine("Em que ano você nasceu?");
            int anoNascimento = int.Parse(Console.ReadLine());

            int idade = anoCalendario - anoNascimento;
            
            Console.WriteLine("Você tem: " + idade + " anos de idade");
        }
    }
}
