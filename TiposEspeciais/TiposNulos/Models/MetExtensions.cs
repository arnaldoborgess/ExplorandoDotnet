using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiposNulos.Models
{
    public static class MetExtensions
    {
        public static bool EhPar(this int numero)
        {
            return numero % 2 == 0;
        }
    }
}