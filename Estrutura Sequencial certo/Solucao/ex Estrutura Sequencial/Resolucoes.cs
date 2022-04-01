using System;
using System.Collections.Generic;
using System.Text;

namespace EstruturaSequencial
{
    class Resolucoes
    {
        public void ex4()
        {
            Console.WriteLine("\n\n\t\tEXERCÍCIO 4\n\n");

            int nFunc, nHrs;
            float vHrs, salario;
            //numero/código do funcionário, numero de horas trabalhadas, valor de cada hora trabalhada e o salário final.

            Console.WriteLine("\nInsira o numero/código do funcionário: ");
            nFunc = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInsira o numero de horas trabalhadas: ");
            nHrs = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInsira o valor de cada hora trabalhada: ");
            vHrs = float.Parse(Console.ReadLine());

            salario = nHrs * vHrs;

            Console.WriteLine("\nO funcionário número {0} deverá receber R${1:F2} como salário\n", nFunc, salario);

        }
    }
}