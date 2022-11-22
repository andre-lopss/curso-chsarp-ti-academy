using System;

namespace ExercisesPOO2
{
    class Livro
    {
        private String NomeLivro { get; set; }
        private Autor[] autoresLivro;

        public Livro(string nomeLivro, Autor[] autor)
        {
            NomeLivro = nomeLivro;
            autoresLivro = autor;
        }
  
        public override string ToString()
        {
            Console.Write("Nome do Livro: ");
            Console.WriteLine(NomeLivro);
            Console.WriteLine("Autores: ");
            int i;
            for (i = 0; i < autoresLivro.Length; i++)
            {
                Console.WriteLine(autoresLivro[i]);
            }
            return " ";             
        }
    }
}    