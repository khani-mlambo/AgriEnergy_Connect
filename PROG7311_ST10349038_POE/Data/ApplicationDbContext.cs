using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PROG7311_ST10349038_POE.Models;

namespace PROG7311_ST10349038_POE.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //the "entity <>" is the model you're using (Asset), and next to it will be your table name for your database
        public DbSet<ProfileModel> Profiles { get; set; }
        public DbSet<ProductModel> Products { get; set; }
    }
}
