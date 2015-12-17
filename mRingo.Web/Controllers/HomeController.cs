using mRingo.Data.Models;
using mRingo.Data.Repositories.Disconnected;
using mRingo.Data.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mRingo.Web.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
        

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        private CustomerInquiryRepository db = new CustomerInquiryRepository(new UnitOfWork());

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Inquiry([Bind(Include = "inquiry_id,cust_name,email_addr_txt,ph_nbr,notes,rec_crt_ts,rec_crt_by,rec_upd_by,rec_upd_ts")] CustomerInquiry customerInquiry)
        {

            if (ModelState.IsValid)
            {
                db.InsertOrUpdate(customerInquiry);
                db.Save();
                DisplaySuccessMessage("Success! You have sent a message.");
                return RedirectToAction("Contact");
            }

            DisplayErrorMessage();
            return View(customerInquiry);
        }


        public ActionResult Inquiry()
        {
            return View();
        }

        private void DisplaySuccessMessage(string msgText)
        {
            TempData["SuccessMessage"] = msgText;
        }

        private void DisplayErrorMessage()
        {
            TempData["ErrorMessage"] = "Save changes was unsuccessful.";
        }


        public ActionResult Faqs()
        {
            return View();
        }
        public ActionResult Terms()
        {
            return View();
        }

        public ActionResult Testimonials()
        {
            return View();
        }
    }
}