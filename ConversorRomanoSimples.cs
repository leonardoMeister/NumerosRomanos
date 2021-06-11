using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ConversorRomanoSimples
    {
        public string Resultado { get; set; }
        public ConversorRomanoSimples(int Valor)
        {
            ConverteParaRomano(Valor);

        }

        private void ConverteParaRomano(int x)
        {
            while (true)
            {
                if (x < 4000 && x > 999)
                {
                    switch (x / 1000)
                    {
                        case 1: Resultado += "M"; break;
                        case 2: Resultado += "MM"; break;
                        case 3: Resultado += "MMM"; break;
                    }
                    x -= 1000 * (x / 1000);
                }
                else if (x < 1000 && x > 99)
                {
                    switch (x / 100)
                    {
                        case 1: Resultado += "C"; break;
                        case 2: Resultado += "CC"; break;
                        case 3: Resultado += "CCC"; break;
                        case 4: Resultado += "CD"; break;
                        case 5: Resultado += "D"; break;
                        case 6: Resultado += "DC"; break;
                        case 7: Resultado += "DCC"; break;
                        case 8: Resultado += "DCCC"; break;
                        case 9: Resultado += "CM"; break;
                    }
                    x -= 100 * (x / 100);
                }
                else if (x < 100 && x > 9)
                {
                    switch (x / 10)
                    {
                        case 1: Resultado += "X"; break;
                        case 2: Resultado += "XX"; break;
                        case 3: Resultado += "XXX"; break;
                        case 4: Resultado += "XL"; break;
                        case 5: Resultado += "L"; break;
                        case 6: Resultado += "LX"; break;
                        case 7: Resultado += "LXX"; break;
                        case 8: Resultado += "LXXX"; break;
                        case 9: Resultado += "XC"; break;
                    }
                    x -= 10 * (x / 10);
                }
                else if (x < 10 && x > 0)
                {
                    switch (x )
                    {
                        case 1: Resultado += "I"; break;
                        case 2: Resultado += "II"; break;
                        case 3: Resultado += "III"; break;
                        case 4: Resultado += "IV"; break;
                        case 5: Resultado += "V"; break;
                        case 6: Resultado += "VI"; break;
                        case 7: Resultado += "VII"; break;
                        case 8: Resultado += "VIII"; break;
                        case 9: Resultado += "IX"; break;
                    }
                    x -= x;
                }
                if (x ==0)
                {
                    break;
                }

            }
        }
    }
}
