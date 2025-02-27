using CallStation.Dtos.Usuarios;
using CallStation.Models;
using System.Runtime.CompilerServices;

namespace CallStation.Mappers
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