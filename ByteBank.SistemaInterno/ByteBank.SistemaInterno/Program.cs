﻿using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaInterno
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(458, 455789);

            Console.WriteLine(conta.Saldo);

            new ContaCorrente(456, 545);
            conta.Sacar(-10);
            string nome = "Guilherme";




            Console.ReadLine();
        }
    }
}
