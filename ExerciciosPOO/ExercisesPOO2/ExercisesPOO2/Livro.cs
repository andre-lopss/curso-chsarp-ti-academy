using System;
using System.Collections.Generic;

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
            foreach(Autor autor in autoresLivro){ 
                Console.WriteLine(autor);
            }
            return " ";             
        }
    }
}    