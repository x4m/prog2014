using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog() { Filter = "няня|*.nyny" };
            var result = sfd.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var fileName = sfd.FileName;
                NynyData pd = new NynyData();
                pd.ItemType = new List<NynyType>();
                if (checkBox1.Checked)
                    pd.ItemType.Add(NynyType.Rus);
                if (checkBox2.Checked)
                    pd.ItemType.Add(NynyType.Eng);
                if (checkBox3.Checked)
                    pd.ItemType.Add(NynyType.Fr);
                if (checkBox4.Checked)
                    pd.ItemType.Add(NynyType.Ger);
                if (checkBox5.Checked)
                    pd.ItemType.Add(NynyType.Nachalnoe);
                if (checkBox6.Checked)
                    pd.ItemType.Add(NynyType.Srednee);
                if (checkBox7.Checked)
                    pd.ItemType.Add(NynyType.Vishee);
                if (checkBox8.Checked)
                    pd.ItemType.Add(NynyType.One);
                if (checkBox9.Checked)
                    pd.ItemType.Add(NynyType.Three);
                if (checkBox10.Checked)
                    pd.ItemType.Add(NynyType.More);
                pd.Age = (int)numericUpDown1.Value;
                pd.Age1 = (int)numericUpDown2.Value;
               
                XmlSerializer xs = new XmlSerializer(typeof(NynyData));
                var fileStream = File.Create(fileName);
                xs.Serialize(fileStream, pd);
                fileStream.Close();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() { Filter = "няня|*.nyny" };
            var result = ofd.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var xs = new XmlSerializer(typeof(NynyData));
                var file = File.Open(ofd.FileName, FileMode.Open);
                var pd = (NynyData)xs.Deserialize(file);
                file.Close();

                checkBox1.Checked = pd.ItemType.Contains(NynyType.Rus);
                checkBox2.Checked = pd.ItemType.Contains(NynyType.Eng);
                checkBox3.Checked = pd.ItemType.Contains(NynyType.Fr);
                checkBox4.Checked = pd.ItemType.Contains(NynyType.Ger);
                checkBox5.Checked = pd.ItemType.Contains(NynyType.Nachalnoe);
                checkBox6.Checked = pd.ItemType.Contains(NynyType.Srednee);
                checkBox7.Checked = pd.ItemType.Contains(NynyType.Vishee);
                checkBox8.Checked = pd.ItemType.Contains(NynyType.One);
                checkBox9.Checked = pd.ItemType.Contains(NynyType.Three);
                checkBox10.Checked = pd.ItemType.Contains(NynyType.More);
                numericUpDown1.Value = pd.Age;
                numericUpDown2.Value = pd.Age1;
            }
        }
    }
    public class NynyData
    {
        public List<NynyType> ItemType { get; set; }
        public int Age { get; set; }
        public int Age1 { get; set; }
    }
    public enum NynyType
    {
        Rus, Eng, Fr, Ger, Nachalnoe, Srednee, Vishee, One, Three, More
    }
}
