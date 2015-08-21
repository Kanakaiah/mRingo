using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using mRingo.Data.Models.Mapping;

namespace mRingo.Data.Models
{
    public partial class mRingoContext : DbContext
    {
        static mRingoContext()
        {
            Database.SetInitializer<mRingoContext>(null);
        }

        public mRingoContext()
            : base("Name=mRingoContext")
        {
        }

        public DbSet<ArtistGenre> ArtistGenres { get; set; }
        public DbSet<ArtistInstrument> ArtistInstruments { get; set; }
        public DbSet<ArtistMaster> ArtistMasters { get; set; }
        public DbSet<CalenderMaster> CalenderMasters { get; set; }
        public DbSet<CustomerArtistInfo> CustomerArtistInfoes { get; set; }
        public DbSet<CustomerInquiry> CustomerInquiries { get; set; }
        public DbSet<CustomerMaster> CustomerMasters { get; set; }
        public DbSet<GenreMaster> GenreMasters { get; set; }
        public DbSet<InstrumentMaster> InstrumentMasters { get; set; }
        //public DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ArtistGenreMap());
            modelBuilder.Configurations.Add(new ArtistInstrumentMap());
            modelBuilder.Configurations.Add(new ArtistMasterMap());
            modelBuilder.Configurations.Add(new CalenderMasterMap());
            modelBuilder.Configurations.Add(new CustomerArtistInfoMap());
            modelBuilder.Configurations.Add(new CustomerInquiryMap());
            modelBuilder.Configurations.Add(new CustomerMasterMap());
            modelBuilder.Configurations.Add(new GenreMasterMap());
            modelBuilder.Configurations.Add(new InstrumentMasterMap());
            //modelBuilder.Configurations.Add(new sysdiagramMap());
        }
    }
}
