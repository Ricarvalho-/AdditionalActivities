using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdditionalActivities.View.Screen.Portfolio;
using AdditionalActivities.Model.Domain;

namespace AdditionalActivities.View.Screen.Student
{
    public partial class StudentDetScreen : UserControl, IScreen
    {
        private bool ShouldSwapOnSave { get; set; }
        private bool ShouldPopOnCancel { get; set; }
        private bool isEditing;

        public bool IsEditing {
            get
            {
                return isEditing;
            }
            private set
            {
                isEditing = value;
                editSaveButton.Text = IsEditing ? "Salvar" : "Editar";
                backButton.Text = isEditing ? "Cancelar" : "Voltar";
                tableLayoutPanel1.Enabled = IsEditing;
                if (!IsEditing)
                    ShouldPopOnCancel = false;
            }
        }

        public StudentDetScreen(bool startEditing, bool fromPortfolioListContext)//UNDONE: Receive student
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            ShouldSwapOnSave = fromPortfolioListContext;
            IsEditing = startEditing;
            ShouldPopOnCancel = startEditing;
            registerStateComboBox.DataSource = Enum.GetValues(typeof(RegistrationState));
            semesterComboBox.SelectedIndex = 0;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (isEditing && !ShouldPopOnCancel)
            {
                IsEditing = false;
                //Resets fields and discard changes
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
                    //Set original to WC here
                    if (ShouldSwapOnSave)
                        MainForm.Instance.SwapLastWithScreen(new PortfolioDetScreen(true));//UNDONE: Pass prefilled object
                }
            }
            else
                IsEditing = true;
        }
    }
}
