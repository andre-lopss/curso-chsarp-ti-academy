using System;
using System.Text;
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
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nome do livro: " + NomeLivro);
            sb.AppendLine("Autores: ");
            foreach(Autor autor in Autores){ 
                sb.AppendLine(autor.ToString());
            }
            return sb.ToString() ;             
        }
    }
}    