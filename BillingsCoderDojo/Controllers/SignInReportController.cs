using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BillingsCoderDojo.Models;
using BillingsCoderDojo.ViewModels;
using Microsoft.AspNet.Identity;

namespace BillingsCoderDojo.Controllers
{
    public class SignInReportController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: SignInReport
        [Authorize(Roles = "Mentors")]
        public ActionResult Index()
        {
            var signInSheet = from signIns in db.SignInModels
                              join users in db.Users on signIns.UserId equals users.Id
                              orderby signIns.LogTime descending
                              select new SignInReportViewModel
                              {
                                  Username = users.UserName,
                                  SignInTime = signIns.LogTime
                              };

            var signInSheetList = signInSheet.ToList().Select(s => new SignInReportViewModel{Username = s.Username, SignInTime = s.SignInTime});

            return View(signInSheetList);
        }

        // POST: SignInReport
        [Authorize(Roles = "Mentors")]
        [HttpPost]
        public ActionResult Index(string dateFilter)
        {
            var dateMin = Convert.ToDateTime(dateFilter);
            var dateMax = dateMin.AddDays(1);

            var signInSheet = from signIns in db.SignInModels
                              join users in db.Users on signIns.UserId equals users.Id
                              where signIns.LogTime > dateMin && signIns.LogTime < dateMax
                              orderby signIns.LogTime descending
                              select new SignInReportViewModel
                              {
                                  Username = users.UserName,
                                  SignInTime = signIns.LogTime
                              };

            return View(signInSheet.ToList());
        }
    }
}