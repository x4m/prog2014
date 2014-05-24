using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using PartyData;

namespace TcpPartyClient
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void кнопкаДобавить_Click(object sender, EventArgs e)
        {

            var sd = new SnackData
            {
                Salo = checkBox1.Checked,
                Jam = checkBox3.Checked,
                Толщина = trackBar1.Value,
            };
            switch (checkBox2.CheckState)
            {
                case CheckState.Unchecked:
                    sd.Caviar = false;
                    break;
                case CheckState.Checked:
                    sd.Caviar = true;
                    break;
                case CheckState.Indeterminate:
                    sd.Caviar = null;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            listBox1.Items.Add(sd);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var adress = textBox1.Text.Split(':');
            var client = new TcpClient(adress[0], int.Parse(adress[1]));
            var xs = new XmlSerializer(typeof (List<SnackData>));
            
            xs.Serialize(client.GetStream(), listBox1.Items.OfType<SnackData>().ToList());
            client.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var adress = textBox1.Text.Split(':');
            //var client = new UdpClient(adress[0], int.Parse(adress[1]));

            var xs = new XmlSerializer(typeof(List<SnackData>));

            var ms = new MemoryStream();
            xs.Serialize(ms, listBox1.Items.OfType<SnackData>().ToList());

            //client.Send(ms.GetBuffer(), (int) ms.Length);
            //client.Close();
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPAddress broadcast = IPAddress.Parse(adress[0]);

            IPEndPoint ep = new IPEndPoint(broadcast, int.Parse(adress[1]));
            s.SendTo(ms.ToArray(), ep);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var xs = new XmlSerializer(typeof(List<SnackData>));

            var ms = new MemoryStream();
            xs.Serialize(ms, listBox1.Items.OfType<SnackData>().ToList());
            var adr = textBox2.Text;
            var wc = new WebClient();
            wc.UploadData(new Uri(adr), "POST", ms.ToArray());
        }
    }
}
