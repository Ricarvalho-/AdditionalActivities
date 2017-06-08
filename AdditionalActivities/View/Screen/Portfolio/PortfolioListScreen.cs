using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdditionalActivities.View.Screen.Student;
using Domain = AdditionalActivities.Model.Domain;

namespace AdditionalActivities.View.Screen.Portfolio
{
    public partial class PortfolioListScreen : UserControl, IScreen
    {
        public bool IsEditing { get { return false; } }

        public PortfolioListScreen()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            studentDetFlowLayoutPanel.Controls.Clear();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance.PresentScreen(new PortfolioDetScreen(false, new Domain.ActivityPortfolio()));//UNDONE: Pass object
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance.PresentScreen(new PortfolioDetScreen(true, new Domain.ActivityPortfolio()));
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Todos os registros de atividades relacionadas a este portifólio também serão removidos.\nNão será possível desfazer esta ação.", "Remover?", MessageBoxButtons.OKCancel))
            {
                case DialogResult.OK:
                //TODO: Remove object
                default:
                    break;
            }
        }

        private void newStudentButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance.PresentScreen(new StudentDetScreen(true, true, new Domain.Student()));//UNDONE: Pass object
        }

        private void portfoliosDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            openButton.Enabled = portfoliosDataGridView.SelectedRows.Count == 1;
            removeButton.Enabled = portfoliosDataGridView.SelectedRows.Count > 0;
        }

        private void studentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            studentDetFlowLayoutPanel.Controls.Clear();
            studentDetFlowLayoutPanel.Controls.Add(nameLabel);
            studentDetFlowLayoutPanel.Controls.Add(registerNumberLabel);
            studentDetFlowLayoutPanel.Controls.Add(ruleLabel);
            studentDetFlowLayoutPanel.Controls.Add(registerStateLabel);

            Domain.Student student = (Domain.Student)studentComboBox.SelectedItem;
            nameLabel.Text = "Nome: " + student.Name;
            registerNumberLabel.Text = "Prontuário: " + student.RegistrationNumber;
            ruleLabel.Text = "Regra: " + student.Rule.Name;
            registerStateLabel.Text = "Estado da matrícula: " + Enum.GetName(typeof(Domain.RegistrationState), student.RegistrationState);
        }

        private void studentComboBox_TextUpdate(object sender, EventArgs e)
        {
            studentDetFlowLayoutPanel.Controls.Clear();
        }
    }
}
