using API.Dtos.Usuarios;
using API.Models;
using System.Runtime.CompilerServices;

namespace API.Mappers
{
    public static class UsuariosMappers
    {
        public static UsuariosDto ToUsuariosDto(this Usuarios UsuariosModel)
        {
            return new UsuariosDto
            {
                Nome = UsuariosModel.Nome,
                Senha = UsuariosModel.Senha
            };

        }
    }
}