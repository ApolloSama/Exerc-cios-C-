using System;

namespace Exercicio_C__1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de idades\n");

            Console.WriteLine("Digite Sua idade: ");
            int idade = int.Parse(Console.ReadLine());
 
            int idadeMeses = idade * 12;
            int idadeDias = idade * 365;
            int idadeHoras = idade *  8760;
            int idadeMinutos = idade * 525600;

            Console.WriteLine("Meses: " + idadeMeses);
            Console.WriteLine("Dias: " + idadeDias);
            Console.WriteLine("Horas: " + idadeHoras);
            Console.WriteLine("Minutos: " + idadeMinutos);

        }
    }
}
