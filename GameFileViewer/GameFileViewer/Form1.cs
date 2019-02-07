using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using GameFileViewer.Enums;
using GameFileViewer.Other;

namespace GameFileViewer
{
    public partial class Form1 : Form
    {
        private List<Weapon> ListOfAllWeapon = new List<Weapon>();
        private List<Skill> ListOfAllSkills = new List<Skill>();
        private List<Class> ListOfAllClasses = new List<Class>();
        private List<ComboBox> AllComboBoxes = new List<ComboBox>();

        private string PathToWeaponsDB = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                                         @"\DBItems\DatabaseWeapons.xml";
        private string PathToClassesDB = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                                          @"\DBItems\DatabaseClasses.xml";
        private string PathToSkillDB = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                                       @"\DBItems\DatabaseSkill.xml";
        public Form1()
        {
            InitializeComponent();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\DBItems";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            AllComboBoxes.Add(RarityWeapon);
            AllComboBoxes.Add(WeaponTypeWeapon);
            AllComboBoxes.Add(TypeOfDamageSkill);
            AllComboBoxes.Add(EffectSkill);
            AllComboBoxes.Add(WeaponTypesClass);
            AllComboBoxes.Add(ClassTypeClass);

            //Retrieve Old Data
            if (File.Exists(PathToWeaponsDB))
            {
                XmlSerializer weaponSerializer = new XmlSerializer(typeof(List<Weapon>));

                ListOfAllWeapon = ReadWeaponDatabase(weaponSerializer);
            }

            if (File.Exists(PathToClassesDB))
            {
                XmlSerializer classSerializer = new XmlSerializer(typeof(List<Class>));

                ListOfAllClasses = ReadClassesDatabase(classSerializer);
            }

            if (File.Exists(PathToSkillDB))
            {
                XmlSerializer skillSerializer = new XmlSerializer(typeof(List<Skill>));

                ListOfAllSkills = ReadSkillDatabase(skillSerializer);
            }
        }

        //Methods to read all existing databases
        #region Read Old Databases
        private List<Weapon> ReadWeaponDatabase(XmlSerializer serializer)
        {
            List<Weapon> toReturnWeapons = new List<Weapon>();


            StreamReader reader = new StreamReader(PathToWeaponsDB);
            toReturnWeapons = (List<Weapon>)serializer.Deserialize(reader);
            reader.Close();


            return toReturnWeapons;
        }

        private List<Class> ReadClassesDatabase(XmlSerializer serializer)
        {
            List<Class> toReturnClasses = new List<Class>();

            StreamReader reader = new StreamReader(PathToClassesDB);
            toReturnClasses = (List<Class>)serializer.Deserialize(reader);
            reader.Close();

            return toReturnClasses;
        }

        private List<Skill> ReadSkillDatabase(XmlSerializer serializer)
        {
            List<Skill> toReturnSkills = new List<Skill>();

            StreamReader reader = new StreamReader(PathToSkillDB);
            toReturnSkills = (List<Skill>)serializer.Deserialize(reader);
            reader.Close();

            return toReturnSkills;
        }
        #endregion

        //Methods to Create the importable database for each
        #region Create Class, Skill and Weapon Methods
        private void CreateClass(string name, WeaponType weaponTypes, int hpLow, int hpHigh, ClassType classType)
        {
            ListOfAllClasses.Add(new Class(name, weaponTypes, hpLow, hpHigh, classType));
            XmlSerializer serializer = new XmlSerializer(typeof(List<Class>));
            XmlWriter writer;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\DBItems\DatabaseClasses.xml";


            writer = new XmlTextWriter(path, Encoding.UTF8);
            serializer.Serialize(writer, ListOfAllClasses);

            writer.Flush();
            writer.Close();
        }

        private void CreateSkill(int damage, string name, Effects effect, int probability, TypeOfDamage type)
        {
            ListOfAllSkills.Add(new Skill(damage, name, effect, probability, type));
            XmlSerializer serializer = new XmlSerializer(typeof(List<Skill>));
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\DBItems\DatabaseSkill.xml";

            XmlWriter writer = new XmlTextWriter(path, Encoding.UTF8);
            serializer.Serialize(writer, ListOfAllSkills);

            writer.Flush();
            writer.Close();
        }

