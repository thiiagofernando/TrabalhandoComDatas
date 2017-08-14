using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caelum.Stella.CSharp.Vault;

namespace TrabalhandoComDinheiro
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
            Money money = 10.00;
            Debug.WriteLine(money);

            double valor1 = 10.00;
            double valor2 = 20.00;
            Money total = valor1 + valor2;
            Debug.WriteLine(total);

            decimal minuendo = 20m;
            decimal subtraindo = 15m;
            Money diferenca = minuendo - subtraindo;
            Debug.WriteLine(diferenca);

            Money euro = new Money(Currency.EUR, 1000);
            Debug.WriteLine("Euro " + euro);

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            Money dolar = new Money(Currency.USD, 1000);
            Debug.WriteLine("Dolar " + dolar);

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
            Money real = new Money(Currency.BRL, 1000);
            Debug.WriteLine("Real " + real);
            Console.WriteLine(""+real);
            Console.ReadKey();


        }
    }
}
