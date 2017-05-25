using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdditionalActivities.View.Screen.Student;

namespace AdditionalActivities.View.Screen
{
    public partial class StudentListScreen : UserControl, IScreen
    {
        public bool IsEditing { get { return false; } }

        public StudentListScreen()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            MainForm.Shared().SwapToScreen(new StudentDetScreen());//UNDONE: Pass object
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            MainForm.Shared().SwapToScreen(new StudentDetScreen());
        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
