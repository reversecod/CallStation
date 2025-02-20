using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CallStation.Models
{
    public class Usuarios
    {
        [Key]
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Senha { get; set; }

        // Relacionamento: Um usuário pode abrir vários chamados
        public List<Chamados> ChamadosAbertos { get; set; } = new();
    }
}
