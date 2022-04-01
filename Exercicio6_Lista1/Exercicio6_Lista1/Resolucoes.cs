using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio6_Lista1
{
    class Resolucoes
    {
            public void ex6()
            {
                Console.WriteLine("\n\n\t\tEXERCÍCIO 6\n\n");
                float a, b, c;
                double result, pi = 3.14159;

                Console.WriteLine("\n Insira três valores: ");
                string[] input = Console.ReadLine().Split(" ");
                a = float.Parse(input[0]);
                b = float.Parse(input[1]);
                c = float.Parse(input[2]);

                /*
                Console.WriteLine("\nInsira o primeiro valor: ");
                a = float.Parse(Console.ReadLine());
                Console.WriteLine("\nInsira o segundo valor: ");
                b = float.Parse(Console.ReadLine());
                Console.WriteLine("\nInsira o terceiro valor: ");
                c = float.Parse(Console.ReadLine());
                */

                result = (a * c) / 2;

                Console.WriteLine("\n Triângulo (A como base e C como altura: \t {0:F3}", result);

                result = c * c * pi;

                Console.WriteLine("\n Círculo (C como raio): \t\t\t {0:F3}", result);

                result = (a + b) / 2 * c;

                Console.WriteLine("\n Trapézio (A e B como base e C como altura): \t {0:F3}", result);

                result = b * b;

                Console.WriteLine("\n Quadrado (B como lado):  \t\t\t {0:F3}", result);

                result = a * b;

                Console.WriteLine("\n Retângulo (A e B como lados): \t\t\t {0:F3}", result);
            }
        }
    }


