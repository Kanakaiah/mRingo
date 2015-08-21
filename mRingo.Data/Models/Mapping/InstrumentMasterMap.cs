using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace mRingo.Data.Models.Mapping
{
    public class InstrumentMasterMap : EntityTypeConfiguration<InstrumentMaster>
    {
        public InstrumentMasterMap()
        {
            // Primary Key
            this.HasKey(t => t.instrument_id);

            // Properties
            this.Property(t => t.instrument_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.instrument_nm)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.instrument_typ)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.rec_crt_by)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.rec_upd_by)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("InstrumentMaster");
            this.Property(t => t.instrument_id).HasColumnName("instrument_id");
            this.Property(t => t.instrument_nm).HasColumnName("instrument_nm");
            this.Property(t => t.instrument_typ).HasColumnName("instrument_typ");
            this.Property(t => t.rec_crt_ts).HasColumnName("rec_crt_ts");
            this.Property(t => t.rec_crt_by).HasColumnName("rec_crt_by");
            this.Property(t => t.rec_upd_by).HasColumnName("rec_upd_by");
            this.Property(t => t.rec_upd_ts).HasColumnName("rec_upd_ts");
        }
    }
}
