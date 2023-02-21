using CRUD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Data.Common;

namespace CRUD.Data
{
    public class ApplicationDBContext: DbContext
    {  

      public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options) :base(options){ 
        }

        public DbSet<Employee> Employees { get; set; } //representative of table database
    }
}
