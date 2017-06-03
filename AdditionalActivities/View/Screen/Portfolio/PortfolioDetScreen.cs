using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdditionalActivities.View.Screen.Portfolio
{
    public partial class PortfolioDetScreen : UserControl, IScreen
    {
        private bool isEditing;

        public bool IsEditing
        {
            get
            {
                return isEditing;
            }
            private set
            {
                isEditing = value;
                editSaveButton.Text = IsEditing ? "Salvar" : "Editar";
                splitContainer1.Panel1Collapsed = IsEditing;
                //TODO: Change fields mode
            }
        }

        public PortfolioDetScreen()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public void ScreenWillApear()
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance.PopScreen();
        }

        private void editSaveButton_Click(object sender, EventArgs e)
        {
            if (IsEditing)
            {
                if (true)//UNDONE: Could save object
                    IsEditing = false;
            }
            else
                IsEditing = true;
        }
    }
}
