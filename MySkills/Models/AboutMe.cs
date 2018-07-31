using System.Globalization;

namespace MySkills.Models
{
    public class AboutMe
    {
        public AboutMe()
        {
            InitDefaultEnglishValue();
        }

        public AboutMe(CultureInfo culture)
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

        public string Description { get; set; }


        private void InitDefaultEnglishValue()
        {
            Description = "I was born on 05/03/1980, in Leningrad, but I consider myself a native Sevastopol. " +
                "Now I live in Sevastopol. I can work as a team part, I am sociable. " +
                "I learn and ask questions, easily share my knowledge and experience with others. " + 
                "I have experience in running a small business(5 - 7 people). " +
                "Work experience as a private entrepreneur." + 
                "Driving expirence more than 10 years." +
                "I grow from beginner to team leader, but I ready to repeat it in new area." +
                "I do not smoke or have other bad habits.Married,have kids." + 
                "Possible business trips, it is not possible to move to work in another city or country.";
        }

        private void InitDefaultRussianValue()
        {
            Description = "Родился 03.05.1980, в г. Ленинграде, но считаю себя коренным Севастопольцем. " + 
                "Сейчас проживаю в г.Севастополь.Умею работать в команде, коммуникабелен. " + 
                "Не стесняюсь учится и задавать вопросы, легко делюсь знаниями и опытом с другими. " + 
                "Неплохо знаю английский язык. Опыт ведения хозяйственной деятельность небольшого предприятия(5 - 7 человек).   " +
                "Опыт работы частным предпринимателем. " +
                "Стаж вождения автомобиля более 10 лет. " + 
                "Прошёл путь от новичка до ведущего инженера, но готов его повторить. " +
                "Не курю и не имею других вредных привычек. Женат, дети. " +
                "Возможны командировки, не возможен переезд на работу в другой город или страну.";
        }
    }
}