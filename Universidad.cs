using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static tarea4.Universidad.Estudiante;
using static tarea4.Universidad;

namespace tarea4
{
    public class Universidad
    {

        public class Estudiante
        {
            public string Nombre { get; set; }
            public double SesionesT { get; set; } // Total de sesiones
            public double SesionesA { get; set; } // Asistencias

            public class Asistencia
            {
                public static double Porcentaje(double asistencias, double totalSesiones)
                {
                    if (totalSesiones == 0)
                    {
                        return 0; // Evitar división por cero
                    }
                    return (asistencias / totalSesiones) * 100;
                }
            }

        }

    }

    public static class Extensiones
    {
        public static void MostrarInformacion(this Estudiante texto)
        {
            double asistencia = Asistencia.Porcentaje(texto.SesionesA, texto.SesionesT);
            Console.WriteLine($"Nombre del Estudiante: {texto.Nombre}");
            Console.WriteLine($"Total de Sesiones: {texto.SesionesT}");
            Console.WriteLine($"Sesiones Asistidas: {texto.SesionesA}");
            Console.WriteLine($"Porcentaje de Asistencia: {asistencia}%");

            if (asistencia >= 75)
            {
                Console.WriteLine("El estudiante cumple con el requisito de asistencia.");
            }
            else
            {
                Console.WriteLine("El estudiante NO cumple con el requisito de asistencia.");
            }
        }
    }

}
