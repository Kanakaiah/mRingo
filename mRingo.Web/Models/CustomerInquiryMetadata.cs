using System;
using System.ComponentModel.DataAnnotations;

namespace mRingo.Web.Models
{
    [MetadataType(typeof(CustomerInquiryMetadata))]
    public partial class CustomerInquiry
    {
    }

    public partial class CustomerInquiryMetadata
    {
        [Required(ErrorMessage = "Please enter : inquiry_id")]
        [Display(Name = "inquiry_id")]
        public long inquiry_id { get; set; }

        [Display(Name = "Name")]
        public string cust_name { get; set; }

        [Display(Name = "Email")]
        public string email_addr_txt { get; set; }

        [Required(ErrorMessage = "Please enter : Mobile")]
        [Display(Name = "Mobile")]
        public string ph_nbr { get; set; }

        [Display(Name = "Text")]
        public string notes { get; set; }

        [Required(ErrorMessage = "Please enter : rec_crt_ts")]
        [Display(Name = "rec_crt_ts")]
        public DateTime rec_crt_ts { get; set; }

        [Required(ErrorMessage = "Please enter : rec_crt_by")]
        [Display(Name = "rec_crt_by")]
        public string rec_crt_by { get; set; }

        [Required(ErrorMessage = "Please enter : rec_upd_by")]
        [Display(Name = "rec_upd_by")]
        public string rec_upd_by { get; set; }

        [Required(ErrorMessage = "Please enter : rec_upd_ts")]
        [Display(Name = "rec_upd_ts")]
        public DateTime rec_upd_ts { get; set; }

    }
}
