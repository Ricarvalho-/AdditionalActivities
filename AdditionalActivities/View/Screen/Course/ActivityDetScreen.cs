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
            stepCheckBox.Checked = activity.HourStep != 1;
            SetupBindings();
        }

        private void SetupBindings()
        {
            nameTextBox.DataBindings.Add("Text", WorkingCopyActivity, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            courseTextBox.DataBindings.Add("Text", WorkingCopyActivity, "Rule.Course.Name", true, DataSourceUpdateMode.Never);
            ruleTextBox.DataBindings.Add("Text", WorkingCopyActivity, "Rule.Name", true, DataSourceUpdateMode.Never);
            categoryComboBox.DataBindings.Add("SelectedValue", WorkingCopyActivity, "Category.Name", true, DataSourceUpdateMode.OnPropertyChanged);
            minHoursNumericUpDown.DataBindings.Add("Value", WorkingCopyActivity, "MinHours", true, DataSourceUpdateMode.OnPropertyChanged);
            maxHoursNumericUpDown.DataBindings.Add("Value", WorkingCopyActivity, "MaxHours", true, DataSourceUpdateMode.OnPropertyChanged);
            stepHoursNumericUpDown.DataBindings.Add("Value", WorkingCopyActivity, "HourStep", true, DataSourceUpdateMode.OnPropertyChanged);
            descriptionTextBox.DataBindings.Add("Text", WorkingCopyActivity, "Description", true, DataSourceUpdateMode.OnPropertyChanged);
            stepHoursNumericUpDown.DataBindings.Add("Enabled", stepCheckBox, "Checked", true, DataSourceUpdateMode.Never);
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
            if (!stepCheckBox.Checked)
            {
                stepHoursNumericUpDown.Value = 1;
            }
        }
        #endregion
    }
}
