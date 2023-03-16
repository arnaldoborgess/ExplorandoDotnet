using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tuplas.Models
{
    public class LeituraArquivo
    {
        // vai ler o arquivo e tipo de retorno é uma tupla = com bool, string e int
        public (bool Sucesso, string[] Linhas, int QuantidadeLinhas) LerArquivo(string caminho)
        {   
            try
            {
            string[] linhas = File.ReadAllLines(caminho);
            return(true, linhas, linhas.Count());
            
            }
            catch(Exception)
            {
                return (false, new string[0], 0);
            }
        }
    }
}