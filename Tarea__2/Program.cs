using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea__2;

class Program
{
    public static void Main(string[] args)
    {


        Expresion1 ex = new Expresion1();

        ex.pedir_digitos();
        ex.Sumar();
        ex.dividir();
        ex.multiplicar();
        ex.restar();
        ex.Maximo();
        ex.Minimo();

        Expresion1 ex2 = new Expresion1();
        ex2.pedir_digitos();
        ex2.Sumar();
        ex2.dividir();
        ex2.multiplicar();
        ex2.restar();
        ex2.Maximo();
        ex2.Minimo();

    }
}
