using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;

namespace mRingo.Data.Services.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<mRingo.Data.Models.CustomerMaster> CustomerMasters { get; set; }

        public System.Data.Entity.DbSet<mRingo.Data.Models.ArtistGenre> ArtistGenres { get; set; }

        public System.Data.Entity.DbSet<mRingo.Data.Models.ArtistMaster> ArtistMasters { get; set; }

        public System.Data.Entity.DbSet<mRingo.Data.Models.GenreMaster> GenreMasters { get; set; }

        public System.Data.Entity.DbSet<mRingo.Data.Models.ArtistInstrument> ArtistInstruments { get; set; }

        public System.Data.Entity.DbSet<mRingo.Data.Models.InstrumentMaster> InstrumentMasters { get; set; }

        public System.Data.Entity.DbSet<mRingo.Data.Models.CalenderMaster> CalenderMasters { get; set; }

        public System.Data.Entity.DbSet<mRingo.Data.Models.CustomerArtistInfo> CustomerArtistInfoes { get; set; }
    }
}