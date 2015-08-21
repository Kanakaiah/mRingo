using System;
using System.Collections.Generic;

namespace mRingo.Data.Models
{
    public partial class InstrumentMaster
    {
        public InstrumentMaster()
        {
            this.ArtistInstruments = new List<ArtistInstrument>();
        }

        public long instrument_id { get; set; }
        public string instrument_nm { get; set; }
        public string instrument_typ { get; set; }
        public System.DateTime rec_crt_ts { get; set; }
        public string rec_crt_by { get; set; }
        public string rec_upd_by { get; set; }
        public Nullable<System.DateTime> rec_upd_ts { get; set; }
        public virtual ICollection<ArtistInstrument> ArtistInstruments { get; set; }
    }
}
