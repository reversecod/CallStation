using System.ComponentModel.DataAnnotations;

namespace CallStation.Dtos.ToDo
{
    public class ToDoDto
    {
   
        public required string NomeTarefa { get; set; }

   
        public required string? Descricao { get; set; }


        public required DateTime DataCriacao { get; set; } = DateTime.UtcNow;

        public bool Concluida { get; set; } = false;


        [Range(0, 2, ErrorMessage = "Urgência deve estar entre 0 (Baixa) e 2 (Alta).")]
        public int Urgencia { get; set; } = 0; // 0 = Baixa, 1 = Média, 2 = Alta

        internal object ToToDo()
        {
            throw new NotImplementedException();
        }
    }
}
