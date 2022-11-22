using System;

namespace ExercisesPOO1
{
    class Animal
    {
        public string Raca { get; set; }
        public double Tamanho { get; set; }

        public virtual void EmitirSom()
        {
        }

        public override string ToString()
        {
            Console.WriteLine();
            return "Raça: "
                + Raca
                + " - Tamanho: "
                + Tamanho
                + "cm ";
        }
    }
}
