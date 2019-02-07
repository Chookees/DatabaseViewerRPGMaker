using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using GameFileViewer.Other;

namespace GameFileViewer
{
    public partial class DatabaseViewerC : Form
    {
        private string Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\DBItems\DatabaseClasses.xml";
        private List<Class> DatabaseClass = new List<Class>();

        public DatabaseViewerC()
        {
            InitializeComponent();

            XmlSerializer serializer = new XmlSerializer(typeof(List<Class>));

            DatabaseClass = ReadClassDatabase(serializer);
            DataGridClass.DataSource = DatabaseClass;
        }

        private List<Class> ReadClassDatabase(XmlSerializer serializer)
        {
            List<Class> toReturnClasses = new List<Class>();

            if (File.Exists(Path))
            {
                StreamReader reader = new StreamReader(Path);
                toReturnClasses = (List<Class>)serializer.Deserialize(reader);
                reader.Close();
            }

            return toReturnClasses;
        }

        private void DatabaseViewerC_KeyDown(object sender, KeyEventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Skill>));
            if (e.KeyCode == Keys.F5)
            {
                DataGridClass.DataSource = ReadClassDatabase(serializer);
            }
        }
    }
}
