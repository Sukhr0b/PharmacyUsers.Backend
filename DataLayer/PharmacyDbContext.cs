using Microsoft.EntityFrameworkCore;
using PharmacyUsers.Services;

namespace PharmacyUsers.Backend.DataLayer
{
    public class PharmacyDbContext: DbContext
    {

        public PharmacyDbContext(DbContextOptions<PharmacyDbContext> options)
            :base(options)
        {

        }

        public DbSet<UserModel> Model { get; set; }

    }
}
