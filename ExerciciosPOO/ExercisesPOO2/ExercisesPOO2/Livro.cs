﻿using System;
using System.Collections.Generic;

namespace ExercisesPOO2
{
    class Livro
    {
        private string NomeLivro { get; set; }
        private List<Autor> Autores = new List<Autor>();

        public Livro(string nomeLivro, List<Autor> autores)
        {
            NomeLivro = nomeLivro;
            this.Autores = autores;
        }

        public override string ToString()
        {
            Console.Write("Nome do Livro: ");
            Console.WriteLine(NomeLivro);
            Console.WriteLine("Autores: ");
            foreach(Autor autor in Autores){ 
                Console.WriteLine(autor);
            }
            return " ";             
        }
    }
}    