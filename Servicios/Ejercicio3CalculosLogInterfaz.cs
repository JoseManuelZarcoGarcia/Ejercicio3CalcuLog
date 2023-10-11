using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3CalcuLog.Servicios
{
    internal interface Ejercicio3CalculosLogInterfaz
    {

        /// <summary>
        /// Llamada al metodo que pregunta el primer numero
        /// jzg - 111023
        /// </summary>
        /// <returns></returns>
        public string dameUnNum();

        /// <summary>
        /// Llamada al metodo que pregunta el segundo numero
        /// jzg - 111023
        /// </summary>
        /// <returns></returns>
        public string dameOtroNum();

        /// <summary>
        /// Llamada al metodo que implementa el metodo igualdad
        /// jzg - v
        /// </summary>
        /// <returns></returns>
        public void igualdad();

        /// <summary>
        /// Llamada al metodo que implementa el metodo desigualdad
        /// jzg - 111023
        /// </summary>
        /// <returns></returns>
        public void desigualdad();

    }
}
