﻿using System;
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
        private List<Activity> ActivityList { get; set; }

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

        private void SetupBindings() {
            nameTextBox.DataBindings.Add("Text", WorkingCopyRule, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            yearNumericUpDown.DataBindings.Add("Value", WorkingCopyRule, "Year", true, DataSourceUpdateMode.OnPropertyChanged);
            courseTextBox.DataBindings.Add("Text", WorkingCopyRule, "Course.Name", true, DataSourceUpdateMode.Never);
            requiredHoursNumericUpDown.DataBindings.Add("Value", WorkingCopyRule, "RequiredHours", true, DataSourceUpdateMode.OnPropertyChanged);
            
            BindingSource bSource = new BindingSource();
            bSource.DataSource = ActivityList;
            activitiesDataGridView.DataSource = bSource;
        }
        #endregion

        #region Event handlers
        public void ScreenWillAppear()
        {
            //TODO: Update dataGridView (done below)
            //ActivityList = ActivityDAO.GetAllWithRule(WorkingCopyRule);
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance.PresentScreen(new ActivityDetScreen(false, (Activity)activitiesDataGridView.SelectedRows[0].DataBoundItem));
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance.PresentScreen(new ActivityDetScreen(true, new Activity(WorkingCopyRule)));
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Todas as atividades realizadas por alunos correspondentes a este item também serão removidas dos portifólios.\nNão será possível desfazer esta ação.", "Remover?", MessageBoxButtons.OKCancel))
            {
                case DialogResult.OK:
                    foreach (DataGridViewRow row in activitiesDataGridView.SelectedRows)
                    {
                        activitiesDataGridView.Rows.RemoveAt(row.Index);
                        //TODO: Delete selected (done below)
                        //ActivityDAO.Delete((Activity)row.DataBoundItem);
                    }
                    break;
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
                if (true)//UNDONE: Could save object: if (RuleDAO.TrySave(WorkingCopyRule))
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
