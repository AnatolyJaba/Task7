using Microsoft.EntityFrameworkCore;

namespace zadanie7.Models
{
    public class RecordContext : DbContext
    {
        public DbSet<Record> Records { get; set; }
        public RecordContext(DbContextOptions<RecordContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
    }
}
