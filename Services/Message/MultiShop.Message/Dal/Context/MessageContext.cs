using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MultiShop.Message.Dal.Entities;
using System.Security.Cryptography.X509Certificates;

namespace MultiShop.Message.Dal.Context
{
    public class MessageContext:DbContext
    {
        public MessageContext(DbContextOptions<MessageContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=localhost;Database=MultiShopMessageDb;Uid=sa;Pwd=aysu123;TrustServerCertificate=True;");

        }
        public DbSet<UserMessage> UserMessages { get; set; }
    }
}
