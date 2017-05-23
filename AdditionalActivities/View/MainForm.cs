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
using AdditionalActivities.View.Controls.CRUDs;
using AdditionalActivities.View.Controls.FilterOrder;

namespace AdditionalActivities.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //NOTE: Will be changed to dashboard
            splitContainer.Panel1.Controls.Add(new AboutScreen());//HACK: Mock
            splitContainer.Panel2.Controls.Add(new FilterOrderTableControl());//HACK: Mock
            //NOTE: Will start collapsed and should be opened by filter button in CRUDs, if previously activated in settings
            //splitContainer.Panel2Collapsed = true;
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            SwapToScreen(new DashboardScreen());
        }

        private void coursesButton_Click(object sender, EventArgs e)
        {
            SwapToScreen(new CourseCrud());
        }

        private void rulesButton_Click(object sender, EventArgs e)
        {
            SwapToScreen(new RuleCrud());
        }

        private void activitiesButton_Click(object sender, EventArgs e)
        {
            SwapToScreen(new ActivityCrud());
        }

        private void studentsButton_Click(object sender, EventArgs e)
        {
            SwapToScreen(new StudentCrud());
        }

        private void activityPortfoliosButton_Click(object sender, EventArgs e)
        {
            SwapToScreen(new ActivityPortfolioCrud());
        }

        private void activityItemsButton_Click(object sender, EventArgs e)
        {
            SwapToScreen(new ActivityItemCrud());
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SwapToScreen(new SettingsScreen());
        }

        private void SwapToScreen(UserControl newScreen)
        {
            if(true)//UNDONE: if(editing)
                switch (MessageBox.Show("Suas alterações serão descartadas.", "Sair sem salvar?", MessageBoxButtons.OKCancel))
                {
                    case DialogResult.OK:
                        break;
                    default:
                        return;
                }
            splitContainer.Panel2Collapsed = true;
            splitContainer.Panel1.Controls.Clear();
            splitContainer.Panel1.Controls.Add(newScreen);
        }
    }
}
