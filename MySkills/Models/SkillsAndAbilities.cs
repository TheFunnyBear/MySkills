using System.Collections.Generic;

namespace MySkills.Models
{
    public class SkillsAndAbilities
    {
        public SkillsAndAbilities()
        {
            InitDefaultValue();
        }

        public List<Skill> Skills { get; set; }

        private void InitDefaultValue()
        {
            Skills = new List<Skill>();

            Skills.Add(new Skill() { Name = "Знание языков программирования С, С++, С#." });
            Skills.Add(new Skill() { Name = "Умение проектировать и реализовывать интерфейсы пользователя, в средах Microsoft", SubSkills = new List<string>() { "VS2003/VS2005/VS2008/VS2010 Visual C++" } });
            Skills.Add(new Skill() { Name = "Знание библиотеки классов MFC." });
            Skills.Add(new Skill() { Name = "Знание и опыт использования библиотек расширения MFC:", SubSkills = new List<string>() { "Stingray Studio", "BCGControlBar Pro" } });
            Skills.Add(new Skill()
            {
                Name = "Знание и опыт работы с технологиями:",
                SubSkills = new List<string>() {
                    "Windows Forms",
                    "WPF",
                    "WCF",
                    "C# .NET 2.0 - 4.5" }
            });
            Skills.Add(new Skill()
            {
                Name = "Знание и jпыт использования библиотек:",
                SubSkills = new List<string>() {
                    "MindFusion WPFDiagram",
                    "Actipro WPF Studio",
                    "Stimulsoft Reports.Wpf",
                    "ComponentOne Studio for WPF;"
                }
            });
            Skills.Add(new Skill() { Name = "Знание и опыт работы с Microsoft.Pratices.Unity." });
            Skills.Add(new Skill() { Name = "Опыт работы с паттернами проектирования GOF." });
            Skills.Add(new Skill() { Name = "Знание и опыт работы с DI, IoC." });
            Skills.Add(new Skill() { Name = "Опыт работы с технологией ClickOnce." });
            Skills.Add(new Skill()
            {
                Name = "Знание стандартов и опыт выполнения работ по интеграции драйверов телекоммуникационных протоколов связи:",
                SubSkills = new List<string>()
                {
                    "DNP3(master, slave)",
                    "IEC870-5-101 (slave)"
                }
            });
            Skills.Add(new Skill() { Name = "Опыт собственной реализации протокола Modbus(master, slave)" });
            Skills.Add(new Skill() { Name = "Клиент-серверное ПО на базе TCP-IP: реализация алгоритмов аутентификации и шифрования" });
            Skills.Add(new Skill()
            {
                Name = "Базовые знания SQL(https://www.sololearn.com/certificate/1060-6186720/pdf/ ), работа с хранимыми процедурами.",
                SubSkills = new List<string>()
                {
                    "Microsoft T-SQL (MSSQL Server 2005 - 2008)",
                    "SQLite",
                    "MySQL",
                    "PostgreSQL"
                }
            });
            Skills.Add(new Skill() { Name = "Потоки именованные каналы и прочие межпрограммные взаимодействия" });
            Skills.Add(new Skill() { Name = "Опыт работы с системами управления версий CVS, SVN, GIT, TFS(+ работа с библиотеками)" });
            Skills.Add(new Skill() { Name = "Опыт работы с системами для хостинга проектов и их совместной разработки, Jira, Google Code, Bitbucket и т.д." });
            Skills.Add(new Skill()
            {
                Name = "Опыт разработки инсталляторов программ на базе:",
                SubSkills = new List<string>()
                {
                    "Advansed Installer",
                    "InstallShield",
                }
            });
            Skills.Add(new Skill()
            {
                Name = "Опыт работы с:",
                SubSkills = new List<string>()
                {
                    "Delphi",
                    "Pascal",
                    "VBA",
                    "Basic",
                }
            });
            Skills.Add(new Skill()
            {
                Name = "Опыт работы с средами виртуализации:",
                SubSkills = new List<string>()
                {
                    "Microsoft HyperV",
                    "Виртуализация VmWare",
                    "Oracle Virtualbox"
                }
            });
            Skills.Add(new Skill() { Name = "Опыт написания скриптов Windows PowerShell" });
            Skills.Add(new Skill()
            {
                Name = "Модульное тестирование:",
                SubSkills = new List<string>()
                {
                    "Nunit",
                }
            });
            Skills.Add(new Skill()
            {
                Name = "Автоматическое тестирование:",
                SubSkills = new List<string>()
                {
                    "MS Test",
                    "Selenium",
                    "WatIn",
                    "Given/ When / Then в автотестировании",
                    "Mock в автотестировании",
                    "AutoIt"

                }
            });
            Skills.Add(new Skill() { Name = "Chocolate deploymen" });
            Skills.Add(new Skill() { Name = "Arduino базовые знания платформы, опыт проектирования" });
            Skills.Add(new Skill() { Name = "Java базовый знания(https://www.sololearn.com/certificate/1068-6186720/pdf/)" });
            Skills.Add(new Skill() { Name = "HTML 4.0" });
            Skills.Add(new Skill() { Name = "MS DOS" });
            Skills.Add(new Skill() { Name = "Linux базовые знания консоли и работы с ОС." });
        }
    }
}