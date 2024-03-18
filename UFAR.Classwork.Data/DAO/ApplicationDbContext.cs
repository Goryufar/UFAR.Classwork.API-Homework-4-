using Microsoft.EntityFrameworkCore;
using UFAR.Classwork.Data.Entities;

namespace UFAR.Classwork.Data.DAO;

// This class is a public class
// This class is a DbContext class from EntityFrameworkCore
// DbContext is a class that is used to connect to a database
// DbContext is a class that is used to query a database
// DbContext is a class that is used to save data to a database
// DbContext is a class that is used to update data in a database
// DbContext is a class that is used to delete data from a database
// DbContext is a class that is used to create a database
// DbContext is a class that is used to create tables in a database
// DbContext is a class that is used to create relationships between tables in a database
public class ApplicationDbContext : DbContext
{
    string _connectionString = "Server = (localdb)\\MSSQLLocalDB;Database = Ufar_LibraryClasswork; Trusted_Connection = True;";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectionString, b => b.MigrationsAssembly("UFAR.Classwork.API"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      //  modelBuilder.Entity<noteData>().ToTable(tb => tb.HasTrigger("TriggerName"));


        base.OnModelCreating(modelBuilder);
    }
    // This is a public constructor
    // This constructor takes in a parameter of type DbContextOptions
    // This constructor calls the base constructor and passes in the options parameter
    // DbContextOptions is a class that is used to configure the DbContext class
    // DbContextOptions is a class that is used to configure the connection string
    // DbContextOptions is a class that is used to configure the database provider
    // DbContextOptions is a class that is used to configure the database provider options
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {  
    }

    // This is a public property
    // This property is of type DbSet
    // DbSet is a class that is used to query a database
    // DbSet is a class that is used to save data to a database
    public DbSet<LibraryEntity> Libraries { get; set; }
    public DbSet<BooksEntity> Books { get; set; }
}
