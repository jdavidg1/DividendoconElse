using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DividendoconElse
{
    class Program
    {
        static void Main(string[] args)
        {

            float dividendo = 1.0f;
            float divisor = 1.0f;
            float resultado = 1.0f;


            Console.WriteLine("Cual es el dividendo: ");
            dividendo = Convert.ToSingle(Console.ReadLine());


            Console.WriteLine("Cual es el divisor: ");
            divisor = Convert.ToSingle(Console.ReadLine());

            if(divisor!=0)

            {
                resultado = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("El resultado de dividir {0} por {1} es {2}", dividendo, divisor, resultado);
            }

            else
            {
                Console.WriteLine("La división por cero no se puede hacer");

            }

            Console.ReadKey();
        }
    }
}
