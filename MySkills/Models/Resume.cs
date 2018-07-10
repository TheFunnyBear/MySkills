namespace MySkills.Models
{
    public class Resume
    {
        public Resume()
        {
            Contacts = new Contacts();
            Target = new TargetDescription();
            Education = new Education();
            Stages = new Stages();
            SkillsAndAbilities = new SkillsAndAbilities();
            AboutMe = new AboutMe();
        }

        public Contacts Contacts { get; set; }
        public TargetDescription Target { get; set; }
        public Education Education { get; set; }
        public Stages Stages { get; set; }
        public SkillsAndAbilities SkillsAndAbilities { get; set; }
        public AboutMe AboutMe { get; set; }
    }
}