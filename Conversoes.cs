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
        /// <summary>
        /// Conversao de temperaturas
        /// </summary>
        public enum ConvercaoDistancias
        {
            Nulo = 0, MetrosMilhas,
            MilhasMetros
        }

        public static double ConverteDistancias(ConvercaoDistancias Conversao, double Distancia)
        {
            if (Conversao == ConvercaoDistancias.MilhasMetros)
            {
                return (Distancia * 0.00006213712);
            }
            else if (Conversao == ConvercaoDistancias.MetrosMilhas)
            {
                return Distancia* 1609.344;
            }
            return -1;
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
