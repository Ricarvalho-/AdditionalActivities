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

namespace AdditionalActivities.View.Screen.Portfolio
{
    public partial class PortfolioDetScreen : UserControl, IScreen
    {
        private bool ShouldPopOnCancel { get; set; }
        private bool isEditing, isEditingActivity;

        #region Init
        public PortfolioDetScreen(bool startEditing, ActivityPortfolio portfolio)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            IsEditing = startEditing;
            ShouldPopOnCancel = startEditing;
            //semesterComboBox.SelectedIndex = 0;

            Portfolio = portfolio;
            ActItem = new ActivityItem(WorkingCopyPortfolio);

            SetupPortfolioBindings();
            SetupActivityBindings();
        }

        private void SetupPortfolioBindings()
        {
            semesterComboBox.Items.AddRange(new object[] { 1, 2 });

            studentTextBox.DataBindings.Add("Text", WorkingCopyPortfolio, "Student.Name");
            yearNumericUpDown.DataBindings.Add("Value", WorkingCopyPortfolio, "SchoolPeriod.Year");
            semesterComboBox.DataBindings.Add("SelectedItem", WorkingCopyPortfolio, "SchoolPeriod.Semester");
            deliveryDateTimePicker.DataBindings.Add("Value", WorkingCopyPortfolio, "DeliveryDate");
            evaluationDateTimePicker.DataBindings.Add("Value", WorkingCopyPortfolio, "EvaluationDate");
            evaluatorComboBox.DataBindings.Add("SelectedItem", WorkingCopyPortfolio, "Evaluator");

            evaluationDateTimePicker.Checked = WorkingCopyPortfolio.EvaluationDate != WorkingCopyPortfolio.DeliveryDate;

            BindingSource bSource = new BindingSource();
            bSource.DataSource = ActivityList;
            activitiesDataGridView.DataSource = bSource;
        }

        private void SetupActivityBindings() {
            activityNameTextBox.DataBindings.Add("Text", WorkingCopyActItem, "Name");
            activityCertificateTextBox.DataBindings.Add("Text", WorkingCopyActItem, "Certificate");
            activityComboBox.DataBindings.Add("SelectedItem", WorkingCopyActItem, "Activity");
            activityScheduledHoursNumericUpDown.DataBindings.Add("Value", WorkingCopyActItem, "ScheduledHours");
            activityDeferredHoursTextBox.DataBindings.Add("Text", WorkingCopyActItem, "DeferredHours");
            activityApprovationComboBox.DataBindings.Add("SelectedItem", WorkingCopyActItem, "Approvation");
            activityObservationTextBox.DataBindings.Add("Text", WorkingCopyActItem, "Observation");

            activityApprovationComboBox.DataSource = Enum.GetValues(typeof(ApprovationState));
        }
        #endregion

        #region Portfolio
        #region Properties
        private ActivityPortfolio portfolio;
        private ActivityPortfolio WorkingCopyPortfolio { get; set; }
        private List<ActivityItem> ActivityList { get; set; }

        private ActivityPortfolio Portfolio
        {
            get { return portfolio; }
            set
            {
                portfolio = value;
                WorkingCopyPortfolio = (ActivityPortfolio)Portfolio.Copy();
            }
        }

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
                tableLayoutPanel1.Enabled = isEditing;
                if (!isEditing)
                    ShouldPopOnCancel = false;
            }
        }
        #endregion

        #region Event handlers
        public void ScreenWillAppear() { }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (isEditing && !ShouldPopOnCancel)
            {
                IsEditing = false;
                Portfolio = Portfolio;
            }
            else
                MainForm.Instance.PopScreen();
        }

        private void editSaveButton_Click(object sender, EventArgs e)
        {
            if (IsEditing)
            {
                if (true)//UNDONE: Could save object: if (ActivityPortfolioDAO.TrySave(WorkingCopyPortfolio))
                {
                    IsEditing = false;
                    Portfolio = WorkingCopyPortfolio;
                }
                else
                    MessageBox.Show("Falha ao salvar portifólio.", "Erro", MessageBoxButtons.OK);//UNDONE: Show validation error
            }
            else
                IsEditing = true;
        }

        private void activitiesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            splitContainer2.Panel2Collapsed = activitiesDataGridView.SelectedRows.Count != 1;
            removeButton.Enabled = activitiesDataGridView.SelectedRows.Count > 0;
            if (activitiesDataGridView.SelectedRows.Count == 1)
                ActItem = (ActivityItem)activitiesDataGridView.SelectedRows[0].DataBoundItem;
            else
                ActItem = new ActivityItem(WorkingCopyPortfolio);
        }
        #endregion
        #endregion

        #region Activity
        #region Properties
        private ActivityItem actItem;
        private ActivityItem WorkingCopyActItem { get; set; }

        private ActivityItem ActItem
        {
            get { return actItem; }
            set
            {
                actItem = value;
                WorkingCopyActItem = (ActivityItem)ActItem.Copy();
            }
        }

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
                tableLayoutPanel2.Enabled = IsEditingActivity;
            }
        }
        #endregion

        #region Event handlers
        private void addButton_Click(object sender, EventArgs e)
        {
            IsEditingActivity = true;
            ActItem = new ActivityItem(WorkingCopyPortfolio);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Não será possível desfazer esta ação.", "Remover?", MessageBoxButtons.OKCancel))
            {
                case DialogResult.OK:
                    foreach (DataGridViewRow row in activitiesDataGridView.SelectedRows)
                    {
                        activitiesDataGridView.Rows.RemoveAt(row.Index);
                        //TODO: Delete selected (done below)
                        //ActivityItemDAO.Delete((ActivityItem)row.DataBoundItem);
                    }
                    break;
                default:
                    break;
            }
        }

        private void activityCancelButton_Click(object sender, EventArgs e)
        {
            IsEditingActivity = false;
            splitContainer2.Panel2Collapsed = activitiesDataGridView.SelectedCells.Count != 1;
            ActItem = ActItem;
        }

        private void activityEditSaveButton_Click(object sender, EventArgs e)
        {
            if (IsEditingActivity)
            {
                if (true)//UNDONE: Could save object: if (RuleDAO.TrySave(WorkingCopyRule))
                {
                    IsEditingActivity = false;
                    ActItem = WorkingCopyActItem;
                }
                else
                    MessageBox.Show("Falha ao salvar atividade.", "Erro", MessageBoxButtons.OK);//UNDONE: Show validation error
            }
            else
                IsEditingActivity = true;
        }
        #endregion
        #endregion
    }
}
