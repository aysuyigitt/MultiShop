using Microsoft.EntityFrameworkCore;
using MultiShop.Comment.Entites;

namespace MultiShop.Comment.Context
{
    public class CommentContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=localhost,1443;initial Catalog=MultiShopCommentDb;Uid=sa;Pwd=123456bB*;TrustServerCertificate=True;");
        }
        public DbSet<UserComment> UserComments { get; set; }    
    }
}
