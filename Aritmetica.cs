using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// Implementa operações aritméticas
    /// </summary>
    internal class Aritmetica
    {
        /// <summary>
        /// Operação soma.
        /// </summary>
        /// <returns>Retorma a soma de 2 números</returns>
        public int Somar(int x, int y)
        {
            return x + y;
        }
        /// <summary>
        /// OPeração Subtrair
        /// </summary>

        /// <returns>Retorma a diferença de 2 números</returns>
        public int Subtrair(int x, int y)
        {
            return x - y;
        }
    }
}
