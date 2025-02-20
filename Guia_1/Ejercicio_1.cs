using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_1
{
    public class Ejercicio_1
    {
        //constantes
        const float PORC_NOTA1 = 0.3F;
        const float PORC_NOTA2 = 0.3F;
        const float PORC_NOTA3 = 0.4F;

        //variables
        public string nombre;
        public float nota1;
        public float nota2;
        public float nota3;

        //funciones
        public void CapturarNotas()
        {
            Console.Clear();
            Console.WriteLine("SISTEMA DE GESTION DE NOTAS");

            Console.Write("Nombre Estudiante: ");
            nombre = Console.ReadLine();

            Console.Write("NOTA 1: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.Write ("NOTA 2: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.Write ("NOTA 3: ");
            nota3 = float.Parse(Console.ReadLine());

            Console.WriteLine("datos cargados correctamente");
            Console.ReadKey();

        }

        private float CalcularPromedio()
        {
            //float promedio;
            //promedio = nota1 * PORC_NOTA1 + nota2 * PORC_NOTA2 + nota3 * PORC_NOTA3;
            //return promedio;

            return nota1 * PORC_NOTA1 + nota2 * PORC_NOTA2 + nota3 * PORC_NOTA3;
        }

        private string EstadoEstudiante()
        {
            if (CalcularPromedio()>=3)
            {
                return "Eres un Estudiante Feliz ...";
            }
            return "siga intentando ...";
        }

        public void ImprimirResultado()
        {
            Console.Clear();
            Console.WriteLine("SISTEMA DE GESTION DE NOTAS");
            Console.WriteLine("Nombre: " + nombre);
            //Console.WriteLine(nombre);
            Console.WriteLine($"Primer Parcial {nota1.ToString("0.0")}");
            //Console.WriteLine(nota1);
            Console.Write("Segundo Parcial ");
            Console.WriteLine(nota2.ToString("0.0"));
            Console.Write("Examen Final ");
            Console.WriteLine(nota3.ToString("0.00"));
            Console.Write("DEfinitiva ");
            Console.WriteLine(CalcularPromedio().ToString("0.00"));
            Console.WriteLine(EstadoEstudiante());

            Console.ReadKey();
        }
    }
}
