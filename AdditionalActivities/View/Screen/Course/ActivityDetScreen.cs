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
        #region Properties
        private bool ShouldPopOnCancel { get; set; }
        private bool isEditing;
        private Activity activity;
        private Activity WorkingCopyActivity { get; set; }

        private Activity Activity
        {
            get { return activity; }
            set
            {
                activity = value;
                WorkingCopyActivity = (Activity)Activity.Copy();
                stepCheckBox.Checked = Activity.HourStep != 1;
            }
        }

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
                tableLayoutPanel1.Enabled = IsEditing;
                if (!IsEditing)
                    ShouldPopOnCancel = false;
            }
        }
        #endregion

        #region Init
        public ActivityDetScreen(bool startEditing, Activity activity)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            IsEditing = startEditing;
            ShouldPopOnCancel = startEditing;
            Activity = activity;
            SetupBindings();
        }

        private void SetupBindings()
        {
            nameTextBox.DataBindings.Add("Text", WorkingCopyActivity, "Name");
            courseTextBox.DataBindings.Add("Text", WorkingCopyActivity, "Rule.Course.Name");
            ruleTextBox.DataBindings.Add("Text", WorkingCopyActivity, "Rule.Name");
            categoryComboBox.DataBindings.Add("SelectedValue", WorkingCopyActivity, "Category");
            minHoursNumericUpDown.DataBindings.Add("Value", WorkingCopyActivity, "MinHours");
            maxHoursNumericUpDown.DataBindings.Add("Value", WorkingCopyActivity, "MaxHours");
            stepHoursNumericUpDown.DataBindings.Add("Value", WorkingCopyActivity, "HourStep");
            descriptionTextBox.DataBindings.Add("Text", WorkingCopyActivity, "Description");
            stepHoursNumericUpDown.DataBindings.Add("Enabled", stepCheckBox, "Checked");
        }
        #endregion

        #region Event handlers
        public void ScreenWillAppear() { }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (isEditing && !ShouldPopOnCancel)
            {
                IsEditing = false;
                Activity = Activity;//Set working copy to a new copy
            }
            else
                MainForm.Instance.PopScreen();
        }

        private void editSaveButton_Click(object sender, EventArgs e)
        {
            if (IsEditing)
            {
                if (true)//UNDONE: Could save working copy: if (ActivityDAO.TrySave(WorkingCopyActivity))
                {
                    IsEditing = false;
                    Activity = WorkingCopyActivity;
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
        #endregion
    }
}
