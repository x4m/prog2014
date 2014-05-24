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
using System.Xml.Serialization;
using PartyData;

namespace HttpServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        HttpListener listener;
        private List<SnackData> _snacks;
        List<SnackData> _allSnacks = new List<SnackData>();

        private void Form1_Load(object sender, EventArgs e)
        {
            listener = new HttpListener();
            listener.Prefixes.Add("http://employee8:8081/Party/");
            listener.Start();

            new Thread(ThreadStart).Start();
        }

        private void ThreadStart()
        {
            while (true)
            {
                HttpListenerContext context = listener.GetContext();
                HttpListenerRequest request = context.Request;

                if (request.HttpMethod == "POST")
                {
                    var xs = new XmlSerializer(typeof(List<SnackData>));
                    var list = (List<SnackData>)xs.Deserialize(request.InputStream);
                    _snacks = list;
                    _allSnacks.AddRange(list);
                }
                // Obtain a response object.
                HttpListenerResponse response = context.Response;
                // Construct a response.
                string responseString = "<HTML><BODY> Hello world! Use method POST to send Snack Data <br> <table>"+GetSnacksString()+"</table></BODY></HTML>";
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
                // Get a response stream and write the response to it.
                response.ContentLength64 = buffer.Length;
                System.IO.Stream output = response.OutputStream;
                output.Write(buffer, 0, buffer.Length);
                // You must close the output stream.
                output.Close();
            }
        }

        private string GetSnacksString()
        {
            var rows = _allSnacks.Select(s => "<tr><td>" + s.ToString() + "</td></tr>");
            return string.Join("", rows);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (_snacks == null)
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
