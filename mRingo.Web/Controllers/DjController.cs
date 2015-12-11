using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using mRingo.Web.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System.Threading.Tasks;
using System.Text;

namespace mRingo.Web.Controllers
{
    public class DjController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;

        public DjController()
        {

        }

        public DjController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }

        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }


        // GET: Dj
        public ActionResult Index()
        {
            return View(db.ArtistMasters.ToList());
        }

        // GET: Dj/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ArtistMaster artistMaster = db.ArtistMasters.Find(id);
            if (artistMaster == null)
            {
                return HttpNotFound();
            }
            return View(artistMaster);
        }

        // GET: Dj/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dj/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "artist_info_id,frst_nm,mid_nm,last_nm,nick_nm,addr_ln_1_txt,addr_ln_2_txt,addr_city_nm,addr_state,addr_zip_cde,addr_ctry_nm,day_ph_nbr,evng_ph_nbr,cellph_nbr,pager_nbr,othr_ph_nbr,day_fax_nbr,evng_fax_nbr,login_id_txt,email_addr_txt,alt_email_addr_txt,rec_crt_ts,rec_crt_by,rec_upd_by,rec_upd_ts")] ArtistMaster artistMaster)
        {
            if (ModelState.IsValid)
            {
                db.ArtistMasters.Add(artistMaster);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(artistMaster);
        }

        // GET: Dj/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ArtistMaster artistMaster = db.ArtistMasters.Find(id);
            if (artistMaster == null)
            {
                return HttpNotFound();
            }
            return View(artistMaster);
        }

        // POST: Dj/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "artist_info_id,frst_nm,mid_nm,last_nm,nick_nm,addr_ln_1_txt,addr_ln_2_txt,addr_city_nm,addr_state,addr_zip_cde,addr_ctry_nm,day_ph_nbr,evng_ph_nbr,cellph_nbr,pager_nbr,othr_ph_nbr,day_fax_nbr,evng_fax_nbr,login_id_txt,email_addr_txt,alt_email_addr_txt,rec_crt_ts,rec_crt_by,rec_upd_by,rec_upd_ts")] ArtistMaster artistMaster)
        {
            if (ModelState.IsValid)
            {
                db.Entry(artistMaster).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(artistMaster);
        }

        // GET: Dj/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ArtistMaster artistMaster = db.ArtistMasters.Find(id);
            if (artistMaster == null)
            {
                return HttpNotFound();
            }
            return View(artistMaster);
        }

        // POST: Dj/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            ArtistMaster artistMaster = db.ArtistMasters.Find(id);
            db.ArtistMasters.Remove(artistMaster);
            db.SaveChanges();
            return RedirectToAction("Index");
        }



        public async Task<ActionResult> Book(long? id)
        {

            ArtistMaster artistMaster = db.ArtistMasters.Find(id);

            //string htmlbody = @"<html><head><title></title></head><body><h2>Hereyougo</h2><p>Please contact the band group directly at</p><ul><li>Name:" + artistMaster.frst_nm + "</li><li>Mobile#:" + @artistMaster.day_ph_nbr.ToString() + "</li></ul><p>Haveaniceday!</p><p>-mRingoTeam</p></body></html>";
            //htmlbody=System.Net.WebUtility.HtmlEncode(htmlbody);
             await UserManager.SendEmailAsync(
                //artist.email_addr_txt,
                "1f1e69a2-bfe2-4bac-ae3d-ae07bbb77aba",
                "Here is the Booking email for your Band",
                "Name: " + artistMaster.frst_nm + "  Mobile#:" + @artistMaster.day_ph_nbr.ToString() + "  Haveaniceday!        -mRingoTeam");

            return RedirectToAction("Index");
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> Book([Bind(Include = "artist_info_id,frst_nm,mid_nm,last_nm,nick_nm,addr_ln_1_txt,addr_ln_2_txt,addr_city_nm,addr_state,addr_zip_cde,addr_ctry_nm,day_ph_nbr,evng_ph_nbr,cellph_nbr,pager_nbr,othr_ph_nbr,day_fax_nbr,evng_fax_nbr,login_id_txt,email_addr_txt,alt_email_addr_txt,rec_crt_ts,rec_crt_by,rec_upd_by,rec_upd_ts")] ArtistMaster artistMaster)
        {
            if (ModelState.IsValid)
            {
                await UserManager.SendEmailAsync(
                //artist.email_addr_txt,
                "1f1e69a2-bfe2-4bac-ae3d-ae07bbb77aba",
                "<br>Here is the Booking email for your Band</br>",
                "Please contact them at 425-829-0230");

                return RedirectToAction("Index");
            }
            return View(artistMaster);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
