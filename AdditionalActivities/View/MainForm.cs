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
        #region Single instance application handler
        ///<summary> Single instance application callback handler.</summary>
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
        #endregion

        #region Singleton
        private static MainForm instance;

        private MainForm()
        {
            InitializeComponent();
            SelectedButton = dashButton;
            screenStack.Push(new DashboardScreen());
            ReplaceAllWithScreen(screenStack.Peek());
        }

        /// <summary> MainForms's Singleton instance getter.</summary>
        public static MainForm Instance
        {
            get
            {
                if (instance == null)
                    instance = new MainForm();
                return instance;
            }
        }
        #endregion

        #region Navigation
        private Stack<IScreen> screenStack = new Stack<IScreen>();
        private Button SelectedButton { get; set; }

        ///<summary> Clears the navigation stack and presents an IScreen.</summary>
        public void ReplaceAllWithScreen(IScreen screen)
        {
            if (!ShouldChangeScreen())
                return;
            screenStack.Clear();
            screenStack.Push(screen);
            ShowTopScreen();
        }
        
        /// <summary> Presents the top IScreen in navigation stack.</summary>
        private void ShowTopScreen()
        {
            if (screenStack.Count == 0)
                return;
            panel.Controls.Clear();
            screenStack.Peek().ScreenWillAppear();
            panel.Controls.Add((UserControl)screenStack.Peek());
            SelectedButton.Select();
        }

        /// <summary> Asks user to save if actual screen is in editing mode.</summary>
        private bool ShouldChangeScreen()
        {
            if (screenStack.Count > 0 && screenStack.Peek().IsEditing)
                switch (MessageBox.Show("Suas alterações não salvas serão descartadas.", "Sair sem salvar?", MessageBoxButtons.OKCancel))
                {
                    case DialogResult.OK:
                        return true;
                    default:
                        return false;
                }
            return true;
        }

        /// <summary> Presents an IScreen, preserving actual presented IScreen in navigation stack.</summary>
        public void PresentScreen(IScreen screen)
        {
            if (!ShouldChangeScreen())
                return;
            screenStack.Push(screen);
            ShowTopScreen();
        }

        ///<summary> Presents previous IScreen in navigation stack, discarding actual presented IScreen</summary>
        public void PopScreen()
        {
            if (!ShouldChangeScreen() || screenStack.Count <= 1)
                return;
            screenStack.Pop();
            ShowTopScreen();
        }

        /// <summary> Presents an IScreen, discarding actual presented IScreen.</summary>
        public void SwapLastWithScreen(IScreen screen)
        {
            if (!ShouldChangeScreen() || screenStack.Count == 0)
                return;
            screenStack.Pop();
            screenStack.Push(screen);
            ShowTopScreen();
        }
        #endregion

        #region MainMenu callbacks
        private void dashButton_Click(object sender, EventArgs e)
        {
            SelectedButton = dashButton;
            ReplaceAllWithScreen(new DashboardScreen());
        }

        private void coursesButton_Click(object sender, EventArgs e)
        {
            SelectedButton = coursesButton;
            ReplaceAllWithScreen(new CourseListScreen());
        }

        private void studentsButton_Click(object sender, EventArgs e)
        {
            SelectedButton = studentsButton;
            ReplaceAllWithScreen(new StudentListScreen());
        }

        private void portfoliosButton_Click(object sender, EventArgs e)
        {
            SelectedButton = portfoliosButton;
            ReplaceAllWithScreen(new PortfolioListScreen());
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SelectedButton = settingsButton;
            ReplaceAllWithScreen(new SettingsScreen());
        }
        #endregion
    }
}
