using Microsoft.EntityFrameworkCore;
using PersonFormApi;

namespace PersonFormApi.Data
{
    public class PersonDbContext : DbContext
    {
        public PersonDbContext(DbContextOptions<PersonDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> People { get; set; }
    }
}
