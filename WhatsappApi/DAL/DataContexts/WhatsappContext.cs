using Microsoft.EntityFrameworkCore;
using WhatsappApi.Entites;

namespace WhatsappApi.DAL.DataContexts
{
    public class WhatsappContext : DbContext
    {
        public WhatsappContext(DbContextOptions<WhatsappContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>()
                .HasIndex(c => new { c.UserId, c.Name })
                .IsUnique();

            modelBuilder.Entity<Message>()
            .HasOne(m => m.User)
            .WithMany(u => u.Messages)
            .HasForeignKey(m => m.UserId);

            modelBuilder.Entity<Message>()
            .HasOne(m => m.Contact)
            .WithMany(c => c.Messages)
            .HasForeignKey(m => m.ContactId);
        }
    }
}
