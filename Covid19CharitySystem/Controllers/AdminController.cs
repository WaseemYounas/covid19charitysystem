using Covid19CharitySystem.BL;
using Covid19CharitySystem.DAL;
using Covid19CharitySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Covid19CharitySystem.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Volunteers()
        {
            List<User> volunteers = new UserDAL().getUsersList().Where(x => x.Role == 3).ToList();
            return View(volunteers);
        }
        public ActionResult Donors()
        {
            List<User> donors = new UserDAL().getUsersList().Where(x => x.Role == 2).ToList();

            return View(donors);
        }
        public ActionResult RecentDonations()
        {
            List<Donation> list = new UserDAL().getDonationsList().Where(x => x.Status == 0).ToList();
                return View(list);
        }
        public ActionResult CollectedDonations()
        {
            List<Donation> list = new UserDAL().getDonationsList().Where(x => x.Status == 1).ToList();
            return View(list);
        }
        public ActionResult AssignTask(int Did)
        {
            ViewBag.donationId = Did;
           ViewBag.volunteers= new UserBL().getUserList().Where(x => x.Role == 2).ToList();
            return View();
        }
    }
}