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
using Domain = AdditionalActivities.Model.Domain;

namespace AdditionalActivities.View.Screen.Student
{
    public partial class StudentDetScreen : UserControl, IScreen
    {
        #region Properties
        private bool ShouldSwapOnSave { get; set; }
        private bool ShouldPopOnCancel { get; set; }
        private bool isEditing;
        private Domain.Student student;
        private Domain.Student WorkingCopyStudent { get; set; }

        private Domain.Student Student
        {
            get { return student; }
            set
            {
                student = value;
                WorkingCopyStudent = (Domain.Student)Student.Copy();
            }
        }

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
        #endregion

        #region Init
        public StudentDetScreen(bool startEditing, bool fromPortfolioListContext, Domain.Student student)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            ShouldSwapOnSave = fromPortfolioListContext;
            IsEditing = startEditing;
            ShouldPopOnCancel = startEditing;

            //semesterComboBox.SelectedIndex = 0;
            Student = student;
            SetupBindings();
        }

        private void SetupBindings()
        {
            registerStateComboBox.DataSource = Enum.GetValues(typeof(Domain.RegistrationState));
            semesterComboBox.Items.AddRange(new object[] { 1, 2 });

            nameTextBox.DataBindings.Add("Text", WorkingCopyStudent, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            registerNumberTextBox.DataBindings.Add("Text", WorkingCopyStudent, "RegistrationNumber", true, DataSourceUpdateMode.OnPropertyChanged);
            courseComboBox.DataBindings.Add("SelectedItem", WorkingCopyStudent, "Course", true, DataSourceUpdateMode.OnPropertyChanged);
            ruleComboBox.DataBindings.Add("SelectedItem", WorkingCopyStudent, "Rule", true, DataSourceUpdateMode.OnPropertyChanged);
            yearNumericUpDown.DataBindings.Add("Value", WorkingCopyStudent, "Year", true, DataSourceUpdateMode.OnPropertyChanged);
            semesterComboBox.DataBindings.Add("SelectedItem", WorkingCopyStudent, "Semester", true, DataSourceUpdateMode.OnPropertyChanged);
            registerStateComboBox.DataBindings.Add("SelectedItem", WorkingCopyStudent, "RegistrationState", true, DataSourceUpdateMode.OnPropertyChanged);
            achievedHoursTextBox.DataBindings.Add("Text", WorkingCopyStudent, "AchievedHours", true, DataSourceUpdateMode.OnPropertyChanged);
        }
        #endregion

        #region Event handlers
        public void ScreenWillAppear() { }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (isEditing && !ShouldPopOnCancel)
            {
                IsEditing = false;
                Student = Student;
            }
            else
                MainForm.Instance.PopScreen();
        }

        private void editSaveButton_Click(object sender, EventArgs e)
        {
            if (IsEditing)
            {
                if (true)//UNDONE: Could save object: if (StudentDAO.TrySave(WorkingCopyStudent))
                {
                    IsEditing = false;
                    Student = WorkingCopyStudent;
                    if (ShouldSwapOnSave)
                        MainForm.Instance.SwapLastWithScreen(new PortfolioDetScreen(true, new Domain.ActivityPortfolio(WorkingCopyStudent)));
                }
                else
                    MessageBox.Show("Falha ao salvar aluno.", "Erro", MessageBoxButtons.OK);//UNDONE: Show validation error
            }
            else
                IsEditing = true;
        }

        private void courseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO: Get list of rule by course
            //ruleComboBox.DataSource = RuleDAO.GetRulesWithCourse((Domain.Course)courseComboBox.SelectedItem);
        }
        #endregion
    }
}
