using Microsoft.EntityFrameworkCore;

namespace MVC_second.Models
{
    public class iticontext:DbContext
    {
        public DbSet<employee> employees { get; set; }
        public DbSet<department> departments { get; set; }
        //Data Source=.;Integrated Security=True;Encrypt=False;Trust Server Certificate=True
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer(@"Data Source=AYA_HAMDY\SQLEXPRESS;Database=
           second_mvc; Trusted_Connection = True; TrustServerCertificate = True");

            base.OnConfiguring(optionsBuilder);

        }
    }
}
/*
(@"Data Source=AYA_HAMDY\SQLEXPRESS;Database=second_mvc;Integrated Security=
True;Encrypt=False;Trust Server Certificate=True");
 */
