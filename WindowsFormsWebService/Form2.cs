﻿using System;
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
        private void buttonGetStudentUsername_Click(object sender, EventArgs e)
        {
            client.GetStudentByUsername(textBoxUsername.Text);
        }

        private void buttonGetStudentUID_Click(object sender, EventArgs e)
        {
           client.GetStudentByUID((int) double.Parse(textBoxUID.Text));
        }

        private void buttonGetAll_Click(object sender, EventArgs e)
        {
            client.GetAllStudents();
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUID_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonGetAll_Click_1(object sender, EventArgs e)
        {

        }
    }
}
