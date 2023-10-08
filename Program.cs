using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplicação Cálculos");
            Console.WriteLine($"4+2={Aritmetica.Somar(4,2)}");
            Console.WriteLine($"4-2={Aritmetica.Subtrair(4, 2)}");
            double t1 = Conversoes.ConverteTemperatura(Conversoes.ConvercaoTemperatura.CelciusFahr, 36);
            double t2 = Conversoes.ConverteTemperatura(Conversoes.ConvercaoTemperatura.FahrCelcius, 100);
            Console.WriteLine($" 36º Celcius={t1}º Fahrenheit");
            Console.WriteLine($" 100º Fahrenheit={t2}º Celcius");
            Console.ReadKey();
        }
    }
}
