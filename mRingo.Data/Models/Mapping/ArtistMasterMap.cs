using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace mRingo.Data.Models.Mapping
{
    public class ArtistMasterMap : EntityTypeConfiguration<ArtistMaster>
    {
        public ArtistMasterMap()
        {
            // Primary Key
            this.HasKey(t => t.artist_info_id);

            // Properties
            this.Property(t => t.artist_info_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.frst_nm)
                .HasMaxLength(64);

            this.Property(t => t.mid_nm)
                .HasMaxLength(40);

            this.Property(t => t.last_nm)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.nick_nm)
                .HasMaxLength(40);

            this.Property(t => t.addr_ln_1_txt)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.addr_ln_2_txt)
                .HasMaxLength(100);

            this.Property(t => t.addr_city_nm)
                .IsRequired()
                .HasMaxLength(35);

            this.Property(t => t.addr_state)
                .IsRequired()
                .HasMaxLength(35);

            this.Property(t => t.addr_zip_cde)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.addr_ctry_nm)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.day_ph_nbr)
                .HasMaxLength(40);

            this.Property(t => t.evng_ph_nbr)
                .HasMaxLength(40);

            this.Property(t => t.cellph_nbr)
                .HasMaxLength(40);

            this.Property(t => t.pager_nbr)
                .HasMaxLength(40);

            this.Property(t => t.othr_ph_nbr)
                .HasMaxLength(40);

            this.Property(t => t.day_fax_nbr)
                .HasMaxLength(40);

            this.Property(t => t.evng_fax_nbr)
                .HasMaxLength(40);

            this.Property(t => t.login_id_txt)
                .HasMaxLength(20);

            this.Property(t => t.email_addr_txt)
                .HasMaxLength(150);

            this.Property(t => t.alt_email_addr_txt)
                .HasMaxLength(150);

            this.Property(t => t.rec_crt_by)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.rec_upd_by)
                .HasMaxLength(20);

            this.Property(t => t.rec_upd_ts)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("ArtistMaster");
            this.Property(t => t.artist_info_id).HasColumnName("artist_info_id");
            this.Property(t => t.frst_nm).HasColumnName("frst_nm");
            this.Property(t => t.mid_nm).HasColumnName("mid_nm");
            this.Property(t => t.last_nm).HasColumnName("last_nm");
            this.Property(t => t.nick_nm).HasColumnName("nick_nm");
            this.Property(t => t.addr_ln_1_txt).HasColumnName("addr_ln_1_txt");
            this.Property(t => t.addr_ln_2_txt).HasColumnName("addr_ln_2_txt");
            this.Property(t => t.addr_city_nm).HasColumnName("addr_city_nm");
            this.Property(t => t.addr_state).HasColumnName("addr_state");
            this.Property(t => t.addr_zip_cde).HasColumnName("addr_zip_cde");
            this.Property(t => t.addr_ctry_nm).HasColumnName("addr_ctry_nm");
            this.Property(t => t.day_ph_nbr).HasColumnName("day_ph_nbr");
            this.Property(t => t.evng_ph_nbr).HasColumnName("evng_ph_nbr");
            this.Property(t => t.cellph_nbr).HasColumnName("cellph_nbr");
            this.Property(t => t.pager_nbr).HasColumnName("pager_nbr");
            this.Property(t => t.othr_ph_nbr).HasColumnName("othr_ph_nbr");
            this.Property(t => t.day_fax_nbr).HasColumnName("day_fax_nbr");
            this.Property(t => t.evng_fax_nbr).HasColumnName("evng_fax_nbr");
            this.Property(t => t.login_id_txt).HasColumnName("login_id_txt");
            this.Property(t => t.email_addr_txt).HasColumnName("email_addr_txt");
            this.Property(t => t.alt_email_addr_txt).HasColumnName("alt_email_addr_txt");
            this.Property(t => t.rec_crt_ts).HasColumnName("rec_crt_ts");
            this.Property(t => t.rec_crt_by).HasColumnName("rec_crt_by");
            this.Property(t => t.rec_upd_by).HasColumnName("rec_upd_by");
            this.Property(t => t.rec_upd_ts).HasColumnName("rec_upd_ts");
        }
    }
}
