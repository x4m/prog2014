using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace library_application   {
    public partial class Form1 : Form    {
        public Form1()  {
            InitializeComponent();
        }

        public class library    {
            public List<book> books { get; set; }

            public static object Two { get; set; }
       
        }
        public class book   {
            public string author { get; set; }
            public string name { get; set; }
            public int year { get; set; }
            public override string ToString()
            {
                var str = "Книга: " + author + " / " + name + ", " + year + "г.";
                return str;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog() { Filter = "список книг|*.xml" };
            var result = save.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var fileName = save.FileName;
                library lb = new library();
                lb.books = new List<book>();
                foreach (book bk in listBox1.Items)     {
                    lb.books.Add(bk);
                }
                XmlSerializer xser = new XmlSerializer(typeof(library));
                var fileStream = File.Create(fileName);
                xser.Serialize(fileStream, lb);
                fileStream.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 2 || textBox2.TextLength < 2)            {
                var res = MessageBox.Show("Введите значения!", "Ошибка!", MessageBoxButtons.OK);
                return;
            }
                var bk = new book   {
                author = textBox1.Text,
                name = textBox2.Text,
                year = (int)numericUpDown1.Value,
            };
            listBox1.Items.Add(bk);
            textBox1.Text = null;
            textBox2.Text = null;
            numericUpDown1.Value = 1900;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog() { Filter = "список книг|*.xml" };
            var result = open.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                if (listBox1.Items.Count > 1)
                {
                    var res = MessageBox.Show("Вы уверены что хотите продолжить? Введённые ранее данные будут утеряны!", "Предупреждение", MessageBoxButtons.YesNo);
                    if (res != DialogResult.Yes)
                        return;
                }
                var xser = new XmlSerializer(typeof(library));
                var file = File.Open(open.FileName, FileMode.Open);
                var lb = (library)xser.Deserialize(file);
                file.Close();
                listBox1.Items.Clear();
                foreach (var book in lb.books)
                {
                    listBox1.Items.Add(book);                  
                }
                     
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox2.Checked == true)
                MessageBox.Show("Вы выбрали две книги");


            else if (checkBox1.Checked == true)
                MessageBox.Show("Вы выбрали одну книгу");
            else if (checkBox2.Checked == true)
                MessageBox.Show("Вы выбрали одну книгу");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox2.Checked == true)
                MessageBox.Show("Вы выбрали две книги");


            else if (checkBox1.Checked == true)
                MessageBox.Show("Вы выбрали одну книгу");
            else if (checkBox2.Checked == true)
                MessageBox.Show("Вы выбрали одну книгу");  
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightYellow;
        }

    }
}
