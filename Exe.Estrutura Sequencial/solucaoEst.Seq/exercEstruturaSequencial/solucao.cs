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

        public void ex4()
        {
            Console.WriteLine("\n\n\t\tEXERCÍCIO 4\n\n");

            int nFunc, nHrs, salario;
            float vHrs;
            //numero/código do funcionário, numero de horas trabalhadas, valor de cada hora trabalhada e o salário final.
            
            Console.WriteLine("\nInsira o numero/código do funcionário: ");
            nFunc = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInsira o numero de horas trabalhadas: ");
            nHrs = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInsira o valor de cada hora trabalhada: ");
            vHrs = float.Parse(Console.ReadLine());

            salario = nHrs*vHrs;
            
            Console.WriteLine("\nO funcionário número {0} deverá receber R${1:F2} como salário\n", nFunc, salario);

        }
        
        public void ex5()
        {
            Console.WriteLine("\n\n\t\tEXERCÍCIO 5\n\n");
            string codPec1, codPec2;                //código da peça 1 e da 2
            int quantPec1, quantPec2;               //quantidade de peças 1 e 2 
            float vUnit1, vUnit2;                   //valor peça 1 e 2
            float tProd1, tProd2, valorTotal;       //valor total de cada produto / compra final  

            Console.WriteLine("\nInsira o código do produto 1: ");
            codPec1 = string.Parse(Console.ReadLine());
            Console.WriteLine("\nInsira a quantidade que será comprada deste produto: ");
            quantPec1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInforme o valor unitário deste produto: ");
            vUnit1= float.Parse(Console.ReadLine());

            
            Console.WriteLine("\nInsira o código do produto 2: ");
            codPec2 = string.Parse(Console.ReadLine());
            Console.WriteLine("\nInsira a quantidade que será comprada deste produto: ");
            quantPec2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInforme o valor unitário deste produto: ");
            vUnit2 = float.Parse(Console.ReadLine());

            tProd1 = quantPec1*vUnit1;
            tProd2 = quantPec2*vUnit2;

            valorTotal = tProd1 + tProd2;

            Console.WriteLine("\nO valor total da sua compra é de R${0:F2}",valorTotal);
        }

        public void ex6()
        {
            Console.WriteLine("\n\n\t\tEXERCÍCIO 6\n\n");
            float a, b, c;
            double result, pi=3.14159;
            Console.WriteLine("\nInsira o primeiro valor: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("\nInsira o segundo valor: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("\nInsira o terceiro valor: ");
            c = float.Parse(Console.ReadLine());

            result = (a*c)/2;

            Console.WriteLine("\n Triângulo (A como base e C como altura: \t {0:F3}", result );

            result = c*c*pi;

            Console.WriteLine("\n Círculo (C como raio): \t {0:F3}", result );

            result = (a+b)/2 * c;

            Console.WriteLine("\n Trapézio (A e B como base e C como altura): \t {0:F3}", result );

            result = b*b;

            Console.WriteLine("\n Quadrado (B como lado):  \t {0:F3}", result);

            result = a*b;

            Console.WriteLine("\n Retângulo (A e B como lados): \t {0:F3}");
        }
    }
}
