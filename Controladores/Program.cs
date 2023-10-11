using Ejercicio3CalcuLog.Servicios;

namespace Ejercicio3CalcuLog.Controladores
{

    class Program
    {
        /// <summary>
        /// Metodo por el que iniciara la aplicacion
        /// jzg - 111023
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Ejercicio3MenuInterfaz im = new Ejercicio3MenuImplementacion();
            Ejercicio3CalculosLogInterfaz ic = new Ejercicio3CalculosLogImplementacion();



            bool cerrarMenu = false;
            int opcionSeleccionada;

            while (!cerrarMenu)
            {
                opcionSeleccionada = im.implementacionMenu();
                Console.WriteLine(opcionSeleccionada);
                switch (opcionSeleccionada)
                {
                    case 1:
                        Console.WriteLine("[info] - se cerrara el programa");
                        cerrarMenu = true;
                        break;

                    case 2:
                        Console.WriteLine("[info] - Igualdad");
                        ic.igualdad();
                        break;

                    case 3:
                        Console.WriteLine("[info] - Desigualdad");
                        ic.desigualdad();
                        break;

                    default:
                        Console.WriteLine("[info] - la opcion deseada no existe.");
                        break;
                }

            }

        }

    }

}