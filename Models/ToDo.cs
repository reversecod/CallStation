using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CallStation.Models
{
    public class ToDo
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName ="string(50)"]
        public string? NomeTarefa { get; set; }

        [Column(TypeName = "string(50)"]
        public string? Descricao { get; set; }

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

