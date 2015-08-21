using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace mRingo.Data.Models.Mapping
{
    public class GenreMasterMap : EntityTypeConfiguration<GenreMaster>
    {
        public GenreMasterMap()
        {
            // Primary Key
            this.HasKey(t => t.genre_id);

            // Properties
            this.Property(t => t.genre_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.genre_nm)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.cat_nm)
                .HasMaxLength(40);

            this.Property(t => t.rec_crt_by)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.rec_upd_by)
                .HasMaxLength(20);

            this.Property(t => t.rec_upd_ts)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("GenreMaster");
            this.Property(t => t.genre_id).HasColumnName("genre_id");
            this.Property(t => t.genre_nm).HasColumnName("genre_nm");
            this.Property(t => t.cat_nm).HasColumnName("cat_nm");
            this.Property(t => t.rec_crt_ts).HasColumnName("rec_crt_ts");
            this.Property(t => t.rec_crt_by).HasColumnName("rec_crt_by");
            this.Property(t => t.rec_upd_by).HasColumnName("rec_upd_by");
            this.Property(t => t.rec_upd_ts).HasColumnName("rec_upd_ts");
        }
    }
}
