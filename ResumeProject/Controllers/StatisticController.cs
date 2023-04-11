using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeProject.Models;


namespace ResumeProject.Controllers
{
    public class StatisticController : Controller
    {
        // GET: Statistic
        DbResumeEntities db = new DbResumeEntities();
        public ActionResult Index()
        {
            //ViewBag.countProjeTalebi = db.CountProjeTalebi.Count();
            ViewBag.skillCount = db.TblSkill.Count();
            ViewBag.technologyCount = db.TblTechnology.Count();
            ViewBag.csharpValue = db.TblTechnology.Where(x => x.TechnologyTitle == "C#").Select(y => y.TechnologyValue).FirstOrDefault();
            ViewBag.contactCount = db.TblContact.Count();
            ViewBag.subjectTesekkur = db.TblContact.Where(x => x.Subject == 1).Count();
            ViewBag.sumTechnologyValue = db.TblTechnology.Sum(x => x.TechnologyValue);
            ViewBag.avarageTechnologyValue = db.TblTechnology.Average(x => x.TechnologyValue);
            ViewBag.GetBy3ID = db.TblSkill.Where(x => x.SkillID == 3).Select(y=>y.SkillTitle).FirstOrDefault();
            ViewBag.maxTechnologyValue = db.TblTechnology.Max(x => x.TechnologyValue);
            return View();
        }
    }
}