using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea__2
{
    public class Expresion1
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }


        public void pedir_digitos()
        {
            Console.WriteLine("Digite el primer numero");
            Num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero");
            Num2 = double.Parse(Console.ReadLine());

        }

        public void Sumar()
        {
            Console.WriteLine("La suma es: ");
            Console.WriteLine(Num1 + Num2);

        }

        public void dividir()
        {
            Console.WriteLine("La division es: ");
            Console.WriteLine(Num1 / Num2);

        }

        public void multiplicar()
        {

            Console.WriteLine("La Multiplicacion es: ");
            Console.WriteLine(Num1 * Num2);


        }

        public void restar()
        {
            Console.WriteLine("La resta es:");
            Console.WriteLine(Num1 - Num2);

        }

        public void Maximo()
        {
            if (Num1 > Num2)
            {
                Console.WriteLine("El maximo es: ");
                Console.WriteLine(Num1);

            }
            else
            {
                Console.WriteLine("El maximo es: ");
                Console.WriteLine(Num2);

            }

        }

        public void Minimo()
        {
            if (Num1 < Num2)
            {
                Console.WriteLine("El minimo es: ");
                Console.WriteLine(Num1);

            }
            else
            {
                Console.WriteLine("El minimo es: ");

                Console.WriteLine(Num2);

            }
            Console.ReadLine();
        }

        public void resultado()
        {
            Sumar();
            restar();
            multiplicar();
            dividir();
            Maximo();
            Minimo();
        }

    }
}
