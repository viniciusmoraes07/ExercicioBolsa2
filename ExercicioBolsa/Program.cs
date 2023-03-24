using ExercicioBolsa.Interfaces;
using ExercicioBolsa.Models;
using ExercicioBolsa.Models.Alarmes;
using ExercicioBolsa.Models.Algoritmos;

public class Program
{
    public static void Main(string[] args)
    {
        List<IEvento> eventos = new List<IEvento>();
        eventos.Add(new Fibonacci());
        eventos.Add(new AlarmeSuperior());

        IMonitor monitorBovespa = new MonitorV("Monitor Bovespa",eventos);

        Bolsa bolsaBovespa = new Bolsa("Bolsa Bovespa");
        Ativo Petrobras = new Ativo("Petrobras");
        Ativo Magazine = new Ativo("Magazine Luiza");

        Petrobras.subscribe(monitorBovespa);
        Magazine.subscribe(monitorBovespa);

        bolsaBovespa.addAtivo(Petrobras);
        bolsaBovespa.addAtivo(Magazine);

        while (true)
        {
         
            foreach(var ativo in bolsaBovespa.listaAtivos)
            {
                ativo.buscaNovoValorAcao();
            }

            System.Threading.Thread.Sleep(7000);
        }
    }
}