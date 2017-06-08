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
    public partial class CourseListScreen : UserControl, IScreen
    {
        public bool IsEditing { get { return false; } }

        public CourseListScreen()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance.PresentScreen(new CourseDetScreen(false));//UNDONE: Pass object
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance.PresentScreen(new CourseDetScreen(true));
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Todas as regras, atividades e alunos relacionados também serão removidos.\nNão será possível desfazer esta ação.", "Remover?", MessageBoxButtons.OKCancel))
            {
                case DialogResult.OK:
                    //TODO: Remove object
                default:
                    break;
            }
        }

        private void coursesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            openButton.Enabled = coursesDataGridView.SelectedRows.Count == 1;
            removeButton.Enabled = coursesDataGridView.SelectedRows.Count > 0;
        }
    }
}
