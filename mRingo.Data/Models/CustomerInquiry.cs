using System;
using System.Collections.Generic;

namespace mRingo.Data.Models
{
    public partial class CustomerInquiry
    {
        public long inquiry_id { get; set; }
        public string cust_name { get; set; }
        public string email_addr_txt { get; set; }
        public string ph_nbr { get; set; }
        public string notes { get; set; }
        public System.DateTime rec_crt_ts { get; set; }
        public string rec_crt_by { get; set; }
        public string rec_upd_by { get; set; }
        public Nullable<System.DateTime> rec_upd_ts { get; set; }
    }
}
