using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using mRingo.Data.Repositories;
using mRingo.Data.Models;
using mRingo.Data.Repositories.Disconnected;
using mRingo.Data.Repositories.Models;

namespace Repositories.Test
{
    [TestClass]
    public class RepoUnitTest
    {
        [TestMethod]
        public void CanCustomerInsert()
        {
            int isSaved = 0;
            using (var context = new CustomerMasterRepository(new UnitOfWork()))
            {
                var cust = new CustomerMaster
                {
                    addr_city_nm = "Beerakuppam",
                    addr_ctry_nm = "India",
                    addr_zip_cde = "517589",
                    addr_state = "AP",
                    addr_ln_1_txt = "Nagalapuram (M),Chittoor(d)",
                    mid_nm = "",
                    frst_nm = "Kanakaiah",
                    last_nm = "Etipakam",
                    email_addr_txt = "kanakaiah.e@gmail.com",
                    rec_crt_ts = DateTime.UtcNow,
                    rec_crt_by = "Test-Project-KK"
                };
                context.InsertOrUpdate(cust)
                ;

                isSaved = (int)cust.cust_info_id;

                isSaved = context.Save();

                Assert.AreEqual(1, isSaved);
            }
        }


        [TestMethod]
        public void CanCustomerInquiryInsert()
        {
            int isSaved = 0;
            using (var context = new CustomerInquiryRepository(new UnitOfWork()))
            {
                var cust = new CustomerInquiry
                {
                    cust_name="KK",
                    email_addr_txt="keinhim@yahoo.com",
                    //inquiry_id=1,
                    notes="Jesus is the Savior",
                    ph_nbr="",
                    rec_crt_by="KK",
                    rec_crt_ts=DateTime.UtcNow,
                    rec_upd_by="KK",
                    rec_upd_ts = DateTime.UtcNow
                    
                };
                context.InsertOrUpdate(cust)
                ;

               isSaved = context.Save();

                Assert.AreEqual(1, isSaved);
            }
        }
    }
}
