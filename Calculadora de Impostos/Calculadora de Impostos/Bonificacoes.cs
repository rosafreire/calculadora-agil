using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_Impostos
{
    class Bonificacoes
    {
        //classe desenvolvida para cálculo de possiveis descontos
        public void Descontos(double resultado)
        {
            if (resultado < 3.05 * 500)
            {
                Console.WriteLine("Não há descontos possíveis nessa compra. Para desconto de 10% adquira mais: " + ( 1525 - resultado) + " em produtos");
            }
            if(resultado >= 3.05* 500)
            {
                double desconto = resultado * 0.10;
                Console.WriteLine("Descontos possíveis: " + desconto);
                Console.WriteLine("Valor Final: " + (resultado - desconto));

            }
            if (resultado >= 4.5 * 1000)
            {
                double desconto = resultado * 0.20;
                Console.WriteLine("Descontos possíveis: " + desconto);
                Console.WriteLine("Valor Final: " + (resultado - desconto));

            }
        }
    }
}
