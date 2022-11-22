﻿using System;
using Aula05.Models;

namespace Aula05
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente c1 = new ContaCorrente();
            c1.Nome = "Leonardo";
            c1.Numero = 1234;
            c1.Agencia = 1111;
            c1.Tarifa = 2;
            c1.Depositar(100);
            c1.ExibirResumoConta();

            Console.WriteLine("\n");

            ContaPoupanca c2 = new ContaPoupanca();
            c2.Nome = "Eduardo";
            c2.Numero = 4987;
            c2.Agencia = 2222;
            c2.Juros = 15;
            c2.Depositar(200);
            c2.ExibirResumoConta();

            Console.ReadLine();
        }
    }
}
