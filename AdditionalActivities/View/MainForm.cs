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
using AdditionalActivities.View.Screen.Course;
using AdditionalActivities.View.Screen.Portfolio;
using AdditionalActivities.View.Screen.Student;

namespace AdditionalActivities.View
{
    public partial class MainForm : Form
    {
        private Stack<IScreen> screenStack = new Stack<IScreen>();

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
            screenStack.Push(new DashboardScreen());
            ReplaceAllWithScreen(screenStack.Peek());
        }

        public static MainForm Shared()
        {
            if (SharedInstance == null)
                SharedInstance = new MainForm();
            return SharedInstance;
        }

        public void ReplaceAllWithScreen(IScreen screen)
        {
            if (!ShouldChangeScreen())
                return;
            screenStack.Clear();
            screenStack.Push(screen);
            ShowTopScreen();
        }

        private void ShowTopScreen()
        {
            if (screenStack.Count == 0)
                return;
            panel.Controls.Clear();
            screenStack.Peek().ScreenWillApear();
            panel.Controls.Add((UserControl)screenStack.Peek());
        }

        private bool ShouldChangeScreen()
        {
            if (screenStack.Count > 0 && screenStack.Peek().IsEditing)
                switch (MessageBox.Show("Suas alterações serão descartadas.", "Sair sem salvar?", MessageBoxButtons.OKCancel))
                {
                    case DialogResult.OK:
                        return true;
                    default:
                        return false;
                }
            return true;
        }

        public void PresentScreen(IScreen screen)
        {
            if (!ShouldChangeScreen())
                return;
            screenStack.Push(screen);
            ShowTopScreen();
        }

        public void PopScreen()
        {
            if (!ShouldChangeScreen() || screenStack.Count <= 1)
                return;
            screenStack.Pop();
            ShowTopScreen();
        }

        public void SwapLastWithScreen(IScreen screen)
        {
            if (!ShouldChangeScreen() || screenStack.Count == 0)
                return;
            screenStack.Pop();
            screenStack.Push(screen);
            ShowTopScreen();
        }

        private void dashButton_Click(object sender, EventArgs e)
        {
            ReplaceAllWithScreen(new DashboardScreen());
        }

        private void coursesButton_Click(object sender, EventArgs e)
        {
            ReplaceAllWithScreen(new CourseListScreen());
        }

        private void studentsButton_Click(object sender, EventArgs e)
        {
            ReplaceAllWithScreen(new StudentListScreen());
        }

        private void portfoliosButton_Click(object sender, EventArgs e)
        {
            ReplaceAllWithScreen(new PortfolioListScreen());
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            ReplaceAllWithScreen(new SettingsScreen());
        }
    }
}
