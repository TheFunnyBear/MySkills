using System;
using System.Collections.Generic;
using System.Globalization;

namespace MySkills.Models
{
    public class Stages
    {
        public Stages()
        {
            StagesOfWork = new List<StageOfWork>();
            InitDefaultEnglishValue();
        }

        public Stages(CultureInfo culture)
        {
            StagesOfWork = new List<StageOfWork>();
            if (culture.Name == "ru-RU")
            {
                InitDefaultRussianValue();
            }
            else
            {
                InitDefaultEnglishValue();
            }
        }

        public List<StageOfWork> StagesOfWork { get; set; }

        private void InitDefaultEnglishValue()
        {
            StagesOfWork.Add(new StageOfWork()
            {
                StartDate = new DateTime(year: 2016, month: 01, day: 11),
                IsCompleate = false,
                Firm = new FirmDescription() { Name = "«SunBay» LLC" },
                Professions = new List<ProfessionDescription>()
                {
                    new ProfessionDescription()
                    {
                        ProfessionName = "C# .NET SENIOR DEVELOPER IN TESTS",
                        Jobs = new List<JobDescription>()
                        {
                            new JobDescription() { Title = "Outsourcing for Kaspersky Lab" },
                            new JobDescription() { Title = "Development of autotests of complex systems (C#)" },
                            new JobDescription() { Title = "Projects on internal infrastructure" },
                        }
                    }
                }
            });

            StagesOfWork.Add(new StageOfWork()
            {
                StartDate = new DateTime(year: 2015, month: 01, day: 12),
                EndDate = new DateTime(year: 2015, month: 12, day: 31),
                IsCompleate = true,
                Firm = new FirmDescription() { Name = "«BizApps» LLC" },
                Professions = new List<ProfessionDescription>()
                {
                    new ProfessionDescription()
                    {
                        ProfessionName = "C# .NET SENIOR DEVELOPER IN TESTS",
                        Jobs = new List<JobDescription>()
                        {
                            new JobDescription() { Title = "Outsourcing for Kaspersky Lab" },
                            new JobDescription() { Title = "Development of autotests of complex systems (C#)" },
                            new JobDescription() { Title = "Development of mechanisms for auto-testing to support multiple localizations" },
                            new JobDescription() { Title = "Development of WCF services for remote deployment of test products" },
                            new JobDescription() { Title = "Works on the configuration of the automatic testing infrastructure" },
                            new JobDescription() { Title = "Development of software for comparing large arrays of images" },
                            new JobDescription() { Title = "Projects on internal infrastructure" }
                        }
                    }
                }
            });

            StagesOfWork.Add(new StageOfWork()
            {
                StartDate = new DateTime(year: 2013, month: 10, day: 1),
                EndDate = new DateTime(year: 2014, month: 12, day: 31),
                IsCompleate = true,
                Firm = new FirmDescription() { Name = "«WebConsultants» LLC" },
                Professions = new List<ProfessionDescription>()
                {
                    new ProfessionDescription()
                    {
                        ProfessionName = "C# DEVELOPER IN TESTS",
                        Jobs = new List<JobDescription>()
                        {
                            new JobDescription() { Title = "Outsourcing for Kaspersky Lab" },
                            new JobDescription() { Title = "Development of autotests of complex systems (C #)" },
                            new JobDescription() { Title = "Development of auto-tests of web applications (Silenium, WatIn), development of wrappers for Selenium drivers" }
                        }
                    }
                }
            });

            StagesOfWork.Add(new StageOfWork()
            {
                StartDate = new DateTime(year: 2009, month: 01, day: 2),
                EndDate = new DateTime(year: 2013, month: 09, day: 30),
                IsCompleate = true,
                Firm = new FirmDescription() { Name = "«SevSoft» LLC" },
                Professions = new List<ProfessionDescription>()
                {
                    new ProfessionDescription()
                    {
                        ProfessionName = "C++, C# DEVELOPER",
                        Jobs = new List<JobDescription>()
                        {
                            new JobDescription() { Title = "Software Development Editor of Diagrams of Technological Processes (Project Leader)" },
                            new JobDescription() { Title = "Software development of the Classification of elements" },
                            new JobDescription() { Title = "Development of top-level software for testing power supplies" }
                        }
                    }
                }
            });

            StagesOfWork.Add(new StageOfWork()
            {
                StartDate = new DateTime(year: 2003, month: 03, day: 01),
                EndDate = new DateTime(year: 2009, month: 01, day: 2),
                IsCompleate = true,
                Firm = new FirmDescription() { Name = "«Design Bureau of Switchgear Equipment» LLC" },
                Professions = new List<ProfessionDescription>()
                {
                    new ProfessionDescription()
                    {
                        ProfessionName = "C++ DEVELOPER",
                        Jobs = new List<JobDescription>()
                        {
                            new JobDescription() { Title = "Development of software for monitoring telecommunications connections (Project Leader)" },
                            new JobDescription() { Title = "Software development for the installation package" },
                            new JobDescription() { Title = "Development of an Internet server for transferring data via GPRS from reclosers to software on a PC (Project Leader)" },
                            new JobDescription() { Title = "Development of an application for local connection of reclosers with software on PC, via USB, Bluetooth (Project Leader)" },
                            new JobDescription() { Title = "Integration of telecommunication protocols DNP3 and IEC870-5-101 in reclosers RC02" },
                            new JobDescription() { Title = "Participation with the report at the scientific and technical seminar \"MODERN SYSTEMS OF COLLECTION, TRANSMISSION, PROCESSING AND DISPLAY OF INFORMATION ON ELECTRIC POWER OBJECTS\", Moscow. (Speaker, preparing a report)" },
                        }
                    }
                }
            });

            StagesOfWork.Add(new StageOfWork()
            {
                StartDate = new DateTime(year: 2002, month: 08, day: 31),
                EndDate = new DateTime(year: 2002, month: 12, day: 31),
                IsCompleate = true,
                Firm = new FirmDescription() { Name = "Tavrida Electric LLC" },
                Professions = new List<ProfessionDescription>()
                {
                    new ProfessionDescription()
                    {
                        ProfessionName = "C++ DEVELOPER",
                        Jobs = new List<JobDescription>()
                        {
                            new JobDescription() { Title = "Development of implementation of the Modbus telecommunications protocol for the RC / TEL recloser" }
                        }
                    }
                }
            });

            StagesOfWork.Add(new StageOfWork()
            {
                StartDate = new DateTime(year: 2000, month: 01, day: 06),
                EndDate = new DateTime(year: 2002, month: 08, day: 31),
                IsCompleate = true,
                Firm = new FirmDescription() { Name = "Electron OJSC" },
                Professions = new List<ProfessionDescription>()
                {
                    new ProfessionDescription()
                    {
                        ProfessionName = "SYSTEM ADMINISTRATOR",
                        Jobs = new List<JobDescription>()
                        {
                            new JobDescription() { Title = "Building a local enterprise network of 25 computers" },
                            new JobDescription() { Title = "Training of computer literacy staff; Support for accountant software" },
                            new JobDescription() { Title = "Domain, E-mail, Web page, file and print server" },
                            new JobDescription() { Title = "Copywriting, publication of articles on the site ixbt.com" },
                        }
                    }
                }
            });
        }

