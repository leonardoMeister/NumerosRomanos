using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class RomanosParaNumeros
    {
        public int NumeroArabico { get; private set; }
        public string NumeroRomano { get; set; }

        private Dictionary<string, int> dicionarioConversao = new Dictionary<string, int>()
        {
            { "e", 10000 },
            { "w", 5000 },
            { "m", 1000 },
            { "d", 500 },
            { "c", 100 },
            { "l", 50 },
            { "x", 10},
            { "v", 5},
            { "i", 1},
        };

        private List<string> valoresQuePodemDiminuir = new List<string>()
        {
            "i",
            "x",
            "c",
        };

        public void NumerosRomanosParaArabicos(string numeroRomano)
        {
            numeroRomano = Normalizar(numeroRomano);
            NumeroRomano = numeroRomano.ToLower();
            NumeroArabico = Converter(numeroRomano.ToLower());
        }
        private int Converter(string numeroRomano)
        {

            char[] valoresParaConversao = numeroRomano.ToCharArray();
            int saida = 0;

            for (int i = 0; i < valoresParaConversao.Length; i++)
            {          
                string valor = valoresParaConversao[i].ToString();
                int valorASerAdicionado = 0;

                if (PodeAvancarMaisUmaPosicao(valoresParaConversao, i))
                {
                    string proximoValor = valoresParaConversao[i + 1].ToString();

                    if (valoresQuePodemDiminuir.Contains(valor) && ProximoValorEhMaiorQueOAtual(valor, proximoValor))
                    {
                        valorASerAdicionado = dicionarioConversao[proximoValor] - dicionarioConversao[valor];
                        i++;
                    }
                }

                if (valorASerAdicionado == 0)
                {
                    valorASerAdicionado = dicionarioConversao[valor];
                }

                saida += valorASerAdicionado;
            }

            return saida;
        }

        private string Normalizar(string str)
        {
            str = str.ToUpper();

            str = str.Replace("Ī", "q");
            str = str.Replace("V̄", "w");
            str = str.Replace("X̄", "e");

            return str;
        }

        private bool ProximoValorEhMaiorQueOAtual(string valor, string proximoValor)
        {
            return dicionarioConversao[proximoValor] > dicionarioConversao[valor];
        }

        private static bool PodeAvancarMaisUmaPosicao(char[] valoresParaConversao, int i)
        {
            return i + 1 < valoresParaConversao.Length;
        }
    }
}


