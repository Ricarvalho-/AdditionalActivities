using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdditionalActivities.View.Screen;
using AdditionalActivities.View.Screen.Misc;

namespace AdditionalActivities.View
{
    public partial class MainForm : Form
    {
        private IScreen ActualScreen { get; set; }

        private static MainForm SharedInstance { get; set; }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Program.WM_SHOW)
            {
                if (WindowState == FormWindowState.Minimized)
                    WindowState = FormWindowState.Normal;
                bool top = TopMost;
                TopMost = true;
                TopMost = top;
            }
            base.WndProc(ref m);
        }

        private MainForm()
        {
            InitializeComponent();
            ActualScreen = new DashboardScreen();
            SwapToScreen(ActualScreen);
        }

        public static MainForm Shared()
        {
            if (SharedInstance == null)
                SharedInstance = new MainForm();
            return SharedInstance;
        }

        internal void SwapToScreen(IScreen newScreen)
        {
            if(ActualScreen.IsEditing)
                switch (MessageBox.Show("Suas alterações serão descartadas.", "Sair sem salvar?", MessageBoxButtons.OKCancel))
                {
                    case DialogResult.OK:
                        break;
                    default:
                        return;
                }
            panel.Controls.Clear();
            panel.Controls.Add((UserControl)newScreen);
            ActualScreen = newScreen;
        }

        private void dashButton_Click(object sender, EventArgs e)
        {
            SwapToScreen(new DashboardScreen());
        }

        private void coursesButton_Click(object sender, EventArgs e)
        {
            SwapToScreen(new CourseListScreen());
        }

        private void studentsButton_Click(object sender, EventArgs e)
        {
            SwapToScreen(new StudentListScreen());
        }

        private void regPortfolioButton_Click(object sender, EventArgs e)
        {
            SwapToScreen(new RegPortfolioScreen());
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SwapToScreen(new SettingsScreen());
        }
    }
}
