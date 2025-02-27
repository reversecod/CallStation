using CallStation.Models;

namespace CallStation.Interfaces
{
    public interface ICallStationRepo
    {
        Task<List<Usuarios>> GetUsuarios();
        Task<List<Chamados>> GetChamados();
        Task<List<ToDo>> GetToDo();
        Task AddChamado(object chamado);
        Task AddToDo(object todo);
        Task AddUsuario(object usuario);
    }
}
