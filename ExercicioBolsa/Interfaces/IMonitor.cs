using ExercicioBolsa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBolsa.Interfaces
{
    public interface IMonitor
    {
        List<IEvento> Eventos { get; set; }
        void ExecutaAcao(Ativo ativo);

    }
}
