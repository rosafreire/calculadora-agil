using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_Impostos
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc;
            calc = new Calculadora();
            string cliente;
            double quantidade;
            

            Bonificacoes boni;
            boni = new Bonificacoes();
            double resultado;


            Interface();


            void Interface()
            {
                Console.WriteLine("Empresa Compradora: ");
                cliente = Console.ReadLine();
                Console.WriteLine("Quantidade Adquirida: ");
                string qnt = Console.ReadLine();
                quantidade = Double.Parse(qnt);

                Console.WriteLine("Aqui está o seu resultado... ");
                calc.TotalDeMercadorias(cliente, quantidade);

                resultado = calc.resultado;
                Menu(); 
            }

            void Menu()
            {
                Console.WriteLine();
                Console.WriteLine("Para descontos tecle: D");
                Console.WriteLine("Para sair tecle: Enter");
                Console.WriteLine("Para novo cálculo digite: N");

                string Op = Console.ReadLine();

                if (Op == "D" || Op == "d")
                {
                    boni.Descontos(resultado);
                    Menu();
                    Console.Read();
                }
                if (Op == "N" || Op == "n")
                {
                    Console.Clear();
                    Interface();
                    Menu();
                }
                else
                {
                    return;
                }
            }
        }
    }
}
