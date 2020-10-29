using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Web_Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            browser.GoBack();
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            browser.GoForward();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            browser.Navigate(urlBox.Text);
        }


    }
}
