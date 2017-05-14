using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model.Persistent
{
    class Activity : DatabaseObject
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Observation { get; set; }
        public string Certificate { get; set; }
        public int Id { get; set; }
        public int MinHours { get; set; }
        public int MaxHours { get; set; }
        public int HourStep { get; set; }
        public ActivityCategory Category { get; set; }

        public Activity() { }

        public Activity(string title, string certificate, int minHours, int maxHours, ActivityCategory category)
        {
            Title = title;
            Certificate = certificate;
            MinHours = minHours;
            MaxHours = maxHours;
            HourStep = 1;
            Category = category;
            //TODO: set actions, properties, field, editingFields lists
        }

        public Activity(string name, string description, string observation, string certificate, int minHours, int maxHours, int hourStep, ActivityCategory category)
        {
            Title = name;
            Description = description;
            Observation = observation;
            Certificate = certificate;
            MinHours = minHours;
            MaxHours = maxHours;
            HourStep = hourStep;
            Category = category;
            //TODO: set actions, properties, field, editingFields lists
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
