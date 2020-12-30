﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Views
{
    public partial class AdminPortal : Form
    {
        public AdminPortal(string name)
        {
            InitializeComponent();
            string output = String.Format("Welcome {0}", name);
            WelcomeBox.Text = output;
        }

        private void RManagementClicked(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void emanagemenetClicked(object sender, EventArgs e)
        {
            new EmployeeManagement().Show();
        }

        private void emClicked(object sender, EventArgs e)
        {
            new EmployeeManagement().Show();
        }

        private void RM_Click(object sender, EventArgs e)
        {
            new RestaurantManagement().Show();
        }
    }
}
