using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using GameFileViewer.Other;

namespace GameFileViewer
{
    public partial class DatabaseViewerS : Form
    {
        private string Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\DBItems\DatabaseSkill.xml";
        private List<Skill> DatabaseSkill = new List<Skill>();

        public DatabaseViewerS()
        {
            InitializeComponent();

            XmlSerializer serializer = new XmlSerializer(typeof(List<Skill>));

            DatabaseSkill = ReadSkillDatabase(serializer);
            DataGridSkill.DataSource = DatabaseSkill;
        }

        private List<Skill> ReadSkillDatabase(XmlSerializer serializer)
        {
            List<Skill> toReturnSkills = new List<Skill>();

            if (File.Exists(Path))
            {
                StreamReader reader = new StreamReader(Path);
                toReturnSkills = (List<Skill>)serializer.Deserialize(reader);
                reader.Close();
            }

            return toReturnSkills;
        }

        private void DatabaseViewerS_KeyDown(object sender, KeyEventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Skill>));
            if (e.KeyCode == Keys.F5)
            {
                DataGridSkill.DataSource = ReadSkillDatabase(serializer);
            }
        }
    }
}
