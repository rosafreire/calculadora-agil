using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_Impostos
{
    //classe criada para gerenciar calculos necessarios
    // contem serie de funções para calculos de impostos individuais + função de impressão de resultado na tela
    class Calculadora
    {
        public double resultado;
        public void TotalDeMercadorias(string cliente, double quantidade)
        {
            Console.WriteLine("Cliente: " + cliente);
            Console.WriteLine("Quantidadde: " + quantidade);
            Console.WriteLine("ICMS: " + CalcICMS(quantidade));
            Console.WriteLine("IPI: " + CalcIPI(quantidade));
            Console.WriteLine("COFINS: " + CalcCOFINS(quantidade));
            Console.WriteLine("PIS: " + CalcPIS(quantidade));
            Console.WriteLine("Total em impostos: " + TotalDeImpostos(quantidade));
            Console.WriteLine("Valor venda: " + ValorVenda(quantidade));
            resultado = ValorVenda(quantidade) - TotalDeImpostos(quantidade);
            Console.WriteLine("Resultado: " +resultado);
           
        }

        public double TotalDeImpostos(double quantidade)
        {
            double valor = quantidade * 4.5 * 0.324;

            return valor;
        }
        
        public double CalcICMS(double quantidade)
        {
            double total = quantidade * 4.5 * 0.18;
            return total;
        }
        public double CalcIPI(double quantidade)
        {
            double total = quantidade * 4.5 * 0.04;
            return total;
        }
        public double CalcPIS(double quantidade)
        {
            double total = quantidade * 4.5 * 0.0186;
            return total;
        }
        public double CalcCOFINS(double quantidade)
        {
            double total = quantidade * 4.5 * 0.0854;
            return total;
        }
        public double ValorVenda(double quantidade)
        {
            double total = quantidade * 4.5;
            return total;
        }
       
    }
}
