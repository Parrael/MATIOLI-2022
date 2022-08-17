using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaDiagnostica
{
    class Solucao
    {
        
        //Exercicio 1.1
        public void Ex1()
        {
            int cp1, qp1;
            float unitPrice1, vlrPagar;
            int cp2, qp2;
            float unitPrice2;

            Console.WriteLine("Exercicio 1");

            Console.WriteLine("\n\nDigita o código da peça 1: ");
            cp1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigita a quantidade da peça 1: ");
            qp1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigita o preço unitário da peça 1: ");
            unitPrice1 = float.Parse(Console.ReadLine());

            vlrPagar = qp1 * unitPrice1;
            Console.WriteLine("\nValor a ser pago: R${0:F2}", vlrPagar);

            Console.WriteLine("\n\nDigita o código da peça 2: ");
            cp2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigita a quantidade da peça 2: ");
            qp2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigita o preço unitário da peça 2: ");
            unitPrice2 = float.Parse(Console.ReadLine());

            vlrPagar = qp2 * unitPrice2;
            Console.WriteLine("\nValor a ser pago: R${0:F2}", vlrPagar);

        }

        //Exercicio 1.2
        public void Ex2()
        {
            double pi = 3.14159, area, raio;
            Console.WriteLine("Exercicio 1.2");

            Console.WriteLine("\nInsira o valor do raio da circunferência");
            raio = int.Parse(Console.ReadLine());
            area = raio * raio * pi;
            Console.WriteLine("\nValor da área = {0:F4}", area);
        }

        //Exercicio 2.1
        public void Ex3()
        {
            Console.WriteLine("Exercicio 2.1");
            int code, quant;
            double total=0;

            Console.WriteLine("\nInsira o código do seu pedido: ");
            code = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInsira a quantidade do item: ");
            quant = int.Parse(Console.ReadLine());
            switch (code)
            {
                case 1:
                    total += 16 * quant;
                    break;
                case 2:
                    total += 25 * quant;
                    break;
                case 3:
                    total += 20 * quant;
                    break;
                case 4:
                    total += 6.5 * quant;
                    break;
                case 5:
                    total += 8 * quant;
                    break;
            }
            Console.WriteLine("\nO valor total da sua compra foi de R${0:F2}", total)


        }
    }
}
