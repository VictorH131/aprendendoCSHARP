using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap02_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, R;     // add variavel numerica (INTEIRA)

            // escrever na tela, e ler o valor 1 e 2
            Console.Write("Entre 1 valor: ");     
            A = int. Parse(Console.ReadLine());

            Console.Write("Entre 2 valor: ");
            B = int.Parse(Console.ReadLine());
            
            R = A + B;

            Console.WriteLine();
            Console.WriteLine("Resultados = " + R);


            // comando basico de controle de finalização
            Console.WriteLine();
            Console.WriteLine("tecle <Enter> para encerrar... ");
            Console.ReadLine();

        }
    }
}
