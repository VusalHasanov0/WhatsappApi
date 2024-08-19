using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WhatsappApi.BLL.Abstract;

namespace WhatsappApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService _messageService;
        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpPost("{userId}/{contactId}")]

        public IActionResult AddMessage([FromRoute] int userId, [FromRoute] int contactId, [FromBody] string message)
        {
            _messageService.AddMessage(userId, contactId, message);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAllMessageUser(int userId)
        {
            var data = _messageService.GetAllMessageUser(userId);
            return Ok(data);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMessage([FromRoute] int userId)
        {
            _messageService.DeleteMessage(userId);
            return Ok();
        }

    }
}
