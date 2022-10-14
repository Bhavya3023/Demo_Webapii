using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Demo_Webapii.Models
{
    public class EmpDBContext : DbContext
    {
        public EmpDBContext(DbContextOptions<EmpDBContext> options): base(options)
            {

            }

        public DbSet<EmployeeClass>? EmployeeClasses { get; set; }
    }
}
