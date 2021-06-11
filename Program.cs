using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            ConversorRomanoSimples aux = new ConversorRomanoSimples(1);

            Console.WriteLine(aux.Resultado);

            ConversorArabicoSimples romano = new ConversorArabicoSimples("IV");

            Console.WriteLine(romano.Resultado);
        }
    }
}
