using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, Bem vindo ao meu primeiropprojeto em C#!");

            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine($"Olá,{nome}! Vamos fazer um cálculo simples");

            Console.Write("Digite um número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite um segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double soma = num1 + num2;

            Console.WriteLine($"A soma de {num1} e {num2} é {soma}.");

            Console.WriteLine("Presione qualquer tecla para sair ...");
            Console.ReadKey();
        }
    }
}
