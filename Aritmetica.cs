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
    internal static class Aritmetica
    {
        /// <summary>
        /// Operação soma.
        /// </summary>
        /// <returns>Retorma a soma de 2 números</returns>
        

        public static enum ConvercaoTemperatura
        {
            Nulo=0, CelciusFahr,
            FahrCelcius
        }
        public static double ConverteTemperatura(ConvercaoTemperatura Conversao, double Temperatura)
        {
            if (Conversao==ConvercaoTemperatura.CelciusFahr)
            {
                return (Temperatura*1.80000+32);
            }else if (Conversao==ConvercaoTemperatura.FahrCelcius)
            {
                return ((Temperatura - 32 )/ 1.8000);
            }
            return -1;
        }
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
    }
}
