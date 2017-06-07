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
        private bool ShouldPopOnCancel { get; set; }
        private bool isEditing, isEditingActivity;

        public PortfolioDetScreen(bool startEditing)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            IsEditing = startEditing;
            ShouldPopOnCancel = startEditing;
        }

        public void ScreenWillAppear()
        {

        }

        #region Portfolio
        public bool IsEditing
        {
            get
            {
                return isEditing || IsEditingActivity;
            }
            private set
            {
                isEditing = value;
                editSaveButton.Text = isEditing ? "Salvar" : "Editar";
                backButton.Text = isEditing ? "Cancelar" : "Voltar";
                splitContainer1.Panel1Collapsed = isEditing;
                splitContainer2.Panel2Collapsed = isEditing || activitiesDataGridView.SelectedCells.Count != 1;
                if (!isEditing)
                    ShouldPopOnCancel = false;

                yearNumericUpDown.Enabled = IsEditing;
                semesterComboBox.Enabled = IsEditing;
                deliveryDateTimePicker.Enabled = IsEditing;
                evaluationDateTimePicker.Enabled = IsEditing;
                evaluatorComboBox.Enabled = IsEditing;
            }
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
                if (true)//UNDONE: Could save object
                    IsEditing = false;
            }
            else
                IsEditing = true;
        }
        #endregion

        #region Activity
        private bool IsEditingActivity
        {
            get
            {
                return isEditingActivity;
            }
            set
            {
                isEditingActivity = value;
                activityEditSaveButton.Text = IsEditingActivity ? "Salvar" : "Editar";
                activityCancelButton.Visible = IsEditingActivity;
                splitContainer1.Panel1Collapsed = IsEditingActivity;
                splitContainer2.Panel1Collapsed = IsEditingActivity;

                activityNameTextBox.ReadOnly = !IsEditingActivity;
                activityCertificateTextBox.ReadOnly = !IsEditingActivity;
                activityComboBox.Enabled = IsEditingActivity;
                activityScheduledHoursNumericUpDown.Enabled = IsEditingActivity;
                activityApprovationComboBox.Enabled = IsEditingActivity;
                activityObservationTextBox.ReadOnly = !IsEditingActivity;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            IsEditingActivity = true;
            //TODO: Clear all activity fields
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Não será possível desfazer esta ação.", "Remover?", MessageBoxButtons.OKCancel))
            {
                case DialogResult.OK:
                    //TODO: Remove object
                default:
                    break;
            }
        }

        private void activityCancelButton_Click(object sender, EventArgs e)
        {
            IsEditingActivity = false;
            splitContainer2.Panel2Collapsed = activitiesDataGridView.SelectedCells.Count != 1;
            //TODO: Discard changes
        }

        private void activityEditSaveButton_Click(object sender, EventArgs e)
        {
            if (IsEditingActivity)
            {
                if (true)//UNDONE: Could save object
                    IsEditingActivity = false;
            }
            else
                IsEditingActivity = true;
        }

        private void activitiesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            splitContainer2.Panel2Collapsed = activitiesDataGridView.SelectedRows.Count != 1;
            removeButton.Enabled = activitiesDataGridView.SelectedRows.Count > 0;
        }
        #endregion
    }
}
