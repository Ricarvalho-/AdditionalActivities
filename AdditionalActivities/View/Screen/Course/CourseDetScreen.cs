using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain = AdditionalActivities.Model.Domain;

namespace AdditionalActivities.View.Screen.Course
{
    public partial class CourseDetScreen : UserControl, IScreen
    {
        #region Properties
        private bool ShouldPopOnCancel { get; set; }
        private bool isEditing;
        private Domain.Course course;
        private Domain.Course WorkingCopyCourse { get; set; }
        private List<Domain.Rule> RuleList { get; set; }

        private Domain.Course Course
        {
            get { return course; }
            set
            {
                course = value;
                WorkingCopyCourse = (Domain.Course)Course.Copy();
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
        public CourseDetScreen(bool startEditing, Domain.Course course)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            IsEditing = startEditing;
            ShouldPopOnCancel = startEditing;
            Course = course;
            SetupBindings();
        }

        private void SetupBindings()
        {
            nameTextBox.DataBindings.Add("Text", WorkingCopyCourse, "Name");
            minDurationNumericUpDown.DataBindings.Add("Value", WorkingCopyCourse, "MinDuration");
            maxDurationNumericUpDown.DataBindings.Add("Value", WorkingCopyCourse, "MaxDuration");

            BindingSource bSource = new BindingSource();
            bSource.DataSource = RuleList;
            rulesDataGridView.DataSource = bSource;
        }
        #endregion

        #region Event handlers
        public void ScreenWillAppear()
        {
            //TODO: Update dataGridView (done below)
            //RuleList = RuleDAO.GetAllWithCourse(WorkingCopyCourse);
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance.PresentScreen(new RuleDetScreen(false, (Domain.Rule)rulesDataGridView.SelectedRows[0].DataBoundItem));
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance.PresentScreen(new RuleDetScreen(true, new Domain.Rule(WorkingCopyCourse)));
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Todas as atividades e alunos relacionados também serão removidos.\nNão será possível desfazer esta ação.", "Remover?", MessageBoxButtons.OKCancel))
            {
                case DialogResult.OK:
                    foreach (DataGridViewRow row in rulesDataGridView.SelectedRows)
                    {
                        rulesDataGridView.Rows.RemoveAt(row.Index);
                        //TODO: Delete selected (done below)
                        //RuleDAO.Delete((Domain.Rule)row.DataBoundItem);
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
                Course = Course;
            }
            else
                MainForm.Instance.PopScreen();
        }

        private void editSaveButton_Click(object sender, EventArgs e)
        {
            if (IsEditing)
            {
                if (true)//UNDONE: Could save object: if (CourseDAO.TrySave(WorkingCopyCourse))
                {
                    IsEditing = false;
                    Course = WorkingCopyCourse;
                }
                else
                    MessageBox.Show("Falha ao salvar curso.", "Erro", MessageBoxButtons.OK);//UNDONE: Show validation error
            }
            else
                IsEditing = true;
        }

        private void rulesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            openButton.Enabled = rulesDataGridView.SelectedRows.Count == 1;
            removeButton.Enabled = rulesDataGridView.SelectedRows.Count > 0;
        }
        #endregion
    }
}
