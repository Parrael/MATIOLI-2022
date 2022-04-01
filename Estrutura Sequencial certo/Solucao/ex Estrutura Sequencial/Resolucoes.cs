using System;
using System.Collections.Generic;
using System.Text;

namespace EstruturaSequencial
{
    class Resolucoes
    {
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