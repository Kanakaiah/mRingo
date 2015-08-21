using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace mRingo.Data.Models.Mapping
{
    public class CustomerArtistInfoMap : EntityTypeConfiguration<CustomerArtistInfo>
    {
        public CustomerArtistInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.cust_artist_id);

            // Properties
            this.Property(t => t.cust_artist_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.review_txt)
                .HasMaxLength(1000);

            this.Property(t => t.suggest_txt)
                .HasMaxLength(1000);

            this.Property(t => t.rating_txt)
                .HasMaxLength(10);

            this.Property(t => t.notes)
                .HasMaxLength(1000);

            this.Property(t => t.confirmed_flg)
                .HasMaxLength(1);

            this.Property(t => t.rec_crt_by)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.rec_upd_by)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("CustomerArtistInfo");
            this.Property(t => t.cust_artist_id).HasColumnName("cust_artist_id");
            this.Property(t => t.cust_info_id).HasColumnName("cust_info_id");
            this.Property(t => t.artist_info_id).HasColumnName("artist_info_id");
            this.Property(t => t.review_txt).HasColumnName("review_txt");
            this.Property(t => t.suggest_txt).HasColumnName("suggest_txt");
            this.Property(t => t.rating_txt).HasColumnName("rating_txt");
            this.Property(t => t.notes).HasColumnName("notes");
            this.Property(t => t.booked_when_ts).HasColumnName("booked_when_ts");
            this.Property(t => t.genre_id).HasColumnName("genre_id");
            this.Property(t => t.artist_cost_per_hr).HasColumnName("artist_cost_per_hr");
            this.Property(t => t.discount).HasColumnName("discount");
            this.Property(t => t.booked_hr).HasColumnName("booked_hr");
            this.Property(t => t.actual_hr).HasColumnName("actual_hr");
            this.Property(t => t.total_cost).HasColumnName("total_cost");
            this.Property(t => t.actual_cost).HasColumnName("actual_cost");
            this.Property(t => t.confirmed_flg).HasColumnName("confirmed_flg");
            this.Property(t => t.rec_crt_ts).HasColumnName("rec_crt_ts");
            this.Property(t => t.rec_crt_by).HasColumnName("rec_crt_by");
            this.Property(t => t.rec_upd_by).HasColumnName("rec_upd_by");
            this.Property(t => t.rec_upd_ts).HasColumnName("rec_upd_ts");

            // Relationships
            this.HasRequired(t => t.ArtistMaster)
                .WithMany(t => t.CustomerArtistInfoes)
                .HasForeignKey(d => d.artist_info_id);

        }
    }
}
