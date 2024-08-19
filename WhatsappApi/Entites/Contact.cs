using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WhatsappApi.Entites
{
    [Index(nameof(PhoneNumber), IsUnique = true)]
    [Index(nameof(Name), IsUnique = true)]
    public class Contact
    {
        public int ContactId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]

        public string PhoneNumber { get; set; }
        public User Users { get; set; }
        public int UserId { get; set; }
        public List<Message> Messages { get; set; }


    }
}
