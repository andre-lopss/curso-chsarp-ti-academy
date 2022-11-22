using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesPOO2
{
    class Autor
    {
        private string NomeAutor { get; set; }
        private string EmailAutor { get; set; }

        public Autor(string nome, string email)
        {
            NomeAutor = nome;
            EmailAutor = email;
        }

        public override string ToString()
        {
            return "Nome: " + NomeAutor + " - Email: " + EmailAutor;
        }
    }
}
