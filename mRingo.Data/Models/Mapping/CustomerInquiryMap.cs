using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace mRingo.Data.Models.Mapping
{
    public class CustomerInquiryMap : EntityTypeConfiguration<CustomerInquiry>
    {
        public CustomerInquiryMap()
        {
            // Primary Key
            this.HasKey(t => t.inquiry_id);

            // Properties
            this.Property(t => t.inquiry_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.cust_name)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.email_addr_txt)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.ph_nbr)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.notes)
                .HasMaxLength(100);

            this.Property(t => t.rec_crt_by)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.rec_upd_by)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("CustomerInquiry");
            this.Property(t => t.inquiry_id).HasColumnName("inquiry_id");
            this.Property(t => t.cust_name).HasColumnName("cust_name");
            this.Property(t => t.email_addr_txt).HasColumnName("email_addr_txt");
            this.Property(t => t.ph_nbr).HasColumnName("ph_nbr");
            this.Property(t => t.notes).HasColumnName("notes");
            this.Property(t => t.rec_crt_ts).HasColumnName("rec_crt_ts");
            this.Property(t => t.rec_crt_by).HasColumnName("rec_crt_by");
            this.Property(t => t.rec_upd_by).HasColumnName("rec_upd_by");
            this.Property(t => t.rec_upd_ts).HasColumnName("rec_upd_ts");
        }
    }
}
