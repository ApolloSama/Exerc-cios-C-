using System;

namespace Exercício_Desafio_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Categorizador de nadadores \n");

            Console.WriteLine("Digite a sua idade: ");
            
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18){
                Console.WriteLine("Você está na categoria Sênior");
            }
            if (idade <= 17 && idade > 13){
                Console.WriteLine("Você está na categoria Juvenil B");
            }
            if (idade <= 13 && idade > 10){
                Console.WriteLine("Você está na categoria Juvenil A");
            }
            if (idade <= 10 && idade > 7){
                Console.WriteLine("Você está na categoria Infantil B");
            }
            if (idade <= 7){
                Console.WriteLine("Você está na categoria Infantil A");
            }    
        }
    }
}
