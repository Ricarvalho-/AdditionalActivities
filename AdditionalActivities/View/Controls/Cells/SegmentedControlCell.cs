﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdditionalActivities.View.Controls.FilterOrder;
using AdditionalActivities.Model;

namespace AdditionalActivities.View.Controls.Cells
{
    public partial class SegmentedControlCell : UserControl, ICell, IFilterOrder
    {
        public SegmentedControlCell()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        public void AddNew()
        {
            throw new NotImplementedException();
        }

        public FilterOrderCriteria GetCriteria()
        {
            throw new NotImplementedException();
        }

        public void Remove(IFilterOrder filterOrder)
        {
            throw new NotImplementedException();
        }
    }
}