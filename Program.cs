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
                Console.WriteLine("Ingrese la Asistencia Total: ");
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
            double[] CaAsi = new double[estudiante];


            for (int i = 0; i < CaNombre.Length; i++)
            {
                Console.WriteLine();

                Console.WriteLine($"Nombre del Estudiante {i + 1} ");
                CaNombre[i] = Convert.ToString(Console.ReadLine());

                do
                {

                    Console.WriteLine("Ingrese la Sesiones Asistida: ");
                    CaAsi[i] = Convert.ToDouble(Console.ReadLine());
                    if (CaAsi[i] < 0)
                    {

                        Console.WriteLine("Ingrese un numero Positivo");
                    }

                } while (CaAsi[i] < 0 || CaAsi[i] > CaTotal);


                var universidad = new Universidad.Estudiante
                {

                    Nombre = CaNombre[i],
                    SesionesT = CaTotal,
                    SesionesA = CaAsi[i],

                };


                universidad.MostrarInformacion();

         
             }

            Console.WriteLine();
            Console.WriteLine("Los Nombre Ingresados Fueron: ");
            foreach (var i in CaNombre)
            {
                Console.WriteLine(i);
            }
        }
    }
}