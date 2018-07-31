using System.Collections.Generic;
using System.Globalization;

namespace MySkills.Models
{
    public class SkillsAndAbilities
    {
        public SkillsAndAbilities()
        {
            InitDefaultEnglishValue();
        }

        public SkillsAndAbilities(CultureInfo culture)
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

        public List<Skill> Skills { get; set; }

        private void InitDefaultEnglishValue()
        {
            Skills = new List<Skill>();

            Skills.Add(new Skill() { Name = "Knowledge of programming languages C, C++, C#" });
            Skills.Add(new Skill() { Name = "Ability to design and implement user interfaces, in Microsoft ", SubSkills = new List<string>() { "VS2003/VS2005/VS2008/VS2010 Visual C++" } });
            Skills.Add(new Skill() { Name = "MFC class library" });
            Skills.Add(new Skill() { Name = "Knowledge and experience of using MFC extension libraries:", SubSkills = new List<string>() { "Stingray Studio", "BCGControlBar Pro" } });
            Skills.Add(new Skill()
            {
                Name = "Knowledge and experience with technology:",
                SubSkills = new List<string>() {
                    "Windows Forms",
                    "WPF",
                    "WCF",
                    "C# .NET 2.0 - 4.5" }
            });
            Skills.Add(new Skill()
            {
                Name = "Knowledge and experience of using libraries:",
                SubSkills = new List<string>() {
                    "MindFusion WPFDiagram",
                    "Actipro WPF Studio",
                    "Stimulsoft Reports.Wpf",
                    "ComponentOne Studio for WPF;"
                }
            });
            Skills.Add(new Skill() { Name = "Microsoft.Pratices.Unity" });
            Skills.Add(new Skill() { Name = "GOF paterns understending" });
            Skills.Add(new Skill() { Name = "DI, IoC" });
            Skills.Add(new Skill() { Name = "Small projects in ASP.NET MVC 5" });
            Skills.Add(new Skill() { Name = "Experience with ClickOnce technology" });
            Skills.Add(new Skill()
            {
                Name = "Knowledge of the standards and experience in the implementation of work on the integration of the drivers of telecommunications protocols:",
                SubSkills = new List<string>()
                {
                    "DNP3(master, slave)",
                    "IEC870-5-101 (slave)"
                }
            });
            Skills.Add(new Skill() { Name = "Experience of own C++ implementation of the Modbus (master, slave);" });
            Skills.Add(new Skill() { Name = "Client-server software based on TCP-IP: implementation of authentication and encryption algorithms" });
            Skills.Add(new Skill()
            {
                Name = "Basic knowledge of SQL (https://www.sololearn.com/certificate/1060-6186720/pdf/ ), can work with servers:",
                SubSkills = new List<string>()
                {
                    "Microsoft T-SQL (MSSQL Server 2005 - 2008)",
                    "SQLite",
                    "MySQL",
                    "PostgreSQL"
                }
            });
            Skills.Add(new Skill() { Name = "Threads named pipes and other inter-program interactions" });
            Skills.Add(new Skill() { Name = "Experience working with version control systems CVS, SVN, GIT, TFS ( + write addons for TFS)" });
            Skills.Add(new Skill() { Name = "Experience with systems for hosting projects and their joint development, Jira, Google Code, Bitbucket, etc." });
            Skills.Add(new Skill()
            {
                Name = "Experience in developing installers:",
                SubSkills = new List<string>()
                {
                    "Advansed Installer",
                    "InstallShield",
                }
            });
            Skills.Add(new Skill()
            {
                Name = "Work experience with:",
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
                Name = "Work experience with virtualization:",
                SubSkills = new List<string>()
                {
                    "Microsoft HyperV",
                    "VmWare",
                    "Virtualbox"
                }
            });
            Skills.Add(new Skill() { Name = "Windows PowerShell" });
            Skills.Add(new Skill()
            {
                Name = "Unit testing:",
                SubSkills = new List<string>()
                {
                    "Nunit",
                }
            });
            Skills.Add(new Skill()
            {
                Name = "Automatic testing:",
                SubSkills = new List<string>()
                {
                    "MS Test",
                    "Selenium",
                    "WatIn",
                    "Given/ When / Then in autotesting",
                    "Mock in autotesting",
                    "AutoIt"

                }
            });
            Skills.Add(new Skill() { Name = "Chocolate deploymen" });
            Skills.Add(new Skill() { Name = "Arduino basic platform knowledge, small design experience" });
            Skills.Add(new Skill() { Name = "Small project with Java (https://www.sololearn.com/certificate/1068-6186720/pdf/)" });
            Skills.Add(new Skill() { Name = "HTML 4.0" });
            Skills.Add(new Skill() { Name = "MS DOS" });
            Skills.Add(new Skill() { Name = "Linux basic knowledge of the console and working with the OS" });
        }


        private void InitDefaultRussianValue()
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
                Name = "Знание и опыт использования библиотек:",
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