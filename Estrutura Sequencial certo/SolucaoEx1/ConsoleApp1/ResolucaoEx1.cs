using System;
using System.Collections.Generic;
using System.Text;

namespace EstruturaSequencial
{
    class Resolucoes
    {
        public void ex1()
        {
            Console.WriteLine("\n\n\t\tEXERCÍCIO 1\n\n");
            int n1, n2;
            Console.WriteLine("\nInsira um numero inteiro para ser somado: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInsira o segundo numero inteiro que será somado.");
            n2 = int.Parse(Console.ReadLine());

            n1 += n2;

            Console.WriteLine("Soma = {0}", n1);

        }
    }
}