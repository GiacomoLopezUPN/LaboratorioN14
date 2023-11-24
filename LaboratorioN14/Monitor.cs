using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioN14
{
    public class Pantallas
    {
        public static int[] edad = new int[1000];
        public static int[] voto = new int[1000];
        public static int contador = 0;
        public static int Principal()
        {
            string txt = "================================\n" +
                   "Encuesta Covid-19\n" +
                   "================================\n" +
                   "1: Realizar Encuesta\n" +
                   "2: Mostrar Datos de la encuesta\n" +
                   "3: Mostrar Resultados\n" +
                   "4: Buscar Personas por edad\n" +
                   "5: Salir\n" +
                   "================================\n";
            Console.Write(txt);
            return Operaciones.getEntero("Ingrese una opción: ", txt);
        }
        public static int EncuestaVacu()

        {
            string txt = " ================================\n" +
                "Encuesta de vacunación\n" +
                "================================\n";
            Console.Write(txt);
            int edad = Operaciones.getENTERO("¿Qué edad tienes: ");
            if (contador == 1000)
            {
                Console.WriteLine("LA LISTA YA ESTÁ LLENA");
            }
            else
            {
                string txt2 = "Te has vacunado\n" +
                "1: Sí\n" +
                "2: No\n" +
                "================================\n";
                Console.Write(txt2);
                int voto;
                do
                {
                    voto = Operaciones.getENTERO("Ingrese una opción: ");

                    if (voto != 1 && voto != 2)
                    {
                        Console.WriteLine("Ingresa una opción valida");
                    }
                } while (voto != 1 && voto != 2);

                Pantallas.edad[contador] = edad;
                Pantallas.voto[contador] = voto;
                contador++;
            }

            Console.Clear();
            return GraciasPorParticipar();
        }
        public static int GraciasPorParticipar()
        {
            string txt = " ================================\n" +
                "Encuesta de vacunación\n" +
                "================================\n" +
                " \n" +
                " \n" +
                "¡Gracias por participar!\n" +
                " \n" +
                " \n" +
                "================================\n" +
                "1: Regresar al menú\n" +
                "================================\n";
            Console.Write(txt);
            int opcion = Operaciones.getEntero("Ingrese una opción: ", txt);
            if (opcion == 1) return 0;
            return opcion;
        }
        public static int InfoEncuesta()
        {
            string txt = "================================\n" +
              "Datos de la encuesta\n" +
              "================================\n" +
              " \n" +
              "  ID |\tEdad |\tVacunado\n" +
              "================================\n";
            Console.Write(txt);

            if (contador == 0)
            {
                Console.WriteLine("No extisten notas");
            }
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine($"{i.ToString("D4")} | {edad[i].ToString().PadLeft(4)}  | {(voto[i] == 1 ? "Si" : "No").PadRight(2)}");
            }

            string txt2 = "================================\n" +
              "1: Regresar\n" +
              "================================\n";
            Console.Write(txt2);

            int opcion = Operaciones.getEntero("Ingrese una opción: ", txt);
            if (opcion == 1) return 0;
            return opcion;
        }
        public static int MostrarConclusion()
        {
            string txt = "================================\n" +
              "Resultados de la encuesta\n" +
              "================================\n";
            Console.Write(txt);

            int[] conteoPorOpcion = new int[3];
            int[] conteoedad = new int[7];

            for (int i = 0; i < contador; i++)
            {
                int OPCION = voto[i];
                conteoPorOpcion[OPCION]++;

                int edad = Pantallas.edad[i];

                if (edad >= 1 && edad <= 20)
                {
                    conteoedad[1]++;
                }
                else if (edad >= 21 && edad <= 30)
                {
                    conteoedad[2]++;
                }
                else if (edad >= 31 && edad <= 40)
                {
                    conteoedad[3]++;
                }
                else if (edad >= 41 && edad <= 50)
                {
                    conteoedad[4]++;
                }
                else if (edad >= 51 && edad <= 60)
                {
                    conteoedad[5]++;
                }
                else if (edad > 60)
                {
                    conteoedad[6]++;
                }
            }

            string txt2 = $"{conteoPorOpcion[1]} personas se han vacunado\n" +
              $"{conteoPorOpcion[2]} personas no se han vacunado\n" +
              " \n" +
              "Existen:\n" +
              $"{conteoedad[1]} personas entre 01 y 20 años\n" +
              $"{conteoedad[2]} personas entre 21 y 30 años\n" +
              $"{conteoedad[3]} personas entre 31 y 40 años\n" +
              $"{conteoedad[4]} personas entre 41 y 50 años\n" +
              $"{conteoedad[5]} personas entre 51 y 60 años\n" +
              $"{conteoedad[6]} personas de más de 61 años\n" +
              "================================\n" +
              "1: Regresar\n" +
              "================================\n";
            Console.Write(txt2);

            int opcion = Operaciones.getEntero("Ingrese una opción: ", txt);
            if (opcion == 1) return 0;
            return opcion;
        }
        public static int BuscarPersona()
        {
            string txt = "================================\n" +
              "Busca a personas por edad\n" +
              "================================\n";
            Console.Write(txt);

            int Buscar = Operaciones.getENTERO("¿Qué edad quieres buscar?: ");
            int vacunados = 0;
            int noVacunados = 0;
            bool numeroHallado = false;

            for (int i = 0; i < contador; i++)
            {
                if (Buscar == edad[i])
                {
                    if (voto[i] == 1)
                    {
                        vacunados++;
                    }
                    else if (voto[i] == 2)
                    {
                        noVacunados++;
                    }
                    numeroHallado = true;
                }
            }
            if (!numeroHallado)
            {
                Console.WriteLine("\nEl número ingresado no existe");
            }
            else
            {
                Console.WriteLine($"\n{vacunados} se vacunaron");
                Console.WriteLine($"{noVacunados} no se vacunaron");
            }
            string txt2 = " \n" +
              "================================\n" +
              "1: Regresar\n" +
              "================================\n";
            Console.Write(txt2);

            int opcion = Operaciones.getEntero("Ingrese una opción: ", txt);
            if (opcion == 1) return 0;
            return opcion;
        }
    }
}