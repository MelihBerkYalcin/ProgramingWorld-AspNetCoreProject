using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Context
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=LENOVO\SQLEXPRESS;database=FullProgrWordDB;integrated security=true;");
        }

        public DbSet<About> About { get; set; }
        public DbSet<Advert> Advert { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<BlogReyting> BlogReyting { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<SubCategory> SubCategory { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Logo> Logo { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<Notification> Notification { get; set; }
        public DbSet<SocialMedia> SocialMedia { get; set; }
        public DbSet<CommentReply> CommentReply { get; set; }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<Update> Updated { get; set; }
    }
}
