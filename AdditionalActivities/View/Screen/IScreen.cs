﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdditionalActivities.View.Screen
{
    public interface IScreen
    {
        ///<summary> Provides a hint to when to warn user about possible unsaved data loss.</summary>
        bool IsEditing { get; }

        ///<summary> Called each time an IScreen will be presented, right before being added to view hierarchy.</summary>
        void ScreenWillAppear();
    }
}
