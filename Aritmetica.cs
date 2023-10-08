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
        

        public enum ConvercaoTemperatura
        {
            Nulo=0, CelciusFahr,
            FahrCelcius
        }
        public double ConverteTemperatura(ConvercaoTemperatura Conversao, double Temperatura)
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
