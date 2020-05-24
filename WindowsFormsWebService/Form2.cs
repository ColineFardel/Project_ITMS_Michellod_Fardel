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
    public partial class Form2 : Form
    {

        private StudentServiceReference.StudentClient client;
        public Form2()
        {
            InitializeComponent();
            client = new StudentServiceReference.StudentClient();
        }

        private void buttonShowBalanceUID_Click(object sender, EventArgs e)
        {
            client.ShowBalanceID((int)double.Parse(textBoxUID.Text));
        }

        private void buttonShowBalanceUsername_Click(object sender, EventArgs e)
        {
            client.ShowBalanceUsername(textBoxUsername.Text);
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
