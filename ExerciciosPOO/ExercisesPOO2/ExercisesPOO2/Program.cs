using System;

namespace ExercisesPOO2
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro livro1 = new Livro("As Crônicas de Nárnia", new Autor[] { new Autor("C. S. Lewis", "cslewis@hotmail.com")});

            Livro livro2 = new Livro("E se fosse a gente?", new Autor[] { new Autor("Adam Silveira", "adam@hotmail.com"), new Autor( "Becky Albertalli", "becky@hotmail.com")});

            Console.WriteLine(livro1);

            Console.WriteLine(livro2);

            Console.ReadLine();
        }
    }
}
