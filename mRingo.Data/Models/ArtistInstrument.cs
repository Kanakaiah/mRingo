using System;
using System.Collections.Generic;

namespace mRingo.Data.Models
{
    public partial class ArtistInstrument
    {
        public long artist_instrument_id { get; set; }
        public long artist_info_id { get; set; }
        public Nullable<long> instrument_id { get; set; }
        public System.DateTime rec_crt_ts { get; set; }
        public string rec_crt_by { get; set; }
        public string rec_upd_by { get; set; }
        public Nullable<System.DateTime> rec_upd_ts { get; set; }
        public virtual ArtistMaster ArtistMaster { get; set; }
        public virtual InstrumentMaster InstrumentMaster { get; set; }
    }
}
