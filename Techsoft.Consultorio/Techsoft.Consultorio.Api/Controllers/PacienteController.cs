using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Techsoft.Consultorio.Aplicacion.DataTransferObjects;
using Techsoft.Consultorio.Aplicacion.Servicios;
using Techsoft.Consultorio.Dominio.Contratos;
using Techsoft.Consultorio.Dominio.Entidades;

namespace Techsoft.Consultorio.Api.Controllers
{
    [Route("api/paciente")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        // NLog
        // private readonly ILoggerManager _logger;
        private readonly ILogger<PacienteController> _logger;
        private readonly IMapper _mapper;
        private readonly PacientesService _service;

        public PacienteController(ILogger<PacienteController> logger, IMapper mapper, PacientesService service)
        {
            _logger = logger;
            _mapper = mapper;
            _service = service;
        }

        [HttpPost]
        public IActionResult CreatePaciente([FromBody] PacienteCreationDto paciente)
        {
            try
            {
                if (paciente == null)
                {
                    _logger.LogError("El paciente enviado del cliente es nulo.");
                    return BadRequest("El paciente es nulo");
                }
                if (!ModelState.IsValid)
                {
                    _logger.LogError("Los datos enviados del paciente son inválidos");
                    return BadRequest("Modelo inválido");
                }
                var pacienteEntidad = _mapper.Map<Paciente>(paciente);
                _service.Guardar(pacienteEntidad);
                var pacienteCreado = _mapper.Map<PacienteDto>(pacienteEntidad);

                return Ok(pacienteCreado);
            }
            catch (InvalidOperationException iex)
            {
                _logger.LogError($"Error al crear paciente: {iex}");
                return BadRequest(iex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al crear paciente: {ex}");
                return StatusCode(500, "Internal Server Error.");
            }
        }

        [HttpPost("CrearConsulta")]
        public IActionResult CreateConsulta([FromBody] ConsultaCreationDto consulta)
        {
            try
            {
                if (consulta == null)
                {
                    _logger.LogError("La consulta enviada del cliente es nula.");
                    return BadRequest("La consulta es nula");
                }
                if (!ModelState.IsValid)
                {
                    _logger.LogError("Los datos enviados de la consulta son inválidos");
                    return BadRequest("Modelo inválido");
                }
                var consultaEntidad = _mapper.Map<Consulta>(consulta);
                _service.AgendarConsulta(consultaEntidad);
                var consultaCreada = _mapper.Map<ConsultaDto>(consultaEntidad);

                return Ok(consultaCreada);
            }
            catch (InvalidOperationException iex)
            {
                _logger.LogError($"Error al crear consulta: {iex}");
                return BadRequest(iex.Message);
            }
            catch (ArgumentException aex)
            {
                _logger.LogError($"Error al crear consulta: {aex}");
                return BadRequest(aex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al crear consulta: {ex}");
                return StatusCode(500, "Internal Server Error.");
            }
        }
    }
}
