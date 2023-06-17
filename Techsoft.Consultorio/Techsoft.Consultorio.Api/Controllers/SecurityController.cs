using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Techsoft.Consultorio.Aplicacion.DataTransferObjects;

namespace Techsoft.Consultorio.Api.Controllers
{
    [Route("api/security")]
    [ApiController]
    public class SecurityController : ControllerBase
    {
        [HttpPost("login")]
        public async Task<ActionResult> Login([FromBody] UserAuthDto user)
        {
            var Login = user.Login;
            var Contraseña = user.Contraseña;

            var loginCorrecto = "Kiyoshi";
            var contraCorrecto = "1234";

            //User usuarioConsultado = await _userServices.ConsultarUser(Login);

            if (user == null /*|| usuarioConsultado == null*/)
            {
                return BadRequest("Usuario: invalido");
            }

            if (user.Login == loginCorrecto && user.Contraseña == contraCorrecto)
            {
                var secretkey = new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes("suP32@cR3T00$24T"));

                var credentials = new SigningCredentials(
                    secretkey, SecurityAlgorithms.HmacSha256);

                var tokenOptions = new JwtSecurityToken(
                    issuer: "http://localhost:5105",
                    audience: "http://localhost:5105",
                    expires: DateTime.Now.AddSeconds(60),
                    signingCredentials: credentials,
                    claims: new List<Claim>() { new Claim("email", "ivanh@techsoft.com.mx") }
                    );

                var tokenString = new JwtSecurityTokenHandler()
                    .WriteToken(tokenOptions);

                return Ok(tokenString);

            }

            return Unauthorized();

        }
    }
}
