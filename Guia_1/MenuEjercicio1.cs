using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_1
{
    public class MenuEjercicio1
    {
        Ejercicio_1 ejercicio_1 = new Ejercicio_1();
        public void Menu1()
        {
            Persona persona = new Persona();
            int op;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(10, 2); Console.Write("G E S T I O N  D E  N O T A S");
                Console.SetCursorPosition(12, 4); Console.Write("1. CAPTURAR NOTAS");
                Console.SetCursorPosition(12, 6); Console.Write("2. INFORME DE NOTAS");
                Console.SetCursorPosition(12, 8); Console.Write("3. ELIMINAR ESTUDIANTE");
                Console.SetCursorPosition(12, 10); Console.Write("4. ACTUALIZAR INFORMACION DE ESTUDIANTE ");
                Console.SetCursorPosition(12, 12); Console.Write("9. VOLVER AL MENU PRINCIPAL ");

                Console.SetCursorPosition(12, 15); Console.Write("Digite una opcion: ");
                Console.SetCursorPosition(32, 15); op = int.Parse(Console.ReadLine());


                switch (op)
                {
                    case 1:
                        ejercicio_1.CapturarNotas();
                        break;
                    case 2:
                        ejercicio_1.ImprimirResultado();
                        break;
                    case 3:
                        Eliminar();
                        break;
                    case 4:
                        Actualizar();
                        break;
                    case 9:
                        Console.Clear();
                        break;
                }

            } while (op != 9);

        }

        public void Eliminar()
        {
            Console.Clear();
            string nombre;
            Persona persona = new Persona();
            Console.WriteLine("Digite nombre: ");
            nombre = Console.ReadLine();

            persona = ejercicio_1.BuscarPersona(nombre);
            var msj = ejercicio_1.Eliminar(persona);
            Console.WriteLine(msj);
            Console.ReadKey();
        }

        public void Actualizar()
        {
            Console.Clear();
            string nombre;
            Persona persona = new Persona();
            Console.WriteLine("Digite nombre: ");
            nombre = Console.ReadLine();

            persona = ejercicio_1.BuscarPersona(nombre);
            var msj = ejercicio_1.Actualizar(persona);
            Console.WriteLine(msj);
            Console.ReadKey();
        }
    }
}
