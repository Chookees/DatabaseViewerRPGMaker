using System.Xml.Serialization;

namespace GameFileViewer.Other
{
    [XmlRoot(ElementName = "Weapon")]
    public class Weapon
    {
        [XmlElement()]
        public string Name { get; set; }

        [XmlElement()]
        public int BaseDamage { get; set; }

        [XmlElement()]
        public Rarity Rarity { get; set; }

        [XmlElement()]
        public WeaponType WeaponType { get; set; }

        [XmlElement()]
        public int Value { get; set; }

        public Weapon(string name, int baseDamage, Rarity rarity, WeaponType weaponType, int value)
        {
            this.BaseDamage = baseDamage;
            this.Name = name;
            this.Rarity = rarity;
            this.WeaponType = weaponType;
            this.Value = value;
        }

        public Weapon()
        {

        }
    }
}
