using mRingo.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mRingo.Data.Initilization
{
    public class mRingoDatabase:DbContext
    {
        public DbSet<ArtistGenre> ArtistGenres { get; set; }
        public DbSet<ArtistInstrument> ArtistInstruments { get; set; }
        public DbSet<ArtistMaster> ArtistMasters { get; set; }
        public DbSet<CalenderMaster> CalenderMasters { get; set; }
        public DbSet<CustomerArtistInfo> CustomerArtistInfoes { get; set; }
        public DbSet<CustomerInquiry> CustomerInquiries { get; set; }
        public DbSet<CustomerMaster> CustomerMasters { get; set; }
        public DbSet<GenreMaster> GenreMasters { get; set; }
        public DbSet<InstrumentMaster> InstrumentMasters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           

            /*
               modelBuilder.Ignore<Category>();
             */
        }
    }
}
