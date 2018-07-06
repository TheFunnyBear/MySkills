namespace MySkills.Models
{
    public class TargetDescription
    {
        public TargetDescription()
        {
            InitDefaultValue();
        }

        public string Target { get; set; }

        private void InitDefaultValue()
        {
            Target = "Ищу интересную работу в IT.";
        }
    }
}