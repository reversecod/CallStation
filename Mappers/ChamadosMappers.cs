using CallStation.Dtos.Chamados;
using CallStation.Models;
using System.Runtime.CompilerServices;

namespace CallStation.Mappers
{
    public static class ChamadosMappers
    {
        public static ChamadosDto ToChamadosDto(this Chamados ChamadosModel)
        {
            return new ChamadosDto
            {
                Titulo = ChamadosModel.Titulo,
                Descricao = ChamadosModel.Descricao,
                DataAbertura = ChamadosModel.DataAbertura,
                DataFechamento = ChamadosModel.DataFechamento,
                UsuarioId = ChamadosModel.UsuarioId
            };

        }
    }
}