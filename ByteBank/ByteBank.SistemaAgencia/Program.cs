﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFimPagamento = new DateTime(2021, 1, 30);
            DateTime dataCorrente = DateTime.Now;
            TimeSpan diferenca = dataFimPagamento - dataCorrente;

            string mensagem = "Vencimento em: " + GetIntervaloDeTempoLegivel(diferenca);
            Console.WriteLine(mensagem);
            
            Console.ReadLine();
        }

        static string GetIntervaloDeTempoLegivel(TimeSpan timeSpan)
        {
            if(timeSpan.Days > 30)
            {
                int quantidadeMeses = timeSpan.Days / 30;
                if(quantidadeMeses == 1)
                {
                    return "1 mes";
                }
                return quantidadeMeses + " meses";
            }
            else if(timeSpan.Days > 7)
            {
                int quantidadeSemanas = timeSpan.Days / 7;

            }
            return timeSpan.Days + " dias";
        }
    }
}
