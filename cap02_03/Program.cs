using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap02_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float HT, VH, PD, SB, TD, SL; // add de variavel numerico ("flutuante")
            // HT= Horas trabalhadas, VH= Valor da Hora, PD= Percentual de desconto, SB= salario bruto, TD= total descontado, SL= Salario liquido 
            
            // escreve na tela e le os valores "HT" "VH" e "PD"
            Console.Write("Horas trabalhadas ..............: ");
            HT = float.Parse(Console.ReadLine());
            Console.Write("valor da Hora ..............: ");
            VH = float.Parse(Console.ReadLine());
            Console.Write("Valor do percentual de desconto .: ");
            PD = float.Parse(Console.ReadLine());

            // faz um calculo de salario liquido
            SB = HT * VH;
            TD = (PD / 100) * SB;
            SL = SB - TD;

            // mostra o resultado
            Console.WriteLine();
            Console.Write("Salario liquido .................: ");
            Console.WriteLine(SL.ToString("##,##0,00")); // mascara  de comando

            // comando basico de controle de finalização
            Console.WriteLine();
            Console.WriteLine("tecle <Enter> para encerrar... ");
            Console.ReadLine();



        }
    }
}
