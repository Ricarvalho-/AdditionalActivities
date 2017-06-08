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
        public bool ActivityHaveHourStep { get { return Activity.HourStep != 1; } }
        private bool isEditing;
        private Activity Activity { get; set; }
        private Activity WorkingCopyActivity { get; set; }

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
                tableLayoutPanel1.Enabled = IsEditing;
            }
        }

        public ActivityDetScreen(bool startEditing, Activity activity)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            IsEditing = startEditing;
            ShouldPopOnCancel = startEditing;
            Activity = activity;
            SetupBindings();
        }

        public void SetupBindings()
        {
            stepHoursNumericUpDown.DataBindings.Add(new Binding("Enabled", stepCheckBox, "Checked", true));
            nameTextBox.DataBindings.Add("Text", Activity, "Name");
            courseTextBox.DataBindings.Add("Text", Activity, "Rule.Course.Name");
            ruleTextBox.DataBindings.Add("Text", Activity, "Rule.Name");
            categoryComboBox.DataBindings.Add("SelectedValue", Activity, "Category");
            minHoursNumericUpDown.DataBindings.Add("Value", Activity, "MinHours");
            maxHoursNumericUpDown.DataBindings.Add("Value", Activity, "MaxHours");
            stepCheckBox.DataBindings.Add("Checked", this, "ActivityHaveHourStep");
            stepHoursNumericUpDown.DataBindings.Add("Value", "Activity", "HourStep");
            descriptionTextBox.DataBindings.Add("Text", Activity, "Description");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (isEditing && !ShouldPopOnCancel)
            {
                IsEditing = false;
                //TODO: Set working copy obj to a copy of original object
            }
            else
                MainForm.Instance.PopScreen();
        }

        private void editSaveButton_Click(object sender, EventArgs e)
        {
            if (IsEditing)
            {
                if (true)//UNDONE: Could save object
                {
                    IsEditing = false;
                    //TODO: set original object to a copy of working copy obj
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
        }
    }
}
