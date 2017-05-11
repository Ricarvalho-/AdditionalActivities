using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model.Persistent
{
    class Activity : IPersistentObjectModel
    {
        private string title, description, observation, certificate;
        private int id, minHours, maxHours, hourStep;
        private ActivityCategory category;

        public Activity(string title, string certificate, int minHours, int maxHours, ActivityCategory category)
        {
            this.Title = title;
            this.Certificate = certificate;
            this.MinHours = minHours;
            this.MaxHours = maxHours;
            this.HourStep = 1;
            this.Category = category;
        }

        public Activity(string name, string description, string observation, string certificate, int minHours, int maxHours, int hourStep, ActivityCategory category)
        {
            this.Title = name;
            this.Description = description;
            this.Observation = observation;
            this.Certificate = certificate;
            this.MinHours = minHours;
            this.MaxHours = maxHours;
            this.HourStep = hourStep;
            this.Category = category;
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

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public string Observation
        {
            get
            {
                return observation;
            }

            set
            {
                observation = value;
            }
        }

        public string Certificate
        {
            get
            {
                return certificate;
            }

            set
            {
                certificate = value;
            }
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

        public int MinHours
        {
            get
            {
                return minHours;
            }

            set
            {
                minHours = value;
            }
        }

        public int MaxHours
        {
            get
            {
                return maxHours;
            }

            set
            {
                maxHours = value;
            }
        }

        public int HourStep
        {
            get
            {
                return hourStep;
            }

            set
            {
                hourStep = value;
            }
        }

        internal ActivityCategory Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
            }
        }

        static PersistentObjectModelType GetModelType()
        {
            return null;//new PersistentObjectModelType();
        }

        public PersistentObjectModelType GetObjectModelType()
        {
            throw new NotImplementedException();
        }

        public List<FieldModel> GetFields(bool editingMode)
        {
            throw new NotImplementedException();
        }

        public string GetTitle()
        {
            throw new NotImplementedException();
        }

        public string GetSubtitle()
        {
            throw new NotImplementedException();
        }

        public bool IsParent()
        {
            throw new NotImplementedException();
        }

        public bool ShouldSave()
        {
            throw new NotImplementedException();
        }
    }
}
