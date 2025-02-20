using API.Data;
using API.Interfaces;
using API.Models;
using CallStation.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Repository
{
    public class OperacoesRepository : IOperacoesRepo
    {
        private readonly ApplicationDBContext _context;
        public OperacoesRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public Task<List<Almoxarifados>> GetAlmoxarifados()
        {
            return _context.Almoxarifados
                .FromSqlInterpolated($"EXEC spGetAPIOperacoes @rota = {"almoxarifados"}")
                .ToListAsync();
        }
        public Task<List<Notas>> GetNotas()
        {
            return _context.Notas
                .FromSqlInterpolated($"EXEC spGetAPIOperacoes @rota = {"notas"}")
                .ToListAsync();
        }
    }
}
