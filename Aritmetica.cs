using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    ///<summary>
    /// Implementa operações aritméticas.
    /// </summary>
    
    internal static class Aritmetica 
    {
        /// <summary>
        /// Tipo de Conversão de temperarura a executar.
        /// </summary>

        public enum ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius


        }
        ///<summary>
        /// Operação soma.
        /// </sumary>
        /// <returns>Retorna a soma de dois números.</returns>

        public static int Somar(int x, int y)
        {
            return x + y;
        }
        ///<summary>
        /// Operação de subtração.
        /// <returns>Retorna o resultado da subtração de dois números.</returns>
        public static int Subtrair(int x, int y)
        {
            return x - y;
        }
    }
}     
    