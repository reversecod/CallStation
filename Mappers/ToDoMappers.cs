using API.Dtos.ToDo;
using API.Models;
using CallStation.Models;
using System.Runtime.CompilerServices;

namespace API.Mappers
{
    public static class ToDoMappers
    {
        public static ToDoDto ToToDoDto(this ToDo ToDoModel)
        {
            return new ToDoDto
            {
                NomeTarefa = ToDoModel.NomeTarefa,
                Descricao = ToDoModel.Descricao,
                DataCriacao = ToDoModel.DataCriacao,
                Concluida = ToDoModel.Concluida,
                Urgencia = ToDoModel.Urgencia
            };

        }
    }
}