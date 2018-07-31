using System;
using System.Collections.Generic;
using System.Threading;

namespace MySkills.Models
{

    public class StageOfWork
    {
        public StageOfWork()
        {
            StartDate = DateTime.Now;
            EndDate = DateTime.Now;
            IsCompleate = false;
            Firm = new FirmDescription();
            Professions = new List<ProfessionDescription>();
        }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsCompleate { get; set; }
        public FirmDescription Firm { get; set; }
        public List<ProfessionDescription> Professions { get; set; }

        public string GetWorkRange()
        {
            const string dateFormat = "dd.MM.yyyy";

            var endDate = (IsCompleate) ? EndDate.ToString(dateFormat) : "NOW";

            if (Thread.CurrentThread.CurrentCulture.Name == "ru-RU")
            {
                endDate = (IsCompleate) ? EndDate.ToString(dateFormat) : "СЕЙЧАС";
            }
                
            return $"{StartDate.ToString(dateFormat)} - {endDate}";
        }

    }
}