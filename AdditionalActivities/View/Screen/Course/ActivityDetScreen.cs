using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdditionalActivities.View.Screen.Course
{
    public partial class ActivityDetScreen : UserControl, IScreen
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
                backButton.Text = isEditing ? "Cancelar" : "Voltar";
                //TODO: Change fields mode
                nameTextBox.ReadOnly = !IsEditing;
                categoryComboBox.Enabled = IsEditing;
                minHoursNumericUpDown.Enabled = IsEditing;
                maxHoursNumericUpDown.Enabled = IsEditing;
                stepCheckBox.Enabled = IsEditing;
                stepHoursNumericUpDown.Enabled = stepCheckBox.Checked && IsEditing;
                descriptionTextBox.ReadOnly = !IsEditing;
            }
        }

        public ActivityDetScreen()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public void ScreenWillAppear()
        {

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

        private void stepCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            stepHoursNumericUpDown.Value = 1;
            stepHoursNumericUpDown.Enabled = stepCheckBox.Checked && IsEditing;
        }
    }
}
