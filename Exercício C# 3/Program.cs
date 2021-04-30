using System;

namespace Exercício_C__2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seria seu salário?");

            int salario = int.Parse(Console.ReadLine());

            if(salario < 500){
                decimal porcentagem = salario/10 * 3;
                decimal salarioAjuste = salario + porcentagem;
                Console.WriteLine("Seu salário ajustado: " + salarioAjuste + " Reais");
            } else{
                Console.WriteLine("Seu salário é maior ou igual a 500 Reais");
            }            
        }
    }
}
