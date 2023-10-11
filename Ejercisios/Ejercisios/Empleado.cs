using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercisios
{
    public class Empleado
    {
        public Empleado()
        {

        }

        public decimal CalculaIMC(decimal Altura,decimal peso)
        {
            decimal MasaCorporal = 0;
            try
            {
              MasaCorporal = peso / suma(Altura , Altura);
               Console.WriteLine("Su Masa Corporal es de: " + MasaCorporal.ToString());
            }catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }

            return MasaCorporal;
        }

        public void CalcularBono(decimal antiguedad, decimal rendimiento)
        {

            try
            {
                if ((antiguedad >= 5) && (rendimiento == 5))
                {
                    Console.WriteLine("su bono es del 20%");
                }
                else if ((antiguedad >= 5) && (rendimiento > 5))
                {
                    Console.WriteLine("su bono es del 10%");
                }
                else if ((antiguedad < 5) && (rendimiento == 5))
                {
                    Console.WriteLine("su bono es del 15%");
                }
                if ((antiguedad != 5) && (rendimiento != 5))
                {
                    Console.WriteLine("su bono es del 5%");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

       public decimal suma(decimal a , decimal b) 
        {
          decimal resp = a * b;

           return resp;
        }

    }
}