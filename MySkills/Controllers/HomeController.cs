using MySkills.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MySkills.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var currentContacts = new Contacts();
            return View(currentContacts);
        }

        [HttpGet]
        public ViewResult AboutMeView()
        {
            var aboutMe = new AboutMe();
            return View(aboutMe);
        }

        [HttpGet]
        public ViewResult EducationView()
        {
            var education = new Education();
            return View(education);
        }

        [HttpGet]
        public ViewResult SkillsAndAbilitiesView()
        {
            var skillsAndAbilities = new SkillsAndAbilities();
            return View(skillsAndAbilities);
        }

        [HttpGet]
        public ViewResult StagesView()
        {
            var stages = new Stages();
            return View(stages);
        }

        [HttpGet]
        public ViewResult TargetDescriptionView()
        {
            var targetDescription = new TargetDescription();
            return View(targetDescription);
        }

        [HttpGet]
        public FileStreamResult VCardFile()
        {
            var currentContacts = new Contacts();
            var vCardStream = currentContacts.GetVCardStream();
            var fileStreamResult = new FileStreamResult(vCardStream, "application/vcf")
            {
                FileDownloadName = "DenisKosolapovCard.vcf"
            };
            return fileStreamResult;
        }
    }
}