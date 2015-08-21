using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace mRingo.Data.Models.Mapping
{
    public class ArtistGenreMap : EntityTypeConfiguration<ArtistGenre>
    {
        public ArtistGenreMap()
        {
            // Primary Key
            this.HasKey(t => t.artist_genre_id);

            // Properties
            this.Property(t => t.artist_genre_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.default_genre_nm)
                .HasMaxLength(64);

            this.Property(t => t.genre_rating_txt)
                .HasMaxLength(10);

            this.Property(t => t.rec_crt_by)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.rec_upd_by)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("ArtistGenre");
            this.Property(t => t.artist_genre_id).HasColumnName("artist_genre_id");
            this.Property(t => t.artist_info_id).HasColumnName("artist_info_id");
            this.Property(t => t.genre_id).HasColumnName("genre_id");
            this.Property(t => t.artist_cost_per_hr).HasColumnName("artist_cost_per_hr");
            this.Property(t => t.default_genre_nm).HasColumnName("default_genre_nm");
            this.Property(t => t.genre_rating_txt).HasColumnName("genre_rating_txt");
            this.Property(t => t.rec_crt_ts).HasColumnName("rec_crt_ts");
            this.Property(t => t.rec_crt_by).HasColumnName("rec_crt_by");
            this.Property(t => t.rec_upd_by).HasColumnName("rec_upd_by");
            this.Property(t => t.rec_upd_ts).HasColumnName("rec_upd_ts");

            // Relationships
            this.HasRequired(t => t.ArtistMaster)
                .WithMany(t => t.ArtistGenres)
                .HasForeignKey(d => d.artist_info_id);
            this.HasRequired(t => t.GenreMaster)
                .WithMany(t => t.ArtistGenres)
                .HasForeignKey(d => d.genre_id);

        }
    }
}
