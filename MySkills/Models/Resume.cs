using System.Globalization;
using System.Threading;

namespace MySkills.Models
{
    public class Resume
    {
        public Resume()
        {
            var currentCulture = Thread.CurrentThread.CurrentCulture;
            Contacts = new Contacts(currentCulture);
            Target = new TargetDescription(currentCulture);
            Education = new Education(currentCulture);
            Stages = new Stages(currentCulture);
            SkillsAndAbilities = new SkillsAndAbilities(currentCulture);
            AboutMe = new AboutMe(currentCulture);
            NavBar = new NavBar();
        }

        public Contacts Contacts { get; set; }
        public TargetDescription Target { get; set; }
        public Education Education { get; set; }
        public Stages Stages { get; set; }
        public SkillsAndAbilities SkillsAndAbilities { get; set; }
        public AboutMe AboutMe { get; set; }
        public NavBar NavBar { get; set; }
    }
}