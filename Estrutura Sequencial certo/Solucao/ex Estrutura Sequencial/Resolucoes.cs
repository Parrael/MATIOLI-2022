using System;
using System.Collections.Generic;
using System.Text;

namespace EstruturaSequencial
{
    class Resolucoes
    {
        public void ex5()
        {
            Console.WriteLine("\n\n\t\tEXERCÍCIO 5\n\n");
            int codPec1, codPec2;                //código da peça 1 e da 2
            int quantPec1, quantPec2;               //quantidade de peças 1 e 2 
            float vUnit1, vUnit2;                   //valor peça 1 e 2
            float tProd1, tProd2, valorTotal;       //valor total de cada produto / compra final  

            Console.WriteLine("\nInsira o código do produto 1: ");
            codPec1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInsira a quantidade que será comprada deste produto: ");
            quantPec1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInforme o valor unitário deste produto: ");
            vUnit1 = float.Parse(Console.ReadLine());


            Console.WriteLine("\nInsira o código do produto 2: ");
            codPec2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInsira a quantidade que será comprada deste produto: ");
            quantPec2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInforme o valor unitário deste produto: ");
            vUnit2 = float.Parse(Console.ReadLine());

            tProd1 = quantPec1 * vUnit1;
            tProd2 = quantPec2 * vUnit2;

            valorTotal = tProd1 + tProd2;

            Console.WriteLine("\nO valor total da sua compra é de R${0:F2}", valorTotal);
        }
    }
}