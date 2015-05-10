using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC5Course.Models;
using MVC5Course.attribute;
using PagedList;
using PagedList.Mvc;

namespace MVC5Course.Controllers
{
    public class ClientsController :baseController
    {
        //private FabricsEntities db = new FabricsEntities();
        //ClientRepository repo = new ClientRepository();
        ClientRepository repo = RepositoryHelper.GetClientRepository();
        //使用NEW 並無CONTEXT也就是未做完完整步奏。使用HELPER則可將步驟完整

#if DEBUG

        public ActionResult debug()
        {
            return View();
        }
       
        public ActionResult yy()
        {
            return View();
        }
#endif
        public ActionResult Login()
        {            
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginVM data)
        {
            return View("LoginResult", data);
        }

        // GET: Clients
        [shareData]
        public ActionResult Index(int pageNo=1)
        {
            ViewBag.Message = "123456.";
            //var client = db.Client.Include(c => c.Occupation).Take(10);
            //var client = repo.All().Take(10);
            var client = repo.All().ToPagedList(pageNo, 10);
            return View(client.ToList());
        }

        // GET: Clients/Details/5
        public ActionResult Details(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Client client = db.Client.Find(id);
            var client = repo.Find(id.Value);
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);


        }
        OccupationRepository repoOcc = RepositoryHelper.GetOccupationRepository();
        // GET: Clients/Create
        public ActionResult Create()
        {
            ViewBag.OccupationId = new SelectList(repoOcc.All(), "OccupationId", "OccupationName");
            return View();
        }

        // POST: Clients/Create
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ClientId,FirstName,MiddleName,LastName,Gender,DateOfBirth,CreditRating,XCode,OccupationId,TelephoneNumber,Street1,Street2,City,ZipCode,Longitude,Latitude,Notes")] Client client)
        {
            if (ModelState.IsValid)
            {
                //db.Client.Add(client);
                //db.SaveChanges();
                repo.Add(client);
                repo.UnitOfWork.Commit();
                return RedirectToAction("Index");
            }

            ViewBag.OccupationId = new SelectList(repoOcc.All(), "OccupationId", "OccupationName", client.OccupationId);
            return View(client);
        }

        // GET: Clients/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Client client = db.Client.Find(id);
            var client = repo.Find(id.Value);
            if (client == null)
            {
                return HttpNotFound();
            }
            ViewBag.OccupationId = new SelectList(repo.All(), "OccupationId", "OccupationName", client.OccupationId);
            return View(client);
        }

        // POST: Clients/Edit/5
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ClientId,FirstName,MiddleName,LastName,Gender,DateOfBirth,CreditRating,XCode,OccupationId,TelephoneNumber,Street1,Street2,City,ZipCode,Longitude,Latitude,Notes")] Client client)
        {
            if (ModelState.IsValid)
            {
                repo.UnitOfWork.Context.Entry(client).State = EntityState.Modified;
                //db.SaveChanges();
                repo.UnitOfWork.Commit();
                return RedirectToAction("Index");
            }
            ViewBag.OccupationId = new SelectList(repoOcc.All(), "OccupationId", "OccupationName", client.OccupationId);
            return View(client);
        }

        // GET: Clients/Delete/5
        public ActionResult Delete(int? id)
        {


            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Client client = db.Client.Find(id);
            var client = repo.Find(id.Value);
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        // POST: Clients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Client client =repo.Find(id);
            
            //db.Client.Remove(client);
            repo.Delete(client);
            repo.UnitOfWork.Commit();
            //db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //db.Dispose();
                repo.UnitOfWork.Context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
