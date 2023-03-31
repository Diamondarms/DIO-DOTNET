using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosFundamentos.Common.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, string sobrenome){
            Nome = nome;
            SobreNome = sobrenome;
        }
        public Pessoa() { }

        private string _nome;
        private int _idade;
        public string Nome{ 
            get => _nome;
            set{
                if (value == "") {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            } 
        }
        public string SobreNome { get; set; }
        public string NomeCompleto => $"{Nome} {SobreNome}".ToUpper();
        public int Idade {
            get => _idade;
            set{
                if (value < 0) {
                    throw new ArgumentException("Idade Inválida");
                }
                _idade = value;
            }
            
        }

        public void Apresentar(){
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}