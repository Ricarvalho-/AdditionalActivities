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
    public partial class CourseListScreen : UserControl, IScreen
    {
        public bool IsEditing { get { return false; } }
        private List<Domain.Course> CourseList { get; set; }

        public CourseListScreen()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;

            BindingSource bSource = new BindingSource();
            bSource.DataSource = CourseList;
            coursesDataGridView.DataSource = bSource;
        }

        #region Event handlers
        public void ScreenWillAppear()
        {
            //TODO: Update dataGridView (done below)
            //CourseList = CourseDAO.GetAll();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance.PresentScreen(new CourseDetScreen(false, (Domain.Course)coursesDataGridView.SelectedRows[0].DataBoundItem));
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance.PresentScreen(new CourseDetScreen(true, new Domain.Course()));
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Todas as regras, atividades e alunos relacionados também serão removidos.\nNão será possível desfazer esta ação.", "Remover?", MessageBoxButtons.OKCancel))
            {
                case DialogResult.OK:
                    foreach (DataGridViewRow row in coursesDataGridView.SelectedRows)
                    {
                        coursesDataGridView.Rows.RemoveAt(row.Index);
                        //TODO: Delete selected (done below)
                        //CourseDAO.Delete((Domain.Course)row.DataBoundItem);
                    }
                    break;
                default:
                    break;
            }
        }

        private void coursesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            openButton.Enabled = coursesDataGridView.SelectedRows.Count == 1;
            removeButton.Enabled = coursesDataGridView.SelectedRows.Count > 0;
        }
        #endregion
    }
}
