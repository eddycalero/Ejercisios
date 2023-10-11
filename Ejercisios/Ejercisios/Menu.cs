using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercisios
{
    public class Menu
    {
        public Menu() 
        {
            
        }

        public void MenuOpciones()
        {
            bool salir = false;
            Empleado a = new Empleado();
            while (!salir)
            {

                try
                {
                    Console.WriteLine("***Binevenido**");
                    Console.WriteLine("1.Calcular el Bono Anual");
                    Console.WriteLine("2. Calcular Su Masa Corporal");
                    Console.WriteLine("3. Salir");
                    Console.WriteLine("Elige una de las opciones");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Ingrese su Antiguedad");
                            decimal antiguedad = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine("Ingrese su rendimiento");
                            decimal rendimiento = Convert.ToDecimal(Console.ReadLine());
                            a.CalcularBono(antiguedad,rendimiento);
                            break;
                        case 2:
                           
                            Console.WriteLine("Ingrese su Altura");
                            decimal altura = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine("Ingrese su Peso");
                            decimal peso = Convert.ToDecimal(Console.ReadLine());
                            a.CalculaIMC(altura,peso);
                            break;
                        case 3:
                            Console.WriteLine("Has elegido la opción 3");
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Elige una opcion entre 1 y 3");
                            break;
                    }

                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

          

        }

    }

}

