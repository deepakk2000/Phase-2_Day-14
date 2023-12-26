using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TeamsController : Controller
    {
        // GET: Teams
        static List<Team> listTeam = new List<Team>()
        {
            new Team(){Id=1,Name="India",NOWC=10},
            new Team(){Id=2,Name="Austria",NOWC=4},
            new Team(){Id=3,Name="West Indies",NOWC=2},
            new Team(){Id=4,Name="England",NOWC=1},
        };
        public ActionResult Index()
        {
            return View(listTeam);
        }
    }
}