using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WhatsappApi.Entites
{
    [Index(nameof(Name), IsUnique = true)]
    public class User
    {
        public int UserId { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Contact> Contacts { get; set; }
        public List<Message> Messages { get; set; } 


    }
}
