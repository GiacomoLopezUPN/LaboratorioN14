using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioN14
{
    public class Operaciones
    {
        public static int getEntero(string prefijo, string sustitución)
        {

            int respuesta = 0;
            bool correcto = false;

            do
            {
                string numTxT = getTextoPantalla(prefijo);
                correcto = int.TryParse(numTxT, out respuesta);
                if (!correcto)
                {
                    Console.Clear();
                    Console.WriteLine(sustitución);
                    Console.WriteLine("Ingresa un número válido");
                }

            } while (!correcto);

            return respuesta;

        }
        public static int getENTERO(string prefijo)
        {
            int respuesta = 0;
            bool correcto = false;

            do
            {
                string numTxT = getTextoPantalla(prefijo);
                correcto = int.TryParse(numTxT, out respuesta);
                if (!correcto)
                {
                    Console.Clear();
                    Console.WriteLine("Ingresa un número válido");
                }

            } while (!correcto);

            return respuesta;
        }
        public static float getDecimal(string prefijo)
        {
            float respuesta = 0;
            bool correcto = false;

            do
            {
                string numTxT = getTextoPantalla(prefijo);
                correcto = float.TryParse(numTxT, out respuesta);
                if (!correcto)
                {
                    Console.WriteLine("Ingresa un número válido");
                }

            } while (!correcto);

            return respuesta;
        }

        public static string getTextoPantalla(string prefijo)
        {
            Console.Write(prefijo);
            return Console.ReadLine();
        }
    }
}
