using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static hebroDates.configuration.Appconfiguration;

namespace hebroDates.sevice
{
    internal static class HebrewDateService
    {
        public static void CreateXmlIfNotExists()
        {
            if (!File.Exists(HebrewDatePath))
            {
                XDocument document = new();
                XElement Dates = new("dates");
                document.Add(Dates);
                document.Save(HebrewDatePath);
            }

        }
        public static void AddDay(string day)
        {
            XDocument document = XDocument.Load(HebrewDatePath);
            XElement Dates = document.Root;
            if (Dates == null) { return; }

            XElement xElement = new XElement("day", day);
            Dates.Add(xElement);
            document.Save(HebrewDatePath);

        }
        public static void AddDayMonth(int dayMonth)
        {
            XDocument document = XDocument.Load(HebrewDatePath);
            XElement Dates = document.Root;
            if (Dates == null) { return; }

            XElement xElement = new XElement("dayMonth", dayMonth);
            Dates.Add(xElement);
            document.Save(HebrewDatePath);

        }
        public static void AddMonth(string month)
        {
            XDocument document = XDocument.Load(HebrewDatePath);
            XElement Dates = document.Root;
            if (Dates == null) { return; }

            XElement xElement = new XElement("year", month);
            Dates.Add(xElement);
            document.Save(HebrewDatePath);

        }
        public static void AddYear(string year)
        {
            XDocument document = XDocument.Load(HebrewDatePath);
            XElement Dates = document.Root;
            if (Dates == null) { return; }

            XElement xElement = new XElement("year", year);
            Dates.Add(xElement);
            document.Save(HebrewDatePath);
        }
        public static void res(string mesege) 
        {
            XDocument document = XDocument.Load(HebrewDatePath);
            XElement res = document.Root;
            if (res == null) { return; }
            XElement resElement = new XElement("res", mesege);
            res.Add(resElement);
            document.Save(HebrewDatePath);
        }
    }
}
