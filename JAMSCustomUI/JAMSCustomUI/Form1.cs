using MVPSI.JAMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAMSCustomUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var server = Server.GetServer("DF-JAMS7.helpsysdev.com");

            Submit.Info si;
            Submit.Load(out si, textBox1.Text, server);
            si.Submit();
        }
    }
}
