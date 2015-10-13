namespace mRingo.Web.Models

{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerArtistInfo")]
    public partial class CustomerArtistInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long cust_artist_id { get; set; }

        public long cust_info_id { get; set; }

        public long artist_info_id { get; set; }

        [StringLength(1000)]
        public string review_txt { get; set; }

        [StringLength(1000)]
        public string suggest_txt { get; set; }

        [StringLength(10)]
        public string rating_txt { get; set; }

        [StringLength(1000)]
        public string notes { get; set; }

        public DateTime? booked_when_ts { get; set; }

        public long? genre_id { get; set; }

        public decimal? artist_cost_per_hr { get; set; }

        public decimal? discount { get; set; }

        public decimal? booked_hr { get; set; }

        public decimal? actual_hr { get; set; }

        public decimal? total_cost { get; set; }

        public decimal? actual_cost { get; set; }

        [StringLength(1)]
        public string confirmed_flg { get; set; }

        public DateTime rec_crt_ts { get; set; }

        [Required]
        [StringLength(20)]
        public string rec_crt_by { get; set; }

        [StringLength(20)]
        public string rec_upd_by { get; set; }

        public DateTime? rec_upd_ts { get; set; }

        public virtual ArtistMaster ArtistMaster { get; set; }
    }
}
