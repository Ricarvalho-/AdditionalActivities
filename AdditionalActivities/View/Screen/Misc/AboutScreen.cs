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
        private IScreen PreviousScreen {get; set;}

        public AboutScreen(IScreen previousScreen)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            PreviousScreen = previousScreen;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainForm.Shared().SwapToScreen(PreviousScreen);
        }
    }
}
