using System.ComponentModel.DataAnnotations.Schema;

namespace API.Dtos.Usuarios
{
    public class UsuariosDto
    {
        public required string Nome { get; set; }
        public required string Senha { get; set; }
    }
}
