using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using GameFileViewer.Other;

namespace GameFileViewer
{
    public partial class WeaponDatabaseViewerW : Form
    {
        private string Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\DBItems\DatabaseWeapons.xml";
        private List<Weapon> DatabaseWeapons = new List<Weapon>();


        public WeaponDatabaseViewerW()
        {
            InitializeComponent();

            XmlSerializer serializer = new XmlSerializer(typeof(List<Weapon>));

            DatabaseWeapons = ReadWeaponDatabase(serializer);
            DataGridWeapon.DataSource = DatabaseWeapons;
        }

        private List<Weapon> ReadWeaponDatabase(XmlSerializer serializer)
        {
            List<Weapon> toReturnWeapons = new List<Weapon>();

            if (File.Exists(Path))
            {
                StreamReader reader = new StreamReader(Path);
                toReturnWeapons = (List<Weapon>) serializer.Deserialize(reader);
                reader.Close();
            }

            return toReturnWeapons;
        }

        private void WeaponDatabaseViewerW_KeyDown(object sender, KeyEventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Weapon>));
            if (e.KeyCode == Keys.F5)
            {
                DataGridWeapon.DataSource = ReadWeaponDatabase(serializer);
            }
        }
    }
}
