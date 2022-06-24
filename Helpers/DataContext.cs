using Microsoft.EntityFrameworkCore;
using Simple_Crud_Api.Entities;
using System.Data.SqlClient;

namespace Simple_Crud_Api.Helpers
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        //protected readonly IConfiguration Configuration;
        //private readonly string _connectionString= "Data Source=HUUTRAN; Initial Catalog=SimpleApi; User ID=bipdev;Password=bipvn52C";

        //public DataContext(IConfiguration configuration,string connectionString)
        //{
        //    Configuration = configuration;
        //    _connectionString = connectionString;
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    // in memory database used for simplicity, change to a real db for production applications
        //    // options.UseInMemoryDatabase("TestDb");

        //    options.UseSqlServer(_connectionString);
        //}

        public DbSet<User> Users { get; set; }
    }
}
