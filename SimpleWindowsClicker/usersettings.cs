using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleWindowsClicker
{
    public partial class usersettings : Form
    {
        public string Userb = "Default";
        public usersettings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Userb = textBox1.Text;
            var yPr = new Program();
            yPr.settingsFile.Write("username", Userb, "User");
            var xFrm = new Form1();
        }

        private void usersettings_Load(object sender, EventArgs e)
        {
            textBox1.Text = Userb;
        }
    }
}
