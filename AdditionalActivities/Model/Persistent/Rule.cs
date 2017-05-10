using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdditionalActivities.Model.Persistent
{
    class Rule : IPersistentObjectModel
    {
        private string title, course;
        private int year, hours;
        private List<ActivityCategory> categories;

        public Rule(string title, string course, int year, int hours)
        {
            this.Title = title;
            this.Course = course;
            this.Year = year;
            this.Hours = hours;
            this.categories = new List<ActivityCategory>();
        }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public string Course
        {
            get
            {
                return course;
            }

            set
            {
                course = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }

        public int Hours
        {
            get
            {
                return hours;
            }

            set
            {
                hours = value;
            }
        }

        internal List<ActivityCategory> Categories
        {
            get
            {
                return categories;
            }

            set
            {
                categories = value;
            }
        }

        public void AddCategory(ActivityCategory category)
        {
            this.Categories.Add(category);
        }

        public void RemoveCategory(ActivityCategory category)
        {
            this.Categories.Remove(category);
        }

        public ActivityCategory GetCategory(int index)
        {
            return this.Categories[index];
        }

        public void SetCategory(int index, ActivityCategory category)
        {
            this.Categories[index] = category;
        }

        public PersistentObjectModelType GetObjectModelType()
        {
            throw new NotImplementedException();
        }

        public List<FieldModel> GetFields(bool editingMode)
        {
            List<FieldModel> fields = new List<FieldModel>();

            Control title = editingMode ? (Control)new TextBox() : (Control)new Label();
            Control course = editingMode ? (Control)new TextBox() : (Control)new Label();
            Control year = editingMode ? (Control)new TextBox() : (Control)new Label();
            Control hours = editingMode ? (Control)new TextBox() : (Control)new Label();

            title.Text = this.title;
            course.Text = this.course;
            year.Text = this.year.ToString();
            hours.Text = this.hours.ToString();

            fields.Add(new FieldModel("Título", title));
            fields.Add(new FieldModel("Curso", course));
            fields.Add(new FieldModel("Ano", year));
            fields.Add(new FieldModel("Horas necessárias", hours));

            return fields;
        }

        public string GetTitle()
        {
            return this.title;
        }

        public string GetSubtitle()
        {
            return this.course + " - " + this.year;
        }

        public bool IsParent()
        {
            return true;
        }

        public bool ShouldSave()
        {
            throw new NotImplementedException();
        }
    }
}
