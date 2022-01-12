using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using crm.Domain.Interface;
using System.ComponentModel.DataAnnotations;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace crm.Api.Controllers
{
    [ApiController]
    [Route("api/users")]
    [Display(Description = "Usuários")]
    public class UserController : ControllerBase
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok("Retornando lista de usuários");
        }

        [HttpGet]
        [Route("{publicId:guid}")]
        public IActionResult GetUser(Guid publicId)
        {
            return Ok("Retornando usuário único");
        }

        [HttpPost]
        public IActionResult PostUser([FromBody] string Name)
        {
            return Ok($"Salvando usuário: {Name}");
        }

        [HttpPut]
        public IActionResult PutUser([FromBody] string Name)
        {
            return Ok($"Atualizando usuário: {Name}");
        }

        [HttpDelete]
        [Route("{publicId:guid}")]
        public IActionResult DeleteUser(Guid publicId)
        {
            return Ok("Usuário deletado.");
        }
    }
}

