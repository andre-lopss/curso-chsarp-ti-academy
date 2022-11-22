using System;

namespace Aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool? variavel = null;
            //int? teste = null;
    
            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o seu peso: ");
            double peso = Convert.ToDouble(Console.ReadLine().Replace(".", ","));

            Console.WriteLine("\nApresentação:");
            Console.WriteLine("Seu nome é: " + nome);
            Console.WriteLine("Sua idade é: " + idade);
            Console.WriteLine("Seu peso é: " + peso);

            Console.ReadLine();
        }
    }
}
