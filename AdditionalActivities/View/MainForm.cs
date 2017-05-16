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
        PlaceholderUI placeholder = new PlaceholderUI();
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

            mainSplitContainer.Panel2.Controls.Clear();
            mainSplitContainer.Panel2.Controls.Add(placeholder);
            mainSplitContainer.Panel2.Controls.Add(subSplitContainer);
            placeholder.Hide();
        }

        public void ToggleMainMenuSize(bool expanded)
        {

        }

        public void ShowPlaceholderUI()
        {
            placeholder.Show();
        }

        public void HidePlaceholderUI()
        {
            placeholder.Hide();
        }
    }
}
