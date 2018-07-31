using MixERP.Net.VCards;
using MixERP.Net.VCards.Models;
using MixERP.Net.VCards.Serializer;
using MixERP.Net.VCards.Types;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;

namespace MySkills.Models
{
    public class Contacts
    {
        public Contacts()
        {
            InitDefaultEnglishValue();
        }

        public Contacts(CultureInfo culture)
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

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string FullName { get { return (Patronymic == null) ? $"{FirstName} {LastName}" : $"{LastName} {FirstName} {Patronymic}"; } }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Skype { get; set; }
        public Uri WebSite { get; set; }
        public string Location { get; set; }
        public byte[] QrCode { get { return GetQrCodeBytes(); } }

        public MemoryStream GetVCardStream()
        {
            var vrCard = GetVcard();
            return new MemoryStream(ASCIIEncoding.Default.GetBytes(vrCard));
        }

        private string GetVcard()
        {
            var vcard = new VCard
            {
                Version = VCardVersion.V4,
                FormattedName = $"{FirstName} {LastName}",
                FirstName = FirstName,
                LastName = LastName,
                Classification = ClassificationType.Public,
                Categories = new[] { "Developer C#" },
                Emails = new List<Email>() { new Email() { EmailAddress = Email.ToLower() } },
                Telephones = new List<Telephone>() { new Telephone() { Number = Phone, Type = TelephoneType.Cell } },
                Url = WebSite,
                DeliveryAddress = new DeliveryAddress() { Address = Location }
            };
            return vcard.Serialize();
        }

        private byte[] GetQrCodeBytes()
        {
            var qrGenerator = new QRCodeGenerator();
            var vrCard = GetVcard();
            var qrCodeData = qrGenerator.CreateQrCode(vrCard, QRCodeGenerator.ECCLevel.M);
            var qrCode = new QRCode(qrCodeData);
            var qrCodeBitMap = qrCode.GetGraphic(pixelsPerModule: 2);
            return (byte[])new ImageConverter().ConvertTo(qrCodeBitMap, typeof(byte[]));
        }

        private void InitDefaultEnglishValue()
        {
            FirstName = "DENIS";
            LastName = "KOSOLAPOV";
            Phone = "+7(978)811-63-27";
            Email = "DENIS@KOSOLAPOV.INFO";
            Skype = "denis.kosolapov";
            WebSite = new Uri(@"https://www.kosolapov.info/");
            Location = "Russia, Sevastopol";
        }


        private void InitDefaultRussianValue()
        {
            FirstName = "ДЕНИС";
            LastName = "КОСОЛАПОВ";
            Patronymic = "АЛЕКСАНДРОВИЧ";
            Phone = "+7(978)811-63-27";
            Email = "DENIS@KOSOLAPOV.INFO";
            Skype = "denis.kosolapov";
            WebSite = new Uri(@"https://www.kosolapov.info/");
            Location = "Россия, г. Севастополь";
        }
    }
}