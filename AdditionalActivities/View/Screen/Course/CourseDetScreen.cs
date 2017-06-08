using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdditionalActivities.View.Screen.Course
{
    public partial class CourseDetScreen : UserControl, IScreen
    {
        private bool ShouldPopOnCancel { get; set; }
        private bool isEditing;

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
                if (!IsEditing)
                    ShouldPopOnCancel = false;
                tableLayoutPanel1.Enabled = IsEditing;
            }
        }

        public CourseDetScreen(bool startEditing)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            IsEditing = startEditing;
            ShouldPopOnCancel = startEditing;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance.PresentScreen(new RuleDetScreen(false));//UNDONE: Pass object
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance.PresentScreen(new RuleDetScreen(true));
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Todas as atividades e alunos relacionados também serão removidos.\nNão será possível desfazer esta ação.", "Remover?", MessageBoxButtons.OKCancel))
            {
                case DialogResult.OK:
                    //TODO: Remove object
                default:
                    break;
            }
        }

        public void ScreenWillAppear()
        {

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

        private void rulesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            openButton.Enabled = rulesDataGridView.SelectedRows.Count == 1;
            removeButton.Enabled = rulesDataGridView.SelectedRows.Count > 0;
        }
    }
}
