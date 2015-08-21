using System;
using System.Collections.Generic;

namespace mRingo.Data.Models
{
    public partial class GenreMaster
    {
        public GenreMaster()
        {
            this.ArtistGenres = new List<ArtistGenre>();
        }

        public long genre_id { get; set; }
        public string genre_nm { get; set; }
        public string cat_nm { get; set; }
        public System.DateTime rec_crt_ts { get; set; }
        public string rec_crt_by { get; set; }
        public string rec_upd_by { get; set; }
        public string rec_upd_ts { get; set; }
        public virtual ICollection<ArtistGenre> ArtistGenres { get; set; }
    }
}
