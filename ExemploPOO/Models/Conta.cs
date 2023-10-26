using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public abstract class Conta
    {
        protected decimal Saldo { get; set; }

        public abstract void Creditar(decimal valor);

        public void ExibirSaldo(){
            Console.WriteLine($"Saldo: {Saldo}");
        }
    }
}