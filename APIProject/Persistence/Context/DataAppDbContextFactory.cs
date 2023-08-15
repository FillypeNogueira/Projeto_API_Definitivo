using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;


namespace APIProject.Persistence.Context
{
    public class DataAppDbContextFactory : IDesignTimeDbContextFactory<DataAppDbContext>
    {
 
        public DataAppDbContext CreateDbContext(string[] args)
        {
          
            var options = new DbContextOptionsBuilder<DataAppDbContext>();
            options.UseNpgsql("User ID=postgres;Password=BGHptk99###;Host=192.168.1.17;Port=5432;Database=localdb;");
            return new DataAppDbContext(options.Options, null);
        }
    }
}