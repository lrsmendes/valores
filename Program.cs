using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nome
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicio!
            double a, b, c, mult, ad, sub;
             Console.WriteLine("(c)Raziel, 2022\n");
            Console.Write("Digite um valor: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n");
            Console.Write("Digite outro valor: ");
            b = Convert.ToDouble(Console.ReadLine());

            c = a / b;

            sub = a - b;

            mult = a * b;

            ad = a + b;

            Console.Write("\n");
            Console.WriteLine("Divisão: " + c);

            Console.Write("\n");
            Console.WriteLine("Subtração: " + sub);

            Console.Write("\n");
            Console.WriteLine("Multiplicação: " + mult);

            Console.Write("\n");
            Console.WriteLine("Adição " + ad);

            Console.Write("\n\nAperte uma tecla para sair...");
            Console.ReadKey();
        }
    }
}
