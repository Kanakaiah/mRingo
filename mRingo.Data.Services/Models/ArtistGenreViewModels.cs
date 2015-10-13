namespace mRingo.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ArtistGenre
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long artist_genre_id { get; set; }

        public long artist_info_id { get; set; }

        public long genre_id { get; set; }

        public decimal? artist_cost_per_hr { get; set; }

        [StringLength(64)]
        public string default_genre_nm { get; set; }

        [StringLength(10)]
        public string genre_rating_txt { get; set; }

        public DateTime rec_crt_ts { get; set; }

        [Required]
        [StringLength(20)]
        public string rec_crt_by { get; set; }

        [StringLength(20)]
        public string rec_upd_by { get; set; }

        public DateTime? rec_upd_ts { get; set; }

        public virtual ArtistMaster ArtistMaster { get; set; }

        public virtual GenreMaster GenreMaster { get; set; }
    }
}
