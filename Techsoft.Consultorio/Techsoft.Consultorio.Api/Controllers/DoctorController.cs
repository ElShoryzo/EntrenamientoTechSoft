using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Techsoft.Consultorio.Aplicacion.DataTransferObjects;
using Techsoft.Consultorio.Aplicacion.Servicios;
using Techsoft.Consultorio.Dominio.Contratos;
using Techsoft.Consultorio.Dominio.Entidades;

namespace Techsoft.Consultorio.Api.Controllers
{
    [Route("api/doctor")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        private readonly DoctoresService _service;

        public DoctorController(ILoggerManager logger, IMapper mapper, DoctoresService service)
        {
            _logger = logger;
            _mapper = mapper;
            _service = service;
        }

        [HttpPost]
        public IActionResult CreateDoctor([FromBody] DoctorCreationDto doctor) 
        {
            try
            {
                if (doctor == null)
                {
                    _logger.LogError("El doctor enviado del cliente es nulo.");
                    return BadRequest("El doctor es nulo");
                }
                if (!ModelState.IsValid)
                {
                    _logger.LogError("Los datos enviados del doctor son inválidos");
                    return BadRequest("Modelo inválido");
                }
                var doctorEntidad = _mapper.Map<Doctor>(doctor);
                _service.Guardar(doctorEntidad);
                var doctorCreado = _mapper.Map<DoctorDto>(doctorEntidad);

                return Ok(doctorCreado);
            }
            catch(InvalidOperationException iex)
            {
                _logger.LogError($"Error al crear doctor: {iex}");
                return BadRequest(iex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al crear doctor: {ex}");
                return StatusCode(500, "Internal Server Error.");
            }
        }
    }
}
