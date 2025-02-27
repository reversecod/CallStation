using CallStation.Data;
using CallStation.Dtos.Chamados;
using CallStation.Dtos.ToDo;
using CallStation.Dtos.Usuarios;
using CallStation.Interfaces;
using CallStation.Mappers;
using CallStation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace CallStation.Controllers
{
    [Route("CallStation/callstation")]
    [CallStationController]
    public class CallStationController : ControllerBase
    {
        private readonly ICallStationRepo _callstationRepo;

        public CallStationController(ICallStationRepo callstationRepo)
        {
            _callstationRepo = callstationRepo;
        }

        [HttpGet("{rota}")]
        //Chamada utilizando Procedure
        public async Task<IActionResult> spGetAPICallStation(string rota)
        {
            if (rota.ToLower() != "chamados" && rota.ToLower() != "usuarios" && rota.ToLower() != "todo")
                return BadRequest();

            if (rota.ToLower() == "chamados")
            {
                var chamados = await _callstationRepo.GetChamados();
                var chamadosDto = chamados.Select(n => n.ToChamadosDto());
                return Ok(chamadosDto);
            }
            else if (rota.ToLower() == "usuarios")
            {
                var usuarios = await _callstationRepo.GetUsuarios();
                var usuariosDto = usuarios.Select(n => n.ToUsuariosDto());
                return Ok(usuariosDto);
            }
            else
            {
                var todo = await _callstationRepo.GetToDo();
                var todoDto = todo.Select(a => a.ToToDoDto());
                return Ok(todoDto);
            }
        }

        private class CallStationControllerAttribute : Attribute
        {
        }
    }
}



