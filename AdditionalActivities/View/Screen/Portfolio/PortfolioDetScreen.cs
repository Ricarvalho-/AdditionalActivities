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
            //evaluatorComboBox.DataSource = EvaluatorDAO.GetAll();//List<string>

            studentTextBox.DataBindings.Add("Text", WorkingCopyPortfolio, "Student.Name", true, DataSourceUpdateMode.Never);
            yearNumericUpDown.DataBindings.Add("Value", WorkingCopyPortfolio, "Year", true, DataSourceUpdateMode.OnPropertyChanged);
            semesterComboBox.DataBindings.Add("SelectedItem", WorkingCopyPortfolio, "Semester", true, DataSourceUpdateMode.OnPropertyChanged);
            deliveryDateTimePicker.DataBindings.Add("Value", WorkingCopyPortfolio, "DeliveryDate", true, DataSourceUpdateMode.OnPropertyChanged);
            evaluationDateTimePicker.DataBindings.Add("Value", WorkingCopyPortfolio, "EvaluationDate", true, DataSourceUpdateMode.OnPropertyChanged);
            evaluatorComboBox.DataBindings.Add("Text", WorkingCopyPortfolio, "Evaluator", true, DataSourceUpdateMode.OnPropertyChanged);
            evaluationDateTimePicker.DataBindings.Add("Checked", WorkingCopyPortfolio, "IsEvaluated", true, DataSourceUpdateMode.OnPropertyChanged);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = ActivityList;
            activitiesDataGridView.DataSource = bSource;
        }

        private void SetupActivityBindings()
        {
            activityApprovationComboBox.DataSource = Enum.GetValues(typeof(ApprovationState));
            //activityComboBox.DataSource = ActivityDAO.GetActivitiesByRule(WorkingCopyPortfolio.Student.Rule);

            activityNameTextBox.DataBindings.Add("Text", WorkingCopyActItem, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            activityCertificateTextBox.DataBindings.Add("Text", WorkingCopyActItem, "Certificate", true, DataSourceUpdateMode.OnPropertyChanged);
            activityComboBox.DataBindings.Add("SelectedItem", WorkingCopyActItem, "Activity", true, DataSourceUpdateMode.OnPropertyChanged);
            activityScheduledHoursNumericUpDown.DataBindings.Add("Value", WorkingCopyActItem, "ScheduledHours", true, DataSourceUpdateMode.OnPropertyChanged);
            activityDeferredHoursTextBox.DataBindings.Add("Text", WorkingCopyActItem, "DeferredHours", true, DataSourceUpdateMode.Never);
            activityApprovationComboBox.DataBindings.Add("SelectedItem", WorkingCopyActItem, "Approvation", true, DataSourceUpdateMode.OnPropertyChanged);
            activityObservationTextBox.DataBindings.Add("Text", WorkingCopyActItem, "Observation", true, DataSourceUpdateMode.OnPropertyChanged);
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
