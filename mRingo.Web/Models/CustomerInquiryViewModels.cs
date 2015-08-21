namespace mRingo.Web.Models

{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CustomerInquiry
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long inquiry_id { get; set; }

        [Required]
        [StringLength(64)]
        public string cust_name { get; set; }

        [Required]
        [StringLength(150)]
        public string email_addr_txt { get; set; }

        [Required]
        [StringLength(40)]
        public string ph_nbr { get; set; }

        [StringLength(100)]
        public string notes { get; set; }

        public DateTime rec_crt_ts { get; set; }

        [Required]
        [StringLength(20)]
        public string rec_crt_by { get; set; }

        [StringLength(20)]
        public string rec_upd_by { get; set; }

        public DateTime? rec_upd_ts { get; set; }
    }
}
