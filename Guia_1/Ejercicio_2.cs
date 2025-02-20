using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_1
{
    public class Ejercicio_2
    {
        /*
           Calcular el número de pulsaciones que debe tener una persona por cada 10 segundos 
           de ejercicio aeróbico; la formula que se aplica cuando:
           
           el sexo es femenino es: 
           pulsaciones = (220 -edad)/10
           
           si el sexo es masculino: 
           pulsaciones = (210 -edad)/10
         */

        public void CapturarDatos()
        {
            Persona2 persona2 = new Persona2();

            Console.Write("Sexo: ");
            persona2.sexo = Console.ReadLine();
            Console.Write("Edad: ");
            persona2.edad = int.Parse(Console.ReadLine());
        }

        public int CalcularPulsaciones(Persona2 persona2)
        {
            if (persona2.sexo == "f") 
            {
                return (220 - persona2.edad) / 10;
            }
                return (210 - persona2.edad) / 10;
        }
    }
}
