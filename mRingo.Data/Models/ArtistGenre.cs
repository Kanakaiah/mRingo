using System;
using System.Collections.Generic;

namespace mRingo.Data.Models
{
    public partial class ArtistGenre
    {
        public long artist_genre_id { get; set; }
        public long artist_info_id { get; set; }
        public long genre_id { get; set; }
        public Nullable<decimal> artist_cost_per_hr { get; set; }
        public string default_genre_nm { get; set; }
        public string genre_rating_txt { get; set; }
        public System.DateTime rec_crt_ts { get; set; }
        public string rec_crt_by { get; set; }
        public string rec_upd_by { get; set; }
        public Nullable<System.DateTime> rec_upd_ts { get; set; }
        public virtual ArtistMaster ArtistMaster { get; set; }
        public virtual GenreMaster GenreMaster { get; set; }
    }
}
