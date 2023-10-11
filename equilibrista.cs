using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Namespace;

namespace Namespace
{
    public class Equilibrista : Artista
    {
        public double AlturaEquilibrio { get; set; }

        public Equilibrista(string nome, int tempoApresentacao, DateTime dataInicio, DateTime? dataSaida = null, double alturaEquilibrio = 5.0)
            : base(nome, tempoApresentacao, dataInicio, dataSaida)
        {
            AlturaEquilibrio = alturaEquilibrio;
        }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Altura de equilíbrio: {AlturaEquilibrio} metros");
        }
    }
}
