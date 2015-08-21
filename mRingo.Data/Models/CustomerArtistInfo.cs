using System;
using System.Collections.Generic;

namespace mRingo.Data.Models
{
    public partial class CustomerArtistInfo
    {
        public long cust_artist_id { get; set; }
        public long cust_info_id { get; set; }
        public long artist_info_id { get; set; }
        public string review_txt { get; set; }
        public string suggest_txt { get; set; }
        public string rating_txt { get; set; }
        public string notes { get; set; }
        public Nullable<System.DateTime> booked_when_ts { get; set; }
        public Nullable<long> genre_id { get; set; }
        public Nullable<decimal> artist_cost_per_hr { get; set; }
        public Nullable<decimal> discount { get; set; }
        public Nullable<decimal> booked_hr { get; set; }
        public Nullable<decimal> actual_hr { get; set; }
        public Nullable<decimal> total_cost { get; set; }
        public Nullable<decimal> actual_cost { get; set; }
        public string confirmed_flg { get; set; }
        public System.DateTime rec_crt_ts { get; set; }
        public string rec_crt_by { get; set; }
        public string rec_upd_by { get; set; }
        public Nullable<System.DateTime> rec_upd_ts { get; set; }
        public virtual ArtistMaster ArtistMaster { get; set; }
    }
}
