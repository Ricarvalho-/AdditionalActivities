using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdditionalActivities.View.Screen.Student;

namespace AdditionalActivities.View.Screen.Portfolio
{
    public partial class PortfolioListScreen : UserControl, IScreen
    {
        public bool IsEditing { get { return false; } }

        public PortfolioListScreen()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public void ScreenWillAppear()
        {

        }

        private void openButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance.PresentScreen(new PortfolioDetScreen(false));//UNDONE: Pass object
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance.PresentScreen(new PortfolioDetScreen(true));
        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }

        private void newStudentButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance.PresentScreen(new StudentDetScreen(true, true));//UNDONE: Pass object
        }
    }
}
