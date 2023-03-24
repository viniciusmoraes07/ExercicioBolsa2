using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBolsa.Models
{
    public class Bolsa
    {
        public Bolsa(string nome)
        {
            this.nome = nome;
        }
        public string nome { get; set; }
        public List<Ativo> listaAtivos { get; set; } = new List<Ativo>();

        public void addAtivo(Ativo ativo)
        {
            this.listaAtivos.Add(ativo);
        }

    }
}
