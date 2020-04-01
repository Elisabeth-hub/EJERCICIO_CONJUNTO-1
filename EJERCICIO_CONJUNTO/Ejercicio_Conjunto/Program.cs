using System;

namespace Ejercicio_Conjunto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("adios muy buenas");
        }
        static void anadirDato()
        {
            Console.Write("pon lo que quieras añadir");
            string datoAnadir = Console.ReadLine();
            if (cantidad<capacidad)
            {
                nombre[cantidad] = datoAnadir;
                cantidad++;
            }
        }

        static void mostrarDatos()
        {
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write("{0}, ",nombres[i]);
            }
        }
        

        //Prueba commit 2
    }
}
