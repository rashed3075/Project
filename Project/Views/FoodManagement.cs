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
    public partial class FoodManagement : Form
    {
        public FoodManagement()
        {
            InitializeComponent();
        }

        private void AfClicked(object sender, EventArgs e)
        {
            new FoodRegForm().Show();
        }
    }
}
