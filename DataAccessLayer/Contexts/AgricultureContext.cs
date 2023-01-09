
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Contexts
{
    public class AgricultureContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=SABBASZADA-N\\MSSQLSERVER2;database=DbAgriculture;integrated security=true;encrypt=false");
        }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Image> Images { get; set; }

        public DbSet<News> Newses { get; set; }

        public DbSet<Service> Services { get; set; }

        public  DbSet<Team> Teams { get; set; }

        public  DbSet<SocialMedia> SocialMedias { get; set; }

        public  DbSet<About> Abouts { get; set; }

        public DbSet<Admin> Admins { get; set; }

    }
}
