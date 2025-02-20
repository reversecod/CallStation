using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CallStation.Models
{
    public class LogChamados
    {
        public class LogChamado
        {
            public int Id { get; set; }
            public string Descricao { get; set; } = string.Empty;
            public DateTime DataCriacao { get; set; } = DateTime.UtcNow;

            // Relacionamento: Log pertence a um chamado
            public int ChamadoId { get; set; }
            public Chamados Chamado { get; set; } = null!;
        }
    }
}
