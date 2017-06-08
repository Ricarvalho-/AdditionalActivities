﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model.Domain
{
    public class Student : DomainObject
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int AchievedHours { get; set; }
        public int RegistrationNumber { get; set; }
        public RegistrationState RegistrationState { get; set; }
        public Period RegistrationPeriod { get; set; }
        public Rule Rule { get; set; }
        //public List<ActivityPortfolio> Portfolios { get; set; }
        
        //TODO: Methods
    }
    //TODO: States
    public enum RegistrationState {
        Regular,
        Trancada,
        Formado
    };
}
