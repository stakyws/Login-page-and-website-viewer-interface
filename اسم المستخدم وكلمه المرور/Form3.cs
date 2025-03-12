using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace اسم_المستخدم_وكلمه_المرور
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public void lab(string l)
        {
            label4.Text = l;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            HtmlElement el = webBrowser1.Document.GetElementById("true");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = false;
            webBrowser2.Visible = true;
            webBrowser3.Visible = false;
            webBrowser4.Visible = false;
            webBrowser5.Visible = false;
            webBrowser6.Visible = false;
            webBrowser7.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = false;
            webBrowser2.Visible = false;
            webBrowser3.Visible = true;
            webBrowser4.Visible = false;
            webBrowser5.Visible = false;
            webBrowser6.Visible = false;
            webBrowser7.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = false;
            webBrowser2.Visible = false;
            webBrowser3.Visible = false;
            webBrowser4.Visible = true;
            webBrowser5.Visible = false;
            webBrowser6.Visible = false;
            webBrowser7.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = false;
            webBrowser2.Visible = false;
            webBrowser3.Visible = false;
            webBrowser4.Visible = false;
            webBrowser5.Visible = true;
            webBrowser6.Visible = false;
            webBrowser7.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = false;
            webBrowser2.Visible = false;
            webBrowser3.Visible = false;
            webBrowser4.Visible = false;
            webBrowser5.Visible = false;
            webBrowser6.Visible = true;
            webBrowser7.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = false;
            webBrowser2.Visible = false;
            webBrowser3.Visible = false;
            webBrowser4.Visible = false;
            webBrowser5.Visible = false;
            webBrowser6.Visible = false;
            webBrowser7.Visible = true;
        }


    }
}
