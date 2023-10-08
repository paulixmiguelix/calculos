using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    internal static class Conversoes
    {
        /// <summary>
        /// Conversao de temperaturas
        /// </summary>
        public enum ConvercaoTemperatura
        {
            Nulo = 0, CelciusFahr,
            FahrCelcius
        }

        public static double ConverteTemperatura(ConvercaoTemperatura Conversao, double Temperatura)
        {
            if (Conversao == ConvercaoTemperatura.CelciusFahr)
            {
                return (Temperatura * 1.80000 + 32);
            }
            else if (Conversao == ConvercaoTemperatura.FahrCelcius)
            {
                return ((Temperatura - 32) / 1.8000);
            }
            return -1;
        }
    }
}
