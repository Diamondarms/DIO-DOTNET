using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial){
            NumeroConta = numeroConta;
            Saldo = saldoInicial;
        }
        
        public int NumeroConta { get; set; }
        private decimal Saldo;

        public void Sacar(decimal valor){
            if(Saldo >= valor){
                Saldo -= valor;
                Console.WriteLine("Saque efetuado");
            }else{
                Console.WriteLine("valor maior que saldo disponível");
            }
        }

        public void ExibirSaldo(){
            Console.WriteLine($"Saldo: {Saldo}");
        }
    }
}