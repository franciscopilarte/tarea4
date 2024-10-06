using System;

namespace tarea4
{
    class Program
    {
        public static void Main(string[] args)
        {

            int CaTotal = 0;

            Console.WriteLine("Ingrese el Nombre del Grupo");
            string seccion = Console.ReadLine();

            do
            {
                Console.WriteLine("Ingrese la Asisitencia Total: ");
                CaTotal = Convert.ToInt32(Console.ReadLine());
                if (CaTotal < 0)
                {
                    Console.WriteLine("Ingrese un numero Positivo");
                }

            } while (CaTotal < 0);


            Console.WriteLine("Ingrese la Cantidad de Estudiante");
            int estudiante = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            string[] CaNombre = new string[estudiante];
            double[] CaAsis = new double[estudiante];



        }
    }
}