using k8s.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Techsoft.Consultorio.Aplicacion.DataTransferObjects;
using Techsoft.Consultorio.Dominio.Entidades;

namespace Techsoft.Consultorio.Api.Controllers
{
    [Route("api/Consulta")]
    [ApiController]
    public class ConsultaController : ControllerBase
    {
        /*[HttpPost]
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
                var doctorEntidad = _mapper.Map<Doctor>(consulta);
                _service.Guardar(doctorEntidad);
                var doctorCreado = _mapper.Map<DoctorDto>(doctorEntidad);

                return Ok(doctorCreado);
            }
            catch (InvalidOperationException iex)
            {
                _logger.LogError($"Error al crear doctor: {iex}");
                return BadRequest(iex.Message);
            }
            catch (ArgumentException aex)
            {
                _logger.LogError($"Error al crear doctor: {aex}");
                return BadRequest(aex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al crear doctor: {ex}");
                return StatusCode(500, "Internal Server Error.");
            }
        }*/
    }
}
