namespace mRingo.Web.Models

{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GenreMaster")]
    public partial class GenreMaster
    {
        public GenreMaster()
        {
            ArtistGenres = new HashSet<ArtistGenre>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long genre_id { get; set; }

        [Required]
        [StringLength(64)]
        public string genre_nm { get; set; }

        [StringLength(40)]
        public string cat_nm { get; set; }

        public DateTime rec_crt_ts { get; set; }

        [Required]
        [StringLength(20)]
        public string rec_crt_by { get; set; }

        [StringLength(20)]
        public string rec_upd_by { get; set; }

        [StringLength(20)]
        public string rec_upd_ts { get; set; }

        public virtual ICollection<ArtistGenre> ArtistGenres { get; set; }
    }
}
