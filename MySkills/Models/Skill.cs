using System.Collections.Generic;

namespace MySkills.Models
{
    public class Skill
    {
        public Skill()
        {
            SubSkills = new List<string>();
        }

        public string Name { get; set; }
        public List<string> SubSkills { get; set; }
    }
}