using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Xml.Serialization;
using PartyData;


namespace UdpServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        UdpClient listener;

        private void Form1_Load(object sender, EventArgs e)
        {
            listener = new UdpClient(12345);
            new Thread(ThreadStart).Start();
        }

        private List<SnackData> _snacks;

        private void ThreadStart()
        {
            while (true)
            {
                IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, 12345);

                var data = listener.Receive(ref groupEP);

                var xs = new XmlSerializer(typeof(List<SnackData>));
                var ms = new MemoryStream(data);
                var list = (List<SnackData>)xs.Deserialize(ms);
                _snacks = list;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(_snacks==null)
                return;
            listBox1.Items.Add(DateTime.Now + " Пришли бутерброды " + _snacks.Count);

            foreach (var snackData in _snacks)
            {
                listBox1.Items.Add(snackData);
            }
            _snacks = null;
        }
    }
}
