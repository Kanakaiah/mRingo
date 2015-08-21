using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Data.Entity;

namespace mRingoSystem.Data.Test
{
    [TestClass]
    public class TestContext
    {
        //[TestMethod]
        //public void CanInsertCustomer()
        //{
        //    //int isSaved=0;
        //    //using(var context=new mRingoContext())
        //    //{
        //    //    var cust = new CustomerMaster
        //    //    {
        //    //        addr_city_nm = "Beerakuppam",
        //    //        addr_ctry_nm = "India",
        //    //        addr_zip_cde = "517589",
        //    //        addr_state = "AP",
        //    //        addr_ln_1_txt = "Nagalapuram (M),Chittoor(d)",
        //    //        mid_nm = "",
        //    //        frst_nm = "Vikram",
        //    //        last_nm = "Etipakam",
        //    //        email_addr_txt = "vikram.e@gmail.com",
        //    //        rec_crt_ts = DateTime.UtcNow,
        //    //        rec_crt_by = "Test Project-KK"
        //    //    };
        //    //    context.CustomerMasters.Add(cust)
        //    //    ;

        //    //    isSaved=(int)cust.cust_info_id;
                    
        //    //    isSaved=context.SaveChanges();
        //    //}

        //    //using(var context=new mRingoContext())
        //    //{
        //    //    Assert.IsTrue(isSaved == 1);

        //    //}
        //}


        //public void CanNavigateFrome2ndContextTo1ContextAndEditSomething()
        //{
        //    long customerId = 0;
        //    using (var context = new AccountContext())
        //    {
        //        var cust = context.CustomerMasters.FirstOrDefault();
        //        customerId = cust.cust_info_id;
        //    }

        //    using (var context = new CustomerServiceContext())
        //    {
        //        var customer = context.Customers.Find(customerId);
        //        context.Entry(customer).Reference(c => c.OtherTable).Load();
        //        customer.othertable.prop = "";
        //        context.SaveChanges();

        //    }
        //    using(var context=new CustomerServiceContext() )
        //    {
        //        Assert.AreEqual("1" + originalStreet, context.Customers.Where(context => context.id = customerId).select(customerId => customerId.shippingAddress).FirstOrDefault().Stree1);
        //    }
        //}



        //[TestMethod]
        //public void CanCreatemRingoDatabase()
        //{
        //    Database.SetInitializer(new DropCreateDatabaseIfModelChanges<mRingoDatabase>());
        //    using(var context=new mRingoDatabase())
        //    {
        //        Assert.AreEqual(0, context.CustomerMasters.Count());
        //    }
        //}
    
    
        //[TestMethod]
        //public void CanGetCustomer()
        //{
        //    using (var repo = new CustomerMasterRepository(new UnitOfWork()))
        //    {
        //        foreach (var customer in repo.All.ToList())
        //        {
        //            Console.WriteLine(customer.frst_nm)
        //           ;
        //        }
        //    }

        //    WaitConsole();
        
        //}

        [TestMethod]
        public void CanInsertCustomer()
        {
            //using (var repo = new CustomerMasterRepository(new UnitOfWork()))
            //{
            //    var cust = new CustomerMaster
            //    {
            //        addr_city_nm = "Beerakuppam",
            //        addr_ctry_nm = "India",
            //        addr_zip_cde = "517589",
            //        addr_state = "AP",
            //        addr_ln_1_txt = "Nagalapuram (M),Chittoor(d)",
            //        mid_nm = "",
            //        frst_nm = "Vikram",
            //        last_nm = "Etipakam",
            //        email_addr_txt = "vikram.e@gmail.com",
            //        rec_crt_ts = DateTime.UtcNow,
            //        rec_crt_by = "Test Project-KK"
            //    };
            //    context.CustomerMasters.Add(cust)
            //    ;

            //    isSaved = (int)cust.cust_info_id;

            //    isSaved = context.SaveChanges();
            //}

            //using (var context = new mRingoContext())
            //{
            //    Assert.IsTrue(isSaved == 1);

            //}
        }

        //[TestMethod]
        //public void CanDeleteCustomer()
        //{
        //    using (var repo = new CustomerMasterRepository(new UnitOfWork()))
        //    {
        //        foreach (var customer in repo.All.ToList())
        //        {
        //            Console.WriteLine(customer.frst_nm)
        //           ;
        //        }
        //    }

        //    WaitConsole();

        //}

        //[TestMethod]
        //public void CanUpdateCustomer()
        //{
        //    using (var repo = new CustomerMasterRepository(new UnitOfWork()))
        //    {
        //        foreach (var customer in repo.All.ToList())
        //        {
        //            Console.WriteLine(customer.frst_nm)
        //           ;
        //        }
        //    }

        //    WaitConsole();

        //}
    }
}
