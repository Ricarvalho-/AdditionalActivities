using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdditionalActivities.View.Controls;
using AdditionalActivities.Controller;

namespace AdditionalActivities.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            MainMenuControl menuControl = new MainMenuControl(this);
            TableControl navControl = new TableControl();
            TableControl detControl = new TableControl();

            mainSplitContainer.Panel1.Controls.Add(menuControl);
            subSplitContainer.Panel1.Controls.Add(navControl);
            subSplitContainer.Panel2.Controls.Add(detControl);

            ViewMediator.NavTable = navControl;
            ViewMediator.DetTable = detControl;
        }

        public void ToggleMainMenuSize(bool expanded)
        {

        }
    }
}
