using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Techsoft.Consultorio.Aplicacion.Servicios;
using Techsoft.Consultorio.Dominio.Entidades;

namespace Techsoft.Consultorio.Api.Controllers
{
    
    //[Route("api/[controller]")]
    //[ApiController]
    //public class UserController : ControllerBase
    //{
        
    //    private readonly UserService _usersService;

    //    public UserController(UserService usersService)
    //    {
    //        _usersService = usersService;
    //    }

    //    /*
    //    [HttpGet]
    //    //[Authorize] 
    //    public async Task<List<User>> ConsultarUsers()
    //    {
    //        return await _usersService.ConsultarTodos();
    //    }*/

    //    [HttpPost]
    //    /*[Authorize]*/ //comentar para que funcione crear en el login
    //    public async Task<ActionResult> CrearUser(User user)
    //    {
    //        await _usersService.Almacenar(user);
    //        return Ok();
    //    }


        
    //    [HttpGet("{login}")]
    //    //[Authorize]
    //    public async Task<ActionResult<User>> ConsultarUserPorLogin(string login)
    //    {
    //        //var user = _usersService.ConsultarUser(login);
    //        return Ok(await _usersService.ConsultarUser(login));
    //    }
    //}
}
