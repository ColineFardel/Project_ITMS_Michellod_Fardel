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
        public Form3(Form1 frm1)
        {
            InitializeComponent();
            this.f1 = frm1;
        }
        private void Form3_Load (object sender, EventArgs e)
        {
            textBoxUsername.Text = f1.textBoxAmountUID.Text;
        }

    }
}
