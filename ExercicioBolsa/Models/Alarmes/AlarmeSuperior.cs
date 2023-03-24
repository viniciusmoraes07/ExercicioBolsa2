using ExercicioBolsa.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBolsa.Models.Alarmes
{
    public class AlarmeSuperior : IEvento
    {
        public void alarme(Ativo ativo)
        {
            if (ativo.Valor > 5)
                Console.WriteLine("ALARME: VALOR AÇÃO " + ativo.Nome + " ESTA ACIMA DE 5");
        }

        public void OnChange(Ativo ativo)
        {
            alarme(ativo);
        }
    }
}
