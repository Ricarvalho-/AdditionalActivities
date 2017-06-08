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
        #region Properties
        private bool ShouldPopOnCancel { get; set; }
        private bool isEditing, isEditingActivity;
        #endregion

        #region Init
        public PortfolioDetScreen(bool startEditing, ActivityPortfolio portfolio)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            IsEditing = startEditing;
            ShouldPopOnCancel = startEditing;
            Portfolio = portfolio;
            activityApprovationComboBox.DataSource = Enum.GetValues(typeof(ApprovationState));
            semesterComboBox.SelectedIndex = 0;
            SetupBindings();
        }

        private void SetupBindings() { }
        #endregion

        #region Portfolio
        #region Properties
        private ActivityPortfolio portfolio;
        private ActivityPortfolio WorkingCopyPortfolio { get; set; }

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
                if (true)//UNDONE: Could save object
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
                //WorkingCopyActItem = (ActivityItem)ActItem.Copy();//HACK: Prevent nullPointerException
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
            //TODO: Clear all activity fields
            ActItem = null;
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
            ActItem = ActItem;
        }

        private void activityEditSaveButton_Click(object sender, EventArgs e)
        {
            if (IsEditingActivity)
            {
                if (true)//UNDONE: Could save object
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

        private void activitiesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            splitContainer2.Panel2Collapsed = activitiesDataGridView.SelectedRows.Count != 1;
            removeButton.Enabled = activitiesDataGridView.SelectedRows.Count > 0;
            if (activitiesDataGridView.SelectedRows.Count == 1)
                ;//TODO: Item = ItemDTO.GetItem(activitiesDataGridView.SelectedRows[0].Cells[0]);
            else
                ActItem = null;
        }
        #endregion
        #endregion
    }
}
