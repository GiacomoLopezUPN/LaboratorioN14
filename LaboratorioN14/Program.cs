using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioN14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = Pantallas.Principal();
            do
            {
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        opcion = Pantallas.EncuestaVacu();
                        break;
                    case 2:
                        opcion = Pantallas.InfoEncuesta();
                        break;
                    case 3:
                        opcion = Pantallas.MostrarConclusion();
                        break;
                    case 4:
                        opcion = Pantallas.BuscarPersona();
                        break;
                    case 0:
                    default:
                        opcion = Pantallas.Principal();
                        break;
                }
            } while (opcion != 5);

        }
    }
}