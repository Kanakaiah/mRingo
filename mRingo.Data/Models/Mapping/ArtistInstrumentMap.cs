using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace mRingo.Data.Models.Mapping
{
    public class ArtistInstrumentMap : EntityTypeConfiguration<ArtistInstrument>
    {
        public ArtistInstrumentMap()
        {
            // Primary Key
            this.HasKey(t => t.artist_instrument_id);

            // Properties
            this.Property(t => t.artist_instrument_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.rec_crt_by)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.rec_upd_by)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("ArtistInstrument");
            this.Property(t => t.artist_instrument_id).HasColumnName("artist_instrument_id");
            this.Property(t => t.artist_info_id).HasColumnName("artist_info_id");
            this.Property(t => t.instrument_id).HasColumnName("instrument_id");
            this.Property(t => t.rec_crt_ts).HasColumnName("rec_crt_ts");
            this.Property(t => t.rec_crt_by).HasColumnName("rec_crt_by");
            this.Property(t => t.rec_upd_by).HasColumnName("rec_upd_by");
            this.Property(t => t.rec_upd_ts).HasColumnName("rec_upd_ts");

            // Relationships
            this.HasRequired(t => t.ArtistMaster)
                .WithMany(t => t.ArtistInstruments)
                .HasForeignKey(d => d.artist_info_id);
            this.HasOptional(t => t.InstrumentMaster)
                .WithMany(t => t.ArtistInstruments)
                .HasForeignKey(d => d.instrument_id);

        }
    }
}
