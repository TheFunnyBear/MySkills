using System.Threading;

namespace MySkills.Models
{
    public class NavBar
    {
        public bool IsRussian => Thread.CurrentThread.CurrentCulture.Name == "ru-RU";
        public bool IsEnglish => Thread.CurrentThread.CurrentCulture.Name != "ru-RU";
    }
}