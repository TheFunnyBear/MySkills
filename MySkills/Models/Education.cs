using System;

namespace MySkills.Models
{
    public class Education
    {
        public Education()
        {
            InitDefaultValue();
        }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string University { get; set; }
        public string Diplom { get; set; }

        public string GetEducationRange()
        {
            const string dateFormat = "dd.MM.yyyy";
            return $"{StartDate.ToString(dateFormat)} - {EndDate.ToString(dateFormat)}";
        }

        private void InitDefaultValue()
        {
            StartDate = new DateTime(year: 1997, month: 8, day: 21);
            EndDate = new DateTime(year: 2002, month: 6, day: 25);
            University = "Севастопольский Национальный Технический Университет.";
            Diplom = "ДИПЛОМЫ БАКАЛАВРА И СПЕЦИАЛИСТА ПО СПЕЦИАЛЬНОСТИ «СИСТЕМЫ УПРАВЛЕНИЯ И АВТОМАТИКИ», " + 
                "КВАЛИФИКАЦИЯ ИНЖЕНЕР - СИСТЕМОТЕХНИК.";
        }
    }
}