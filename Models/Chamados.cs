using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CallStation.Models
{
    public class Chamados
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "varchar(20)")] // Define o tipo no banco
        public string? Titulo { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string? Descricao { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataAbertura { get; set; } = DateTime.UtcNow;
        public DateTime? DataFechamento { get; set; }
         // Relacionamento: O chamado é aberto por um usuário
        public int UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public required Usuarios Usuario { get; set; }
        public List<LogChamados> Logs { get; set; } = new();
    }
}
