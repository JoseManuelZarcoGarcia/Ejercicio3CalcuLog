using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3CalcuLog.Servicios
{
    internal class Ejercicio3CalculosLogImplementacion : Ejercicio3CalculosLogInterfaz
    {

        /// <summary>
        /// Metodo que pregunta y guarda el primer nuemro
        /// jzg - 111023
        /// </summary>
        /// <returns></returns>
        public string dameUnNum()
        {
            string numEscrito;

            Console.WriteLine("Escriba un numero: ");
            numEscrito = Convert.ToString(Console.ReadLine());

            return numEscrito;

        }

        /// <summary>
        /// Metodo que pregunta y guarda el segundo nuemro
        /// jzg - 111023
        /// </summary>
        /// <returns></returns>
        public string dameOtroNum()
        {
            string numEscrito;

            Console.WriteLine("Escriba otro numero: ");
            numEscrito = Convert.ToString(Console.ReadLine());

            return numEscrito;

        }

        /// <summary>
        /// Metodo que pregunta y suma los numeros
        /// jzg - 111023
        /// </summary>
        /// <returns></returns>
        public void igualdad()
        {
            string num1, num2;
            bool verdaderoFalso;

            num1 = dameUnNum();
            num2 = dameOtroNum();
            if (num1 == num2)
                verdaderoFalso = true;
            else
                verdaderoFalso = false;

            Console.WriteLine(verdaderoFalso);
        }

        /// <summary>
        /// Metodo que pregunta y resta los numeros
        /// jzg - 111023
        /// </summary>
        /// <returns></returns>
        public void desigualdad()
        {
            string num1, num2;
            bool verdaderoFalso;

            num1 = dameUnNum();
            num2 = dameOtroNum();

            if (num1 != num2)
                verdaderoFalso = true;
            else
                verdaderoFalso = false;

            Console.WriteLine(verdaderoFalso);
        }

    }
}
