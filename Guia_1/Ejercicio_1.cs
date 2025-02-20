using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_1
{
    public class Ejercicio_1
    {
        /*
          Capturar 3 notas, sacar el Promedio y determinar si el estudiante ganó o perdió la asignatura 
        (Mayor o igual a 3 ganó en caso contrario Perdió)
         */

        //constantes
        const float PORC_NOTA1 = 0.3F;
        const float PORC_NOTA2 = 0.3F;
        const float PORC_NOTA3 = 0.4F;

        //variables
        public List<Persona> personas = new List<Persona>();

        //funciones
        public void CapturarNotas()
        {
            Persona persona = new Persona();
            Console.Clear();
            Console.WriteLine("SISTEMA DE GESTION DE NOTAS");

            Console.Write("Nombre Estudiante: ");
            persona.nombre = Console.ReadLine();

            Console.Write("NOTA 1: ");
            persona.nota1 = float.Parse(Console.ReadLine());

            Console.Write ("NOTA 2: ");
            persona.nota2 = float.Parse(Console.ReadLine());

            Console.Write ("NOTA 3: ");
            persona.nota3 = float.Parse(Console.ReadLine());

            Console.WriteLine("datos cargados correctamente");

            personas.Add(persona);
            Console.ReadKey();

        }

        public string Eliminar(Persona persona)
        {
            try
            {
                if (persona != null)
                {
                    personas.Remove(persona);
                    return "Estudiante eliminado";
                }
                return "Estudiante no existe";

            }
            catch (Exception e)
            {
                return $"{e.Message}";
            }

        }

        public string Actualizar(Persona persona)
        {
            try
            {
                if (persona != null)
                {
                    Console.Write("NOTA 1: ");
                    persona.nota1 = float.Parse(Console.ReadLine());
                    Console.Write("NOTA 2: ");
                    persona.nota2 = float.Parse(Console.ReadLine());
                    Console.Write("NOTA 3: ");
                    persona.nota3 = float.Parse(Console.ReadLine());
                    return "Estudiante actualizado";
                }

                return "Estudiante no existe";
            }
            catch (Exception e)
            {
                return $"{e.Message}";
            }
        }

        public Persona BuscarPersona(string nombre)
        {
            foreach (var persona in personas)
            {
                if(persona.nombre == nombre)
                {
                    return persona;
                }
            }

            return null;
        }

        private float CalcularPromedio(Persona persona)
        {
            return persona.nota1 * PORC_NOTA1 + persona.nota2 * PORC_NOTA2 + persona.nota3 * PORC_NOTA3;
        }

        private string EstadoEstudiante(Persona persona)
        {
            if (CalcularPromedio(persona)>=3)
            {
                return "Eres un Estudiante Feliz ...";
            }
            return "siga intentando ...";
        }

        public void ImprimirResultado()
        {
            Console.Clear();
            
            Console.SetCursorPosition(20,2); Console.Write("NOMBRE     NOTA 1     NOTA 2     NOTA 3     DEFINITIVA");
            int i = 0;
            foreach (Persona persona in personas)
            {
                Console.SetCursorPosition(20,3 + i); Console.Write(persona.nombre);
                Console.SetCursorPosition(32,3 + i); Console.Write(persona.nota1.ToString("0.0"));
                Console.SetCursorPosition(43,3 + i); Console.Write(persona.nota2.ToString("0.0"));
                Console.SetCursorPosition(54,3 + i); Console.Write(persona.nota3.ToString("0.0"));
                Console.SetCursorPosition(65,3 + i); Console.Write(CalcularPromedio(persona).ToString("0.0"));
                i++;
            }

            Console.ReadKey();
        }
    
    
    }
}

            //Console.WriteLine("SISTEMA DE GESTION DE NOTAS");
            //Console.WriteLine("Nombre: " + persona.nombre);
            ////Console.WriteLine(nombre);
            //Console.WriteLine($"Primer Parcial {persona.nota1.ToString("0.0")}");
            ////Console.WriteLine(nota1);
            //Console.Write("Segundo Parcial ");
            //Console.WriteLine(persona.nota2.ToString("0.0"));
            //Console.Write("Examen Final ");
            //Console.WriteLine(persona.nota3.ToString("0.00"));
            //Console.Write("DEfinitiva ");
            //Console.WriteLine(CalcularPromedio().ToString("0.00"));
            //Console.WriteLine(EstadoEstudiante());