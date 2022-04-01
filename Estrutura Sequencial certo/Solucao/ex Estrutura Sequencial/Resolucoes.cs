using System;
using System.Collections.Generic;
using System.Text;

namespace EstruturaSequencial
{
    class Resolucoes
    {
        public void ex2()
        {
            Console.WriteLine("\n\n\t\tEXERCÍCIO 2\n\n");

            double n1, pi;
            Console.WriteLine("\nInsira o raio do seu círculo: ");
            n1 = double.Parse(Console.ReadLine());

            pi = 3.14159;
            n1 = pi * n1 * n1;

            Console.WriteLine("\nA área desse cículo será de: {0:F4}", n1);
        }
    }
}