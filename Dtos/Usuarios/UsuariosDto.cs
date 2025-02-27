using System.ComponentModel.DataAnnotations.Schema;

namespace CallStation.Dtos.Usuarios
{
    public class UsuariosDto
    {
        public required string Nome { get; set; }
        public required string Senha { get; set; }
    }
}
internal class UsuarioDto
{
    internal object ToUsuario()
    {
        throw new NotImplementedException();
    }
}