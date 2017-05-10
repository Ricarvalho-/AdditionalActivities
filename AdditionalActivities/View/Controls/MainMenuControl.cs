using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdditionalActivities.View.Controls.Headers;
using AdditionalActivities.Model.Persistent;

namespace AdditionalActivities.View.Controls
{
    public partial class MainMenuControl : UserControl
    {
        MainForm parent;

        public MainMenuControl(MainForm parent)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.parent = parent;
        }

        private void studentsButton_Click(object sender, EventArgs e)
        {
            parent.ShowNavigation(new PersistentObjectModelType());
        }

        private void rulesButton_Click(object sender, EventArgs e)
        {
            parent.ShowNavigation(new PersistentObjectModelType());
        }
    }
}
