using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BillingsCoderDojo.Models;
using BillingsCoderDojo.ViewModels;
using Microsoft.AspNet.Identity;

namespace BillingsCoderDojo.Controllers
{
    [Authorize]
    public class SignInController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: SignInModels
        public ActionResult Index()
        {
            var signInViewModel = new SignInViewModel(User.Identity.Name);

            return View(signInViewModel);
        }

        // POST: SignInModels/Index
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(SignInViewModel signInViewModel)
        {
            var signInModels = new SignInModels();
            if (ModelState.IsValid)
            {
                signInModels.UserId = User.Identity.GetUserId();
                signInModels.LogTime = signInViewModel.LogTime;

                db.SignInModels.Add(signInModels);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View(signInModels);
        }      

        // GET: SignInModels/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SignInModels signInModels = db.SignInModels.Find(id);
            if (signInModels == null)
            {
                return HttpNotFound();
            }
            return View(signInModels);
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
