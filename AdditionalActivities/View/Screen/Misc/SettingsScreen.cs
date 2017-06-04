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
    public partial class SettingsScreen : UserControl, IScreen
    {
        public bool IsEditing { get; private set; }

        public SettingsScreen()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance.PresentScreen(new AboutScreen());
        }

        public void ScreenWillAppear()
        {

        }
    }
}
