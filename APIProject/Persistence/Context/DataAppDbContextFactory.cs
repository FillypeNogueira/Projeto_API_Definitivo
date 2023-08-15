using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;


namespace APIProject.Persistence.Context
{
    public class DataAppDbContextFactory : IDesignTimeDbContextFactory<DataAppDbContext>
    {
 
        public DataAppDbContext CreateDbContext(string[] args)
        {
          
            var options = new DbContextOptionsBuilder<DataAppDbContext>();
            options.UseNpgsql("User ID=postgres;Password=;Host=;Port=5432;Database=;");
            return new DataAppDbContext(options.Options, null);
        }
    }
}
