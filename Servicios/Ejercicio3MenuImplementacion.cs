using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3CalcuLog.Servicios
{
    internal class Ejercicio3MenuImplementacion : Ejercicio3MenuInterfaz
    {

        /// <summary>
        /// Metodo que inserta el menu
        /// jzg - 111023
        /// </summary>
        /// <returns></returns>
        public int implementacionMenu()
        {

            int eleccionSeleccionada;

            Console.WriteLine("###############################");
            Console.WriteLine("1. Cerrar ");
            Console.WriteLine("2. Igualdad ");
            Console.WriteLine("3. Desigualdad ");
            Console.WriteLine("###############################");
            Console.WriteLine("seleccione una opcion");

            eleccionSeleccionada = Console.ReadKey(true).KeyChar - ('0');

            return eleccionSeleccionada;
        }

    }
}
