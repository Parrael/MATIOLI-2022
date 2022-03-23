using System;
using System.Collections.Generic;
using System.Text;

namespace exercEstruturaSequencial
{
    class Solucao
    {
        public void ex1()
        {
            Console.WriteLine("\n\n\t\tEXERCÍCIO 1\n\n");
            int n1, n2;
            Console.WriteLine("\nInsira um numero inteiro para ser somado: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInsira o segundo numero inteiro que será somado.");
            n2 = int.Parse(Console.ReadLine());

            n1 += n1 + n2;

            Console.WriteLine("Soma = {0}", n1);

        }

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

        public void ex3()
        {
            Console.WriteLine("\n\n\t\tEXERCÍCIO 3\n\n");

            int a, b, c, d, diferenca;
            Console.WriteLine("\nInsira um numero inteiro: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInsira outro numero inteiro: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInsira outro numero inteiro: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInsira um ultimo numero inteiro: ");
            d = int.Parse(Console.ReadLine());

            diferenca = (a * b - c * d);

            Console.WriteLine("\nDiferença entre os numeros ({0} e {1}) e ({2} e {3}) é de: {4}", a, b, c, d, diferenca);
            

        }

    }
}

