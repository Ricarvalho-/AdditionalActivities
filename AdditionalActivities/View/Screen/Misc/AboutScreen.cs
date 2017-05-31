using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdditionalActivities.View.Screen.Misc
{
    public partial class AboutScreen : UserControl, IScreen
    {
        public bool IsEditing { get { return false; } }

        public AboutScreen()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainForm.Shared().PopScreen();
        }

        public void ScreenWillApear()
        {

        }
    }
}
