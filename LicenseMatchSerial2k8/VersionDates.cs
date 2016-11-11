using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using System.IO;

namespace VersionDates
{

    public class app_versions
    {
        public List<Version> IB_versions = new List<Version>();
        public List<Version> ITE_versions = new List<Version>();

        public app_versions(string sFile)
        {
            try
            {
                deserialize(sFile);
            }
            catch (Exception)
            {
            }
        }
        void deserialize(String sFile)
        {
            var serializer = new XmlSerializer(typeof(Versiondates));
            using (var stream = new FileStream(sFile, FileMode.Open))
            {
                var versions = (Versiondates)serializer.Deserialize(stream);
                IB_versions = versions.IB.Version;
                ITE_versions = versions.ITE.Version;
            }
        }
    }

    [XmlRoot(ElementName = "Version")]
    public class Version
    {
        [XmlAttribute(AttributeName = "Number")]
        public string Number { get; set; }
        [XmlAttribute(AttributeName = "Date")]
        public string DateString { get; set; }
        [XmlIgnore]
        public DateTime DateReleased
        {
            // 10/28/2008   month/day/year
            get {
                    if (DateString=="NA")
                        return new DateTime();
                int year = (int)Convert.ToInt16(DateString.Substring(DateString.LastIndexOf("/") + 1));
                int month = (int)Convert.ToInt16(DateString.Substring(0, DateString.IndexOf("/")));
                int day = (int)Convert.ToInt16(DateString.Substring(DateString.IndexOf("/") + 1, DateString.LastIndexOf("/") - DateString.IndexOf("/") - 1));
                DateTime dateTime = new DateTime(year , month, day);
                return dateTime;
            }
        }
        [XmlAttribute(AttributeName = "Notes")]
        public string Notes { get; set; }

        public override string ToString()
        {
            string s = "";
            s += Number + ", " + DateString + ", " + Notes;
            return s;
        }
    }

    [XmlRoot(ElementName = "ITE")]
    public class ITE
    {
        [XmlElement(ElementName = "Version")]
        public List<Version> Version { get; set; }
    }

    [XmlRoot(ElementName = "IB")]
    public class IB
    {
        [XmlElement(ElementName = "Version")]
        public List<Version> Version { get; set; }
    }

    [XmlRoot(ElementName = "versiondates")]
    public class Versiondates
    {
        [XmlElement(ElementName = "ITE")]
        public ITE ITE { get; set; }
        [XmlElement(ElementName = "IB")]
        public IB IB { get; set; }
    }

}