using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdditionalActivities.Model.Persistent
{
    class Rule : DatabaseObject
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

        public override FieldModel GetTitle(bool editingMode)
        {
            throw new NotImplementedException();
        }

        public override FieldModel GetSubtitle(bool editingMode)
        {
            throw new NotImplementedException();
        }

        public override List<DatabaseObject> ReadChildren()
        {
            throw new NotImplementedException();
        }

        public override DatabaseObject SetupFromDB()
        {
            throw new NotImplementedException();
        }

        public override bool IsParent()
        {
            throw new NotImplementedException();
        }

        public override bool CouldSave()
        {
            throw new NotImplementedException();
        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }
    }
}
