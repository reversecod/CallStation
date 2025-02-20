using System.ComponentModel.DataAnnotations.Schema;

namespace API.Dtos.Chamados
{
    public class ChamadosDto
    {
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataAbertura { get; set; } // Removido o nullable, pois sempre tem valor
        public DateTime? DataFechamento { get; set; }
    }
}
