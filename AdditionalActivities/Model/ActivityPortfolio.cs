using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model
{
    class ActivityPortfolio : IModel
    {
        private int id, semester;
        private string title, evaluator;
        private DateTime deliveryDate, evaluationDate;
        private Student student;
        private List<ActivityItem> items;

        public ActivityPortfolio(string title, int semester, DateTime deliveryDate, Student student)
        {
            this.Title = title;
            this.Semester = semester;
            this.DeliveryDate = deliveryDate;
            this.Student = student;
            this.Items = new List<ActivityItem>();
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int Semester
        {
            get
            {
                return semester;
            }

            set
            {
                semester = value;
            }
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

        public string Evaluator
        {
            get
            {
                return evaluator;
            }

            set
            {
                evaluator = value;
            }
        }

        public DateTime DeliveryDate
        {
            get
            {
                return deliveryDate;
            }

            set
            {
                deliveryDate = value;
            }
        }

        public DateTime EvaluationDate
        {
            get
            {
                return evaluationDate;
            }

            set
            {
                evaluationDate = value;
            }
        }

        internal Student Student
        {
            get
            {
                return student;
            }

            set
            {
                student = value;
            }
        }

        internal List<ActivityItem> Items
        {
            get
            {
                return items;
            }

            set
            {
                items = value;
            }
        }

        public void AddItem(ActivityItem item)
        {
            this.Items.Add(item);
        }

        public void RemoveItem(ActivityItem item)
        {
            this.Items.Remove(item);
        }

        public ActivityItem GetItem(int index)
        {
            return this.Items[index];
        }

        public void SetItem(int index, ActivityItem item)
        {
            this.Items[index] = item;
        }
    }
}
