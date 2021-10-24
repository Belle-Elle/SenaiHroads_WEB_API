using Microsoft.AspNetCore.Mvc;
using SenaiHroads_webapi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SenaiHroads_webapi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private IUsuarioRepository _usuarioRepository { get; set; }

        public LoginController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpPost]
        public IActionResult Login(Usuario Login)
        {
            Usuario usuarioBuscado = _usuarioRepository.BuscarPorEmailSenha(Login.Email, Login.Senha);

            if (usuarioBuscado == null)
                return NotFound("E-mail ou senha inválidos!");

            
        }


    }
}
