using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExplorandoDotnet.Throw.Models
{
    public class ExemploExcecao
    {
        public void Metodo01()
        {
            try
            {
                Metodo02();
            } catch(Exception ex)
            {
                System.Console.WriteLine("Exceção tratada." + ex.Message);
            }
        }
        public void Metodo02()
        {
            Metodo03();
        }
        public void Metodo03()
        {
            Metodo04();
        }

        public void Metodo04()
        {
            throw new Exception("Ocorreu uma execeção");
        }
    }
}