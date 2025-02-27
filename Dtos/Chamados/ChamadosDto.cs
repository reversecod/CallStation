using System.ComponentModel.DataAnnotations.Schema;

namespace CallStation.Dtos.Chamados
{
    public class ChamadosDto
    {
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataAbertura { get; set; } // Removido o nullable, pois sempre tem valor
        public DateTime? DataFechamento { get; set; }
        public int? UsuarioId { get; set; }
    }
}
internal class ChamadoDto
{
    internal object ToChamado()
    {
        throw new NotImplementedException();
    }
}