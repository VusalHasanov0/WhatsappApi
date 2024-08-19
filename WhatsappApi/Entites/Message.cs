using Microsoft.AspNetCore.Antiforgery;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WhatsappApi.Entites
{
    
    public class Message
    {
        public int Id { get; set; }
        public User User { get; set; } 
        public int UserId { get; set; }
        public Contact Contact { get; set; } 
        public int ContactId { get; set; }
        public string Content { get; set; }
        public DateTime SentAt { get; set; }

    }
}
