﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// Implementa operações aritméticas
    /// </summary>
    internal static class Aritmetica
    {
        /// <summary>
        /// Operação soma.
        /// </summary>
        /// <returns>Retorma a soma de 2 números</returns>
        

       
        
        public static int Somar(int x, int y)
        {
            return x + y;
        }
        /// <summary>
        /// OPeração Subtrair
        /// </summary>

        /// <returns>Retorma a diferença de 2 números</returns>
        public static int Subtrair(int x, int y)
        {
            return x - y;
        }
        public static int Multiplicar(int x, int y)
        {
            return x * y;
        }
    }
}
