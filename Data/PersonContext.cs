using Microsoft.EntityFrameworkCore;
using Person.Models;
using System.Collections.Generic;

namespace Person.Data
{
    public class PersonContext : DbContext
    {
        public DbSet<PersonModel> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=person.sqlite");
            base.OnConfiguring(optionsBuilder);
        }
    }
}