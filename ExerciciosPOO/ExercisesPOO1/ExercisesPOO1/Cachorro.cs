using System;

namespace ExercisesPOO1
{
    class Cachorro : Animal
    {
        public Cachorro(string raca, double tamanho)
        {
            Raca = raca;
            Tamanho = tamanho;
        }
        public override void EmitirSom()
        {
            Console.WriteLine("Som: Auau!");
        }

    }
}
