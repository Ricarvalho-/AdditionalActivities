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
    public partial class DashboardScreen : UserControl, IScreen
    {
        public bool IsEditing { get { return false; } }

        public DashboardScreen()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public void ScreenWillAppear() { }
    }
}
