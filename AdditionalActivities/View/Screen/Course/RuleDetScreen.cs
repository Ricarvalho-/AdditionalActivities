using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdditionalActivities.Model.Domain;

namespace AdditionalActivities.View.Screen.Course
{
    public partial class RuleDetScreen : UserControl, IScreen
    {
        #region Properties
        private bool ShouldPopOnCancel { get; set; }
        private bool isEditing;
        private Rule rule;
        private Rule WorkingCopyRule { get; set; }

        private Rule Rule
        {
            get { return rule; }
            set
            {
                rule = value;
                WorkingCopyRule = (Rule)Rule.Copy();
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
                backButton.Text = isEditing ? "Cancelar" : "Voltar";
                splitContainer1.Panel1Collapsed = IsEditing;
                tableLayoutPanel1.Enabled = IsEditing;
                if (!IsEditing)
                    ShouldPopOnCancel = false;
            }
        }
        #endregion

        #region Init
        public RuleDetScreen(bool startEditing, Rule rule)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            IsEditing = startEditing;
            ShouldPopOnCancel = startEditing;
            Rule = rule;
            SetupBindings();
        }

        private void SetupBindings() { }
        #endregion

        #region Event handlers
        private void openButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance.PresentScreen(new ActivityDetScreen(false, new Activity()));//UNDONE: Pass selected object
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance.PresentScreen(new ActivityDetScreen(true, new Activity()));
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Todas as atividades realizadas por alunos correspondentes a este item também serão removidas dos portifólios.\nNão será possível desfazer esta ação.", "Remover?", MessageBoxButtons.OKCancel))
            {
                case DialogResult.OK:
                    //TODO: Remove object
                default:
                    break;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (isEditing && !ShouldPopOnCancel)
            {
                IsEditing = false;
                Rule = Rule;
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
                    Rule = WorkingCopyRule;
                }
                else
                    MessageBox.Show("Falha ao salvar regra.", "Erro", MessageBoxButtons.OK);//UNDONE: Show validation error
            }
            else
                IsEditing = true;
        }

        private void activitiesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            openButton.Enabled = activitiesDataGridView.SelectedRows.Count == 1;
            removeButton.Enabled = activitiesDataGridView.SelectedRows.Count > 0;
        }
        #endregion
    }
}
