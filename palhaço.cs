using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespace
{
    public class Palhaco : Artista
    {
        public int NumeroBrincadeiras { get; set; }

        public Palhaco(string nome, int tempoApresentacao, DateTime dataInicio, DateTime? dataSaida = null, int numeroBrincadeiras = 5)
            : base(nome, tempoApresentacao, dataInicio, dataSaida)
        {
            NumeroBrincadeiras = numeroBrincadeiras;
        }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Número de brincadeiras: {NumeroBrincadeiras}");
        }
    }
}

