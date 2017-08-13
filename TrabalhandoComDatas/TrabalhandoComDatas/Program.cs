using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComDatas
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data = new DateTime(2017,8,13);
            Console.WriteLine(data); //sem formatação
            Console.WriteLine(data.ToString("dd/MM/yyyy"));//com formatação
            Console.WriteLine(data.ToString("d"));//com formatação
            Console.WriteLine(data.ToString("d", new CultureInfo("pt-BR")));//com formatação Brasil


            data = new DateTime(2017, 8, 13, 14,15,10,987);
            Console.WriteLine("#######");
            Console.WriteLine(data);
            Console.WriteLine(data.ToString("HH:mm"));
            Console.WriteLine(data.ToString("HH:mm:ss"));

            Console.ReadKey();
        }
    }
}
