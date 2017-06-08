using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdditionalActivities.View.Screen.Student
{
    public partial class StudentListScreen : UserControl, IScreen
    {
        public bool IsEditing { get { return false; } }

        public StudentListScreen()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance.PresentScreen(new StudentDetScreen(false, false));//UNDONE: Pass object
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance.PresentScreen(new StudentDetScreen(true, false));
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Todos os portifólios e atividades relacionados também serão removidos.\nNão será possível desfazer esta ação.", "Remover?", MessageBoxButtons.OKCancel))
            {
                case DialogResult.OK:
                    //TODO: Remove object
                default:
                    break;
            }
        }

        private void studentsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            openButton.Enabled = studentsDataGridView.SelectedRows.Count == 1;
            removeButton.Enabled = studentsDataGridView.SelectedRows.Count > 0;
        }
    }
}
