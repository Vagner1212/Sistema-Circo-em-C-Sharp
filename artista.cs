using System;

namespace Namespace
{
    public class Artista
    {
        public string Nome { get; set; }
        public int TempoApresentacao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataSaida { get; set; }
        public bool Ativo { get; set; }

        public Artista(string nome, int tempoApresentacao, DateTime dataInicio, DateTime? dataSaida = null)
        {
            Nome = nome;
            TempoApresentacao = tempoApresentacao;
            DataInicio = dataInicio;
            DataSaida = dataSaida;
            Ativo = true;
        }

        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Tempo de apresentação: {TempoApresentacao} minutos");
            Console.WriteLine($"Data de início: {DataInicio}");
            if (DataSaida.HasValue)
            {
                Console.WriteLine($"Data de saída: {DataSaida}");
                Ativo = false; // Defina como inativo se tiver uma data de saída
            }
            else
            {
                Console.WriteLine("Ainda ativo");
            }
            Console.WriteLine($"Ativo: {(Ativo ? "Sim" : "Não")}");
        }

        public void RegistrarSaida(DateTime dataSaida)
        {
            DataSaida = dataSaida;
            Ativo = false;
        }
    }
}

