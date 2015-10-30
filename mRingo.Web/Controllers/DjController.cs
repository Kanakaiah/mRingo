using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using mRingo.Web.Models;

namespace mRingo.Web.Controllers
{
    public class DjController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

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
