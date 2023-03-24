using ExercicioBolsa.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBolsa.Models.Algoritmos
{
    public class PrecoMedio : IEvento
    {
        public string compra(Ativo ativo)
        {
            if (ativo.Valor < 2)
                return "PREÇO MEDIO comprou ações " + ativo.Nome + " ( compra somente abaixo de 2 ) - valor = " + ativo.Valor;

            return "PREÇO MEDIO nao comprou ações " + ativo.Nome + "( compra somente abaixo de 2 ) - valor = " + ativo.Valor;

        }

        public void OnChange(Ativo ativo)
        {
            Console.WriteLine(venda(ativo));
            Console.WriteLine(compra(ativo));
        }

        public string venda(Ativo ativo)
        {
            if (ativo.Valor > 4)
                return "PREÇO MEDIO vendeu ações " + ativo.Nome + "( venda somente acima de 4 ) - valor = " + ativo.Valor;

            return "PREÇO MEDIO não vendeu ações " + ativo.Nome + " ( venda somente acima de 4 ) - valor = " + ativo.Valor;
        }
    }
}
