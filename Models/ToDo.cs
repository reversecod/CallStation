using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CallStation.Models
{
    public class ToDo
    {
            public int Id { get; set; }
            public string NomeTarefa { get; set; } = string.Empty;
            public string Descricao { get; set; } = string.Empty;
            public DateTime DataCriacao { get; set; } = DateTime.UtcNow;
            public bool Concluida { get; set; } = false;
            public UrgenciaTarefa? Urgencia { get; set; }
    }
    public enum UrgenciaTarefa
    {
        Baixa,
        Media,
        Alta
    }
}

