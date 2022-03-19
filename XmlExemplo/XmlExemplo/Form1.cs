using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace XmlExemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlSerializer plantsXmlserializer = new XmlSerializer(typeof(CATALOG));
            TextReader text = (TextReader)new StreamReader("C:\\Lab\\plant_catalog.xml");
            XmlTextReader xmlTextReader = new XmlTextReader(text);
            xmlTextReader.Read();

            CATALOG plantsXmlObj = (CATALOG)plantsXmlserializer.Deserialize(xmlTextReader);


            CATALOGPLANT[] newPlant = new CATALOGPLANT[2];
            

            foreach (CATALOGPLANT c in plantsXmlObj.PLANT)
            {
                MessageBox.Show(c.BOTANICAL) ;
                newPlant[0] = new CATALOGPLANT();
                newPlant[0].COMMON = c.COMMON;
                newPlant[0].BOTANICAL = c.BOTANICAL;
                newPlant[0].AVAILABILITY = c.AVAILABILITY;
                newPlant[0].LIGHT  = c.LIGHT;
                newPlant[0].PRICE= c.PRICE;
                newPlant[0].ZONE = c.ZONE;
                break;
            }
            newPlant[1] = new CATALOGPLANT();
            newPlant[1].BOTANICAL = "teste";
            newPlant[1].COMMON = "teste";
            newPlant[1].AVAILABILITY = "099";
            newPlant[1].LIGHT = "teste";
            newPlant[1].PRICE = "teste";
            newPlant[1].ZONE = "teste";

            plantsXmlObj.PLANT = newPlant;

            foreach (CATALOGPLANT c in plantsXmlObj.PLANT)
            {
                MessageBox.Show(c.BOTANICAL);
            }

            //XmlSerializer x = new XmlSerializer(typeof(CATALOG));
            TextWriter writer = new StreamWriter("C:\\Lab\\plant_catalog_modified.xml");
            plantsXmlserializer.Serialize(writer, plantsXmlObj);

        }
    }
}
