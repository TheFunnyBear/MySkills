using System;
using System.Globalization;

namespace MySkills.Models
{
    public class Education
    {
        public Education()
        {
            InitDefaultEnglishValue();
        }

        public Education(CultureInfo culture)
        {
            if (culture.Name == "ru-RU")
            {
                IsShouldOneginShow = true;
                InitDefaultRussianValue();
            }
            else
            {
                IsShouldOneginShow = false;
                InitDefaultEnglishValue();
            }
        }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string University { get; set; }
        public string Diplom { get; set; }
        public bool IsShouldOneginShow { get; set; }

        public string GetEducationRange()
        {
            const string dateFormat = "dd.MM.yyyy";
            return $"{StartDate.ToString(dateFormat)} - {EndDate.ToString(dateFormat)}";
        }

        private void InitDefaultEnglishValue()
        {
            StartDate = new DateTime(year: 1997, month: 8, day: 21);
            EndDate = new DateTime(year: 2002, month: 6, day: 25);
            University = "Sevastopol National Technical University.";
            Diplom = "DIPLOMS OF THE BACHELOR AND SPECIALIST ON THE SPECIALTY OF \"CONTROL SYSTEMS AND AUTOMATICS\"" +
                "QUALIFICATION ENGINEER - SYSTEM ENGINEER";
        }

        private void InitDefaultRussianValue()
        {
            StartDate = new DateTime(year: 1997, month: 8, day: 21);
            EndDate = new DateTime(year: 2002, month: 6, day: 25);
            University = "Севастопольский Национальный Технический Университет.";
            Diplom = "ДИПЛОМЫ БАКАЛАВРА И СПЕЦИАЛИСТА ПО СПЕЦИАЛЬНОСТИ «СИСТЕМЫ УПРАВЛЕНИЯ И АВТОМАТИКИ», " + 
                "КВАЛИФИКАЦИЯ ИНЖЕНЕР - СИСТЕМОТЕХНИК.";
        }
    }
}