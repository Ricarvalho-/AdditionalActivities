using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
//using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdditionalActivities.Controller;
using AdditionalActivities.Model.Persistent;

namespace AdditionalActivities.View.Controls
{
    public partial class MainMenuControl : UserControl
    {
        MainForm mainForm;
        static bool expanded = false;

        public MainMenuControl(MainForm parent)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            mainForm = parent;
        }

        private void studentsButton_Click(object sender, EventArgs e)
        {
            ViewMediator.RootType = typeof(Student);
        }

        private void rulesButton_Click(object sender, EventArgs e)
        {
            ViewMediator.RootType = typeof(Rule);
        }

        private void toggleSizeButton_Click(object sender, EventArgs e)
        {
            mainForm.ToggleMainMenuSize(expanded = !expanded);
        }

        //TBD: Settings()
        //TBD: Help/About/Feedback()
    }
}
