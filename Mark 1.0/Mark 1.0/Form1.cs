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

namespace Mark_1._0
{
    public partial class Girls : Form
    {
        public Girls()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("780.jpg");
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() { Filter = "заказ|*.Put" };
            var result = ofd.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var xs = new XmlSerializer(typeof(Putana));
                var file = File.Open(ofd.FileName, FileMode.Open);
                var pu = (Putana)xs.Deserialize(file);
                file.Close();
                radioButton1.Checked = pu.option == Option.Azia;
                radioButton2.Checked = pu.option == Option.Evro;
                radioButton3.Checked = pu.option == Option.Mulat;
                radioButton6.Checked = pu.figura == Figura.thin;
                radioButton5.Checked = pu.figura == Figura.norm;
                radioButton4.Checked = pu.figura == Figura.polnaya;
                radioButton7.Checked = pu.figura == Figura.jeer;
                radioButton8.Checked = pu.chas == Chas.hour;
                radioButton9.Checked = pu.chas == Chas.threehour;
                radioButton10.Checked = pu.chas == Chas.night;
                numericUpDown1.Value = pu.Age;
                trackBar1.Value = pu.tits;

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog() { Filter = "заказ|*.Put" };
            var result = sfd.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var fileName = sfd.FileName;
                var pu = CreatePutana();
                

                
            XmlSerializer xs = new XmlSerializer(typeof(Putana));
                var fileStream = File.Create(fileName);
                xs.Serialize(fileStream, pu);
                fileStream.Close();
                
              
            
            }
            
        }

        private Putana CreatePutana()
        {
            Putana pu = new Putana();
            if (radioButton1.Checked)
                pu.option = Option.Azia;
             if (radioButton2.Checked)
                pu.option = Option.Evro;
             if (radioButton3.Checked)
                pu.option = Option.Mulat;
             if (radioButton4.Checked)
                pu.figura = Figura.polnaya;
             if (radioButton6.Checked)
                pu.figura = Figura.thin;
             if (radioButton5.Checked)
                pu.figura = Figura.norm;
             if (radioButton7.Checked)
                pu.figura = Figura.jeer;
             if (radioButton8.Checked)
                pu.chas = Chas.hour;
             if (radioButton9.Checked)
                pu.chas = Chas.threehour;
             if (radioButton10.Checked)
                pu.chas = Chas.night;
            


            pu.Age = (int)numericUpDown1.Value;

            pu.tits = (int)trackBar1.Value;
            
            return pu;
        }
    
         


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label8.Text = trackBar1.Value.ToString();
            label15.Text = trackBar1.Value.ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            int с = 0;
            if (radioButton8.Checked)
            {
                с = 1;
            }
            if (с == 1)
            {
                label17.Text = "один час.";
            }

        }
            

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            int с = 0;
            if (radioButton9.Checked)
            {
                с = 1;
            }
            if (с == 1)
            {
                label17.Text = "три часа.";
            }
        }

        
        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            label11.Text = numericUpDown1.Value.ToString(); 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            int с = 0;
            if (radioButton5.Checked)
            {
                с = 1;
            }
            if (с == 1)
            {
                label12.Text = "Стройную";
            }

        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            int с = 0;
            if (radioButton4.Checked)
            {
                с = 1;
            }
            if (с == 1)
            {
                label12.Text = "Полную";
            }

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            int a=0;
            if (radioButton7.Checked)
            {
                a = 1;
            }
            if (a == 1)
            {
                label12.Text = "Жирную";
            }



        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            int с = 0;
            if (radioButton6.Checked)
            {
                с = 1;
            }
            if (с == 1)
            {
                label12.Text = "Худую";
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int с = 0;
            if (radioButton1.Checked)
            {
                с = 1;
               
                    pictureBox1.Image = Image.FromFile("777.jpg");
             
            }
            if (с == 1)
            {
                label13.Text = "азиатку";
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int с = 0;
            if (radioButton2.Checked)
            {
                с = 1;
            }
            pictureBox1.Image = Image.FromFile("778.jpg");
            if (с == 1)
            {
                label13.Text = "европейку";
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int с = 0;
            if (radioButton3.Checked)
            {
                с = 1;
            }
            pictureBox1.Image = Image.FromFile("779.jpg");
            if (с == 1)
            {
                label13.Text = "мулатку";
            }

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            int с = 0;
            if (radioButton10.Checked)
            {
                с = 1;
            }
            if (с == 1)
            {
                label17.Text = "ночь.";
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        public class Putana
        {
            public Option option { get; set; }
            public Figura figura { get; set; }
            public Chas chas { get; set; }
            public int Age { get; set; }
            public int tits { get; set; }

            [XmlIgnore]
            public string Caption
            {
                get
                {
                    return "Девушка";
                }
            }

            [XmlIgnore]
            public string info
            {
                get
                {
                    if (option == Option.Azia)
                        return "Азиатка";
                    if (option == Option.Evro)
                    return "Европейка";
                    return "Мулатка ";
                }
            }

            [XmlIgnore]
            public string info1
            {
                get
                {
                    if (figura == Figura.thin)
                        return "худую";
                    if (figura == Figura.norm)
                        return "стройную";
                    if (figura == Figura.polnaya)
                    return "полную";
                    return "жирную";
                }
            }

            [XmlIgnore]
            public string info2
            {
                get
                {
                    if (chas == Chas.hour)
                        return "час";
                    if (chas == Chas.threehour)
                        return "3 часа";
                    return "ночь ";
                }
            }
              
        
             
        }
            
                  
           public enum Option
              {
                  Azia,
                  Evro,
                  Mulat
            }
                 public enum Figura
                 {
                thin,
                  norm,
                  polnaya,
                  jeer
                 }
                public enum Chas
                {
                  hour,
                  threehour,
                  night
                  }

              

                private void button3_Click_1(object sender, EventArgs e)
                {
                    var pr = new PutanaReport();
                    Putana pu = CreatePutana();
                    pr.DataSource = new BindingSource() { DataSource = pu };
                    pr.ShowPreview();
                }
                
                  

             
        }


      
       
    
    
    }


