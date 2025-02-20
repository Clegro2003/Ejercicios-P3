using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_1
{
    public class MenuPrincipal
    {
        
        public void Menu()
        {
            int op;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(10,2); Console.Write("M E N U   P R I N C I P A L");
                Console.SetCursorPosition(12,4); Console.Write("1. GESTION DE NOTAS");
                Console.SetCursorPosition(12, 5); Console.Write("2. CARLCULAR NUMERO DE PULSACIONES");
                Console.SetCursorPosition(12, 7); Console.Write("3. INFORMACION FINANCIERA");
                Console.SetCursorPosition(12, 10); Console.Write("9. SALIR ");

                Console.SetCursorPosition(12, 19); Console.Write("Digite una opcion: ");
                Console.SetCursorPosition(32, 19); op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        MenuEjercicio1 menuEjecicio1 = new MenuEjercicio1();
                        menuEjecicio1.Menu1();
                        break;
                    case 2:
                        Ejercicio2();
                        break;
                    case 3:
                        Console.WriteLine("code eje3");
                        break;
                    case 9:
                        Console.Clear();
                        Console.WriteLine("gracias por usar productos johnp");
                        Console.ReadKey();
                        break;
                }

            } while (op!=9);

        }

        public void Ejercicio2()
        {
            Console.Clear();
            Persona2 persona2 = new Persona2();
            Ejercicio_2 ejercicio_2 = new Ejercicio_2();
            ejercicio_2.CapturarDatos();
            var msj = ejercicio_2.CalcularPulsaciones(persona2);
            Console.WriteLine($"Tuvo {msj.ToString("0,0")} pulsaciones");
            Console.ReadKey();
        }
    }
}
