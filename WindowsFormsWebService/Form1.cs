using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsWebService
{
    public partial class Form1 : Form
    {
        private StudentServiceReference.StudentClient client;
        public Form1()
        {
            InitializeComponent();
            client = new StudentServiceReference.StudentClient();
        }
        private void buttonAddMoneyUsername_Click(object sender, EventArgs e)
        {
            client.AddMoneyUsername(textBoxUsername.Text, double.Parse(textBoxAmountUsername.Text));
            this.Hide();
            Form3 f3 = new Form3(this);
            f3.ShowDialog();
        }

        private void buttonAddMoneyUID_Click(object sender, EventArgs e)
        {
           client.AddMoneyUID((int)double.Parse(textBoxUID.Text), double.Parse(textBoxAmountUID.Text));
        }


        private void textBoxAmountUsername_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBoxAmountUID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
