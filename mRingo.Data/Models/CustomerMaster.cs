using System;
using System.Collections.Generic;

namespace mRingo.Data.Models
{
    public partial class CustomerMaster
    {
        public long cust_info_id { get; set; }
        public string frst_nm { get; set; }
        public string mid_nm { get; set; }
        public string last_nm { get; set; }
        public string addr_ln_1_txt { get; set; }
        public string addr_ln_2_txt { get; set; }
        public string addr_city_nm { get; set; }
        public string addr_state { get; set; }
        public string addr_zip_cde { get; set; }
        public string addr_ctry_nm { get; set; }
        public string day_ph_nbr { get; set; }
        public string evng_ph_nbr { get; set; }
        public string cellph_nbr { get; set; }
        public string pager_nbr { get; set; }
        public string othr_ph_nbr { get; set; }
        public string day_fax_nbr { get; set; }
        public string evng_fax_nbr { get; set; }
        public string login_id_txt { get; set; }
        public string email_addr_txt { get; set; }
        public string alt_email_addr_txt { get; set; }
        public System.DateTime rec_crt_ts { get; set; }
        public string rec_crt_by { get; set; }
        public string rec_upd_by { get; set; }
        public string rec_upd_ts { get; set; }
    }
}
