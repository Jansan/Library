using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

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
        public ActionResult Details(int id)
        {
            var member = _context.Members.Include(m => m.MembershipType).ToList();

            if (member == null)
                return HttpNotFound();
            return View(member);
        }
        private IEnumerable<Member> GetMembers()
        {
            return new List<Member>
            {
                new Member { Id = 1, Name ="Jansan"},
                new Member {Id = 2, Name ="Vino"}
            };
        }
    }
}