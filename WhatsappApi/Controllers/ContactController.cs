using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WhatsappApi.BLL.Abstract;
using WhatsappApi.BLL.Concrete;
using WhatsappApi.DTO.ContactDtos;
using WhatsappApi.Entites;

namespace WhatsappApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        [HttpPost]
        public IActionResult AddContactUser([FromBody] ContactToAddDto contact)
        {
            _contactService.Add(contact);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var data = _contactService.GetAll();
            return Ok(data);
        }
        [HttpGet("{name}")]
        public IActionResult Get([FromRoute] string name)
        {
            var data = _contactService.Get(name);
            return Ok(data);
        }

        [HttpPut("{name}")]
        public IActionResult Update([FromRoute] string name, [FromBody] ContactToUpdateDto dto)
        {
            _contactService.Update(name, dto);
            return Ok();
        }

        [HttpDelete("{userId}/{name}")]
        public IActionResult Delete([FromRoute] int userId , [FromRoute] string name)
        {
            _contactService.Delete(userId, name);
            return Ok();
        }
    }
}
