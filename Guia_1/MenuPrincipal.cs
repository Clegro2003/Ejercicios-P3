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
                Console.SetCursorPosition(12,4); Console.Write("1. Gestion de Notas");
                Console.SetCursorPosition(12, 5); Console.Write("2. Calcular el número de pulsaciones ");
                Console.SetCursorPosition(12, 7); Console.Write("3. información financiera ");
                Console.SetCursorPosition(12, 10); Console.Write("9. Salir ");

                Console.SetCursorPosition(12, 19); Console.Write("digite una opcion: ");
                Console.SetCursorPosition(32, 19); op = int.Parse(Console.ReadLine());


                switch (op)
                {
                    case 1:
                        //MenuEjecicio1();
                        Ejercicio_1 ejercicio_1 = new Ejercicio_1();
                        ejercicio_1.CapturarNotas();
                        ejercicio_1.ImprimirResultado();
                        //Console.WriteLine( " aqui va el codigo del menu de ej1");
                        break;
                    case 2:
                        Console.WriteLine("el code ej2");
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
    }
}
