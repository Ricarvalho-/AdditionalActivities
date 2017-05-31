using System;
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
    public partial class ActivityDetScreen : UserControl, IScreen
    {
        public bool IsEditing { get; private set; }

        public ActivityDetScreen()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public void ScreenWillApear()
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainForm.Shared().PopScreen();
        }
    }
}
