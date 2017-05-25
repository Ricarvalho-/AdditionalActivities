﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdditionalActivities.View.Screen.Course
{
    public partial class CourseDetScreen : UserControl, IScreen
    {
        public bool IsEditing { get; private set; }

        public CourseDetScreen()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            MainForm.Shared().SwapToScreen(new RuleDetScreen());//UNDONE: Pass object
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            MainForm.Shared().SwapToScreen(new RuleDetScreen());
        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
