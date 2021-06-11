using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace ConsoleApp1
{
    public class ConversorArabicoSimples
    {
        private List<string> auxLista = new List<string>();
        public int Resultado { get; private set; }

        public ConversorArabicoSimples(string lista)
        {
            PreencherLista(lista);
            Resultado += ResultadoSoma();
        }

        private int ResultadoSoma()
        {
            int resultado = 0;

            for (int i = 0; i < auxLista.Count; i++)
            {
                resultado += VoidPegarValores(auxLista[i]);
            }
            return resultado;
        }

        public int VoidPegarValores(string identificador)
        {
            switch (identificador)
            {
                case "M": return 1000;
                case "D": return 500;
                case "C": return 100;
                case "L": return 50;
                case "X": return 10;
                case "V": return 5;
                case "I": return 1;
                default: return 0;
            }
        }

        private void PreencherLista(string lista)
        {
            for (int i = 0; i < lista.Length; i++)
            {
                auxLista.Add(lista.Substring(i, 1));
            }
        }
    }
}
