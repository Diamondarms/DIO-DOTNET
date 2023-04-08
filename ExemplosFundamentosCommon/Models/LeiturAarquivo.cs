using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosFundamentos.Common.Models
{
    public class LeituraArquivo
    {
        public (bool sucesso, string[] linhas,int qtdLinhas) LerArquivo(string caminho){
            try{
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());
            } catch {
                return (false, new string[0], 0);
            }
        }
    }
}