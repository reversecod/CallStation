using API.Models;
using CallStation.Models;

namespace API.Interfaces
{
    public interface ICallStationRepo
    {
        Task<List<Usuarios>> GetUsuarios();
        Task<List<Chamados>> GetChamados();
        Task<List<ToDo>> GetToDo();
    }
}
