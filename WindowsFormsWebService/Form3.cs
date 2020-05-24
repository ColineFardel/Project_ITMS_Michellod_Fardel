using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsWebService
{
    public partial class Form3 : Form
    {
        Form1 f1;
        private StudentServiceReference.StudentClient client;
        public Form3(Form1 frm1)
        {
            InitializeComponent();
            this.f1 = frm1;
            client = new StudentServiceReference.StudentClient();
        }
        private void Form3_Load (object sender, EventArgs e)
        {
            textBoxUsername.Text = f1.textBoxUsername.Text;
        }

        private void textBoxBalance_TextChanged(object sender, EventArgs e)
        {
            client.ShowBalanceUsername(f1.textBoxUsername.Text);
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
