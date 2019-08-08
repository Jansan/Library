using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Controllers
{
    public class MembersController : Controller
    {
        // GET: Members
        public ActionResult Index()
        {
            var members = GetMembers();
            return View(members);
        }
        public ActionResult Details(int id)
        {
            var member = GetMembers().SingleOrDefault(m => m.Id == id);

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