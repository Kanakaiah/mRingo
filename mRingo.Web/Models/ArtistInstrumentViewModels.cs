namespace mRingo.Web.Models

{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ArtistInstrument")]
    public partial class ArtistInstrument
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long artist_instrument_id { get; set; }

        public long artist_info_id { get; set; }

        public long? instrument_id { get; set; }

        public DateTime rec_crt_ts { get; set; }

        [Required]
        [StringLength(20)]
        public string rec_crt_by { get; set; }

        [StringLength(20)]
        public string rec_upd_by { get; set; }

        public DateTime? rec_upd_ts { get; set; }

        public virtual ArtistMaster ArtistMaster { get; set; }

        public virtual InstrumentMaster InstrumentMaster { get; set; }
    }
}
