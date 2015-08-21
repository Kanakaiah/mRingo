namespace mRingo.Web.Models

{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InstrumentMaster")]
    public partial class InstrumentMaster
    {
        public InstrumentMaster()
        {
            ArtistInstruments = new HashSet<ArtistInstrument>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long instrument_id { get; set; }

        [Required]
        [StringLength(64)]
        public string instrument_nm { get; set; }

        [Required]
        [StringLength(40)]
        public string instrument_typ { get; set; }

        public DateTime rec_crt_ts { get; set; }

        [Required]
        [StringLength(20)]
        public string rec_crt_by { get; set; }

        [StringLength(20)]
        public string rec_upd_by { get; set; }

        public DateTime? rec_upd_ts { get; set; }

        public virtual ICollection<ArtistInstrument> ArtistInstruments { get; set; }
    }
}
