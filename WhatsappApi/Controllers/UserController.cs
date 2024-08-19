using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WhatsappApi.BLL.Abstract;
using WhatsappApi.DTO.UserDtos;
using WhatsappApi.Entites;

namespace WhatsappApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public IActionResult Add([FromBody] UserToAddDto user)
        {
            _userService.Add(user);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {

            var data = _userService.GetAll();
            return Ok(data);
        }

        [HttpPut("{name}")]
        public IActionResult Update([FromRoute] string name, [FromBody] UserToUpdateDto user)
        {
            _userService.Update(name, user);
            return Ok();
        }

        [HttpDelete("{name}")]
        public IActionResult Delete([FromRoute] string name)
        {
            _userService.Delete(name);
            return Ok();
        }
    }
}
