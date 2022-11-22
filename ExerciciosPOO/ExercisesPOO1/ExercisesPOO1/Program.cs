using System;

namespace ExercisesPOO1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro cachorro = new Cachorro("Dobermann", 71);
            Gato gato = new Gato("Persa", 28);
            Passaro passaro = new Passaro("Beija-flor", 9);

            Console.WriteLine("Cachorro - " + cachorro);
            cachorro.EmitirSom();

            Console.WriteLine("Gato - " + gato);
            gato.EmitirSom();

            Console.WriteLine("Pássaro - " + passaro);
            passaro.EmitirSom();

            Console.ReadLine();
        }
    }
}
