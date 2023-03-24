using ExercicioBolsa.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBolsa.Models
{
    public class MonitorV : IMonitor
    {
        public string nome {get;set;}
        public List<IEvento> Eventos { get; set; } = new List<IEvento>();
        public MonitorV(string nome, List<IEvento> eventos)
        {
            this.nome = nome;
            Eventos = eventos;
        }

        public void ExecutaAcao(Ativo ativo)
        {
            Console.WriteLine("\n");

            foreach(var evento in Eventos)
            {
                evento.OnChange(ativo);
            }

            Console.Write("-------------------------------------");
        }
    }
}
