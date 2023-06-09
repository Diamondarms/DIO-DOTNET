using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosFundamentos.Common.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa p){
            Alunos.Add(p);
        }

        public void RemoverAluno(Pessoa p){
            if(Alunos.Contains(p))
                Alunos.Remove(p);   

        }

        public int ObterQuantidadeDeAlunosMatriculados(){
            return Alunos.Count;
        }

        public void ListarAlunos(){
            /*foreach(Pessoa p in Alunos){
                Console.WriteLine($"Nome do Aluno: {p.NomeCompleto}");
            }*/
            for(int i=0;i<Alunos.Count;i++){
                Console.WriteLine($"Aluno {i+1}: {Alunos[i].NomeCompleto}");
            }
        }
    }
}