using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Ghoul_Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FNPath = PathTextBox.Text;
            string FNExePath = System.IO.Path.Combine(this.PathTextBox.Text, "FortniteGame/Binaries/Win64/FortniteClient-Win64-Shipping.exe");
            string LaunchArgs = "-AUTH_LOGIN=" + id.Text + " -AUTH_PASSWORD=" + auth.Text + "-AUTH_TYPE=epic -epicapp=Fortnite -epicenv=Prod -epiclocale=en-us -epicportal";
            System.Diagnostics.Process.Start(FNExePath, LaunchArgs);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://rebrand.ly/authcode");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.epicgames.com/account/personal?lang=en&productName=epicgames");
        }
    }
}
