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

namespace AdditionalActivities.View.Screen.Student
{
    public partial class StudentListScreen : UserControl, IScreen
    {
        public bool IsEditing { get { return false; } }
        private List<Domain.Student> StudentList { get; set; }

        public StudentListScreen()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;

            BindingSource bSource = new BindingSource();
            bSource.DataSource = StudentList;
            studentsDataGridView.DataSource = bSource;
        }

        #region Event handlers
        public void ScreenWillAppear()
        {
            //TODO: Update dataGridView (done below)
            //StudentList = StudentDAO.GetAll();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance.PresentScreen(new StudentDetScreen(false, false, (Domain.Student)studentsDataGridView.SelectedRows[0].DataBoundItem));
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance.PresentScreen(new StudentDetScreen(true, false, new Domain.Student()));
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Todos os portifólios e atividades relacionados também serão removidos.\nNão será possível desfazer esta ação.", "Remover?", MessageBoxButtons.OKCancel))
            {
                case DialogResult.OK:
                    foreach (DataGridViewRow row in studentsDataGridView.SelectedRows)
                    {
                        studentsDataGridView.Rows.RemoveAt(row.Index);
                        //TODO: Delete selected (done below)
                        //StudentDAO.Delete((Student)row.DataBoundItem);
                    }
                    break;
                default:
                    break;
            }
        }

        private void studentsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            openButton.Enabled = studentsDataGridView.SelectedRows.Count == 1;
            removeButton.Enabled = studentsDataGridView.SelectedRows.Count > 0;
        }
        #endregion
    }
}
