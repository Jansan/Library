using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Library.ViewModels;

namespace Library.Controllers
{
    public class MembersController : Controller
    {
        private ApplicationDbContext _context;

        public MembersController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Members
        public ActionResult Index()
        {
            var members = _context.Members;
            return View(members);
        }
        //GET: Members/Details
        public ActionResult Details(int id)
        {
            var member = _context.Members.Include(m => m.MembershipType).SingleOrDefault(m => m.Id == id);

            if (member == null)
                return HttpNotFound();
            return View(member);
        }
        // Add New Book
        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();

            var viewModel = new NewMemberViewModel
            {
                MembershipTypes = membershipTypes
            };
            return View(viewModel);
        }
        
    }
}