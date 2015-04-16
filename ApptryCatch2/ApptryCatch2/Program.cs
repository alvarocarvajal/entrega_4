using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("                     ");
            Console.WriteLine(" ====================");
            Console.WriteLine(" Programa Try Cacth 2 ");
            Console.WriteLine(" ====================");
            Console.WriteLine("                     ");
            Console.WriteLine("                     ");


            Console.WriteLine("                     ");
            Console.WriteLine(" Tabla De Multiplicar Del 5 ");
            Console.WriteLine(" ==========================");
            Console.WriteLine("                     ");
            Console.WriteLine("                     ");

            int numero, contador = 1;
            for (numero = 5; numero <= 50; numero = numero + 5)
            {
                Console.WriteLine(" 5 x  " + contador + " = " + numero);

                contador = contador + 1;

                if (contador == 10)
                {
                    numero = 50;
                    Console.WriteLine(" 5 x " + contador + " = " + numero);
                    break;
                }

            }


            // try
            // {
            //    resultado = 5 / numero;
            // }

            // catch (Exception error)
            // {
            //     Console.WriteLine("                             ");
            //    Console.WriteLine("                             ");
            //    Console.WriteLine(" El Error Es: " + error.Message);
            //}

            Console.WriteLine("                             ");
            Console.WriteLine("                             ");
            Console.WriteLine("                             ");
            Console.WriteLine(" Elaboro <<Ing Alvaro Carvajal>> ");
            Console.Write(" Universidad Simon Bolivar - Ext. Cucuta ");
            Console.ReadKey();

        }
    }
}
