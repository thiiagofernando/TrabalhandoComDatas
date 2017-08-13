using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caelum.Stella.CSharp.Inwords;

namespace NumerosPorExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 75;
            string extenso = new Numero(valor).Extenso();
            Console.WriteLine(extenso);

            valor = 2567;
            extenso=new Numero(valor).Extenso();
            Console.WriteLine(extenso);

            double valor2 = 2567.98;
            string extensobrl= new MoedaBRL(valor2).Extenso();
            Console.WriteLine(extensobrl);


            Console.ReadKey();
        }
    }
}
