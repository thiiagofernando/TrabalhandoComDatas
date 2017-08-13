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
            Console.WriteLine(data.ToString("HH:mm"));// Hora e Minutos
            Console.WriteLine(data.ToString("HH:mm:ss.fff"));//Data e Hora com Segundos

            Console.WriteLine(data.ToString("D", new CultureInfo("pt-BR")));//Data Completa
            Console.WriteLine(data.ToString("m", new CultureInfo("pt-BR")));//Dia numerico , Mes por extenso
            Console.WriteLine(data.ToString("Y", new CultureInfo("pt-BR")));//Mes por extenso, ano numerico
            Console.WriteLine(data.ToString("G", new CultureInfo("pt-BR")));//Data Geral
            Console.WriteLine(data.ToString("g", new CultureInfo("pt-BR")));//Data Geral sem segundos
            Console.WriteLine(data.ToString("O", new CultureInfo("pt-BR")));//Formato de Ida e Volta
            Console.WriteLine(DateTime.Parse(data.ToString("O")).ToString("dd/MM/yyy HH:mm:ss.fff"));//Formato de Ida e Volta Formatado
            Console.WriteLine(data.ToString("t"));//Formato de tempo
            Console.WriteLine(data.ToString("T"));//Formato de tempo
            Console.ReadKey();
        }
    }
}
