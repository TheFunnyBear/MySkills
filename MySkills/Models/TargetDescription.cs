using System.Globalization;

namespace MySkills.Models
{
    public class TargetDescription
    {
        public TargetDescription()
        {
            InitDefaultEnglishValue();
        }

        public TargetDescription(CultureInfo culture)
        {
            if (culture.Name == "ru-RU")
            {
                InitDefaultRussianValue();
            }
            else
            {
                InitDefaultEnglishValue();
            }
        }

        public string Target { get; set; }

        private void InitDefaultEnglishValue()
        {
            Target = "I'm looking for an interesting job in IT.";
        }

        private void InitDefaultRussianValue()
        {
            Target = "Ищу интересную работу в IT.";
        }
    }
}