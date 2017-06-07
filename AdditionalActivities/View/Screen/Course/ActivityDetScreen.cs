using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdditionalActivities.Model.Domain;

namespace AdditionalActivities.View.Screen.Course
{
    public partial class ActivityDetScreen : UserControl, IScreen
    {
        private bool ShouldPopOnCancel { get; set; }
        private bool isEditing;
        private Activity Activity { get; set; }

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
                backButton.Text = IsEditing ? "Cancelar" : "Voltar";
                if (!IsEditing)
                    ShouldPopOnCancel = false;

                nameTextBox.ReadOnly = !IsEditing;
                categoryComboBox.Enabled = IsEditing;
                minHoursNumericUpDown.Enabled = IsEditing;
                maxHoursNumericUpDown.Enabled = IsEditing;
                stepCheckBox.Enabled = IsEditing;
                stepHoursNumericUpDown.Enabled = stepCheckBox.Checked && IsEditing;
                descriptionTextBox.ReadOnly = !IsEditing;
            }
        }

        public ActivityDetScreen(bool startEditing, Activity activity)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            IsEditing = startEditing;
            ShouldPopOnCancel = startEditing;
            Activity = activity;
        }

        public void ScreenWillAppear()
        {
            nameTextBox.Text = Activity.Name;
            courseTextBox.Text = Activity.Rule.Course.Name;
            ruleTextBox.Text = Activity.Rule.Name;
            categoryComboBox.SelectedValue = Activity.Category;
            minHoursNumericUpDown.Value = Activity.MinHours;
            maxHoursNumericUpDown.Value = Activity.MaxHours;
            stepCheckBox.Checked = Activity.HourStep != 1;
            stepHoursNumericUpDown.Value = Activity.HourStep;
            descriptionTextBox.Text = Activity.Description;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (isEditing && !ShouldPopOnCancel)
            {
                IsEditing = false;
                ScreenWillAppear();//Resets fields and discard changes
            }
            else
                MainForm.Instance.PopScreen();
        }

        private void editSaveButton_Click(object sender, EventArgs e)
        {
            if (IsEditing)
            {
                //TODO: create temporary object with fields values to pass on trySave
                if (true)//UNDONE: Could save object
                {
                    IsEditing = false;
                    Activity.Name = nameTextBox.Text;
                    Activity.Category = (ActivityCategory)categoryComboBox.SelectedValue;
                    Activity.MinHours = (int)minHoursNumericUpDown.Value;
                    Activity.MaxHours = (int)maxHoursNumericUpDown.Value;
                    Activity.HourStep = (int)stepHoursNumericUpDown.Value;
                    Activity.Description = descriptionTextBox.Text;
                }
                else
                    MessageBox.Show("Falha ao salvar atividade.", "Erro", MessageBoxButtons.OK);//UNDONE: Show validation error
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
