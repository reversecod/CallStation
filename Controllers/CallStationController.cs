using API.Data;
using API.Interfaces;
using API.Mappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace API.Controllers
{
    [Route("api/operacoes")]
    [ApiController]
    public class OperacoesController : ControllerBase
    {
        private readonly IOperacoesRepo _operacoesRepo;

        public OperacoesController(IOperacoesRepo operacoesRepo)
        {
            _operacoesRepo = operacoesRepo;
        }

        [HttpGet("{rota}")]
        //Chamada utilizando Procedure
        public async Task<IActionResult> spGetAPIOperacoes(string rota)
        {
            if (rota.ToLower() != "notas" && rota.ToLower() != "almoxarifados")
                return BadRequest();

            if (rota.ToLower() == "notas")
            {
                var notas = await _operacoesRepo.GetNotas();
                var notasDto = notas.Select(n => n.ToNotasDto());
                return Ok(notasDto);
            }
            else
            {
                var almoxarifados = await _operacoesRepo.GetAlmoxarifados();
                var almoxarifadosDto = almoxarifados.Select(a => a.ToAlmoxarifadosDto());
                return Ok(almoxarifadosDto);
            }
        }
    }
}