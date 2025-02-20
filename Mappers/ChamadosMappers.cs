using API.Dtos.Chamados;
using API.Models;
using CallStation.Models;
using System.Runtime.CompilerServices;

namespace API.Mappers
{
    public static class ChamadosMappers
    {
        public static ChamadosDto ToChamadosDto(this Chamados ChamadosModel)
        {
            return new ChamadosDto
            {
                Titulo = ChamadosModel.Filial,
                Descricao = ChamadosModel.Nome,
                DataAbertura = ChamadosModel.DataAbertura,
                DataFechamento = ChamadosModel.DataFechamento,
            };

        }
    }
}