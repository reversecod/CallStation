using CallStation.Dtos.ToDo;
using CallStation.Models;
using System.Runtime.CompilerServices;

namespace CallStation.Mappers
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
                Urgencia = (int)ToDoModel.Urgencia
            };

        }
    }
}