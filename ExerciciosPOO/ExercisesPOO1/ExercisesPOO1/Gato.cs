using System;

namespace ExercisesPOO1
{
    class Gato : Animal
    {
        public Gato(string raca, double tamanho)
        {
            Raca = raca;
            Tamanho = tamanho;
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Miau!");
        }
    }
}
