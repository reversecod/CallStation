using CallStation.Data;
using CallStation.Interfaces;
using CallStation.Models;
using Microsoft.EntityFrameworkCore;

namespace CallStation.Repository
{
    public class CallStationRepository : ICallStationRepo
    {
        private readonly ApplicationDBContext _context;
        public CallStationRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public Task<List<Usuarios>> GetUsuarios()
        {
            return _context.Usuarios
                .FromSqlInterpolated($"EXEC spGetAPICallStation @rota = {"usuarios"}")
                .ToListAsync();
        }
        public Task<List<Chamados>> GetChamados()
        {
            return _context.Chamados
                .FromSqlInterpolated($"EXEC spGetAPICallStation @rota = {"chamados"}")
                .ToListAsync();
        }
        public Task<List<ToDo>> GetToDo()
        {
            return _context.ToDo
                .FromSqlInterpolated($"EXEC spGetAPICallStation @rota = {"todo"}")
                .ToListAsync();
        }

        public Task AddChamado(object chamado)
        {
            throw new NotImplementedException();
        }

        public Task AddToDo(object todo)
        {
            throw new NotImplementedException();
        }

        public Task AddUsuario(object usuario)
        {
            throw new NotImplementedException();
        }
    }
}