        private void InitDefaultRussianValue()
        {
            StagesOfWork.Add(new StageOfWork()
            {
                StartDate = new DateTime(year: 2016, month: 01, day: 11),
                IsCompleate = false,
                Firm = new FirmDescription() { Name = "ООО «SunBay»" },
                Professions = new List<ProfessionDescription>()
                {
                    new ProfessionDescription()
                    {
                        ProfessionName = "ВЕДУЩИЙ РАЗРАБОТЧИК C# .NET",
                        Jobs = new List<JobDescription>()
                        {
                            new JobDescription() { Title = "Аутсорсинг для круппной IT компании" },
                            new JobDescription() { Title = "Разработка автотестов сложных систем(С#)" },
                            new JobDescription() { Title = "Проекты по внутренней инфраструктуре" },
                            new JobDescription() { Title = "Менеджмент Севастопольского офиса компании" }
                        }
                    }
                }
            });

            StagesOfWork.Add(new StageOfWork()
            {
                StartDate = new DateTime(year: 2015, month: 01, day: 12),
                EndDate = new DateTime(year: 2015, month: 12, day: 31),
                IsCompleate = true,
                Firm = new FirmDescription() { Name = "ООО «BizApps»" },
                Professions = new List<ProfessionDescription>()
                {
                    new ProfessionDescription()
                    {
                        ProfessionName = "ВЕДУЩИЙ РАЗРАБОТЧИК C# .NET",
                        Jobs = new List<JobDescription>()
                        {
                            new JobDescription() { Title = "Аутсорсинг для круппной IT компании" },
                            new JobDescription() { Title = "Разработка автотестов сложных систем(С#)" },
                            new JobDescription() { Title = "Разработка механизмов авто-тестирования для поддержки множественных локализаций" },
                            new JobDescription() { Title = "Разработка WCF сервисов удалённого деплоймента тестовых продуктов" },
                            new JobDescription() { Title = "Работы по настройке инфраструктуры автоматического тестирования" },
                            new JobDescription() { Title = "Разработка ПО для сравнения больших массивов изображений" },
                            new JobDescription() { Title = "Проекты по внутренней инфраструктуре" },
                            new JobDescription() { Title = "Менеджмент Севастопольского офиса компании" }
                        }
                    }
                }
            });

            StagesOfWork.Add(new StageOfWork()
            {
                StartDate = new DateTime(year: 2013, month: 10, day: 1),
                EndDate = new DateTime(year: 2014, month: 12, day: 31),
                IsCompleate = true,
                Firm = new FirmDescription() { Name = "ООО «WebConsultants»" },
                Professions = new List<ProfessionDescription>()
                {
                    new ProfessionDescription()
                    {
                        ProfessionName = "ВЕДУЩИЙ РАЗРАБОТЧИК C# .NET",
                        Jobs = new List<JobDescription>()
                        {
                            new JobDescription() { Title = "Аутсорсинг для круппной IT компании" },
                            new JobDescription() { Title = "Разработка автотестов сложных систем(С#)" },
                            new JobDescription() { Title = "Разработка автотестов веб приложений(Silenium, WatIn), разработка обёрток для драйверов Selenium" }
                        }
                    }
                }
            });

            StagesOfWork.Add(new StageOfWork()
            {
                StartDate = new DateTime(year: 2009, month: 01, day: 2),
                EndDate = new DateTime(year: 2013, month: 09, day: 30),
                IsCompleate = true,
                Firm = new FirmDescription() { Name = "ООО «Севсофт»" },
                Professions = new List<ProfessionDescription>()
                {
                    new ProfessionDescription()
                    {
                        ProfessionName = "ВЕДУЩИЙ ИНЖЕНЕР-ПРОГРАММИСТ",
                        Jobs = new List<JobDescription>()
                        {
                            new JobDescription() { Title = "Разработка ПО Редактор Диаграмм Технологических Процессов(Лидер проекта)" },
                            new JobDescription() { Title = "Разработка ПО Классификации элементов" },
                            new JobDescription() { Title = "Разработка ПО верхнего уровня для проверки источников питания" }
                        }
                    }
                }
            });

            StagesOfWork.Add(new StageOfWork()
            {
                StartDate = new DateTime(year: 2003, month: 03, day: 01),
                EndDate = new DateTime(year: 2009, month: 01, day: 2),
                IsCompleate = true,
                Firm = new FirmDescription() { Name = "ООО Конструкторское Бюро «Коммутационной аппаратуры»" },
                Professions = new List<ProfessionDescription>()
                {
                    new ProfessionDescription()
                    {
                        ProfessionName = "ИНЖЕНЕР - ПРОГРАММИСТ",
                        Jobs = new List<JobDescription>()
                        {
                            new JobDescription() { Title = "Разработка ПО для мониторинга телекоммуникационных соединений(Лидер проекта)" },
                            new JobDescription() { Title = "Разработка ПО инсталляционного пакета" },
                            new JobDescription() { Title = "Разработка интернет сервера для передачи данных через GPRS от реклоузеров к ПО на ПК(Лидер проекта)" },
                            new JobDescription() { Title = "Разработка приложения для локальных соединений реклоузеров с ПО на ПК, через USB, Bluetooth(Лидер проекта)" },
                            new JobDescription() { Title = "Работы по интеграции телекоммуникационных протоколов DNP3 и IEC870-5 - 101 в реклоузерах RC02" },
                            new JobDescription() { Title = "Участие с докладом на научно - техническом семинаре « СОВРЕМЕННЫЕ СИСТЕМЫ СБОРА, ПЕРЕДАЧИ, ОБРАБОТКИ И ОТОБРАЖЕНИЯ ИНФОРМАЦИИ НА ОБЪЕКТАХ ЭЛЕКТРОЭНЕРГЕТИКИ» г.Москва. (Докладчик, готовил доклад)" },
                        }
                    }
                }
            });

            StagesOfWork.Add(new StageOfWork()
            {
                StartDate = new DateTime(year: 2002, month: 08, day: 31),
                EndDate = new DateTime(year: 2002, month: 12, day: 31),
                IsCompleate = true,
                Firm = new FirmDescription() { Name = "ООО «Таврида Электрик»" },
                Professions = new List<ProfessionDescription>()
                {
                    new ProfessionDescription()
                    {
                        ProfessionName = "ИНЖЕНЕР - ПРОГРАММИСТ",
                        Jobs = new List<JobDescription>()
                        {
                            new JobDescription() { Title = "Разработка реализации телекоммуникационного протокола Modbus для реклоузера RC/ TEL" }
                        }
                    }
                }
            });

            StagesOfWork.Add(new StageOfWork()
            {
                StartDate = new DateTime(year: 2000, month: 01, day: 06),
                EndDate = new DateTime(year: 2002, month: 08, day: 31),
                IsCompleate = true,
                Firm = new FirmDescription() { Name = "ОАО «Электрон»" },
                Professions = new List<ProfessionDescription>()
                {
                    new ProfessionDescription()
                    {
                        ProfessionName = "АДМИНИСТРАТОР",
                        Jobs = new List<JobDescription>()
                        {
                            new JobDescription() { Title = "Построение локальной сети предприятия из 25 компьютеров" },
                            new JobDescription() { Title = "Обучение персонала компьютерной грамотности; Поддержка сетевой версии 1С предприятия 7.7" },
                            new JobDescription() { Title = "Домен, Электронная почта, Web-страница, файловый и принт сервера" },
                            new JobDescription() { Title = "Копирайтинг, публикация статей на сайте ixbt.com" },
                        }
                    }
                }
            });
        }
    }
}