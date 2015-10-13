namespace mRingo.Web.Models

{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ArtistMaster")]
    public partial class ArtistMaster
    {
        public ArtistMaster()
        {
            ArtistGenres = new HashSet<ArtistGenre>();
            ArtistInstruments = new HashSet<ArtistInstrument>();
            CustomerArtistInfoes = new HashSet<CustomerArtistInfo>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long artist_info_id { get; set; }

        [StringLength(64)]
        public string frst_nm { get; set; }

        [StringLength(40)]
        public string mid_nm { get; set; }

        [Required]
        [StringLength(64)]
        public string last_nm { get; set; }

        [StringLength(40)]
        public string nick_nm { get; set; }

        [Required]
        [StringLength(100)]
        public string addr_ln_1_txt { get; set; }

        [StringLength(100)]
        public string addr_ln_2_txt { get; set; }

        [Required]
        [StringLength(35)]
        public string addr_city_nm { get; set; }

        [Required]
        [StringLength(35)]
        public string addr_state { get; set; }

        [Required]
        [StringLength(20)]
        public string addr_zip_cde { get; set; }

        [Required]
        [StringLength(40)]
        public string addr_ctry_nm { get; set; }

        [StringLength(40)]
        public string day_ph_nbr { get; set; }

        [StringLength(40)]
        public string evng_ph_nbr { get; set; }

        [StringLength(40)]
        public string cellph_nbr { get; set; }

        [StringLength(40)]
        public string pager_nbr { get; set; }

        [StringLength(40)]
        public string othr_ph_nbr { get; set; }

        [StringLength(40)]
        public string day_fax_nbr { get; set; }

        [StringLength(40)]
        public string evng_fax_nbr { get; set; }

        [StringLength(20)]
        public string login_id_txt { get; set; }

        [StringLength(150)]
        public string email_addr_txt { get; set; }

        [StringLength(150)]
        public string alt_email_addr_txt { get; set; }

        public DateTime rec_crt_ts { get; set; }

        [Required]
        [StringLength(20)]
        public string rec_crt_by { get; set; }

        [StringLength(20)]
        public string rec_upd_by { get; set; }

        [StringLength(20)]
        public string rec_upd_ts { get; set; }

        public virtual ICollection<ArtistGenre> ArtistGenres { get; set; }

        public virtual ICollection<ArtistInstrument> ArtistInstruments { get; set; }

        public virtual ICollection<CustomerArtistInfo> CustomerArtistInfoes { get; set; }
    }
}
