using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model
{
    class Student : IModel
    {
        private string name, registerNumber, registerState;
        private int hours;
        private Rule rule;
        private List<ActivityPortfolio> portfolios;

        public Student(string name, string registerNumber, string registerState, Rule rule)
        {
            this.Name = name;
            this.RegisterNumber = registerNumber;
            this.RegisterState = registerState;
            this.Hours = 0;
            this.Rule = rule;
            this.Portfolios = new List<ActivityPortfolio>();
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string RegisterNumber
        {
            get
            {
                return registerNumber;
            }

            set
            {
                registerNumber = value;
            }
        }

        public string RegisterState
        {
            get
            {
                return registerState;
            }

            set
            {
                registerState = value;
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

        internal Rule Rule
        {
            get
            {
                return rule;
            }

            set
            {
                rule = value;
            }
        }

        internal List<ActivityPortfolio> Portfolios
        {
            get
            {
                return portfolios;
            }

            set
            {
                portfolios = value;
            }
        }

        public void AddPortfolio(ActivityPortfolio portfolio)
        {
            this.Portfolios.Add(portfolio);
        }

        public void RemovePortfolio(ActivityPortfolio portfolio)
        {
            this.Portfolios.Remove(portfolio);
        }

        public ActivityPortfolio GetPortfolio(int index)
        {
            return this.Portfolios[index];
        }

        public void SetPortfolio(int index, ActivityPortfolio portfolio)
        {
            this.Portfolios[index] = portfolio;
        }
    }
}
