using MySkills.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using PdfSharp;
using TheArtOfDev.HtmlRenderer.PdfSharp;
using System.Threading;
using System.Globalization;

namespace MySkills.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var resume = new Resume();
            return View(resume);
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
        public ViewResult ContactsView()
        {
            var contacts = new Contacts();
            return View(contacts);
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

        private Byte[] PdfSharpConvert(String html)
        {
            var config = new PdfGenerateConfig()
            {
                MarginBottom = 20,
                MarginLeft = 40,
                MarginRight = 20,
                MarginTop = 20,
                PageSize = PageSize.A4,
                PageOrientation = PageOrientation.Portrait
            };
            
            Byte[] res = null;
            using (MemoryStream ms = new MemoryStream())
            {
                var pdf = PdfGenerator.GeneratePdf(html, config);
                pdf.Save(ms);
                res = ms.ToArray();
            }
            return res;
        }

        [HttpGet]
        public FileStreamResult ResumePdfFile()
        {
            var htmlView = new StringBuilder();
            
            var contacts = new Contacts();
            htmlView.AppendLine(this.RenderView("ContactsPdfView", contacts));

            var targetDescription = new TargetDescription();
            htmlView.AppendLine(this.RenderView("TargetDescriptionView", targetDescription));

            var education = new Education();
            htmlView.AppendLine(this.RenderView("EducationPdfView", education));
            
            var stages = new Stages();
            htmlView.AppendLine(this.RenderView("StagesPdfView", stages));

            var skillsAndAbilities = new SkillsAndAbilities();
            htmlView.AppendLine(this.RenderView("SkillsAndAbilitiesPdfView", skillsAndAbilities));

            var aboutMe = new AboutMe();
            htmlView.AppendLine(this.RenderView("AboutMePdfView", aboutMe));

            var pdfArray= PdfSharpConvert(htmlView.ToString());

            var pdfStream = new MemoryStream(pdfArray);
            var fileStreamResult = new FileStreamResult(pdfStream, "application/pdf")
            {
                FileDownloadName = "DenisKosolapov.pdf"
            };
            return fileStreamResult;
        }

        public ActionResult Change(string lang)
        {
            if (lang != null)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(lang);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
            }
            HttpCookie cookie = new HttpCookie("Language");
            cookie.Value = lang;
            Response.Cookies.Add(cookie);

            var resume = new Resume();
            return View("Index", resume);
        }
    }
}