using System.Collections.Generic;

namespace MySkills.Models
{
    public class ProfessionDescription
    {
        public ProfessionDescription()
        {
            Jobs = new List<JobDescription>();
        }

        public string ProfessionName { get; set; }
        public List<JobDescription> Jobs { get; set; }
    }
}