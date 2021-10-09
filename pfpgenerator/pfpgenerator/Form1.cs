using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pfpgenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient web = new WebClient();
            String name = web.DownloadString("https://api.leaked.wiki/randomuser?json=no");

               
                richTextBox1.Text = "";
                richTextBox1.AppendText($"{name}");
                
              
           
        }
    }
}