        private void CreateWeapon(string name, int damage, Rarity rarity, WeaponType weaponType, int value)
        {
            ListOfAllWeapon.Add(new Weapon(name, damage, rarity, weaponType, value));
            XmlSerializer serializer = new XmlSerializer(typeof(List<Weapon>));
            XmlWriter writer;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\DBItems\DatabaseWeapons.xml";


            writer = new XmlTextWriter(path, Encoding.UTF8);
            serializer.Serialize(writer, ListOfAllWeapon);

            writer.Flush();
            writer.Close();
        }
        #endregion

        //Region that prepares the Data inputed by user
        #region Prepare Data for Database
        private void CreateWeaponBtn_Click(object sender, EventArgs e)
        {
            int damage = 0;
            string name = string.Empty;
            int value = 0;
            Rarity rarity = Rarity.Common;
            WeaponType weaponType = WeaponType.Dagger;

            if (NameWeapon.TextLength != 0)
            {
                damage = Convert.ToInt32(DamageWeapon.Text);
                name = NameWeapon.Text;
                value = Convert.ToInt32(ValueWeapon.Text);

                switch (RarityWeapon.Text)
                {
                    case "Common":
                        rarity = Rarity.Common;
                        break;

                    case "Uncommon":
                        rarity = Rarity.Uncommon;
                        break;

                    case "Rare":
                        rarity = Rarity.Rare;
                        break;

                    case "Legend":
                        rarity = Rarity.Legend;
                        break;

                    case "Holy Legend":
                        rarity = Rarity.Holy_Legend;
                        break;
                }

                switch (WeaponTypeWeapon.Text)
                {
                    case "One Handed Sword":
                        weaponType = WeaponType.OneHandedSword;
                        break;

                    case "Two Handed Sword":
                        weaponType = WeaponType.TwoHandedSword;
                        break;

                    case "Bow":
                        weaponType = WeaponType.Bow;
                        break;

                    case "Speer":
                        weaponType = WeaponType.Speer;
                        break;

                    case "Rapier":
                        weaponType = WeaponType.Rapier;
                        break;

                    case "Dagger":
                        weaponType = WeaponType.Dagger;
                        break;
                }

                CreateWeapon(name, damage, rarity, weaponType, value);
            }
            else
            {
                MessageBox.Show("Error, Name is not filled in!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CreateSkillBtn_Click(object sender, EventArgs e)
        {
            int damage = 0;
            string name = String.Empty;
            Effects effect = Effects.None;
            int probabilitySkill = 0;
            TypeOfDamage type = TypeOfDamage.Physical;

            if (NameSkill.TextLength != 0)
            {
                damage = Convert.ToInt32(DamageSkill.Text);
                name = NameSkill.Text;
                probabilitySkill = Convert.ToInt32(ProbsSkill.Text);

                switch (TypeOfDamageSkill.Text)
                {
                    case "Physical":
                        type = TypeOfDamage.Physical;
                        break;

                    case "Magical":
                        type = TypeOfDamage.Magical;
                        break;
                }

                switch (EffectSkill.Text)
                {
                    case "Stun":
                        effect = Effects.Stun;
                        break;

                    case "Blindness":
                        effect = Effects.Blindness;
                        break;

                    case "Sleep":
                        effect = Effects.Sleep;
                        break;

                    case "Knockout":
                        effect = Effects.Knockout;
                        break;

                    case "Burn":
                        effect = Effects.Burn;
                        break;

                    case "Poison":
                        effect = Effects.Poison;
                        break;

                    case "Freeze":
                        effect = Effects.Freeze;
                        break;

                    case "None":
                        effect = Effects.None;
                        break;
                }

                CreateSkill(damage, name, effect, probabilitySkill, type);
            }
            else
            {
                MessageBox.Show("Error, Name is not filled in!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateClassBtn_Click(object sender, EventArgs e)
        {
            string name = string.Empty;
            Int32 hpLow = 0;
            Int32 hpHigh = 0;
            WeaponType weaponType = WeaponType.None;
            ClassType classType = ClassType.Beater;

            if (NameClass.Text.Length != 0)
            {
                name = NameClass.Text;
                hpLow = Convert.ToInt32(HPLowClass.Text);
                hpHigh = Convert.ToInt32(HPHighClass.Text);

                switch (ClassTypeClass.Text)
                {
                    case "Tank":
                        classType = ClassType.Tank;
                        break;

                    case "Beater":
                        classType = ClassType.Beater;
                        break;

                    case "DPS":
                        classType = ClassType.DPS;
                        break;

                    case "Healer":
                        classType = ClassType.Healer;
                        break;

                    case "Archer":
                        classType = ClassType.Archer;
                        break;
                }

                switch (WeaponTypesClass.Text)
                {
                    case "One Handed Sword":
                        weaponType = WeaponType.OneHandedSword;
                        break;

                    case "Two Handed Sword":
                        weaponType = WeaponType.TwoHandedSword;
                        break;

                    case "Bow":
                        weaponType = WeaponType.Bow;
                        break;

                    case "Speer":
                        weaponType = WeaponType.Speer;
                        break;

                    case "Rapier":
                        weaponType = WeaponType.Rapier;
                        break;

                    case "Dagger":
                        weaponType = WeaponType.Dagger;
                        break;
                }

                CreateClass(name, weaponType, hpLow, hpHigh, classType);
            }
            else
            {
                MessageBox.Show("Error, Name is not filled in!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        //Region that covers all Error Messages
        #region Errors

        private void NameWeapon_TextChanged(object sender, EventArgs e)
        {
            if (NameWeapon.TextLength == 0)
            {
                Error1.Visible = true;
            }
            else
            {
                Error1.Visible = false;
            }
        }

        private void NameSkill_TextChanged(object sender, EventArgs e)
        {
            if (NameSkill.TextLength == 0)
            {
                ErrorSkill.Visible = true;
            }
            else
            {
                ErrorSkill.Visible = false;
            }
        }

        private void TypeOfDamageSkill_TextChanged(object sender, EventArgs e)
        {
            if (TypeOfDamageSkill.Text.Length == 0)
            {
                ErrorTypeDMGSkill.Visible = true;
            }
            else
            {
                ErrorTypeDMGSkill.Visible = false;
            }
        }

        private void EffectSkill_TextChanged(object sender, EventArgs e)
        {
            if (EffectSkill.Text.Length == 0)
            {
                ErrorEffectSkill.Visible = true;
            }
            else
            {
                ErrorEffectSkill.Visible = false;
            }
        }

        private void WeaponTypeWeapon_TextChanged(object sender, EventArgs e)
        {
            if (WeaponTypeWeapon.Text.Length == 0)
            {
                ErrorWTWeapon.Visible = true;
            }
            else
            {
                ErrorWTWeapon.Visible = false;
            }
        }

        private void RarityWeapon_TextChanged(object sender, EventArgs e)
        {
            if (RarityWeapon.Text.Length == 0)
            {
                ErrorRarityWeapon.Visible = true;
            }
            else
            {
                ErrorRarityWeapon.Visible = false;
            }
        }

        private void ClassTypeClass_TextChanged(object sender, EventArgs e)
        {
            if (ClassTypeClass.Text.Length == 0)
            {
                ErrorClassTClass.Visible = true;
            }
            else
            {
                ErrorClassTClass.Visible = false;
            }
        }

        private void OnErrorIcon(object sender, EventArgs e)
        {
            foreach (ComboBox allComboBox in AllComboBoxes)
            {
                if (allComboBox.Text.Length == 0)
                {
                    MessageBox.Show("Please enter a selectable or enter a valid Value.",
                        "Error on " + allComboBox.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        //Methods to show each Database
        #region Show Databases
        private void ShowDatabaseWeapon_Click(object sender, EventArgs e)
        {
            WeaponDatabaseViewerW WeaponViewer = new WeaponDatabaseViewerW();
            WeaponViewer.Show();
        }

        private void ShowDatabaseSkill_Click(object sender, EventArgs e)
        {
            DatabaseViewerS SkillViewer = new DatabaseViewerS();
            SkillViewer.Show();
        }

        private void ShowDatabaseClass_Click(object sender, EventArgs e)
        {
            DatabaseViewerC classViewer = new DatabaseViewerC();
            classViewer.Show();
        } 
        #endregion
    }
}
