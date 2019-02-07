using System.Xml.Serialization;
using GameFileViewer.Enums;

namespace GameFileViewer.Other
{
    [XmlRoot(ElementName = "Skill")]
    public class Skill
    {
        [XmlElement()]
        public string Name { get; set; }

        [XmlElement()]
        public int Damage { get; set; }

        [XmlElement()]
        public Effects Effect { get; set; }

        [XmlElement()]
        public int ProbabilityForEffect { get; set; }

        [XmlElement()]
        public TypeOfDamage TypeOfDamage { get; set; }

        public Skill(int damage, string name, Effects effect, int probability, TypeOfDamage type)
        {
            this.Damage = damage;
            this.Name = name;
            this.Effect = effect;
            this.ProbabilityForEffect = probability;
            this.TypeOfDamage = type;
        }

        public Skill()
        {

        }
    }
}
