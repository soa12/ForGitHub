using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UIRS.Models;

namespace UIRS.Controllers
{
    public class ObrasheniesController : Controller
    {

        private ObrashenieContext db = new ObrashenieContext();

        // GET: Obrashenies
        public ActionResult Index()
        {
            return View(db.Obrashenie.ToList());
        }

        // GET: Obrashenies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Obrashenie obrashenie = db.Obrashenie.Find(id);
            if (obrashenie == null)
            {
                return HttpNotFound();
            }
            return View(obrashenie);
        }

        // GET: Obrashenies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Obrashenies/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Lastname,Name1,Surname,Email,Phone,Texttreatment,Busnumber,Bustype,Busgosnumber,Busstop,DateAndTime,Waiting,FIOdriver,FIOconductor,FIOdispetcher,Earlyend,LateBeginning,BigInterval,BreachShedule,StopTravel,ViolationLanding,OutputWithoutContract,ViolationOfTrafficPatterns,VioletionOfTrafficRules,ConflictWithConductor,WrongSurrendere,NotAnnouncedBusstop,SmokingInCabin,DiscussionOnPhone,LoudMusic,LackOfTickets,FaultyBus,SmellOfGus,PoorSanCondition,WorkBoards,WorkSite,WorkSmsService,WorkOnLinemap,WorkMobileApplication,PoorStateReversalArea,PoorStateBusstop,DisadvantageOfInfrastructures,ConflictWithDispather,ComplianceWithShedule,GoodQualityService,CourteousStaff,GoodTransportCondition")] Obrashenie obrashenie)
        {
            if (ModelState.IsValid)
            {
                db.Obrashenie.Add(obrashenie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obrashenie);
        }

        // GET: Obrashenies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Obrashenie obrashenie = db.Obrashenie.Find(id);
            if (obrashenie == null)
            {
                return HttpNotFound();
            }
            return View(obrashenie);
        }

        // POST: Obrashenies/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Lastname,Name1,Surname,Email,Phone,Texttreatment,Busnumber,Bustype,Busgosnumber,Busstop,DateAndTime,Waiting,FIOdriver,FIOconductor,FIOdispetcher,Earlyend,LateBeginning,BigInterval,BreachShedule,StopTravel,ViolationLanding,OutputWithoutContract,ViolationOfTrafficPatterns,VioletionOfTrafficRules,ConflictWithConductor,WrongSurrendere,NotAnnouncedBusstop,SmokingInCabin,DiscussionOnPhone,LoudMusic,LackOfTickets,FaultyBus,SmellOfGus,PoorSanCondition,WorkBoards,WorkSite,WorkSmsService,WorkOnLinemap,WorkMobileApplication,PoorStateReversalArea,PoorStateBusstop,DisadvantageOfInfrastructures,ConflictWithDispather,ComplianceWithShedule,GoodQualityService,CourteousStaff,GoodTransportCondition")] Obrashenie obrashenie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(obrashenie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obrashenie);
        }

        // GET: Obrashenies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Obrashenie obrashenie = db.Obrashenie.Find(id);
            if (obrashenie == null)
            {
                return HttpNotFound();
            }
            return View(obrashenie);
        }

        // POST: Obrashenies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Obrashenie obrashenie = db.Obrashenie.Find(id);
            db.Obrashenie.Remove(obrashenie);
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
