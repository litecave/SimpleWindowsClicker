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
    public partial class Form1 : Form
    {
        int i = 0;
        

        public Form1()
        {
        InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var xPr = new Program();
            var xUsrS = new usersettings();
            label2.Text = Convert.ToString(i);
            xUsrS.Userb = xPr.settingsFile.Read("username", "User");
            xUsrS.textBox1.Text = xUsrS.Userb;
            label3.Text = "Welcome, " + xUsrS.Userb + "!";
            label3.Location = new Point(15, 425);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i = i + 1;
            label2.Text = Convert.ToString(i);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var xPr = new Program();
            xPr.settingsFile.Write("clicks", label2.Text ,"Clicker");
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var xPr = new Program();
            var xUsrS = new usersettings();
            i = Convert.ToInt16(xPr.settingsFile.Read("clicks", "Clicker"));
            label2.Text = Convert.ToString(i);
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nameUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMyDialogBox();
        }



        public void ShowMyDialogBox()
        {
            usersettings testDialog = new usersettings();
            testDialog.ShowDialog(this);
            testDialog.Dispose();
        }
    }
}