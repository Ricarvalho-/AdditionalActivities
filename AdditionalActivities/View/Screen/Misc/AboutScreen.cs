using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;

namespace AdditionalActivities.View.Screen.Misc
{
    public partial class AboutScreen : UserControl, IScreen
    {
        public bool IsEditing { get { return false; } }

        public AboutScreen()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            versionLabel.Text = "Versão " + FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion + " Debug";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance.PopScreen();
        }

        public void ScreenWillAppear()
        {

        }
    }
}
