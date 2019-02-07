using System.Xml.Serialization;

namespace GameFileViewer.Other
{
    [XmlRoot(ElementName = "Class")]
    public class Class
    {
        [XmlElement()]
        public string Name { get; set; }

        [XmlElement()]
        public WeaponType AvailableWeaponType { get; set; }

        [XmlElement()]
        public int HpBeginn { get; set; }

        [XmlElement()]
        public int HPEnd { get; set; }

        [XmlElement()]
        public ClassType ClassType { get; set; }

        public Class(string name, WeaponType weapontype, int hpLow, int hpMax, ClassType classType)
        {
            this.Name = name;
            this.AvailableWeaponType = weapontype;
            this.HpBeginn = hpLow;
            this.HPEnd = hpMax;
            this.ClassType = classType;
        }

        public Class()
        {

        }
    }
}
