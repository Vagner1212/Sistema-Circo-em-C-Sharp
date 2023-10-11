using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Namespace;

namespace Namespace
{
    public class Malabarista : Artista
    {
        public int NumeroBolas { get; set; }

        public Malabarista(string nome, int tempoApresentacao, DateTime dataInicio, DateTime? dataSaida = null, int numeroBolas = 3)
            : base(nome, tempoApresentacao, dataInicio, dataSaida)
        {
            NumeroBolas = numeroBolas;
        }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Número de bolas: {NumeroBolas}");
        }
    }
}
