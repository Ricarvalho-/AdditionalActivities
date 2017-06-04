using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdditionalActivities.View.Screen.Portfolio;

namespace AdditionalActivities.View.Screen.Student
{
    public partial class StudentDetScreen : UserControl, IScreen
    {
        private bool ShouldSwap { get; set; }
        private bool isEditing;

        public bool IsEditing {
            get
            {
                return isEditing;
            }
            private set
            {
                isEditing = value;
                editSaveButton.Text = IsEditing ? "Salvar" : "Editar";
                backButton.Text = isEditing ? "Cancelar" : "Voltar";

                nameTextBox.ReadOnly = !IsEditing;
                registerNumberTextBox.ReadOnly = !IsEditing;
                courseComboBox.Enabled = IsEditing;
                ruleComboBox.Enabled = IsEditing;
                registerStateComboBox.Enabled = IsEditing;
            }
        }

        public StudentDetScreen()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public StudentDetScreen(bool startEditing)//UNDONE: receive Student also
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            ShouldSwap = startEditing;
            IsEditing = startEditing;
        }

        public void ScreenWillAppear()
        {

        }

        private void editSaveButton_Click(object sender, EventArgs e)
        {
            if (IsEditing)
            {
                if (true)//UNDONE: Could save object
                {
                    IsEditing = false;
                    if (ShouldSwap)
                        MainForm.Instance.SwapLastWithScreen(new PortfolioDetScreen());//UNDONE: Pass object
                }
            }
            else
                IsEditing = true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                IsEditing = false;
                //TODO: Discard changes
            }
            else
                MainForm.Instance.PopScreen();
        }
    }
}
