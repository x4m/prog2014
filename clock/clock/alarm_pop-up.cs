using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clock
{
    public partial class alarm_pop_up : Form
    {
        public alarm_pop_up()       {
            InitializeComponent();
        }

        private void alarm_popUp_okButton_Click(object sender, EventArgs e)     {
            this.Close();
        }
    }
}
