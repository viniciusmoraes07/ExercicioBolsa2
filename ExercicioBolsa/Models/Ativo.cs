using ExercicioBolsa.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBolsa.Models
{
    public class Ativo
    {
        public double ValorMax { get; set; }
        public double ValorMin { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public double UltimoValor { get; set; }

        public List<IMonitor> ListaMonitor = new List<IMonitor>();

        public Ativo(string nome)
        {
            this.Nome = nome;
        }
        public virtual string buscaNovoValorAcao()
        {
            this.UltimoValor = this.Valor;
            Random rnd = new Random();
            this.Valor = rnd.Next(10);

            if (this.UltimoValor != this.Valor)
            {
                OnChangeValorAtivo();
                return "\n Valor da ação mudou de " + this.UltimoValor + " para " + this.Valor + "\n\n -----------------------------------------";
            }

            return "\n Valor da acao nao mudou \n -----------------------------------------";
        }
        public void subscribe(IMonitor monitor)
        {
            ListaMonitor.Add(monitor);
        }

        public void OnChangeValorAtivo()
        {

            foreach (IMonitor monitor in this.ListaMonitor)
            {
                monitor.ExecutaAcao(this);
            }
        }
    }
}
