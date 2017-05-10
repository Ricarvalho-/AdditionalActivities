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
using AdditionalActivities.View.Controls.Headers;
using AdditionalActivities.Model.Persistent;

namespace AdditionalActivities.View
{
    public partial class MainForm : Form
    {
        static MainMenuControl menuControl;
        static TableControl navControl;
        static TableControl detControl;

        public MainForm()
        {
            InitializeComponent();

            menuControl = new MainMenuControl(this);
            navControl = new TableControl(this);
            detControl = new TableControl(this);

            this.mainSplitContainer.Panel1.Controls.Add(menuControl);
            this.subSplitContainer.Panel1.Controls.Add(navControl);
            this.subSplitContainer.Panel2.Controls.Add(detControl);
        }

        public void ShowNavigation(PersistentObjectModelType objType)
        {
            navControl.SetHeader(new SearchHeader(navControl, objType));
            detControl = new TableControl(this);
            this.subSplitContainer.Panel2.Controls.Clear();
            this.subSplitContainer.Panel2.Controls.Add(detControl);
        }

        public void showDetails(IPersistentObjectModel obj)
        {
            detControl.SetHeader(new DetailsHeader(detControl, obj));
        }
    }
}
