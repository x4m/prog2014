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

namespace TcpPartyServer
{
    public partial class TcpServerForm : Form
    {
        public TcpServerForm()
        {
            InitializeComponent();
        }

        TcpListener tcpListener;
        private void TcpServerForm_Load(object sender, EventArgs e)
        {
            tcpListener = new TcpListener(IPAddress.Loopback, 12345);
            tcpListener.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(!tcpListener.Pending())
                return;
            var socket = tcpListener.AcceptSocket();
            listBox1.Items.Add(DateTime.Now+ " Принято соединени от " + socket.RemoteEndPoint);
            var buffer = new byte[8192];
            var realyBytesRead = socket.Receive(buffer);
            if (realyBytesRead > 0)
            {
                var xs = new XmlSerializer(typeof(List<SnackData>));
                var ms = new MemoryStream(buffer, 0, realyBytesRead);
                var list = (List<SnackData>)xs.Deserialize(ms);
                listBox1.Items.Add(DateTime.Now + " Пришли бутерброды " +list.Count);
                foreach (var snackData in list)
                {
                    listBox1.Items.Add(snackData);
                }
            
            }
        }
    }
}
