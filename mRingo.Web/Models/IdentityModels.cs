using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using mRingo.Data;
using System.ComponentModel.DataAnnotations;

namespace mRingo.Web.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public string AddressBlock
        {
            get
            {
                string addressBlock = string.Format("{0}<br/>{1}, {2} {3}", Address, City, State, ZipCode).Trim();
                return addressBlock == "<br/>," ? string.Empty : addressBlock;
            }
        }

    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("mRingoContext", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<mRingo.Web.Models.CustomerInquiry> CustomerInquiries { get; set; }
    }

    //public class ApplicationDbContext : mRingoContext
    //{
    //    //public ApplicationDbContext()
    //    //    : base("mRingoContext", throwIfV1Schema: false)
    //    //{
    //    //}

    //    //public static ApplicationDbContext Create()
    //    //{
    //    //    return new ApplicationDbContext();
    //    //}
    //}
}