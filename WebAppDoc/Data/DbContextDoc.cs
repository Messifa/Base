using Microsoft.EntityFrameworkCore;
using WebAppDoc.Models;

namespace WebAppDoc.Data
{
    public class DbContextDoc:DbContext
    {

        public DbContextDoc(DbContextOptions<DbContextDoc> Options):base(Options) 
        {

        }

        public DbSet<patient> Patients { get; set; }
        public DbSet<Choice> Choices { get; set; }
        public DbSet<Medoc> medocs { get; set; }

       
		


    }
}
