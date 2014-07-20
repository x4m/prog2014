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
using DevExpress.XtraReports.UI;
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
                var pd = CreateNynyData();
                var fileName = sfd.FileName;
                XmlSerializer xs = new XmlSerializer(typeof(NynyData));
                var fileStream = File.Create(fileName);
                xs.Serialize(fileStream, pd);
                fileStream.Close();
            }
        }
        private NynyData CreateNynyData()
        {
            NynyData pd = new NynyData();
      
           
            pd.Nyny = new List<Option>();
            foreach (Option nd in listBox1.Items)
            {
                pd.Nyny.Add(nd);
            }
            return pd;
          
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
                
                listBox1.Items.Clear();
                foreach (var nyny in pd.Nyny)
                {
                    listBox1.Items.Add(nyny);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var nd = new Option
             {
                 Russia = checkBox1.Checked,
                 English = checkBox2.Checked,
                 French = checkBox3.Checked,
                 one = checkBox8.Checked,
                 three = checkBox9.Checked,
                 more = checkBox10.Checked,
                 Age = (int)numericUpDown1.Value,
             };
            if (listBox1.Items.Count < 1)
            { listBox1.Items.Add(nd); }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var pr = new XtraReport1();
            NynyData pd = CreateNynyData();
            pr.DataSource = new BindingSource() {DataSource = pd};
            pr.ShowPreview();
        }
       

    }
    public class NynyData
    {
       
        public List<Option> Nyny { get; set; }

        
    }

    public class Option
    {
        public int Age { get; set; }
        public bool Russia { get; set; }
        public bool English { get; set; }
        public bool French { get; set; }
        public bool one { get; set; }
        public bool three { get; set; }
        public bool more { get; set; }

        [XmlIgnore]
        public string Description { get { return this.ToString(); } }
        public override string ToString()
        {
            var s = "Вы выбрали няню " + Age + "лет ";
            if (Russia)
                s += "c знанием только русского языка";
            if (English)
                s += "c знанием английского языка";
            if (French)
                s += "c знанием французского языка";
            if (one)
                s += " на время один час";
            if (three)
                s += " на время от 1 до 3 часов";
            if (more)
                s += " на время более 3 часов";
            return s;
        }
        
    }
    public enum NynyType
    {
        Rus, Eng, Fr, One, Three, More
    }
}
