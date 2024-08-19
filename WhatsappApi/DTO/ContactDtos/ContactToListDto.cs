using System.ComponentModel.DataAnnotations;
using WhatsappApi.Entites;

namespace WhatsappApi.DTO.ContactDtos
{
    public class ContactToListDto
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public int UserId { get; set; }

    }
}
