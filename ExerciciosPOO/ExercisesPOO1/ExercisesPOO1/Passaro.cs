using System;

namespace ExercisesPOO1
{
    class Passaro : Animal
    {
        public Passaro(string raca, double tamanho)
        {
            Raca = raca;
            Tamanho = tamanho;
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Piu piu!");
        }
    }
}
