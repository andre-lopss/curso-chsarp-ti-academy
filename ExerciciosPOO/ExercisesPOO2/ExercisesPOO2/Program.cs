using System;
using System.Collections.Generic;

namespace ExercisesPOO2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Autor> autorList1 = new List<Autor> 
            { new Autor("C. S. Lewis", "cslewis@hotmail.com") };

            Livro livro1 = new Livro("As Crônicas de Nárnia", autorList1);

            List<Autor> autorList2 = new List<Autor>
            {
                new Autor("Adam Silveira", "adam@hotmail.com"),
                new Autor("Becky Albertalli", "becky@hotmail.com")
            };

            Livro livro2 = new Livro("E se fosse a gente?", autorList2);

            Console.WriteLine(livro1);
            Console.WriteLine(livro2);

            Console.ReadLine();
        }
    }
}
