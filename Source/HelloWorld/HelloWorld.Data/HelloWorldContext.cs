using System.Configuration;
using System.Data.Entity;

namespace HelloWorld.Data
{
    public class HelloWorldContext : DbContext
    {
        //Given time, this is the way I would implement the context and pass the value via Unity
        //public HelloWorldContext(string connectionString):base(ConfigurationManager.ConnectionStrings["connectionString"].ToString())
        //{

        //}
       
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        //Ideally - this table needs to be in it's own database (log/error database)
        //public DbSet<Log> Logs { get; set; }
    }
}
